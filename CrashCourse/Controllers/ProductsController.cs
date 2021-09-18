using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashCourse.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Message()
        {
            return "This is the message page!!!!";
        }

        public IActionResult Messagee()
        {
            return View("Messagee");
        }

        //querystring in C#
        /*
        public string Welcome(string name, int secretNumber)
        {
            return $"Hello {name} and your secret number is {secretNumber}";
        }
        */

        public IActionResult Welcome(string name, int secretNumber)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        }
    }
}
