using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

//c I additionally pass 3rd parameter which is named defaults. With this configuration, when there is no specific action in URL, Index is used as default action method.
//c There are 2 ways to define default value for MapRoute(). One is using 3rd argument named default. The other one is inserting into 2nd argument named template.
//c I add 2nd MapRoute. This route is using static segment named public.

namespace UrlsAndRoutes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
                //defaults: new { action = "Index" });
                routes.MapRoute(
                    name: "",
                    template: "Public/{controller=Home}/{action=Index}");
            });
            
        }
    }
}