using Microsoft.AspNetCore.Mvc;

//c The first way of retrieving data from the form, by using HttpRequest.Form property.
//c This is the second way of retrieving data from the form. MVC checks all context objects automatically such as Request.QueryString, Request.Form, RouteData.Value etc, and provides values for action method parameters. The names of the parameters are case-insensitive such as Request.Form[City] and string city.

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //}
        
        public ViewResult ReceiveForm(string name, string city)
            => View("Result", $"{name} lives in {city}");
    }
}