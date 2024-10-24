using System;
using BusinessObjects.Interfaces.Ports;
using BusinessObjects.Interfaces.Presenters;
using Microsoft.Extensions.DependencyInjection;

namespace Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<CreateOrderPresenter>();

            services.AddScoped<ICreateOrderOutputPort>(
                provider => provider.GetService<CreateOrderPresenter>());

            services.AddScoped<ICreateOrderPresenter>(
                provider => provider.GetService<CreateOrderPresenter>());

            services.AddScoped<CreatePaymentPresenter>();

            services.AddScoped<ICreatePaymentOutputPort>(
                provider => provider.GetService<CreatePaymentPresenter>());

            services.AddScoped<ICreatePaymentPresenter>(
                provider => provider.GetService<CreatePaymentPresenter>());

            return services;
        }
    }
}

