using GeekBurguer.Dashboard.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekBurguer.Dashboard.Repository
{
    public class DashboardsDbContext : DbContext
    {
        public DashboardsDbContext(DbContextOptions<DashboardsDbContext> options) : 
            base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }

        public DbSet<Item> Items { get; set; }

    }
}
