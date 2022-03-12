using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ProductTypeVM : BaseVM
    {
        [ForeignKey("BrandId")]
        public BrandVM? Brand { get; set; }
        public int BrandId { get; set; }

        [Display(Name = "Type")]
        [Required]
        public string Name { get; set; }
    }
}
