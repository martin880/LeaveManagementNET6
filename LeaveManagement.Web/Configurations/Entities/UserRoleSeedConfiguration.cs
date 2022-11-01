using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
           builder.HasData(
            new IdentityUserRole<string>
                {
                    RoleId = "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                    UserId = "cdaf8316-04fb-4913-89d9-9fc9635a50a6"
            },
             new IdentityUserRole<string>
             {
                 RoleId = "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                 UserId = "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000"
             }

            );
        }
    }
}