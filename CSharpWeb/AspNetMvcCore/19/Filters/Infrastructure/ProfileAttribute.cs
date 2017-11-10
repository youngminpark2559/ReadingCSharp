using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

//c Add ProfileAttribute class to create [Profile] action filter.
//c Update ProfileAttribute.cs by using asynchronous way for action filter. ActionExecutionDelegate object represents action method to execute or the next filter to execute.

namespace Filters.Infrastructure
{
    public class ProfileAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(
                ActionExecutingContext context,
                ActionExecutionDelegate next)
        {
            Stopwatch timer = Stopwatch.StartNew();
            await next();
            timer.Stop();
            string result = "<div>Elapsed time: " + $"{timer.Elapsed.TotalMilliseconds} ms</div>";
            byte[] bytes = Encoding.ASCII.GetBytes(result);
            await context.HttpContext.Response.Body.WriteAsync(bytes, 0, bytes.Length);
        }
    }
}