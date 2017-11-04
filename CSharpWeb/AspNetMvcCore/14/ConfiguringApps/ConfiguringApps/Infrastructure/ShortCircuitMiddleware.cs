using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

//c Add ShortCircuitMiddleware.cs which will play a role of one middleware component which intercepts the request before the ContentMiddleware gets the request.
//c Update ShortCircuitMiddleware.cs by adding code to cooperate with BrowserTypeMiddleware middleware component which is acted before ShortCircuitMiddleware.

namespace ConfiguringApps.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate nextDelegate;

        public ShortCircuitMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Items["EdgeBrowser"] as bool? == true)
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}