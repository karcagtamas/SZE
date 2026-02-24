using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TouristCore.DependencyInjection;
using TouristDataAccess.Interfaces;
using TouristModel.Models;

namespace TouristLogic.Managers
{
	public class UserManager
	{
		public List<User> GetAll()
		{
			var userRepository = TDI.Resolve<IUserRepository>();
			var userList = userRepository.GetAll().Where(x => x.IsActive == true).ToList();

			return userList;
		}

		public User Get(long oid)
		{
			var userRepository = TDI.Resolve<IUserRepository>();
			var user = userRepository.Get(oid);
			return user;
		}

		public void Update(User tempUser)
		{
			var userRepository = TDI.Resolve<IUserRepository>();
			var user = userRepository.Get(tempUser.OID);
			user.FirstName = tempUser.FirstName;
			user.LastName = tempUser.LastName;
			user.Title = tempUser.Title;
			user.CoverPhotoPath = tempUser.CoverPhotoPath;
			user.UserName = tempUser.UserName;
			userRepository.Update(user);
		}

		public long Add(User user)
		{
			var userRepository = TDI.Resolve<IUserRepository>();
			user.IsActive = true;
			var oid = userRepository.Add(user);
			return oid;
		}

		public void SetDeleted(long oid, string webRootPath)
		{
			var userRepository = TDI.Resolve<IUserRepository>();
			var user = userRepository.Get(oid);

			//TODO: coverphotopath alapján fizikailag törölnia  képet.
			var userImage = user.CoverPhotoPath.Replace("/Contents/", "");
			var filePath = Path.Combine(webRootPath, "Contents", userImage);
			File.Delete(filePath);

			user.FirstName = string.Empty;
			user.LastName = string.Empty;
			user.Title = string.Empty;
			user.CoverPhotoPath = "/Contents/deleted-user.png";
			user.UserName = string.Empty;
			user.IsActive = false;

			userRepository.Update(user);
		}
	}
}
