using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoominApi.Infrastructure.ApiService;
using BoominApi.Infrastructure.Helpers.HttpRequestHandlers;
using BoominApi.Infrastructure.IApiService;
using BoominApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace BoominApi
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
            services.AddControllers();
            
            services.AddSingleton<IApiUserService, ApiUserService>();
            services.AddSingleton<IApiLocationService, ApiLocationService>();
            services.AddSingleton<IApiClient, ApiClient>();

            services.AddTransient<UserDto>();
            services.AddTransient<LocationDto>();

            services.AddHttpClient("TechieDiariesFakeApiClient", client =>
            {

                //local Api
                client.BaseAddress = new Uri("https://localhost:8000/");

                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
