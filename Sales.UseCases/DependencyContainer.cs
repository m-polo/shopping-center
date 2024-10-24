using System;
using BusinessObjects.Interfaces.Ports;
using Microsoft.Extensions.DependencyInjection;
using Sales.UseCases.CreateOrder;
using Sales.UseCases.CreatePayment;

namespace Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderInputPort,
                CreateOrderInteractor>();

            services.AddScoped<ICreatePaymentInputPort, CreatePaymentInteractor>();

            return services;
        }
    }
}

