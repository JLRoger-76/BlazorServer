using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class SupplierProductService
    {
        private readonly IDbContextFactory<Context> factory;
        public SupplierProductService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<List<SupplierProduct>> GetSupplierProductsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.SupplierProducts.Include(s => s.Product).Include(s => s.Supplier).ToListAsync();
        }

        public async Task<List<SupplierProduct>> GetSupplierProductAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.SupplierProducts.Include(s => s.Product).Where(s => s.SupplierId == id).ToListAsync();
        }
        
        public async Task<bool> UpdateSupplierProductAsync(SupplierProduct supplierProduct)
        {
            using (var context = factory.CreateDbContext())
            {
                context.SupplierProducts.Update(supplierProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> InsertSupplierProductAsync(SupplierProduct supplierProduct)
        {
            var context = factory.CreateDbContext();
            await context.SupplierProducts.AddAsync(supplierProduct);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSupplierProductAsync(SupplierProduct supplierProduct)
        {
            var context = factory.CreateDbContext();
            {
                context.SupplierProducts.Remove(supplierProduct);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}

