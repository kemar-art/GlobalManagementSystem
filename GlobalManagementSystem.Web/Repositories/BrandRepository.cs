using GlobalManagementSystem.Web.Contracts;
using GlobalManagementSystem.Web.Data;

namespace GlobalManagementSystem.Web.Repositoriesy
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
