using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//c I verify if the request is from https or not through Request.IsHttps.

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            if (!Request.IsHttps)
            {
                return new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
            else
            {
                return View("Message", "This is the Index action on the Home controller");
            }
        }
    }
}