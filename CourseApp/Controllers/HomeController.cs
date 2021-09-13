using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var course = new Models.Course();
            course.Id = 1;
            course.Name = "Asp .Net Core 2 Kursu";
            return View(course);
        }
    }
}
