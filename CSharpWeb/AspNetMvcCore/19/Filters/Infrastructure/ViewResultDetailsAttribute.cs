using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading.Tasks;

//c Add ViewResultDetailsAttribute.cs to examine the result filter underlying mechanism.
//c Update ViewResultDetailsAttribute.cs to use asynchronous way for result filter. I should invoke ResultExecutionDelegate type delegate which is passed as an argument.

namespace Filters.Infrastructure
{
    public class ViewResultDetailsAttribute : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(
                ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                ["Result Type"] = context.Result.GetType().Name,
            };

            ViewResult vr;

            if ((vr = context.Result as ViewResult) != null)
            {
                dict["View Name"] = vr.ViewName;
                dict["Model Type"] = vr.ViewData.Model.GetType().Name;
                dict["Model Data"] = vr.ViewData.Model.ToString();
            }

            context.Result = new ViewResult
            {
                ViewName = "Message",
                ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = dict
                }
            };

            await next();
        }
    }
}