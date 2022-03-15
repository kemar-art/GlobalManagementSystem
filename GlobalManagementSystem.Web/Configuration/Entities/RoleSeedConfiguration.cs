using GlobalManagementSystem.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobalManagementSystem.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ed8547af - bd5d - 485c - b717 - a200dd49fa9a",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "eae8547af - bd5d - 475a - b777 - a200bd49fe9a",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }

            );
        }
    }
}