using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Routing;
using UrlsAndRoutes.Infrastructure;

//c I additionally pass 3rd parameter which is named defaults. With this configuration, when there is no specific action in URL, Index is used as default action method.
//c There are 2 ways to define default value for MapRoute(). One is using 3rd argument named default. The other one is inserting into 2nd argument named template.
//c I add 2nd MapRoute. This route is using static segment named public.
//c I add MapRoute whose template pattern defines static character(X) and dynamic controller. If I request with URL /xcustomer/index, this is mapped to CustomerController and Index().
//c I made id segment an optional variable. There's nothing wrong when the clinet wouldn't supply id value in the URL, and when the client would supply id value in the URL.
//c I add *catchall segment in the template of MapRoute(). With this configuration, any number of segment after id segment of URL can be mapped to catchall variable.
//c I constraint type of id segment to nullable int type.
//c I specify the constraint outside of URL template pattern. In this version, I also should specify defaults argument.
//c Apply the custom constraint for MapRoute()
//c Using the custom constraint as inline version, by using ConfigureServices().
//c I've seen so far convention-based routing. Now I'm going to examine attribute routing. To do this, first set app.UseMvcWithDefaultRoute() for using default route system. The default route system will match URL by using this pattern, {controller}/{action}/{id?}.
namespace UrlsAndRoutes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => {
                options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint));
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                //routes.MapRoute(
                //    name: "NewRoute",
                //    template: "App/Do{action}",
                //    defaults: new { controller = "Home" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "out",
                    template: "outbound/{controller=Home}/{action=Index}");
            });
        }
    }
}
