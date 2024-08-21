using DemoMvcApp.Models;

namespace DemoMvcApp.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
