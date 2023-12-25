using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Sample Product 1", Type = "Sample type 1", Description = "Sample Description 1", Comments = "Sample Comment 1" },
                new Product { ProductId = 2, Name = "Sample Product 2", Type = "Sample type 2", Description = "Sample Description 2", Comments = "Sample Comment 2" },
                new Product { ProductId = 3, Name = "Sample Product 3", Type = "Sample type 3", Description = "Sample Description 3", Comments = "Sample Comment 3" },
                new Product { ProductId = 4, Name = "Sample Product 4", Type = "Sample type 4", Description = "Sample Description 4", Comments = "Sample Comment 4" }
                );
        }
    }
}
