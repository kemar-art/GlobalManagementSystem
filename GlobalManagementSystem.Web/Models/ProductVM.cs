using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class ProductVM : BaseVM
    {
        [ForeignKey("ModelId")]
        public Model? Model { get; set; }
        public int ModelId { get; set; }

        public string? Description { get; set; }
        public string? Serialnumber { get; set; }
        public double Unitcost { get; set; }
    }
}
