using Gerente.Infra.Data.Context;
using Gerente.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerente.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataDbContext>(o => 
                o.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(DataDbContext).Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<Usuario>(o =>
                {
                    o.SignIn.RequireConfirmedAccount = false;
                    o.SignIn.RequireConfirmedEmail = true;
                    o.Password.RequireDigit = false;
                    o.Password.RequireLowercase = false;
                    o.Password.RequiredLength = 6;
                    o.Password.RequireNonAlphanumeric = false;
                    o.Password.RequireUppercase = false;
                    o.User.RequireUniqueEmail = true;

                })
                .AddEntityFrameworkStores<DataDbContext>(); 
            return services;
        }
    }
}
