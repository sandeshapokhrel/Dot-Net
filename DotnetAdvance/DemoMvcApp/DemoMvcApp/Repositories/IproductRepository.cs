using DemoMvcApp.Models;

namespace DemoMvcApp.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        public void Save();




        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}
