using STAJ22001.Data;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace STAJ22001.Extensions
{
    //an extension for program.cs
    //handles repository connections
    public static class RepositoryExtension
    {

        public static IServiceCollection AddRepositories(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<CustomerDbContext>(options =>
            {
                var connectionStrings =
                configuration.GetSection(key: ConnectionStringOption.Key).Get<ConnectionStringOption>();

                options.UseSqlServer(connectionStrings!.DefaultConnection, sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName);
                });
            });

            return services;
        }
    }
}
