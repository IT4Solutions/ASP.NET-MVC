using IntroductionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroductionProject.Controllers
{
    public class ProductController : Controller
    {
       public ActionResult GetList()
       {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Oppo F11 Pro",
                    Category = "Mobiles",
                    Supplier = "What Mobiles",
                    PurchasePrice = 45000,
                    SalesPrice = 55000,
                    Quantity = 10,
                    Description = "4GB 128 GB Best Resolution"
                },
                new Product
                {
                    Id = 2,
                    Name = "Reno",
                    Category = "Mobiles",
                    Supplier = "What Mobiles",
                    PurchasePrice = 45000,
                    SalesPrice = 55000,
                    Quantity = 10,
                    Description = "4GB 128 GB Best Resolution"
                },
                new Product
                {
                    Id = 3,
                    Name = "I Phone 4",
                    Category = "Mobiles",
                    Supplier = "What Mobiles",
                    PurchasePrice = 45000,
                    SalesPrice = 55000,
                    Quantity = 10,
                    Description = "4GB 128 GB Best Resolution"
                }
            };

            return View(products);
       }

       public ActionResult GetById()
       {
            var product = new Product
            {
                Id = 1,
                Name = "Oppo F11 Pro",
                Category = "Mobiles",
                Supplier = "What Mobiles",
                PurchasePrice = 45000,
                SalesPrice = 55000,
                Quantity = 10,
                Description = "4GB 128 GB Best Resolution"
            };

            return View(product);
       }

       public ActionResult SaveorUpdate()
       {
            return View();
       }

        [HttpPost]
        public ActionResult SaveorUpdate(Product product)
        {
            // Save Product to database
            return RedirectToAction("GetList");
        }

        public ActionResult Delete()
        {
            // Perform Delete Operation
            return RedirectToAction("GetList");
        }

        public ActionResult Edit(int id)
        {
            // Getting Product from Database by productid

            var productById = new Product
            {
                Id = 1,
                Name = "Oppo F11 Pro",
                Category = "Mobiles",
                Supplier = "What Mobiles",
                PurchasePrice = 45000,
                SalesPrice = 55000,
                Quantity = 10,
                Description = "4GB 128 GB Best Resolution"
            };

            return View("SaveorUpdate", productById);
        }
    }
}