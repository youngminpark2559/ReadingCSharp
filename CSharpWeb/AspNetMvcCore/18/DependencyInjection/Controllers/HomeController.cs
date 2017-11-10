using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

//c Use dependancy injection in the way of "action injection" which is another way of DI with "constructor injection" and "property injection" . Action injection is worked by model binding.
//c I can use service provider directly. This is the way of getting implementation for an interface without relying on injection.

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private ProductTotalizer totalizer;
        
        public HomeController(IRepository repo, ProductTotalizer total)
        {
            repository = repo;
            totalizer = total;
        }

        public ViewResult Index([FromServices]ProductTotalizer totalizer)
        {
            IRepository repository =
                 HttpContext.RequestServices.GetService<IRepository>();

            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = totalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}