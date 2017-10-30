using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//c Add IProductRepository.cs which consists of Repository layer which plays a role of logic for storing and retrieving date from persistence data store, in conjunction with classes which implement IProductRepository.cs.

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
