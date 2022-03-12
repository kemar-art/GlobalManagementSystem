using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ProductVM : BaseVM
    {
        [ForeignKey("ModelId")]
        public ModelVM? Model { get; set; }
        [Required]
        public int ModelId { get; set; }

        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Serialnumber { get; set; }
        public double Unitcost { get; set; }
    }
}
