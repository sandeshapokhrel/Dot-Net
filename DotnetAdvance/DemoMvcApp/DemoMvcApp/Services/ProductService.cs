using DemoMvcApp.Models;
using DemoMvcApp.Repositories;
using DemoMvcApp.Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public Product GetProduct(int id)
    {
        return _productRepository.GetProductById(id);
    }

    //public void AddProduct(Product product)
    //{
    //    _productRepository.Add(product);
    //}

    //public void UpdateProduct(Product product)
    //{
    //    _productRepository.Update(product);
    //}

    //public void DeleteProduct(int id)
    //{
    //    _productRepository.Delete(id);
    //}
}

