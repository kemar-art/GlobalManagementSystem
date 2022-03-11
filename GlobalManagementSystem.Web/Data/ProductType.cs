using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Data
{
    public class ProductType : BaseEntity
    {
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        public int BrandId { get; set; }

        public string? Name { get; set; }
    }
}
