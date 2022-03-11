using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ModelVM : BaseVM
    {
        [ForeignKey("ProductTypeId")]
        public ProductType? ProductType { get; set; }
        public int ProductTypeId { get; set; }

        public string? Name { get; set; }
    }
}
