using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Data
{
    public class Product : BaseEntity
    {
        [ForeignKey("ModelId")]
        public Model? Model { get; set; }
        public int ModelId { get; set; }

        public string? Description { get; set; }
        public string? Serialnumber { get; set; }
        public double Unitcost { get; set; }
    }
}
