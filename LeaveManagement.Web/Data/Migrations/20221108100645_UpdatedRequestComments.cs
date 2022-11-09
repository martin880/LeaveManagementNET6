using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                column: "ConcurrencyStamp",
                value: "c13e9443-5e89-4184-a37e-49f29f1e39ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                column: "ConcurrencyStamp",
                value: "3616bba5-28a0-4baa-b7e0-d9abf8622364");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0371bbe6-d30e-450e-b9e0-2bf85d2b2836", "AQAAAAEAACcQAAAAECBhxUuaRvcu6F/o0XVYXn9M5i7yohaAoQ1VcMYLfAN2Y04vJaEA/PnfGQMSNPNaGg==", "50631fa1-5721-46fa-a07f-501a02eeee79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaf8316-04fb-4913-89d9-9fc9635a50a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbac3d28-799d-4943-8879-ebb3596315a0", "AQAAAAEAACcQAAAAENdHvp4y0p42cmSHLK7oIZgVonzsBoCeWwFaRZBgPiUuUeSXv9U+RSuVMVZbuMFXBA==", "8ad33939-c6ed-45de-9bc7-854029576854" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e85557-c0bc-4fc2-989a-a6b1bc4cd7ac",
                column: "ConcurrencyStamp",
                value: "180ca33f-89b0-41da-ba21-f8a6b09d435c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e86667-c0cb-4fd3-989a-a5b2bc3cd8ad",
                column: "ConcurrencyStamp",
                value: "a7206fc6-197e-4299-8e5f-907d2c5e5206");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d72e4a4-cf98-4bd4-b4ba-91a6401f4000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33e9a37a-877f-46e4-b264-2271dc20bc74", "AQAAAAEAACcQAAAAEMvki4BVEX83GFNgJK2W6Eu3FNyaylAbPa1Lb6wURN9gtOb2EmbZiVZjaULCqTCOvw==", "6df99d8a-eec1-458d-9669-422456fee2fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaf8316-04fb-4913-89d9-9fc9635a50a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54625000-031f-4f41-a42f-bd412f1e438a", "AQAAAAEAACcQAAAAEDJAzYLJ7JtkonSfpuQZDifHG/k1u4DOE/FUfjrbC0iyqelloKAH19Dw6oOUg4UTOw==", "f0c608c8-2404-4916-9adf-e0c2b8eae637" });
        }
    }
}
