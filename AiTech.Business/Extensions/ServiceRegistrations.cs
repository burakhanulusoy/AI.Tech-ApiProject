using AiTech.Business.Services.CategoryServices;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            // Business layer service registrations can be added here in the future.


            services.AddScoped<ICategoryService, CategoryService>();

        }




    }
}
