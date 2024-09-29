using Microsoft.EntityFrameworkCore;
using ProductDemoApp.Models; 

namespace ProductDemoApp.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } // Add DbSet for your Product model
    }
}
