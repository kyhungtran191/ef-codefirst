using System.Data.Entity;

namespace EFCore_CodeFirst.Models
{
    public class CompanyDBContext : DbContext
    {
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
    }
}
