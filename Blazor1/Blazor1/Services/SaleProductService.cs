using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class SaleProductService
    {
        private readonly IDbContextFactory<Context> factory;
        public SaleProductService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }

        public async Task<List<SaleProduct>> GetSaleProductsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.SaleProducts.ToListAsync();
        }
        public async Task<List<SaleProduct>> GetSaleProductAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.SaleProducts.Include(s => s.Product).Where(s => s.SaleId == id).ToListAsync();
        }

        public async Task<bool> UpdateSaleProductAsync(SaleProduct saleProduct)
        {
            using (var context = factory.CreateDbContext())
            {
                context.SaleProducts.Update(saleProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> InsertSaleProductAsync(SaleProduct saleProduct)
        {
            using (var context = factory.CreateDbContext())
            {
                context.SaleProducts.Add(saleProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> DeleteSaleProductAsync(SaleProduct saleProduct)
        {
            using (var context = factory.CreateDbContext())
            {
                context.SaleProducts.Remove(saleProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}

