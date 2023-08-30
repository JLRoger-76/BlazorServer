using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class ProductService
    {
        private readonly IDbContextFactory<Context> factory;

        public ProductService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.Products.Include(p => p.Category).ToListAsync();
        }
        public async Task<Product> GetProductAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.Products.FindAsync(id);
        }
        public async Task<bool> UpdateProductAsync(Product product)
        {
            using (var context = factory.CreateDbContext())
            {
                context.Products.Update(product);
                await context.SaveChangesAsync();
            }
            return true;
        }
        public async Task<int> InsertProductAsync(Product product)
        {
            using (var context = factory.CreateDbContext())
            {
                await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
            }
            return product.ProductId;
        }
        public async Task<bool> DeleteProductAsync(Product product)
        {
            var context = factory.CreateDbContext();
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}
