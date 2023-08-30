using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class SaleService
    {
        private readonly IDbContextFactory<Context> factory;
        public SaleService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<List<Sale>> GetSalesAsync()
        {
            var context = factory.CreateDbContext();
            {
                return await context.Sales.ToListAsync();
            }
        }
        public async Task<int> InsertSaleAsync(Sale sale)
        {
           var context = factory.CreateDbContext();
                await context.Sales.AddAsync(sale);
                await context.SaveChangesAsync();
            return sale.SaleId;
        }
    }
}
