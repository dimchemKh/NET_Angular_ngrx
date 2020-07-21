using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NET_Angular_Aionys.API.Extensions
{
    public static class CorsExtensions
    {
        public static void Add(this IServiceCollection services, IConfiguration configuration)
        {
            IConfigurationSection corsOptions = configuration.GetSection("Cors");
            var origins = corsOptions["Origins"];
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", b => b.AllowAnyHeader()
                                                          .AllowAnyMethod()
                                                          //.AllowAnyOrigin()
                                                          .AllowCredentials());

                options.AddPolicy("OriginPolicy", builder => builder//.WithOrigins(origins)
                                                        .AllowAnyHeader()
                                                        .AllowAnyMethod()
                                                        .AllowCredentials());
            });
        }
    }
}
