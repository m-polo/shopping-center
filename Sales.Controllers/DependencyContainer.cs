using System;
using BusinessObjects.Interfaces.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace Sales.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddSalesControllers(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderController,
                CreateOrderController>();
            services.AddScoped<ICreatePaymentController,
               CreatePaymentController>();

            return services;
        }
    }
}

