using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing.Constraints;

//c I additionally pass 3rd parameter which is named defaults. With this configuration, when there is no specific action in URL, Index is used as default action method.
//c There are 2 ways to define default value for MapRoute(). One is using 3rd argument named default. The other one is inserting into 2nd argument named template.
//c I add 2nd MapRoute. This route is using static segment named public.
//c I add MapRoute whose template pattern defines static character(X) and dynamic controller. If I request with URL /xcustomer/index, this is mapped to CustomerController and Index().
//c I made id segment an optional variable. There's nothing wrong when the clinet wouldn't supply id value in the URL, and when the client would supply id value in the URL.
//c I add *catchall segment in the template of MapRoute(). With this configuration, any number of segment after id segment of URL can be mapped to catchall variable.
//c I constraint type of id segment to nullable int type.
//c I specify the constraint outside of URL template pattern. In this version, I also should specify defaults argument.

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
                   name: "MyRoute",
                   template: "{controller}/{action}/{id?}",
                   defaults: new { controller = "Home", action = "Index" },
                   constraints: new { id = new IntRouteConstraint() });
            });
        }
    }
}

