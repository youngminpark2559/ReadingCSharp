using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//c I verify if the request is from https or not through Request.IsHttps.
//c Apply [RequireHttps] filter to action method.
//c Apply [RequireHttps] filter to HomeController.
//c Apply custom filter by decorating HomeController with [HttpsOnly].
//c Apply custom action filter to HomeController. I can apply the action filter for action method and controller.
//c Apply a custom result filter to HomeController.
//c By applying [ViewResultDetails] result filter, I can add data into response object aside from string message(This is..).
//c Apply a custom hybrid action/result filter by using [Profile] and [ViewResultDetails].

namespace Filters.Controllers
{
    [Profile]
    [ViewResultDetails]
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Message", "This is the Index action on the Home controller");

        public ViewResult SecondAction() => View("Message", "This is the SecondAction action on the Home controller");
    }
}