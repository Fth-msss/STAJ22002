using Microsoft.AspNetCore.Mvc;
using STAJ22001.Data;
using STAJ22001.Models;
using System.Diagnostics;

namespace STAJ22001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.MockServiceDefinition.ToList();


            return View(customers);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            var customers = _context.MockServiceDefinition.ToList();


            return View(customers);

        }

        public IActionResult Anasayfa()
        {
            var customers = _context.MockServiceDefinition.ToList();


            return View(customers);
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
