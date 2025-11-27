using AiTech.WebUI.Services.CategoryServices;

namespace AiTech.WebUI.Extensions
{
    public static class ServiceRegistration
    {

        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService,CategoryService>();
        }




    }
}
