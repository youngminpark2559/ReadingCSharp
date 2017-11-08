using Microsoft.AspNetCore.Mvc;
using System.Linq;

//c Add DerivedController.cs which inherits Controller base class including many features of it.
//c Add Headers(). I use Request property of Controller base class which returns HttpRequest object. This object contains informations of http request from client web browser. I convert informations of header to dictionary and send this object to DictionaryResult view. And I display this object in the web page by view file.

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() =>
            View("Result", $"This is a derived controller");

        public ViewResult Headers() => View("DictionaryResult",
                Request.Headers.ToDictionary(kvp => kvp.Key,
                    kvp => kvp.Value.First()));
    }
}