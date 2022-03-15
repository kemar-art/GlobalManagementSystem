using GlobalManagementSystem.Web.Contracts;
using GlobalManagementSystem.Web.Data;

namespace GlobalManagementSystem.Web.Repositoriesy
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}









/*using GlobalManagementSystem.Web.Contracts;
using GlobalManagementSystem.Web.Data;


namespace GlobalManagementSystem.Web.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
*/