using Microsoft.AspNetCore.Mvc;
using STAJ22001.Data;
using STAJ22001.Models;
using System.Diagnostics;

namespace STAJ22001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerDbContext _context;

        public HomeController(ILogger<HomeController> logger, CustomerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();

            if(customers!= null) 
            {
                List<CustomerViewModel> customerList = new List<CustomerViewModel>();
                foreach (var customer in customers) 
                {
                    var CustomerViewModel = new CustomerViewModel()
                    {
                        Id = customer.CustomerId,
                        Service = customer.ServiceName,
                        Type = customer.Type

                    };
                    customerList.Add(CustomerViewModel);


                }
                return View(customerList);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            var customers = _context.Customers.ToList();


            return View(customers);

        }

        public IActionResult Anasayfa()
        {
            var customers = _context.Customers.ToList();


            return View(customers);
        }

        [HttpGet]
        public IActionResult Yeniservis()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeniservis(Customer customerData)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        


    }
}
