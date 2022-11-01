using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                    new IdentityRole
                    {
                        Id = "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                        Name = Roles.User,
                        NormalizedName = Roles.User.ToUpper()
                    }
                );
        }
    }
}