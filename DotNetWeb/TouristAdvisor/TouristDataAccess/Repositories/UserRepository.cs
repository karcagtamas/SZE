using System;
using System.Collections.Generic;
using System.Text;
using TouristDataAccess.Context;
using TouristDataAccess.Interfaces;
using TouristModel.Models;

namespace TouristDataAccess.Repositories
{
	public class UserRepository : BaseRepository<User, TouristContext>, IUserRepository
	{
	}
}
