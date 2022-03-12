using GlobalManagementSystem.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalManagementSystem.Web.Models
{
    public class InventoryVM : BaseVM
    {
        [ForeignKey("ProductId")]
        public ProductVM? Product { get; set; }
        public int ProductId { get; set; }

        public int QTY { get; set; }
        public string? Status { get; set; }
    }
}
