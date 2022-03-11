using Microsoft.AspNetCore.Identity;

namespace GlobalManagementSystem.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? TRN { get; set; }
        public string? NIS { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime Datestarted { get; set; }
        public DateTime DateEnded { get; set; }
    }
}
