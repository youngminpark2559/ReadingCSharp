using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

//c Add code for registering service provider functionality in Program.cs, which is used by DI feature configured in Startup.cs. The registered service provider is a built in one by ASP.NET Core. This feature is mostly enough in any project, but I can use other third party DI service provider.
//c I set codes to configure the functionality dealing with complex configurations by using different external configuration files(in this case, it'll be appsettings.{env.EnvironmentName}.json file.). This is effective alternative way for setting same functionality in Startup.cs by using so many "if statement" whihc can cause bad readability and hard to change, prone to error.
//c I add UseStartup(nameof(ConfiguringApps)) instead of UseStartup<Startup>. So, ASP.NET will look for a class whose name includes the hosting envirionment, for example, StartupEnvironment, StartupProduction, and use the regular Start.cs if there's no those classes containing envirionment information.

namespace ConfiguringApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((hostingContext, config) => {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();
                    if (args != null)
                    {
                        config.AddCommandLine(args);
                    }
                })
                .ConfigureLogging((hostingContext, logging) => {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseIISIntegration()
                .UseDefaultServiceProvider((context, options) => {
                    options.ValidateScopes =
                        context.HostingEnvironment.IsDevelopment();
                })

  
                .UseStartup(nameof(ConfiguringApps))
                .Build();
        }
    }
}