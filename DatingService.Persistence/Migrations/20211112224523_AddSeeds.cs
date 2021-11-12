using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"), "b9aaddfe-6b1e-41d6-8ab7-44ffe74c9818", "SuperAdmin", null },
                    { new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"), "2369894e-9e48-423a-84d2-7d69ed7dacc6", "Admin", null },
                    { new Guid("d821eb23-2337-4e31-a53d-fcec01900507"), "25817d6a-3513-4956-b076-beac340b106d", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8e034e7e-7424-4dea-94b7-0ce34a160bef"), 0, null, "eb3db08f-39f9-4c44-bb6c-0ba0dd109ff0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", true, "SuperAdmin", null, "SuperAdmin", null, false, null, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, false, "superadmin" },
                    { new Guid("5f7578c4-3946-4f25-a8c5-dcdc4f77a06d"), 0, null, "6e7d3b59-2f29-49dc-ae84-174542b67228", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "User", null, "User", null, false, null, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"), new Guid("8e034e7e-7424-4dea-94b7-0ce34a160bef") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"), new Guid("8e034e7e-7424-4dea-94b7-0ce34a160bef") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f7578c4-3946-4f25-a8c5-dcdc4f77a06d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e034e7e-7424-4dea-94b7-0ce34a160bef"));
        }
    }
}
