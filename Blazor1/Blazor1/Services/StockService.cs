
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class StockService
    {
        private readonly IDbContextFactory<Context> factory;
        public StockService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<List<Stock>> GetStocksAsync()
        {
            var context = factory.CreateDbContext();
            {
                return await context.Stocks.ToListAsync();
            }
        }
        public async Task<bool> UpdateStockAsync(Stock stock)
        {
            var context = factory.CreateDbContext();
            {
                context.Stocks.Update(stock);
                await context.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> InsertStockAsync(Stock stock)
        {
            var context = factory.CreateDbContext();
            await context.Stocks.AddAsync(stock);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteStockAsync(Stock stock)
        {
            var context = factory.CreateDbContext();
            {
                context.Stocks.Remove(stock);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}
