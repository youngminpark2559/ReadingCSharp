using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;


namespace UrlsAndRoutes.Controllers
{
    public class PubliController : Controller
    {
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(PubliController),
                Action = nameof(Index)
            });
        public ViewResult List() => View("Result",
            new Result
            {
                Controller = nameof(PubliController),
                Action = nameof(List)
            });
    }
}