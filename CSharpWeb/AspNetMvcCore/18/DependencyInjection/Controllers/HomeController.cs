using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

//c Use dependancy injection in the way of "action injection" which is another way of DI with "constructor injection" and "property injection" . Action injection is worked by model binding.

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
            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = totalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}