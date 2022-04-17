using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ProductTypeVM : BaseVM
    {
        public BrandVM Brand { get; set; }
        [Display(Name = "Manufacturer")]
        [Required]
        public int BrandId { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public string Name { get; set; }
    }
}
