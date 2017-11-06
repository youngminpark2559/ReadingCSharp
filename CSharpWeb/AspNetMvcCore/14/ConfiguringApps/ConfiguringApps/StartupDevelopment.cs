using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ConfiguringApps.Infrastructure;

//c I add StartupDevelopment.cs. I can use different methods which is called as per various hosting environments(development, staging, production, etc) in Startup.cs file, but it can result in large class. To resolve this issue, I can use different classes which is used as per various hosting environments. This class I add, StartupDevelopment.cs, will be used when the hosting environment is development and methods contained in this class also are used in development environment.

namespace ConfiguringApps
{
    public class StartupDevelopment
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<UptimeService>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseBrowserLink();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}