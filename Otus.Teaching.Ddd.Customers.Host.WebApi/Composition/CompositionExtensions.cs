﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Otus.Teaching.Ddd.Customers.Host.WebApi.Composition
{
    /// <summary>
    /// Расширение для регистрации зависимостей
    /// </summary>
    public static class CompositionExtensions
    {
        /// <summary>
        /// Добавить зависимости 
        /// </summary>
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            return services
                .AddApplicationDependencies()
                .AddDalDependencies();
        }
    }
}