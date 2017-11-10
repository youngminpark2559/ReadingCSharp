using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

//c Add RangeExceptionAttribute.cs which is used as exception filter. If the kind of exception which is verified from ExceptionContext object is ArgumentOutOfRangeException, then I create a ViewResult object which contains data.

namespace Filters.Infrastructure
{
    public class RangeExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentOutOfRangeException)
            {
                context.Result = new ViewResult()
                {
                    ViewName = "Message",
                    ViewData = new ViewDataDictionary(
                        new EmptyModelMetadataProvider(),
                        new ModelStateDictionary())
                    {
                        Model = @"The data received by the application cannot be processed"
                    }
                };
            }
        }
    }
}