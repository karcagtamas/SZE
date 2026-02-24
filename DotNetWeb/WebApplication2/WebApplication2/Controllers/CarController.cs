using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CarController : Controller
    {
        private List<Car> cars = new List<Car> { new Car { Color = "Red", EngineNo = "ASD123123", Id = 1, NumberPlate = "AAA-111", PassengerNo = "123123ASF", VIN = "" } };
        // GET: CarController
        public ActionResult Index()
        {
            return View(cars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            return View(cars.FirstOrDefault(x => x.Id == id));
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                cars.Add(car);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(cars.FirstOrDefault(x => x.Id == id));
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Car car, IFormCollection collection)
        {
            try
            {
                // TODO: Save
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(cars.FirstOrDefault(x => x.Id == car.Id));
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(cars.FirstOrDefault(x => x.Id == id));
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                cars.RemoveAll(x => x.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(cars.FirstOrDefault(x => x.Id == id));
            }
        }
    }
}
