using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Linq;

//c Using MVC API in PocoController.cs.
//c Add property which is ControllerContext type and decorated by [ControllerContext]. This property provides the features which are provided by MVC API.

namespace ControllersAndActions.Controllers
{
    public class PocoController
    {

        [ControllerContext]
        public ControllerContext ControllerContext { get; set; }

        public ViewResult Index() => new ViewResult()
        {
            ViewName = "Result",
            ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(),
                    new ModelStateDictionary())
            {
                Model = $"This is a POCO controller"
            }
        };

        public ViewResult Headers() =>
            new ViewResult()
            {
                ViewName = "DictionaryResult",
                ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(),
                    new ModelStateDictionary())
                {
                    Model = ControllerContext.HttpContext.Request.Headers
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())
                }
            };

    }
}