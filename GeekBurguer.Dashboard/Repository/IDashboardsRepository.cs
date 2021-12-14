using GeekBurguer.Dashboard.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GeekBurguer.Dashboard.Repository
{
    public interface IDashboardsRepository
    {
        IEnumerable<Product> GetProductsByStoreName(string storeName);
    }

    public class DashboardsRepository : IDashboardsRepository
    {
        private DashboardsDbContext _context;

        public DashboardsRepository(DashboardsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product>
            GetProductsByStoreName(string storeName)
        {
            var products = _context.Products?
            .Where(product =>
                product.Store.Name.Equals(storeName,
                StringComparison.InvariantCultureIgnoreCase))
            .Include(product => product.Items);

            return products;
        }

    }
}
