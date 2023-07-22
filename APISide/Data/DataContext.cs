using APISide.Entities;
using Microsoft.EntityFrameworkCore;

namespace APISide.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        // public DbSet<EFMigrationsHistory> __EFMigrationsHistory { get; set; }
    }
}