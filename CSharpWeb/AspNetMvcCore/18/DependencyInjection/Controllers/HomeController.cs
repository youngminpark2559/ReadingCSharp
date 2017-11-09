using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //c Decouple between MemoryRepository class and HomeController class. I instantiate MemoryRepository object and assgin it into Repository property which is IRepository type. Visual architecture is like this. HomeController -- [IRepository -- MemoryRepository].
        public IRepository Repository { get; set; } = new MemoryRepository();
        public ViewResult Index() => View(Repository.Products);
    }
}