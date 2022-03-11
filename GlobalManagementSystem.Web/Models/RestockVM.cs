using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class RestockVM : BaseVM
    {
        public Product? Product { get; set; }
        public int ProductId { get; set; }

        public int QTY { get; set; }
        public double Cost { get; set; }
        public DateTime Orderdate { get; set; }
        public DateTime Arriveddate { get; set; }
        public string? Orderstatus { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }
        public int SupplierId { get; set; }
    }
}
