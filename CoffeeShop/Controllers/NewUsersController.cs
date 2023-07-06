
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;


namespace CoffeeShop.Controllers
{
    public class NewUsersController : Controller
    {
        public class CoffeeShopController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult Results(NewUser customer)
            {
                return View(customer);
            }
            public IActionResult Registration()
            {
                return View();
            }
            [HttpPost]
            public IActionResult FormSubmit(NewUser customer)
            {
                return RedirectToAction("Results", customer);
            }
        }
    }
}




