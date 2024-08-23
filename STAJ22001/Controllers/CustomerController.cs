using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STAJ22001.Data;
using STAJ22001.Models;

namespace STAJ22001.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _context;

        CustomerController(CustomerDbContext context) 
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = _context.MockServiceDefinition.ToList();

            if(customers != null) 
            {
            List<MockServiceDefinition> customerList = new List<MockServiceDefinition>();
                foreach(var customer in customers) 
                {
                 var MockServiceDefinition = new MockServiceDefinition();
                    {
                        
                    };
                }
            }

            //this does not work
            return View();
        }

        [HttpGet]
        public IActionResult Yeniservis() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Yeniservis(MockServiceDefinition customerData)
        {
            if (ModelState.IsValid)
            {
                
            }
            else
            {
            }
            return View();
        }

    }
}
