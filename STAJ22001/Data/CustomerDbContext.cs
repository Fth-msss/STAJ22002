using Microsoft.EntityFrameworkCore;
using STAJ22001.Data.customerdata;
using System.Reflection;

namespace STAJ22001.Data
{
    //this is how the project knows what a database is
    public class CustomerDbContext(DbContextOptions<CustomerDbContext> options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
