using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class SupplierService
    {
        private readonly IDbContextFactory<Context> factory;
        public SupplierService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            var context = factory.CreateDbContext();
            {
                return await context.Suppliers.ToListAsync();
            }
        }
        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            var context = factory.CreateDbContext();
            {
                context.Suppliers.Update(supplier);
                await context.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> InsertSupplierAsync(Supplier supplier)
        {
            var context = factory.CreateDbContext();
            await context.Suppliers.AddAsync(supplier);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteSupplierAsync(Supplier supplier)
        {
            var context = factory.CreateDbContext();
            {
                context.Suppliers.Remove(supplier);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}
