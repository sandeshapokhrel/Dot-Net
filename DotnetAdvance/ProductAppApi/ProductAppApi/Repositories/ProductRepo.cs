using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProductAppApi.Data;
using ProductAppApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAppApi.Repositories
{
    public class productRepo : IproductRepo
    {
        private readonly DemoDbContext _context;

        // Constructor for database context
        public productRepo(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
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
                throw new KeyNotFoundException("Product Not Found");
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

        // New transactional method without inventory
        public async Task<bool> ProcessOrderAsync(Product product)
        {
            using (IDbContextTransaction transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Add the product to the database
                    await _context.Products.AddAsync(product);

                    // Commit changes as a transaction
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return true;
                }
                catch (Exception)
                {
                    // Rollback the transaction on error
                    await transaction.RollbackAsync();
                    return false;
                }
            }
        }
    }
}
