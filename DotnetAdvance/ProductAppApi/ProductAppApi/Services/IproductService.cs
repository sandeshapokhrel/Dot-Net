using ProductAppApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAppApi.Services
{
    public interface IproductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<Product> DeleteProductAsync(int id);
        Task<Product> UploadFileAsync(ImageDetail imageDetail);
    }
}
