using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TouristCore.DependencyInjection;
using TouristLogic.Managers;
using TouristModel.Models;

namespace TouristPresentation.Controllers
{
	public class UserController : Controller
	{
		private readonly IWebHostEnvironment _webHostEnvironment;

		public UserController(IWebHostEnvironment webHostEnvironment)
		{
			_webHostEnvironment = webHostEnvironment;
		}

		public ActionResult Index()
		{
			var userManager = TDI.Resolve<UserManager>();
			var userList = userManager.GetAll();

			return View(userList);
		}

		// GET: UserController/Details/5
		public ActionResult Details(int oid)
		{
			var userManager = TDI.Resolve<UserManager>();
			var user = userManager.Get(oid);

			return View(user);
		}

		public ActionResult Create()
		{
			return View(new User());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection, IFormFile file)
		{
			try
			{
				var filePath = string.Empty;
				var webRootPath = _webHostEnvironment.WebRootPath;
				var image = Image.FromStream(file.OpenReadStream());
				var resized = new Bitmap(image, new Size(256, 256));
				using (var imageStream = new MemoryStream())
				{
					resized.Save(imageStream, ImageFormat.Jpeg);
					var imageBytes = imageStream.ToArray();
					var guidString = Guid.NewGuid().ToString();
					var savePath = Path.Combine(webRootPath, "Contents", guidString + ".jpeg");
					filePath = "/Contents/" + guidString + ".jpeg";
					System.IO.File.WriteAllBytes(savePath, imageBytes);
				}				

				var userManager = TDI.Resolve<UserManager>();

				var user = new User()
				{
					FirstName = collection["FirstName"],
					LastName = collection["LastName"],
					Title = collection["Title"],
					CoverPhotoPath = filePath,
					UserName = collection["UserName"]
				};

				userManager.Add(user);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Edit/5
		public ActionResult Edit(int oid)
		{
			var userManager = TDI.Resolve<UserManager>();
			var user = userManager.Get(oid);

			return View(user);
		}

		// POST: UserController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int oid, IFormCollection collection)
		{
			try
			{	var userManager = TDI.Resolve<UserManager>();

				var tempUser = new User()
				{
					OID = oid,
					FirstName = collection["FirstName"],
					LastName = collection["LastName"],
					Title = collection["Title"],
					CoverPhotoPath = collection["CoverPhotoPath"],
					UserName = collection["UserName"],
				};

				userManager.Update(tempUser);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Delete/5
		public ActionResult Delete(int oid)
		{
			var userManager = TDI.Resolve<UserManager>();
			var user = userManager.Get(oid);

			return View(user);
		}

		// POST: UserController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int oid, IFormCollection collection)
		{
			try
			{
				var userManager = TDI.Resolve<UserManager>();
				var webRootPath = _webHostEnvironment.WebRootPath;
				userManager.SetDeleted(oid, webRootPath);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
