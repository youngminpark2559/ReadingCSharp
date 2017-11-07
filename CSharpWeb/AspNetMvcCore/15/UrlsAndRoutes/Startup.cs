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
//c I add MapRoute whose template pattern defines static character(X) and dynamic controller. If I request with URL /xcustomer/index, this is mapped to CustomerController and Index().

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
                routes.MapRoute(name: "MyRoute",
                    template: "{controller=Home}/{action=Index}/{id=DefaultId}");
            });
        }
    }
}