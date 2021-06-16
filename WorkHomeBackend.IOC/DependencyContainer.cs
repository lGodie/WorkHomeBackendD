using Microsoft.Extensions.DependencyInjection;
using WorkHomeBackend.Data.Repository;
using WorkHomeBackend.Data.Repository.Interfaces;
using WorkHomeBackend.Services.Services;
using WorkHomeBackend.Services.Services.Interfaces;

namespace WorkHomeBackend.IOC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository, GenericRepository>();
            services.AddScoped<IRoutineService, RoutineService>();
            return services;
        }
    }
}
