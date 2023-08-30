using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class UserService
    {
        private readonly IDbContextFactory<Context> factory;
        public UserService(IDbContextFactory<Context> factory)
        {
            this.factory = factory;
        }
        public async Task<User[]> GetUsersAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.Users.ToArrayAsync();
        }
        public User GetUserConnected(string password)
        {
            using var context = factory.CreateDbContext();
            User user= context.Users.FirstOrDefault(u => u.Password == password);
        return user;
        }
        public async Task<bool> CreateUserAsync(User user)
        {
            var context = factory.CreateDbContext();
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
