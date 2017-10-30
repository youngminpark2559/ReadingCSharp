using System.Collections.Generic;
using System.Linq;

//c Add FakeProductRepository.cs which implements IProductRepository.(Client->IProductRepository->FakeProductRepository is for testing, Client-IProductRepository->ProductRepository is for accessing to DB.)

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        }.AsQueryable<Product>();
    }
}