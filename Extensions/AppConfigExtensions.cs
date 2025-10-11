using AuthECAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace AuthECAPI.Extensions
{
    public static class AppConfigExtensions
    {
        public static WebApplication ConfigureCORS(this WebApplication app,
            IConfiguration config)
        {
            // Configure the HTTP request pipeline.
            app.UseCors(options =>
                options.WithOrigins(
                    "http://172.20.10.7:4200",
                    "http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader());
            return app;
        }
        public static IServiceCollection AddAppConfig(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<AppSettings>(config.GetSection("AppSettings"));
            return services;
        }

    }
}
