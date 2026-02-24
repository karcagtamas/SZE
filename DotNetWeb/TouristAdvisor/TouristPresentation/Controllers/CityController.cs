using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristCore.DependencyInjection;
using TouristLogic.Managers;
using TouristModel.Models;

namespace TouristPresentation.Controllers
{
    public class CityController : Controller
    {
        // GET: CityController
        public ActionResult Index()
        {
            return View(TDI.Resolve<CityManager>().GetAll());
        }


        // GET: CityController/Create
        public ActionResult Create()
        {
            return View(new City());
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
