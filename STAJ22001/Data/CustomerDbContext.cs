using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using STAJ22001.Models;
using Microsoft.Extensions.Logging;

namespace STAJ22001.Data
{
    public class CustomerDbContext : DbContext
    {
      

        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
