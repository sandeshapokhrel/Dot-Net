using CleanArchitecture.DTOs;
using CleanArchitecture.Entities;
using CleanArchitecture.Repo;

namespace CleanArchitecture.UseCase
{
    public class ProductUseCase
    {
        private readonly IProductRepo _productRepository;

        // Corrected the constructor name to match the class name and updated the parameter type
        public ProductUseCase(IProductRepo productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task ExecuteAsync(ProductDTO productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price
            };

            await _productRepository.AddAsync(product);
        }
    }
}
