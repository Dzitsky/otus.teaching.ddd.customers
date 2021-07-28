using Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess.DbInitialization;
using Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess;
using Otus.Teaching.Ddd.Customers.Domain.Repositories;
using Otus.Teaching.Ddd.Customers.Infrastructure.Repositories;

namespace Otus.Teaching.Ddd.Customers.Host.WebApi.Composition
{
    public static class DalExtensions
    {
        public static IServiceCollection AddDalDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDbInitializer, DropAndCreateDbInitializer>();
            
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite("Filename=OtusTeachingDddCustomersDb.sqlite");
            });
            
            services
                .AddScoped<ICustomerRepository, EfCustomerRepository>();

            return services;
        }
    }
}
