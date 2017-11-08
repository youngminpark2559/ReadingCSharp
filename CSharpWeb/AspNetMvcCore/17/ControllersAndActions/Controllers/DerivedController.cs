using Microsoft.AspNetCore.Mvc;

//c Add DerivedController.cs which inherits Controller base class including many features of it.

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() =>
            View("Result", $"This is a derived controller");
    }
}