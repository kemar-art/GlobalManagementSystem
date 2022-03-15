using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobalManagementSystem.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                    UserId = "eb8547af-bd4d-485c-b761-a200dd49fa9a"

                },
                new IdentityUserRole<string>
                {
                    RoleId = "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                    UserId = "02121aa8-c53e-461f-aa80-870381474d56"

                }
             );
        }
    }
}