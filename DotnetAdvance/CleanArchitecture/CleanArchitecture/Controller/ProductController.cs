using CleanArchitecture.DTOs;
using CleanArchitecture.UseCase;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Repo;
using CleanArchitecture.Entities;
using CleanArchitecture.DTOs;
using CleanArchitecture.UseCase;

namespace CleanArchitecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductUseCase _createProductUseCase;
        private readonly IProductRepo _productRepository;

        public ProductController(ProductUseCase createProductUseCase, IProductRepo productRepository)
        {
            _createProductUseCase = createProductUseCase;
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDTO productDto)
        {
            await _createProductUseCase.ExecuteAsync(productDto);
            return CreatedAtAction(nameof(GetProduct), new { id = productDto.Id }, productDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDTO productDto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return NotFound();

            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Price = productDto.Price;

            await _productRepository.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
