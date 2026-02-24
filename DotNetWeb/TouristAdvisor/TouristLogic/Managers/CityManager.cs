using System;
using System.Collections.Generic;
using System.Text;
using TouristCore.DependencyInjection;
using TouristDataAccess.Interfaces;
using TouristModel.Models;

namespace TouristLogic.Managers
{
    public class CityManager
    {
        public IEnumerable<City> GetAll()
        {
            return TDI.Resolve<ICityRepository>().GetAll();
        }
    }
}
