using CleanArchitecture.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; 
using CleanArchitecture.Entities;

namespace CleanArchitecture.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        // Constructor accepting DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
