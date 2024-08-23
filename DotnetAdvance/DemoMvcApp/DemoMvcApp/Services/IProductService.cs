using DemoMvcApp.Models;

namespace DemoMvcApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}
