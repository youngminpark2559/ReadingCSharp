using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

//c Add ProfileAttribute class to create [Profile] action filter.
//c Update ProfileAttribute.cs by using asynchronous way for action filter. ActionExecutionDelegate object represents action method to execute or the next filter to execute.
//c Update ProfileAttribute.cs to use this filter as hybrid filter which is able to do action and result filter.

namespace Filters.Infrastructure
{
    public class ProfileAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;
        private double actionTime;

        public override async Task OnActionExecutionAsync(
                ActionExecutingContext context, ActionExecutionDelegate next)
        {
            timer = Stopwatch.StartNew();
            await next();
            actionTime = timer.Elapsed.TotalMilliseconds;
        }

        public override async Task OnResultExecutionAsync(
                ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();
            timer.Stop();
            string result = "<div>Action time: "
                + $"{actionTime} ms</div><div>Total time: "
                + $"{timer.Elapsed.TotalMilliseconds} ms</div>";
            byte[] bytes = Encoding.ASCII.GetBytes(result);
            await context.HttpContext.Response.Body.WriteAsync(bytes, 0, bytes.Length);
        }
    }
}