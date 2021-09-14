using CourseApp.Models;
using CourseApp.Models.ViewModels;
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
                var kurs = new List<Kurslar>()
            {
                new Kurslar(){Id=1,Name="İngilizce Kursu",ImageUrl="ingilizce.jfif"},
                new Kurslar(){Id=2,Name="Python Kursu",ImageUrl="python.jpeg"},
                new Kurslar(){Id=3,Name="C# Kursu",ImageUrl="c.jpg"},
                new Kurslar(){Id=4,Name="Angular Kursu",ImageUrl="angular.png"},
                new Kurslar(){Id=5,Name="Php Kursu",ImageUrl="php.jfif"},
                new Kurslar(){Id=6,Name="Asp .Net Core Mvc Kursu",ImageUrl="asp.png"},
                new Kurslar(){Id=8,Name="Java Kursu",ImageUrl="java.jfif"},
                new Kurslar(){Id=9,Name="Siber Güvenlik Kursu",ImageUrl="siber.jfif"},
                new Kurslar(){Id=10,Name="Ünity Oyun Gelistirme Kursu",ImageUrl="ünity.jfif"},
                new Kurslar(){Id=11,Name="Html + Css + Javasceipt Kursu",ImageUrl="html.jpeg"},
                new Kurslar(){Id=12,Name="Algoritma Kursu",ImageUrl="alg.jpeg"},
                new Kurslar(){Id=13,Name="Pascal Kursu",ImageUrl="pascal.jpg"}
            };
                return View("Thanks",new ThanksViewModel { kurslars = kurs, student = student,developer="Hakan BAĞLAN" });
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Thanks()
        {
            var kurs = new List<Kurslar>()
            {
                new Kurslar(){Id=1,Name="İngilizce Kursu"},
                new Kurslar(){Id=2,Name="Frontend Web Devloper Kursu"},
                new Kurslar(){Id=3,Name="C# Kursu"},
                new Kurslar(){Id=4,Name="Angular Kursu"},
                new Kurslar(){Id=5,Name="Php Kursu"},
                new Kurslar(){Id=6,Name="Asp .Net Core Mvc Kursu"},
                new Kurslar(){Id=8,Name="Java Kursu"},
                new Kurslar(){Id=9,Name="Siber Güvenlik Kursu"},
                new Kurslar(){Id=10,Name="Ünity Oyun Gelistirme Kursu"},
                new Kurslar(){Id=11,Name="Html + Css + Javasceipt Kursu"},
            };
            return View(new ThanksViewModel {kurslars=kurs,student=null });
        }
    }
}
