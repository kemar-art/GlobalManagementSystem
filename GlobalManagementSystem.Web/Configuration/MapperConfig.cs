using AutoMapper;
using GlobalManagementSystem.Web.Data;
using GlobalManagementSystem.Web.Models;

namespace GlobalManagementSystem.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<Brand, BrandVM>().ReverseMap();
            CreateMap<Supplier, SupplierVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<ProductType, ProductTypeVM>().ReverseMap();
            CreateMap<Inventory, InventoryVM>().ReverseMap();
            CreateMap<Restock, RestockVM>().ReverseMap();
            CreateMap<Model, ModelVM>().ReverseMap();
        }
    }
}
