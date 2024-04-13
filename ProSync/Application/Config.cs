using Microsoft.AspNetCore.Mvc.Razor;
using ProSync.Application.Services;
using ProSync.Domain.Repositories;
using ProSync.Infraestructure.Data.Repositories;

namespace ProSync.Application
{
    public static class Config
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationFormats.Clear();
                options.ViewLocationFormats.Add("/Presentation/Views/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Presentation/Views/Shared/{0}.cshtml");
                options.ViewLocationFormats.Add("/Presentation/Views/{0}.cshtml");
            });

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ProjectService>();
        }
    }
}
