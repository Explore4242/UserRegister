using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "God Afternoon" : "Goodmorning";
            return View("MyView");
        }
        public ViewResult List()
        {
            var liste = Repository.Students.Where(i => i.WillAtend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }

        }
    }
}
