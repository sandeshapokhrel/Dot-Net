using ProductAppClientSide.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAppClientSide.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync(string token);

    }
}
