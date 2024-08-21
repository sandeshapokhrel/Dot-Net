using DemoMvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoMvcApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Smartphone", Price = 800 },

         new Product { Id = 3, Name = "Smartphone", Price = 800 },

         new Product { Id = 4, Name = "Smartphone", Price = 800 }
            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}

