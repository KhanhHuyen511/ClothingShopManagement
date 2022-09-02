using Microsoft.EntityFrameworkCore;
using ClothingShopManagement.Models;

namespace ClothingShopManagement.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Bill> Bills { get; set; } = null!; 

        public DbSet<BillDetail> BillDetails { get; set; } = null!;
    }
}
