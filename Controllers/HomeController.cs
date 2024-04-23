using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_5.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About_us()
        {
            return View();
        }

        public IActionResult analytics()
        {
            return View();
        }

        public IActionResult Data()
        {
            return View();
        }

        public IActionResult Customer_Story()
        {
            return View();
        }

      




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
