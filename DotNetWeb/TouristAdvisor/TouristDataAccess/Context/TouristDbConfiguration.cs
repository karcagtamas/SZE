using System;
using System.Collections.Generic;
using System.Text;

namespace TouristDataAccess.Context
{
	public static class TouristDbConfiguration
	{
		public static string GetConnectionString()
		{
			return @"Data Source=KARCAGTAMAS-HUA;Initial Catalog=TouristDb;Integrated Security=True;";
		}
	}
}
