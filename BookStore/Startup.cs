using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BookStore{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
           services.AddControllersWithViews();
        }
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(!env.IsDevelopment())
            {
                app.UseExceptionHandler();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}