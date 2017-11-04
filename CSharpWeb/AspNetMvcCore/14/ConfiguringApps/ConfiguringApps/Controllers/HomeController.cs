using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infrastructure;

//c Add HomeController
//c Update HomeController by configuring HomeController to accept UptimeService object from Startup service provider and assign that service object to the field.


namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index()
            => View(new Dictionary<string, string>
            {
                ["Message"] = "This is the Index action",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
    }
}