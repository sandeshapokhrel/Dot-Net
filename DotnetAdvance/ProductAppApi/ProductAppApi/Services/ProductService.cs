
using Microsoft.EntityFrameworkCore;
using ProductAppApi.Models;
using ProductAppApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductAppApi.Services;

namespace ProductAppApi.Services
{
    public class ProductService : IproductService
    {
        private readonly IproductRepo _productRepository;

        public ProductService(IproductRepo productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() // Corrected method call
        {
            return await _productRepository.GetAllProductsAsync(); // Use the correct repository method
        }

        public async Task<Product> GetProductByIdAsync(int id) // Match interface method
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _productRepository.AddProductAsync(product);
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
            return product;
        }

        public async Task<Product> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product != null)
            {
                await _productRepository.DeleteProductAsync(id);
            }
            return product;
        }

        public async Task<Product> UploadFileAsync(ImageDetail imageDetail)
        {
            await _productRepository.UploadFileAsync(imageDetail);

            // Assuming that you want to return a Product object based on ImageDetail
            return new Product
            {
                ImageUrl = imageDetail.ImagePath // Example; adjust as needed
            };
        }
    }
}
