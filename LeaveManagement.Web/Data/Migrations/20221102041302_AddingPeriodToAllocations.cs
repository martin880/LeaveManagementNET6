using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                column: "ConcurrencyStamp",
                value: "2371b2a1-0b0e-4b06-ab50-d6107a03a94a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                column: "ConcurrencyStamp",
                value: "32cf4044-cf6c-41e0-ab25-0d1560bcb877");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff73fffd-8c9e-4c4d-a909-5dc7fa75033d", "AQAAAAEAACcQAAAAEG6rdsY67POj3ZSobg3mpr0FJfV8OSdiRE4xEbahAFr4piztp6qTzrwH/ysHz/LZOQ==", "180a3305-e6db-412b-844e-4db942288ceb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaf8316-04fb-4913-89d9-9fc9635a50a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836e6d4b-d203-4fad-87b4-e2a72ace3e6c", "AQAAAAEAACcQAAAAEC40FF6DaJ6xtdFJrXiuMbuGpMzR8BjdvnO7RYFYJ71uTuCkw2feBDG29ekmsuSXyg==", "83106119-fea7-43f4-96ae-985e3d4822b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                column: "ConcurrencyStamp",
                value: "c499e9f8-c0cc-4418-a79a-cc90dc711239");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                column: "ConcurrencyStamp",
                value: "2396d8b9-7cf1-4cb9-b7a2-17b115aa8cdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f870a600-775e-41f4-859d-93e1112c201b", "AQAAAAEAACcQAAAAEKyIHEjjeMgiIlBrTB1UIZa1xI7LfNGQwPH+5cDH6xELQp/1jNmfSXdV3sF9yPNsVw==", "d862aaca-c813-4939-b4e7-272b87904347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaf8316-04fb-4913-89d9-9fc9635a50a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f06457e4-8b63-42ce-bc98-19dbc3a486e9", "AQAAAAEAACcQAAAAELdoP2YvKZNrp2qL5Dgj03Abpeey7sYvd/qsRNjuk5OdyMfkJIy0sAqUCVo20ZO2Ig==", "cb050df3-2859-48e8-844a-5da9e5d6c404" });
        }
    }
}
