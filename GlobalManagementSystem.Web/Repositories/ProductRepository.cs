using AutoMapper;
using GlobalManagementSystem.Web.Contracts;
using GlobalManagementSystem.Web.Data;
using GlobalManagementSystem.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace GlobalManagementSystem.Web.Repositoriesy
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ProductRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            this._context = context;
            this.mapper = mapper;
        }

        public async Task<ProductVM> GetProductview(int id)
        {
            var products = await _context.Products.Include(p => p.Model.ProductType.Brand).Include(p => p.Model.ProductType).Include(p => p.Model).FirstOrDefaultAsync(m => m.Id == id);
            return mapper.Map<ProductVM>(products);
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