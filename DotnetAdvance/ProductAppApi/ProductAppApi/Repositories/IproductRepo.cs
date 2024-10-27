using ProductAppApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAppApi.Repositories
{
    public interface IproductRepo
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task UploadFileAsync(ImageDetail imageDetail);
    }
}
