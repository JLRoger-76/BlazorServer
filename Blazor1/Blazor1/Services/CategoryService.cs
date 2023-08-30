using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Blazor1.Data
{
    public class CategoryService
    {
        private readonly IDbContextFactory<Context> factory;
        public CategoryService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.Categories.ToListAsync();
        }

        public async Task<bool> UpdateCategoriesAsync(Category category)
        {
            using (var context = factory.CreateDbContext())
            {
                context.Categories.Update(category);
                await context.SaveChangesAsync();
            }            
            return true;
        }

        public async Task<bool> InsertCategoryAsync(Category category)
        {
            using (var context = factory.CreateDbContext())
            {
                context.Categories.Add(category);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> DeleteCategoryAsync(Category category)
        {
            using (var context = factory.CreateDbContext())
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
            }
            return true;
        }
    }
}
