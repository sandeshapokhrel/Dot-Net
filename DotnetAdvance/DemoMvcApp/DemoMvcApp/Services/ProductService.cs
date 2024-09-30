using DemoMvcApp.Models;
using DemoMvcApp.Repositories;
using DemoMvcApp.Services;
using Microsoft.AspNetCore.Hosting; // For handling file uploads
using System.IO; // For handling file paths

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IWebHostEnvironment _hostingEnvironment; // To access the server environment

    public ProductService(IProductRepository productRepository, IWebHostEnvironment hostingEnvironment)
    {
        _productRepository = productRepository;
        _hostingEnvironment = hostingEnvironment;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }

    public Product GetProduct(int id)
    {
        return _productRepository.GetProductById(id);
    }

    public void AddProduct(Product product, IFormFile imageFile) // Accept image file
    {
        if (imageFile != null && imageFile.Length > 0)
        {
            // Set the path to save the image
            var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName; // Create a unique file name
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            // Save the file to the server
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(fileStream); // Copy the uploaded file to the specified path
            }

            product.ImagePath = "/images/" + uniqueFileName; // Store the image path in the product
        }

        _productRepository.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    public void DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
    }

    public void Save()
    {
        _productRepository.Save();
    }
}
