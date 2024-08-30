using DemoMvcApp.Models;

namespace DemoMvcApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        public Product GetProduct(int id);
        void AddProduct(Product product);

        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        void Save();
    }
}
