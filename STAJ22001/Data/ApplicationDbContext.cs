using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using STAJ22001.Models;
using Microsoft.Extensions.Logging;

namespace STAJ22001.Data
{
    public class ApplicationDbContext : DbContext
    {
      

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<MockServiceDefinition> MockServiceDefinition { get; set; }
    }
}
