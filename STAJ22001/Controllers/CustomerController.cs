using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STAJ22001.Data;

namespace STAJ22001.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        CustomerController(ApplicationDbContext context) 
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = _context.MockServiceDefinition.ToList();


            return View(customers);
        }

    }
}
