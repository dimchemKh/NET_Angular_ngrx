using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NET_Angular_Aionys.API.Extensions;
using System.Collections.Generic;
using System.Globalization;
using BLL = NET_Angular.BLL;

namespace NET_Angular_Aionys
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            CorsExtensions.Add(services, Configuration);
            SwaggerExtension.Add(services);
            BLL.Configuration.Add(services);

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(new CultureInfo("en-US")),
                SupportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US")
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US")
                }
            });
            app.UseCors("OriginPolicy");
            app.UseHttpsRedirection();
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "NET_Angular");
            });
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
