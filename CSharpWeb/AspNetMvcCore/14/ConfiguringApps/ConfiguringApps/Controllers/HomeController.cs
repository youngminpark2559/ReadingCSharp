using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infrastructure;

//c Add HomeController
//c Update HomeController by configuring HomeController to accept UptimeService object from Startup service provider and assign that service object to the field.
//c Update HomeController by editing Index(), adding Error(). UseExceptionHandler middleware brings the flow to HomeController\Error(), and this action method brings the flow to the Index() with adding descriptive message into Dictionary object.

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index(bool throwException = false)
        {
            if (throwException)
            {
                throw new System.NullReferenceException();
            }
            return View(new Dictionary<string, string>
            {
                ["Message"] = "This is the Index action",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
        }
        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string>
            {
                ["Message"] = "This is the Error action"
            });
    }
}
