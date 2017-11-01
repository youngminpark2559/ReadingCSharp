using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System.Linq;

//c Update ProductController.cs to correct page number. If the category is not selected(category==null), entire number of Product is assigned to TotalItems. If certain category is selected, the number of that category is assigned to TotalItems.

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int productPage = 1)
           => View(new ProductsListViewModel
           {
               Products = repository.Products
                   .Where(p => category == null || p.Category == category)
                   .OrderBy(p => p.ProductID)
                   .Skip((productPage - 1) * PageSize)
                   .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems =  category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e => e.Category == category).Count()
               },
               CurrentCategory = category
           });
    }
}