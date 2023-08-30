using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class StockProductService
    {
        private readonly IDbContextFactory<Context> factory;
        public StockProductService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<List<StockProduct>> GetStockProductsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.StockProducts.Include(s => s.Product).Include(s => s.Stock).ToListAsync();
        }

        public async Task<List<StockProduct>> GetStockProductAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.StockProducts.Include(s => s.Product).Where(s => s.StockId == id).ToListAsync();
        }
        public async Task<List<StockProduct>> GetStockProductPAsync(string parameters)
        {
            Parameter parameter = JsonSerializer.Deserialize<Parameter>(parameters);
            using var context = factory.CreateDbContext();
            return await context.StockProducts.Include(s => s.Product)
            .Where(s => s.StockId == parameter.StockId
                   && s.Product.CategoryId == parameter.CategoryId
                   && s.Product.Name.Contains(parameter.SearchTerm))
            .ToListAsync();
        }
        public async Task<StockProduct> GetStockProduct2Async(string compositeId)
        {
            int[] ids = compositeId.Split('&').Select(Int32.Parse).ToArray();
            using var context = factory.CreateDbContext();
            return await context.StockProducts.Include(s => s.Product).
                    Where(s => s.StockId == ids[0] & s.ProductId == ids[1]).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateStockProductAsync(StockProduct stockProduct)
        {
            using (var context = factory.CreateDbContext())
            {
                context.StockProducts.Update(stockProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> InsertStockProductAsync(StockProduct stockProduct)
        {
            using var context = factory.CreateDbContext();
            await context.StockProducts.AddAsync(stockProduct);
            await context.SaveChangesAsync();
            return true;
        }

        public void DeleteStockProduct(StockProduct stockProduct)
        {
            using var context = factory.CreateDbContext();
            context.StockProducts.Remove(stockProduct);
            context.SaveChanges();
        }
    }
}
