using DemoMvcApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoMvcApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all products
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();

        }

        // Get product by ID
        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        // Add a new product
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            Save();
        }

        // Update an existing product
        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            Save();
        }

        // Delete a product by ID
        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                Save();
            }
        }

        // Save changes to the database
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}

