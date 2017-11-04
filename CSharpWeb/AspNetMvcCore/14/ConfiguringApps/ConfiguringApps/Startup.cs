﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ConfiguringApps.Infrastructure;

//c Update Startup.cs by adding service UptimeService which starts Stopwatch when UptimeService class is instantiated and ends Stopwatch when the application is ended.
//c Update Startup.cs by adding one middleware component app.UseMiddleware<ContentMiddleware>() to examine how middleware works.
//c Update Startup.cs by adding one middleware component app.UseMiddleware<ShortCircuitMiddleware>() which intercepts Http request from the client, and re-sets HttpContext object and hands it to next middleware component.


namespace ConfiguringApps
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<UptimeService>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseMvcWithDefaultRoute();
            app.UseMiddleware<ShortCircuitMiddleware>();
            app.UseMiddleware<ContentMiddleware>();
        }
    }
}