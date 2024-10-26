using Microsoft.EntityFrameworkCore;
using ProductApp.Data;
using ProductApp.Models;
namespace ProductApp.Repositories
{
    public class productRepo : IproductRepo 
    {
        private readonly DemoDbContext _context;

        //for database
        public productRepo(DemoDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            //return _products;
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException("Product Not Found");
            }
            return product;
        }

        public async Task AddProductAsync(Product product)
        {

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {

            var productDetail = await _context.Products.FindAsync(product.Id);

            if (productDetail == null)
            {
                //Handle the case where the product doesn't exist
                throw new KeyNotFoundException("Product Not found");
            }
            productDetail.Name = product.Name;
            productDetail.Description = product.Description;
            productDetail.Price = product.Price;

            await _context.SaveChangesAsync();

        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

            }
        }



        public async Task UploadFileAsync(ImageDetail imageDetails)
        {
            await _context.ImageDetails.AddAsync(imageDetails);
            await _context.SaveChangesAsync();
        }
    }
}

