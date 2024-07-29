using Microsoft.AspNetCore.Mvc;
using STAJ22001.Models;
using System.Diagnostics;

namespace STAJ22001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Anasayfa()
        {
            return View();
        }

        public IActionResult Yeniservis()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CustomerInfo()
        {
            var TestDataModel = new TestDataModel("Fatih", 23123, "123 TL", 123432);

            return View(TestDataModel);
        }



    }
}
