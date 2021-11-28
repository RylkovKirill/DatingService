using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_ReceiverId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_SenderId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReportCategory_ReportCategoryId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "Reports");

            migrationBuilder.RenameIndex(
                name: "IX_Report_SenderId",
                table: "Reports",
                newName: "IX_Reports_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ReportCategoryId",
                table: "Reports",
                newName: "IX_Reports_ReportCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ReceiverId",
                table: "Reports",
                newName: "IX_Reports_ReceiverId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ReportCategory",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ReportCategory",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                maxLength: 4096,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "d41000cd-3cb3-4deb-b2f1-ca51c619f680");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "fb421fa5-4117-4647-a316-2544f9479a8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe114dd-a2bf-4958-9cde-68726589488b", "AQAAAAEAACcQAAAAEHjhregGXZSo0kkSXUd47I5ywfNCRzXY4sU45e2Jz8cRYDOTWPKIEYbOoHiHI1anFQ==", "c1f00279-e845-4a80-861a-38920dd1372c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f0a117-3373-4646-abb5-fd8ab1752ff1", "AQAAAAEAACcQAAAAEKSKUkqxPPcycqXohYlnv42fRE0JIA+jdIGKEqqualI9+nygZohX+9Wup36DGVAakQ==", "bcd6f044-d227-487a-821e-4e8622652ac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "463aa0c3-1756-405c-809f-86baa96ebb0d", "AQAAAAEAACcQAAAAECwadNbJh6NtPmIhJyi4LI4T8A/I/w+IbaBDxdFniPe6rBTVVbt7itvFjvZKuv/zpw==", "93703469-ad38-4e4b-9be5-33fc4e00c86f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba91276-90fc-4fda-8aa2-86776015787d", "AQAAAAEAACcQAAAAEFGgpR4BKxc94y8zEfYrjB/m/3aEFN0ajBWpjiM9pNY39UbSIp5sVnLJg4EjgzHaEg==", "b1557e22-15d6-40d4-848d-cffb86817ce8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06f9708-b9b1-4090-b04c-3d5b658cbd05", "AQAAAAEAACcQAAAAEEN7tKRQu+mzYSLLLcoCTki18D/SPhyKoPvfXWzOVBUo1sC/qxfVFyH5JL1u+rMcDA==", "ba42728b-5b0e-4480-8d5b-02aa1d657024" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02faa910-cebd-4a8e-a055-a6360812d4bd", "AQAAAAEAACcQAAAAEAB7IWqyfxpUmel3npmL/hfgM5Rofk8OkjjGefikQpq3zgsF/irnufBBFaS0X8VB3A==", "058e6792-3751-4ea3-8203-03d844c7188e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a81a6eaf-cd07-4e9e-babf-27ac37043784", "AQAAAAEAACcQAAAAEHCUnyX8fl8BKUP2tSs0iw4tXVJrSyxmassD++k4bWZNcngRkqmwWl3GSD6slrasog==", "54928626-b636-47c6-a493-e2fdb4ccfb62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8880e131-7209-4542-a0c7-39179133fc01", "AQAAAAEAACcQAAAAEJoFeXAddRtWh5hfj2Cm63l4t7KXmqoGX0gqeIry6spEymJvZq8M/ojXKtU07VAj/A==", "bd8547dd-8e2b-42b0-9d98-97b69fb7464f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a65ebaa-5ef4-4209-8613-7eace674023e", "AQAAAAEAACcQAAAAEKqzTiFjqee9dRiOgLRYZeO1TH8e6hgM7ogaHlHKBU0ecb5dRaxN1xBZ12zRe0LACg==", "09328d6c-1a03-419d-af26-9f88d1a7dd44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccedfaac-b0c9-4989-8a58-c2c65bfe43c0", "AQAAAAEAACcQAAAAEMGUl9nyt6SRY8d+wE+OTM+2GyEk2jDyfQLMdqinO6z3yQaYn9PMWGbTc35fY+G9qg==", "5811a331-65f6-473e-bbe3-bd0c0fb1d103" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7bdf1c1-9324-4248-afc3-4d2f803d8732", "AQAAAAEAACcQAAAAEEzqGVYXnwcegCWy/+0dCtf/tJVd59iJ9GgitiHsraiBLUBYeXVhKXooLL8hDUt05w==", "a1adee4a-c87b-49dc-9552-0ace02c1602a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b63f3f69-429d-47e3-8f7e-f1d9b94853a2", "AQAAAAEAACcQAAAAEMpKZGa2JeRzGpnIMXj4+tTuY2MujZdKQKSm0SA3JYU7iB7vw+B9FiYLZnRC7IWwrA==", "120fc227-79b4-4479-94da-2e679ebe73a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71924c8-16ec-4c04-9274-b4daa6943019", "AQAAAAEAACcQAAAAECCmJQhTw+qXh62OFFRP1cdETelWhcme2iCKa78o4jIvCCUXp9mZlmSf1hiX/vFh2w==", "3b892146-0f3c-4a78-92aa-0ac163bf9140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "378eddf2-73b3-4b3a-9583-7f1322c324dc", "AQAAAAEAACcQAAAAEMn7AV2v8AYdIPPrmAfMptpWNlr1YiK6culdYylSpi5C87VUKIFQvuQRphrpKmcunw==", "f41e37cc-63a7-47eb-ba41-c95c8450a639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707c96f1-106b-4bcc-80fa-a8dff76c28c3", "AQAAAAEAACcQAAAAEO+yFb4aJOBD+Zcs17Ho9rLqKUGJDhFpl/yfVzhuJcUVmbshj5aOiY43icukRELf9w==", "492a2ea0-0a5e-42eb-8dc5-caa445e0eed9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "438565a0-3b85-468a-8f54-6f575d5b7ad5", "AQAAAAEAACcQAAAAECE0lhoYcXZwTPWlcwCrrJUNdWh/tUXsfvptgslzqjU5G4hE8PQnYd23L0OxIu/vbA==", "0294e0d0-3a8a-4827-8d1a-027355065dfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7a9fab-60fe-49da-8862-4d08d8fdc28b", "AQAAAAEAACcQAAAAENKZIVk6iEIy9DSqMQVjWI5Swx1gc0ANG3Z39xJeJ9AvMRxw/3L5eaohro/Ok73GFw==", "5af162cb-a844-41b3-bf84-9bda8a4a96f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03512d9d-fd56-46f3-be55-ea95c8dd42c5", "AQAAAAEAACcQAAAAEIWt4mgF5FioJu9vQUKUg8OvYxXyYGlO43NmPndlDQUDCtv35Ujf1XPTr34nrIhC4Q==", "7e70a2cd-973e-49fa-a0d5-d7f7ffdfbefc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f40d2c-45d8-40f1-aac3-ce3191f77ba7", "AQAAAAEAACcQAAAAEL1w1gLTEeVKkauiXEPZjiML6aKYrYbdMLVpKmuzMO/czEOekEhqf84Tyyb+m28tjQ==", "e5f6f4e5-a309-4d95-9b9a-db3e8234df74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99fed186-18c5-4a4b-af3e-d59362a0c169", "AQAAAAEAACcQAAAAEIEvYEYY0ap3DYdqmXFGeJ/6HCFvBxsa8dweOuG8sJOOdBnL3JZMSHLbMc4Fn8X4uQ==", "f42e2929-03de-4b05-8242-728dfe6659bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2788653d-c527-4af1-a766-378c8b62a601", "AQAAAAEAACcQAAAAEA3K+v9RBxzpB9TG8Jye9j4RO5sNDoFHtQFU6OfNP5yQ1cwjn1lr7DaEXs3dQ1ak0A==", "b09d99f2-614d-4845-aa0f-b186034c496f" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 26, 814, DateTimeKind.Utc).AddTicks(622), new DateTime(2021, 11, 28, 19, 30, 26, 814, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 26, 813, DateTimeKind.Utc).AddTicks(9669), new DateTime(2021, 11, 28, 19, 30, 26, 813, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5238), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5220), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5249), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5242), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(4715), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5257), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5234), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5253), new DateTime(2021, 11, 28, 19, 30, 27, 32, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_ReceiverId",
                table: "Reports",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_SenderId",
                table: "Reports",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportCategory_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId",
                principalTable: "ReportCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_ReceiverId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_SenderId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportCategory_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Report");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_SenderId",
                table: "Report",
                newName: "IX_Report_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Report",
                newName: "IX_Report_ReportCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReceiverId",
                table: "Report",
                newName: "IX_Report_ReceiverId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ReportCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ReportCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 4096);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "1c7c1eff-decd-45bb-a062-0ffb9a514141");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "a14fd088-f4a5-420b-8291-6b7ddc9cd1fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f883525-d24c-4446-a439-59598d634f45", "AQAAAAEAACcQAAAAEKXRrAddzcpomxAwYxqSq7N2FAs5CqQx86/lfwl493glD3X0QE5j8GJ358tEM+GH1A==", "34d47494-7821-437c-9a01-d5c88b933835" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03319783-69dc-4542-a5b9-f3aee697e3f3", "AQAAAAEAACcQAAAAEJb7oJcaOcqLnTgPM7LVYk7UHgRkBC2bD45lSrSSFdLMLrHrXtK/C1ud4niYnihEew==", "0383ba61-f38e-485d-b392-3d02b05f162d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c829c2-40ce-4578-8f80-e06b65c8de23", "AQAAAAEAACcQAAAAEPBiLxYbn1eUJQ7KPJPp7IwJuaH4QOEp9Hdvpssu5hUNmd6H+2BLyA3eP/2R6Z2hpA==", "57a16f3d-94dd-4f02-8155-a81277a04cff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85536c3e-e7ba-40e5-a815-1b4afd093b19", "AQAAAAEAACcQAAAAELQxTIY3NY6e9O2cyImtLTNLg46fD03eo6C/pwMnqapC4P3F/ngiUjJmECRN5If59w==", "8de7e918-1f06-44a0-89b3-f3c8faf76358" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "462a1f49-cd47-404f-b093-f75f891d9d74", "AQAAAAEAACcQAAAAEJnMzIoc1IZ50pDXokIXpu5MHZ+T1xKpjcKqGI0S9F42ggfcvmEhOkqGiWUtPcaxzg==", "e0cbf827-7cd6-4dae-a965-b78b944119e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e6a3809-56f3-4390-82f7-149aa4e21469", "AQAAAAEAACcQAAAAEInLbjmufXr2UDUvNYkYmmZJrKYPlJ06WKd3NGUhDgDDHacENr7RcbpC96/Y/PqSJg==", "4fd8893e-0880-42c9-ac35-21d12804f609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6397208a-21cc-46ff-9e20-87ec5afcbcfa", "AQAAAAEAACcQAAAAEHZ6+9038t3AVdCOqjhBUmD6orZq3ndH2/tCoV1l/CIxghISKknW5aSmasbuKDbfZg==", "d7f9c9c7-6f92-45d8-9f06-7bf68ad5f501" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f4dda5a-9a67-4f73-a1e1-9117d59a6015", "AQAAAAEAACcQAAAAEJbwsPqJJQBn4s68aWFlKczaHiNqn7gtadQj8iMoogJhEcEXqxV7xdL51/R9E3cA9Q==", "08542d15-f711-401b-a7d3-7195103f5b63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8e4d2c2-e035-4f86-beb3-c4bf453404e0", "AQAAAAEAACcQAAAAEIvyCJ3kUryvS09VZ6XpiNAKKC72Dq5Cq3azPTdjBvjiJWGdOc4FD3klrMoLxF5aMQ==", "c441dff5-1100-4e0f-af9f-ec295653caad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef22b9e3-a97c-4a53-98f8-82082fd16075", "AQAAAAEAACcQAAAAEPj0GbIgwiOFixU4K/fnHZ4lFDN7Q4Nz9D0ciTnPT6rRXzq03wyeRzmPxbch05nCow==", "2e9ca892-45cb-4004-8001-41789a4ba04b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1153e4dc-692d-4b8e-a096-1f7fcaf2d48b", "AQAAAAEAACcQAAAAEMywUNyBrZttwdo1EE8+FwwcniLW7Fv4xX+1Es1IRRtDHm7gMcsYu7QoQ24ddkvBpA==", "565fc9e8-3e56-4d92-8716-ee91ec32601a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c80ea8b-95f1-4394-a1ca-35533b8c04b3", "AQAAAAEAACcQAAAAELoxb6/xLGVIVA92djlKbakU/mdywze0ZoLaRHpEoZBovVJXI+6hTfiBA98cmjCwtw==", "6a67784f-ba0a-41d4-8d77-15c564436604" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f43833-3733-40d6-bb09-ba97f8aed4df", "AQAAAAEAACcQAAAAEMs7HMeZpWBIrm7hJ+j5lTwGXwTg2rxHS3pshsuopYRJRa49oSsqjVXATQd7vWXpug==", "40f2ac39-8405-4d58-8251-6cafe6f8a509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c45b63-1597-4666-bacf-793520e56252", "AQAAAAEAACcQAAAAEPzkvH0n/OUhj3VE32wBVK2Rzt/sDhNtVqSEbxI2e6vLE0q9N1jqq3r4Q8pDixpNRQ==", "652398f4-873a-49bf-9f94-c89f22a8e597" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e31e2cc-efd5-4580-b9fa-28f3702340d7", "AQAAAAEAACcQAAAAEEDssCtve+Diq6iyAaoOHXRJxP/cnkA1MDWgqZXx8IlmL7+kU83F1R75g8qir2Cxdw==", "800b928f-24d1-4efb-876c-cf40f720c0b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f14c670-47a8-48b0-bb2d-51698d5813c4", "AQAAAAEAACcQAAAAEN/CUqLqTWPKVVi760uHEXFoFyi40Wnkr+eWG8XPVnFgrdYd/iJwZn+FgeZCS/08Aw==", "2c3efc61-824c-44df-906f-d98b490f46f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37a4cd38-549e-4e1a-ab91-010620bb9375", "AQAAAAEAACcQAAAAEKnk9i05Jon0+nhQNBLQZLtts/2kR7R3VFWciFr4xG7yQ4w0uUg9DoYSU+xTb+bdAw==", "c61ac6b3-d923-4a70-bec0-4d1493d577be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d285a961-ae04-45fb-8465-789d941fbf4f", "AQAAAAEAACcQAAAAENBC6UCk4BseypPh/JuQYDhPV17iqO6SeB29jrLASVz7G9igHeGqM96lPvwIp2IkVg==", "1909d6b7-b222-4fa4-85e9-fa4584c8a8a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec2f2e0e-f913-48b3-8554-13318de6d2b4", "AQAAAAEAACcQAAAAEC7j+rIv5EOtCk/oTGYvWsuLes0qfz2zLK+Kg2WC9zoZ/gEp+EgdCRWmTsrrf/ycRg==", "dc26fecf-93f3-4dd9-93e2-f5681399f7be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab576353-102b-40c4-874e-bb936a2c995e", "AQAAAAEAACcQAAAAEPD1bxOdFEJZ2xJ4ekzwWm/1/ngK+YuGd2b/nGti426CSA/x/A5b+giRKNx2iyuF2g==", "191d9eea-9314-4129-ab5d-40abeb527a6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d25c65ad-1ba0-4f4b-991f-8f2f5fabc045", "AQAAAAEAACcQAAAAEEqNQovXo8d32TwCh4DLwlL6j77lpsehhC+JjLIlHWprLGJFNVciHpMXzdKUbuG/3g==", "f59fde68-8ec1-4300-88d7-102753b11783" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 469, DateTimeKind.Utc).AddTicks(401), new DateTime(2021, 11, 25, 23, 11, 41, 469, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 468, DateTimeKind.Utc).AddTicks(9278), new DateTime(2021, 11, 25, 23, 11, 41, 468, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6771), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6751), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6782), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6775), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6248), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6790), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6765), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6787), new DateTime(2021, 11, 25, 23, 11, 41, 658, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_ReceiverId",
                table: "Report",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_SenderId",
                table: "Report",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReportCategory_ReportCategoryId",
                table: "Report",
                column: "ReportCategoryId",
                principalTable: "ReportCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
