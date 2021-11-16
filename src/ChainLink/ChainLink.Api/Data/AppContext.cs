using ChainLink.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ChainLink.Api.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            
        }

        public DbSet<Account> Accounts;
    }
}