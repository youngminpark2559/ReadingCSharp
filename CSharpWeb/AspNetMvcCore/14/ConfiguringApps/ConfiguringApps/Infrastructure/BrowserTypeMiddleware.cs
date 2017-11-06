using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

//c Add BrowserTypeMiddleware.cs which inspects HttpContext object. If this object contains "edge" on Headers property, set Items property true value with EdgeBrowser key, and then hands this manipulated object to next middleware component.


namespace ConfiguringApps.Infrastructure
{
    public class BrowserTypeMiddleware
    {
        private RequestDelegate nextDelegate;

        public BrowserTypeMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Items["EdgeBrowser"] =
            httpContext.Request.Headers["User-Agent"]
                    .Any(v => v.ToLower().Contains("edge"));
            await nextDelegate.Invoke(httpContext);
        }
    }
}