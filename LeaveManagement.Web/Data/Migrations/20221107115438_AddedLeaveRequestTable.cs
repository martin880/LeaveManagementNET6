using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
