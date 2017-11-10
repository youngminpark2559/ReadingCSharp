using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//c I verify if the request is from https or not through Request.IsHttps.
//c Apply [RequireHttps] filter to action method.
//c Apply [RequireHttps] filter to HomeController.

namespace Filters.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Message", "This is the Index action on the Home controller");

        public ViewResult SecondAction() => View("Message", "This is the SecondAction action on the Home controller");
    }
}