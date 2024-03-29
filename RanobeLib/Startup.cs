﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RanobeLib.Data;
namespace RanobeLib
{
    public static class GlobalRules
    {
        public static string ConectionSTR
        {
            get; set;
        }
        public static UnitOfWork uow = new UnitOfWork();
     
        
    }
    public class Startup
    {

        public IConfiguration Configuration { get; set; }
        public  Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            GlobalRules.ConectionSTR =Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BookContext>(options => options.UseSqlServer(GlobalRules.ConectionSTR));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
        }

       
    }
}
