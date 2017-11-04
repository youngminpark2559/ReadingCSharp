using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

//c Add ShortCircuitMiddleware.cs which will play a role of one middleware component which intercepts the request before the ContentMiddleware gets the request.

namespace ConfiguringApps.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate nextDelegate;

        public ShortCircuitMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Headers["User-Agent"]
                    .Any(h => h.ToLower().Contains("edge")))
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