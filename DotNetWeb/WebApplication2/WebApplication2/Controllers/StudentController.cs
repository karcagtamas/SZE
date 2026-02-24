using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> students = new List<Student> {
                new Student { Id = 1, Name = "Nagy Imre", Age = 12, BirthDate = new DateTime(2001, 6, 8) },
                new Student { Id = 2, Name = "Kiss Aron", Age = 32, BirthDate = new DateTime(1993, 8, 22) },
                new Student { Id = 3, Name = "Kovacs Pista", Age = 76, BirthDate = new DateTime(2008, 2, 5) },
                new Student { Id = 4, Name = "Szabo Adam", Age = 22, BirthDate = new DateTime(1967, 1, 1) },
                new Student { Id = 5, Name = "Korte Alma", Age = 7, BirthDate = new DateTime(1986, 9, 26) }
            };

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Details(long id)
        {
            var st = students.FirstOrDefault(x => x.Id == id);
            return View(st);
        }

        public IActionResult Edit(long id)
        {
            var st = students.FirstOrDefault(x => x.Id == id);
            return View(st);
        }

        [HttpPost]
        public IActionResult Edit(Student model, IFormCollection collection) 
        {
            model.BirthDate = new DateTime(
                int.Parse(collection["BirthDate.Year"]), 
                int.Parse(collection["BirthDate.Month"]), 
                int.Parse(collection["BirthDate.Day"]));

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var original = students.FirstOrDefault(x => x.Id == model.Id);

            original.Name = model.Name;
            original.Age = model.Age;
            original.BirthDate = model.BirthDate;

            return View("Details", original);
            // return RedirectToAction("Details", new { id = original.Id });
        }
    }
}
