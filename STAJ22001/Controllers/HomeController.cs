using Microsoft.AspNetCore.Mvc;
using STAJ22001.Data;
using STAJ22001.Data.customerdata;
using STAJ22001.Models;
using System.Diagnostics;

namespace STAJ22001.Controllers

{
    //this single controller governs both database operations and view pages of this project
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
                        Type = customer.Type,
                        Path = customer.Path

                    };
                    customerList.Add(CustomerViewModel);


                }
                return View(customerList);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Yeniservis()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeniservis(CustomerViewModel customerData)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var customer = new Customer()
                    {
                        ServiceName = customerData.Service,
                        Type = customerData.Type,
                        Path = customerData.Path,
                        QueryString = customerData.Query,
                        Header = customerData.Header,
                        RequestBody = customerData.RequestBody,
                        ResponseBody = customerData.ResponseBody
                    };

                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    TempData["successMessage"] = "creation successful";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "model data not valid";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                throw;
            }
           
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(x => x.CustomerId == id);

                if (customer != null)
                {
                    var customerView = new CustomerViewModel()
                    {
                        Id = customer.CustomerId,
                        Service = customer.ServiceName,
                        Type = customer.Type,
                        Path = customer.Path,
                        Query = customer.QueryString,
                        Header = customer.Header,
                        RequestBody = customer.RequestBody,
                        ResponseBody = customer.ResponseBody,
                        CreatedBy = customer.CreatedBy,
                        UpdatedDate = customer.UpdatedDate,
                        CreatedDate = customer.CreatedDate,
                        UpdatedBy = customer.UpdatedBy,
                        IsEnabled = customer.IsEnabled

                    };
                    return View(customerView);
                }
                else
                {
                    TempData["errorMessage"] = $"customer details not avaible with id: {id}";
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(CustomerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var customer = new Customer()
                    {
                        CustomerId = model.Id,
                        ServiceName = model.Service,
                        Type = model.Type,
                        Path = model.Path,
                        QueryString = model.Query,
                        Header = model.Header,
                        RequestBody = model.RequestBody,
                        ResponseBody = model.ResponseBody,
                    };
                    _context.Customers.Update(customer);
                    _context.SaveChanges();
                    TempData["successMessage"] = "updated successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "model data is invalid";
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View();
            }

         
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(x => x.CustomerId == id);

                if (customer != null)
                {
                    var customerView = new CustomerViewModel()
                    {
                        Id = customer.CustomerId,
                        Service = customer.ServiceName,
                        Type = customer.Type,
                        Path = customer.Path,
                        Query = customer.QueryString,
                        Header = customer.Header,
                        RequestBody = customer.RequestBody,
                        ResponseBody = customer.ResponseBody,
                        CreatedBy = customer.CreatedBy,
                        UpdatedDate = customer.UpdatedDate,
                        CreatedDate = customer.CreatedDate,
                        UpdatedBy = customer.UpdatedBy,
                        IsEnabled = customer.IsEnabled

                    };
                    return View(customerView);
                }
                else
                {
                    TempData["errorMessage"] = $"customer details not avaible with id: {id}";
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(CustomerViewModel model)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(x => x.CustomerId == model.Id);

                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Customer deleted";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = $"customer details not avaible with id: {model.Id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        //an api call that finds data on table and returns another data on the same row
        [HttpGet]
        public IActionResult Getpost(string deneme, string deneme2)
        {
            string search = "{" + $"{deneme},{deneme2}" + "}";

            if (string.IsNullOrEmpty(search))
            {
                return BadRequest("The 'search' string is required.");
            }

            var item = _context.Customers
                .Where(i => i.Type=="Get" && i.RequestBody == search)
                .FirstOrDefault();

            if (item == null)
            {
                return NotFound("No matching item found.");
            }

            return Ok(item.ResponseBody);
        }

        [HttpPost] public IActionResult Getpost([FromBody] string search) 
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
