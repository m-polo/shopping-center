using System;
using BusinessObjects.Interfaces.Repositories;
using EFCore.Repositories.DataContexts;
using EFCore.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName)
        {
            services.AddDbContext<SalesContext>(options =>
            options.UseNpgsql(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<ISalesCommandsRepository,
                SalesCommandsRepository>();

            return services;
        }
    }
}

