using System.Text.Json;
using ProductAppClientSide.Models;
using System.Net.Http.Headers;

namespace ProductAppClientSide.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("https://externalapi.com/api/products");

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IEnumerable<Product>>(jsonContent);
            }

            return Enumerable.Empty<Product>();
        }

    }
}
