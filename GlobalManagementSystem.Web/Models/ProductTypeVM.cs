using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ProductTypeVM : BaseVM
    {
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        public int BrandId { get; set; }

        public string? Name { get; set; }
    }
}
