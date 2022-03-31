using System.ComponentModel.DataAnnotations;

namespace GlobalManagementSystem.Web.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string TRN { get; set; }
        public string NIS { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Datestarted { get; set; }
        public DateTime DateEnded { get; set; }
    }
}
