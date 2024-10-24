using EFCore.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sales.Controllers;
using Sales.Presenters;
using Sales.UseCases;

namespace Sales.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddSalesServices(
        this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName)
    {
        services
            .AddRepositories(configuration, connectionStringName)
            .AddUseCasesServices()
            .AddPresenters()
            .AddSalesControllers();

        return services;
    }
}
