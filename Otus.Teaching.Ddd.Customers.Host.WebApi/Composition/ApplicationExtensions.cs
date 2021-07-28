
using Microsoft.Extensions.DependencyInjection;
using Otus.Teaching.Ddd.Customers.Core.Application.Services;
using Otus.Teaching.Ddd.Customers.Core.Application.Services.Abstractions;

namespace Otus.Teaching.Ddd.Customers.Host.WebApi.Composition
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
             services
                .AddScoped<ICustomerService, CustomerAggregateService>();

             return services;
        }
    }
}
