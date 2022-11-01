using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "cdaf8316-04fb-4913-89d9-9fc9635a50a6",
                    Email = "martinlumbangaol880@gmail.com",
                    NormalizedEmail = "MARTINLUMBANGAOL880@GMAIL.COM",
                    NormalizedUserName = "MARTINLUMBANGAOL880@GMAIL.COM",
                    UserName = "martinlumbangaol880@gmail.com",
                    FirstName = "Martin",
                    LastName = "Halomoan",
                    PasswordHash = hasher.HashPassword(null, "Ar6u!SajxZjv7y4"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000",
                    Email = "iskasigalingging@localhost.com",
                    NormalizedEmail = "ISKASIGALINGGING@LOCALHOST.COM",
                    NormalizedUserName = "ISKASIGALINGGING@LOCALHOST.COM",
                    UserName = "iskasigalingging@localhost.com",
                    FirstName = "Iska",
                    LastName = "Sigalingging",
                    PasswordHash = hasher.HashPassword(null, "at3ktc!dnpJa!2Z"),
                    EmailConfirmed = true
                }
                );
        }
    }
}