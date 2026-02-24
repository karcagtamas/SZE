using System;
using System.Collections.Generic;
using System.Text;
using TouristLogic.Managers;
using Unity;

namespace TouristLogic
{
	public class ModuleRegistration
	{
		private readonly UnityContainer _unityContainer;

		public ModuleRegistration(UnityContainer unityContainer)
		{
			_unityContainer = unityContainer;
		}

		public void Register()
		{
			_unityContainer.RegisterType<UserManager>();
			_unityContainer.RegisterType<CityManager>();

			//_unityContainer.RegisterType<ICountryRepository, CountryRepository>();

		}
	}
}
