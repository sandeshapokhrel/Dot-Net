using DemoMvcApp.Models;
using System.Collections.Generic;

namespace DemoMvcApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product); // Ensure this method handles ImagePath.
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        void Save(); // Typically used for committing changes in a repository pattern.
    }
}
