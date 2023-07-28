using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManagement.Data.Migrations
{
    public partial class addDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8FB4E1AB-7B7E-4A8C-AF5F-CE2D2D5E9188",
                column: "ConcurrencyStamp",
                value: "29222e52-c942-4e4d-bf73-0abb718ec62d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a0c649-5e88-4e33-a5b9-3a7b9911a21e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a6f0a50-5565-42a3-b1f1-32c7537101b4", "02b85941-6600-42f2-8971-6b762c54d999" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58cc2a3c-dc29-4389-bbe5-7aeb7fc02c3b"), "SD" },
                    { new Guid("6cc61a4d-6fd2-439b-bc1c-42c4fd1e8a6e"), "HR" },
                    { new Guid("b1788274-6f92-4c34-bbcc-71d3f5aae3b3"), "Sales" },
                    { new Guid("b4ecd09d-62f7-4345-8acf-320072bd841d"), "QC" },
                    { new Guid("c6a6c322-ef9d-47cb-9214-a3a8a8466003"), "Marketing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("58cc2a3c-dc29-4389-bbe5-7aeb7fc02c3b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6cc61a4d-6fd2-439b-bc1c-42c4fd1e8a6e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b1788274-6f92-4c34-bbcc-71d3f5aae3b3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b4ecd09d-62f7-4345-8acf-320072bd841d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c6a6c322-ef9d-47cb-9214-a3a8a8466003"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8FB4E1AB-7B7E-4A8C-AF5F-CE2D2D5E9188",
                column: "ConcurrencyStamp",
                value: "b9b78448-191f-4f72-9ab7-85368cf95417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a0c649-5e88-4e33-a5b9-3a7b9911a21e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1c59851-01e8-4252-a234-ec0486065bbe", "cdd4b085-570a-4d0f-bf08-31f742a72584" });
        }
    }
}
