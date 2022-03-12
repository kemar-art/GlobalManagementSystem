using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ModelVM : BaseVM
    {
        [ForeignKey("ProductTypeId")]
        public ProductTypeVM? ProductType { get; set; }
        public int ProductTypeId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
