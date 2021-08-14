using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RobbsProductShop.Models;

namespace RobbsProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }

    }
}