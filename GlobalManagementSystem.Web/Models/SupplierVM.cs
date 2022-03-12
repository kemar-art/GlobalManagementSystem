using System.ComponentModel.DataAnnotations;

namespace GlobalManagementSystem.Web.Models
{
    public class SupplierVM : BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contactnumber { get; set; }
        public string Email { get; set; }
    }
}
