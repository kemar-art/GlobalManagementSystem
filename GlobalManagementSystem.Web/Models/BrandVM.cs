using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace GlobalManagementSystem.Web.Models
{
    public class BrandVM : BaseVM
    {
        [Display(Name = "Manufacturer")]
        [Required]
        public string Name { get; set; }
    }
}
