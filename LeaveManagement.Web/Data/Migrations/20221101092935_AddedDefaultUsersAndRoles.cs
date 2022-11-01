using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac", "c499e9f8-c0cc-4418-a79a-cc90dc711239", "Administrator", "ADMINISTRATOR" },
                    { "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad", "2396d8b9-7cf1-4cb9-b7a2-17b115aa8cdf", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000", 0, "f870a600-775e-41f4-859d-93e1112c201b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iskasigalingging@localhost.com", true, "Iska", "Sigalingging", false, null, "ISKASIGALINGGING@LOCALHOST.COM", "ISKASIGALINGGING@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKyIHEjjeMgiIlBrTB1UIZa1xI7LfNGQwPH+5cDH6xELQp/1jNmfSXdV3sF9yPNsVw==", null, false, "d862aaca-c813-4939-b4e7-272b87904347", null, false, "iskasigalingging@localhost.com" },
                    { "cdaf8316-04fb-4913-89d9-9fc9635a50a6", 0, "f06457e4-8b63-42ce-bc98-19dbc3a486e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "martinlumbangaol880@gmail.com", true, "Martin", "Halomoan", false, null, "MARTINLUMBANGAOL880@GMAIL.COM", "MARTINLUMBANGAOL880@GMAIL.COM", "AQAAAAEAACcQAAAAELdoP2YvKZNrp2qL5Dgj03Abpeey7sYvd/qsRNjuk5OdyMfkJIy0sAqUCVo20ZO2Ig==", null, false, "cb050df3-2859-48e8-844a-5da9e5d6c404", null, false, "martinlumbangaol880@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad", "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac", "cdaf8316-04fb-4913-89d9-9fc9635a50a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad", "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac", "cdaf8316-04fb-4913-89d9-9fc9635a50a6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaf8316-04fb-4913-89d9-9fc9635a50a6");
        }
    }
}
