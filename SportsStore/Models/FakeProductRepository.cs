using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product {Name ="Football", Price = 25 },
            new Product {Name ="Ball", Price = 4 },
            new Product {Name ="Shoes", Price = 12 },
        };
    }
}