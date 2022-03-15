using GlobalManagementSystem.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobalManagementSystem.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "eb8547af-bd4d-485c-b761-a200dd49fa9a",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    Firstname = "admin",
                    Lastname = "admin",
                    PasswordHash = hasher.HashPassword(null, "admin@1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "02121aa8-c53e-461f-aa80-870381474d56",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    Firstname = "user",
                    Lastname = "user",
                    PasswordHash = hasher.HashPassword(null, "user@1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}