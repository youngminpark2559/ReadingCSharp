﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DependencyInjection.Infrastructure;
using DependencyInjection.Models;

//c Set TypeBroker's type by invoking SetRepositoryType<AlternateRepository>().
//c Set DI by services.AddTransient<IRepository, MemoryRepository>().

namespace DependencyInjection
{
    public class Startup
    {
        private readonly IHostingEnvironment env;

        public Startup(IHostingEnvironment hostEnv)
        {
            env = hostEnv;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddTransient<MemoryRepository>();
            services.AddTransient<IModelStorage, DictionaryStorage>();
            services.AddTransient<ProductTotalizer>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}