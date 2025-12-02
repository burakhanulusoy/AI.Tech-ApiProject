using AiTech.WebUI.Services.CategoryServices;
using AiTech.WebUI.Services.ProjectServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AiTech.WebUI.Extensions
{
    public static class ServiceRegistration
    {

        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IProjectService,ProjectService>();

            services.AddFluentValidationAutoValidation()
                     .AddFluentValidationClientsideAdapters()
                     .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());



        }




    }
}
