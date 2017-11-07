using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

//c I use id parameter in CustomVariable(). I already set URL mapping template to {controller=Home}/{action=Index}/{id=DefaultId}. So, whatever client input in id segment, this is passed into id parameter of CustomVariable().
//c I use null coalescing operator for the case that id is null passed from URL. When the id is null, I assign a specific words(<no value>) into Result object.

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });

        public ViewResult CustomVariable(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable),
            };

            //r.Data["Id"] = id;
            r.Data["Id"] = id ?? "<no value>";
            return View("Result", r);
        }
    }
}