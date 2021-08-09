using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mohome.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Articles()
        {
            return View();
        }

        public IActionResult Knowledge()
        {
            return View();
        }

        public IActionResult Life()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }
    }
}
