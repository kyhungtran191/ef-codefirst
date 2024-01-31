using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst.Models
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions options) : base(options) { 
        }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Brand>().HasData(new Brand()
            {
                BrandId = 121312321,
                BrandName = "Brand 1"
            }, new Brand()
            {
                BrandId = 12131221321,
                BrandName = "Brand 3"
            });
        }
    }
}
