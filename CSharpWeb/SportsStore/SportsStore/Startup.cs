﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

//c Add code for registering Repository service. Each component in MVC is recommended to be loosely coupled each other. In this case, controller and Repository layer should be loosely coupled. For this, FakeProductRepository object which is needed by controller is supplied by DI container, by stating code like this - services.AddTransient<IProductRepository, FakeProductRepository>();


namespace SportsStore
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));
            services.AddTransient<IProductRepository, EFProductRepository>();
            //services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
            name: null,
            template: "{category}/Page{productPage:int}",
            defaults: new { controller = "Product", action = "List" }
            );

                routes.MapRoute(
            name: null,
            template: "Page{productPage:int}",
            defaults: new
            {
                controller = "Product",
                action = "List",
                productPage = 1
            });

                routes.MapRoute(
            name: null,
            template: "{category}",
            defaults: new
            {
                controller = "Product",
                action = "List",
                productPage = 1
            });

                routes.MapRoute(
            name: null,
            template: "",
            defaults: new
            {
                controller = "Product",
                action = "List",
                productPage = 1
            });

            routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");


            });
            SeedData.EnsurePopulated(app);
        }
    }
}
