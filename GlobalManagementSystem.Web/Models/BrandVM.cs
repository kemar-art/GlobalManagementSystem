using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace GlobalManagementSystem.Web.Models
{
    public class BrandVM : BaseVM
    {
        [Required]
        public string Name { get; set; }
    }
}
