using Microsoft.EntityFrameworkCore;
using ProductApp.Models;



namespace ProductApp.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ImageDetail> ImageDetails { get; set; } // Ensure this is included

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optionally configure the table names and relationships
            modelBuilder.Entity<ImageDetail>()
                .ToTable("ImageDetails"); // Ensure the table name matches

            // Configure foreign key relationship
            modelBuilder.Entity<ImageDetail>()
                .HasOne(i => i.Product)
                .WithMany() // Assuming Product does NOT have a collection of ImageDetails
                .HasForeignKey(i => i.ProductId);
        }

    }
}
