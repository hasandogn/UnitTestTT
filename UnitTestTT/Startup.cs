using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Data;
using UnitTestTT.Repository.Interfaces;
using UnitTestTT.Repository.Manager;

namespace UnitTestTT
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Projenin çalışması için mvc olduğunu anlıyor
            services.AddControllersWithViews();

            services.AddDbContext<GlobalContext>(q => q.UseSqlServer(Configuration.GetConnectionString("GlobalContext")));

            services.AddScoped<IWebUserRepository, WebUserRepository>();
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
                // MVC nin kendi default yönlendirilmesi
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
