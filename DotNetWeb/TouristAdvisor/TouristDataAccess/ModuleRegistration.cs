using System;
using System.Collections.Generic;
using System.Text;
using TouristDataAccess.Context;
using TouristDataAccess.Interfaces;
using TouristDataAccess.Repositories;
using Unity;

namespace TouristDataAccess
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
			_unityContainer.RegisterType<TouristContext>();

			_unityContainer.RegisterType<ICityRepository, CityRepository>();
			_unityContainer.RegisterType<ICountryRepository, CountryRepository>();
			_unityContainer.RegisterType<IGalleryItemRepository, GalleryItemRepository>();
			_unityContainer.RegisterType<ILandmarkRepository, LandmarkRepository>();
			_unityContainer.RegisterType<ILandmarkDescriptionRepository, LandmarkDescriptionRepository>();
			_unityContainer.RegisterType<ILandmarkGalleryRepository, LandmarkGalleryRepository>();
			_unityContainer.RegisterType<ILandmarkVisitRepository, LandmarkVisitRepository>();
			_unityContainer.RegisterType<ILanguageRepository, LanguageRepository>();
			_unityContainer.RegisterType<IRatingRepository, RatingRepository>();
			_unityContainer.RegisterType<ITourRepository, TourRepository>();
			_unityContainer.RegisterType<ITourLandmarkRepository, TourLandmarkRepository>();
			_unityContainer.RegisterType<ITourVisitRepository, TourVisitRepository>();
			_unityContainer.RegisterType<IUserRepository, UserRepository>();

		}

	}
}
