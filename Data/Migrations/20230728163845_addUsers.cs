using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManagement.Data.Migrations
{
    public partial class addUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreateVacationRequestVM_Departments_DepartmentId",
                table: "CreateVacationRequestVM");

            migrationBuilder.DropIndex(
                name: "IX_CreateVacationRequestVM_DepartmentId",
                table: "CreateVacationRequestVM");

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
                value: "db308bea-452a-4b33-8aca-5a22de913adb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a0c649-5e88-4e33-a5b9-3a7b9911a21e",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "b23b2c9f-8516-472b-820c-80b7b8f2ca2c", "Manager@Email.com", "MANAGER@EMAIL.COM", "MANAGER", "75156847-55f0-46ae-aef5-df6e3989ec4f", "Manager" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00b2ce4e-81eb-4882-af7a-1aa48e34c2fc", 0, "0fc78a8e-6444-4645-ab5c-4bda3a10954d", "Employee@gmail.com", false, false, null, "EMPLOYEE@GMAIL.COM", "EMPLOYEE", "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg==", null, false, "44a68553-a84f-4a6a-89ee-6bc001e1a3b3", false, "Employee" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("17351a56-7445-4a15-a3ad-d3bdc84f0ab6"), "Sales" },
                    { new Guid("6b318638-9772-49fe-9c0d-fd7224089da4"), "QC" },
                    { new Guid("750fa262-bf95-4255-bb12-666340f5e43a"), "SD" },
                    { new Guid("ebfbaa34-4c8f-4b6c-8a04-f1fb90973d43"), "Marketing" },
                    { new Guid("fbb0f052-f509-4190-9844-017374fea077"), "HR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00b2ce4e-81eb-4882-af7a-1aa48e34c2fc");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("17351a56-7445-4a15-a3ad-d3bdc84f0ab6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6b318638-9772-49fe-9c0d-fd7224089da4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("750fa262-bf95-4255-bb12-666340f5e43a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ebfbaa34-4c8f-4b6c-8a04-f1fb90973d43"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbb0f052-f509-4190-9844-017374fea077"));

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9a6f0a50-5565-42a3-b1f1-32c7537101b4", "MahmoudNasser@gmail.com", "MAHMOUDNASSER@GMAIL.COM", "MAHMOUDNASSER", "02b85941-6600-42f2-8971-6b762c54d999", "MahmoudNasser" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CreateVacationRequestVM_DepartmentId",
                table: "CreateVacationRequestVM",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreateVacationRequestVM_Departments_DepartmentId",
                table: "CreateVacationRequestVM",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
