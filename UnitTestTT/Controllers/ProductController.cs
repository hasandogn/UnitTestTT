using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Model;

namespace UnitTestTT.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductVM product = new ProductVM()
            {
                Name = "Iphone",
                Description = "Iphone şarjı hızlı",
                Price = 10000
            };

            ProductVM product1 = new ProductVM()
            {
                Name = "Samsung",
                Description = "Samsung şarjı hızlı",
                Price = 40000
            };

            List<ProductVM> products = new List<ProductVM>();

            products.Add(product);
            products.Add(product1);

            return View(products);
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index", "Product");
        }
    }
}
