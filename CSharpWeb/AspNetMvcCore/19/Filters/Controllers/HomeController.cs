using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//c I verify if the request is from https or not through Request.IsHttps.
//c Apply [RequireHttps] filter to action method.

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ViewResult Index() => View("Message", "This is the Index action on the Home controller");

        [RequireHttps]
        public ViewResult SecondAction() => View("Message", "This is the SecondAction action on the Home controller");
    }
}