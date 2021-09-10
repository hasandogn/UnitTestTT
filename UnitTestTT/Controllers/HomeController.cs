using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Model;

namespace UnitTestTT.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactVM model)
        {
            var name = model.Email.ToUpper();
            return View();
        }
    }
}
