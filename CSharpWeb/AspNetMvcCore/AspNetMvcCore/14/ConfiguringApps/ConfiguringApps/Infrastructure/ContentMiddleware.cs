using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

//c Add ContentMiddleware.cs which is used to configure one middleware component generating content.
//c Update ContentMiddleware.cs adding UptimeService object as a argument of ContentMiddleware constructor and the object will be passed into here by service provider of Startup.cs. This means that services can be provided not only for controller but also any part of the application.

namespace ConfiguringApps.Infrastructure
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;
        private UptimeService uptime;

        public ContentMiddleware(RequestDelegate next, UptimeService up)
        {
            nextDelegate = next;
            uptime = up;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response
                    .WriteAsync("This is from the content middleware " +
                    $"(uptime: {uptime.Uptime}ms)", Encoding.UTF8);
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}