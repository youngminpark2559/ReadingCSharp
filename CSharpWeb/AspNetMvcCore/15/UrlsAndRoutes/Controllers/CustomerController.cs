﻿using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

//c Update List()
//c Add attribute route [Route("myroute")] on Index(). With this setting, I can access like this, /Customer/List for List(), /myroute for Index(). 

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        [Route("myroute")]
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });

        public ViewResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(List),
            };
            r.Data["Id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}