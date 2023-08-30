using Microsoft.EntityFrameworkCore;

namespace Blazor1.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockProduct> StockProducts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
