using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ConfiguringApps.Infrastructure;
using Microsoft.Extensions.Configuration;

//c Update Startup.cs by adding service UptimeService which starts Stopwatch when UptimeService class is instantiated and ends Stopwatch when the application is ended.
//c Update Startup.cs by adding one middleware component app.UseMiddleware<ContentMiddleware>() to examine how middleware works.
//c Update Startup.cs by adding one middleware component app.UseMiddleware<ShortCircuitMiddleware>() which intercepts Http request from the client, and inspects HttpContext object if it contains "edge" in their Http request header and this either hands it to next middleware component or send 404 error contained in HttpContext.Response.StatusCode.
//c Update Startup.cs by adding code to register app.UseMiddleware<BrowserTypeMiddleware>().
//c Update Startup.cs by adding code to register app.UseMiddleware<ErrorMiddleware>().
//c Update Startup.cs by adding code to register app.UseMvc() which sets the middleware components for MVC system, including routing system. To complete MVC system work well, not only are MVC middleware componenets needed, but also services for MVC system are needed. It can be resolved by adding services.AddMvc() in ConfigureService(IServiceCollection services).
//c Update Startup.cs by removing middleware components which were used to examine middleware and adding exception-handling middlewares.
//c I invoke AddMvcOptions() additionally after AddMvc(). This followed method can customize options in MVC by manipulating the default behavior of MVC which is acted by rules defined by AddMvc().
//c I add ConfigureDevelopmentServices(), ConfigureDevelopment(), and update Configure(). These methods are suffixed by Development which means that these methods are for development environment. These are needed because even if the different configuration files are useful, they can't contain C# codes such as method.

namespace ConfiguringApps
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<UptimeService>();
            services.AddMvc().AddMvcOptions(options => {
                options.RespectBrowserAcceptHeader = true;
            });
        }
        
        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            services.AddSingleton<UptimeService>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        public void ConfigureDevelopment(IApplicationBuilder app,
                IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseBrowserLink();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}