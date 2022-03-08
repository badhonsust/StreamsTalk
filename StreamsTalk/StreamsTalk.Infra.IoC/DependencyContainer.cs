using Microsoft.Extensions.DependencyInjection;
using StreamsTalk.Application.Interfaces;
using StreamsTalk.Application.Services;
using StreamsTalk.Domain.Interfaces;
using StreamsTalk.Infra.Data.Repositories;

namespace StreamsTalk.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();


        }
    }
}
