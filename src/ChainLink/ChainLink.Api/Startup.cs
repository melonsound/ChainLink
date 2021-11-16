using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChainLink.Api.Common;
using ChainLink.Api.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AppContext = ChainLink.Api.Data.AppContext;

namespace ChainLink.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            var authOptionsCfg = Configuration.GetSection("Auth");
            
            services.AddControllers();

            services.Configure<AuthOptions>(authOptionsCfg);

            services.AddDbContext<AppContext>(options =>
                options.UseNpgsql(Config.DatabaseConnectionString()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}