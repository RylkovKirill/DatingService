using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddTelegramUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelegramUsername",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "d159fd17-0d67-4f9c-a817-5ebb2962e767");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "08b32234-91db-44d3-a320-048c02feec13");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c0cb9ef-c3e3-474d-bb57-15d2c975bf60", "AQAAAAEAACcQAAAAEDOH1cZbMwsRgVGS75qm9MkA1rqIJnuDaVSJ6AWPPEdqkDwrZQsfaDFYpNCBnZrX+A==", "a77d25d1-cce0-48d9-8280-15a49425c726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad208bea-2735-4c55-a0fa-e0e838fa4c44", "AQAAAAEAACcQAAAAEDsFRegcL8MWLMK0mnfxtVT5FnxeBx8MygPmHoWW+/xUOiCHmRQjSkjMayLgZ7u47w==", "9472bd7b-fa47-4e9e-a39d-98ca2e09f24e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "515ffa65-6f74-480b-a2ae-c701bc243947", "AQAAAAEAACcQAAAAEJ/bbP13wPb0UI/ByUPdlby1/ah+7nck6qUYPsFSvz601NxHTNcbqYvaI/6OZjwzYA==", "1c3bb7cc-5396-4aa7-9412-edce089472c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7847ab1-1f79-4833-b455-21dd56c706a3", "AQAAAAEAACcQAAAAEEQt3AF0VZa0OiZa+oZHDbtZAYr2+NtzZws1CSQhFhSIL59Eweb1owcsgD1IlgsK2Q==", "ae67264a-380d-40ff-bc3f-cf28b20ef433" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45907c55-b1db-45da-9663-c6020a1c6275", "AQAAAAEAACcQAAAAEJyPhXAwniLemFyo8Q4XnxbWllFgADK6NnMya7UlKWi73qD6CRgWN5QTXhlv1jxBwQ==", "7b95ce30-9977-4cf1-a4a2-55786f64df2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f815b6f-75b5-4aa1-bf73-071945bf5812", "AQAAAAEAACcQAAAAEL7ToA5tnWCnyoC27u6wJE08wFogxzS3nH4gdbapaWzSBeEvkqRVlba8s9pL6rqD8g==", "97fc718d-65ef-49d1-989f-4c94f058c8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27067059-5073-4a67-aa00-3d28f6efde2b", "AQAAAAEAACcQAAAAEJdKfbDTzrEj1uvNjK/uOC97n6EB/juY4qXUab9bc0gOPDwdU+nhOqWgi7TX1tSc5A==", "2a1026b7-b85a-4ad7-9229-e5b54da77c03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bcd574b-3938-4f72-8623-fc62802963c7", "AQAAAAEAACcQAAAAEITiSfHPWdHcL7TER5t7bC5/yIVDVfIuVvYFMVW9dn3uAlPvKe8fBjMGSC5ZVtY7IQ==", "687e7302-58d3-45ab-adb8-8a01c7009bbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeaf0b5d-bcd1-46d3-b3f4-604a1e49d7b3", "AQAAAAEAACcQAAAAEHnmGP1VXk54Yc8IYOcEkEr3zWqtMKQBWldHzeNag4NoNtmlmlWr9LIqx6G1jahEXQ==", "f54b8064-ab5d-448d-9f39-526cdff4e219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "014a8c5c-c880-497b-94fb-242ebf360b3e", "AQAAAAEAACcQAAAAEJPiQlzX63khzHCc7JN+aHWiNcwtr+npvgLT6v2axvjddrIkYlI7MwfUjC2dsGbNEw==", "b1c93f24-93a2-4228-8902-aa36f389518a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36bee66b-f085-410f-894b-e27c8d8f45aa", "AQAAAAEAACcQAAAAEK2vhqbuxRYsRjyTFrH+1xYgzlFCFLbvw8UsnITTRfcG6SX3rziGnJxFonBbVfAS1w==", "0d6dda39-dc6f-4d67-87d1-1759eadc5bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dd532fa-6dfa-4788-a307-99da0d2c5458", "AQAAAAEAACcQAAAAEKQ7jE05TG7UH5y6nEyw4IkqmARSS5qxTiFg3XZnN2+oB7MCtDGr30aU9egyx1nITA==", "536f87f5-380c-47db-9489-7fe89858e140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d276ff-7eeb-47b5-aeb9-388b8766b3b8", "AQAAAAEAACcQAAAAEGjZmKTTfnfQ+gdaejx5paGMFPeDVvRi24uBons60XKlzMilyVOyq1kJ+XNnG+GF5A==", "607281ea-5575-4fd6-a03e-0915870afe7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cccca44-5167-4056-93c0-43360fd37b0c", "AQAAAAEAACcQAAAAEG2axftTYC67c4Wqq3vojl6Z8582DT5rjP9eP29cWk+8hhuOIsQmG4EMayWA+WOKjg==", "fb5afd9c-c62b-4126-b002-39b541710081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d7a3137-dee0-4b9d-9de1-7c48939c8271", "AQAAAAEAACcQAAAAEAyJkSXIP7Lv3IDHHybET91ogw/k3O9dAjZLLksJgtztRHHZtwUlZjL1ipeQwNatRQ==", "3253aed4-add1-45ef-94a9-703835a21602" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e86263f-857d-42f0-b18f-b2eac41b9435", "AQAAAAEAACcQAAAAEL4o+2zph8ddrwy8P9HpH3uaj1jByRtSZ0cIc34i6CxYqJJVrKYNluSstd1lVe43yg==", "be3ea0cb-00f0-461f-9b8a-335a02d9beba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e5737e-aa02-45e8-9246-1e696b96f729", "AQAAAAEAACcQAAAAEAxfN3jCJvCpwdVm4Ft20Bjdc0947BHhaF6Lv0pjJJrqOfiZaK7AlT2BZ4zcqZ0F7g==", "74a11821-4b09-4202-8db2-d2a8b37c70b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "986aa125-c1f2-4e03-adb3-140bb7dfda74", "AQAAAAEAACcQAAAAEHNyLF8sqyrOmgOwWQ5D7yblVvJCc4EHiB3ImTd8lCBB/C1Vurhmc6N+0UO+m8eVxA==", "f56e57e1-ffec-400e-944c-54e82a5268e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b1c98c-322f-4ab4-84a3-7da5b8ae1d69", "AQAAAAEAACcQAAAAEIQUuSYsbcv1qpTY5hsY2w0QHXn/8eCC424otJCzGuBT0g1CbO4eLUK+bACd/Bh77Q==", "21af8323-bd2c-4cb6-9394-8a712856f75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2f8e9f-e32e-4c49-970b-fe0540172f6c", "AQAAAAEAACcQAAAAENqsaRHdDxUvy9wwcp+49rQtDjZfFkehzZvg5qsE0py26u78SHM1h5Hrr1MV/dp5yQ==", "598046ec-3fde-4e6a-b2e2-4e3f475040bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "619b035c-6ba1-4eaf-bd70-b328d8c674a0", "AQAAAAEAACcQAAAAECmJ6ck1LgkRqk3qCWPIRtS9COnH4+AhkVFC/N8J2lk/nyZ4DDal+kVOF/U0fwAMUg==", "d6a3a49c-2749-4214-bb33-11042af6c65c" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 19, 847, DateTimeKind.Utc).AddTicks(8093), new DateTime(2021, 12, 1, 23, 59, 19, 847, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 19, 847, DateTimeKind.Utc).AddTicks(7167), new DateTime(2021, 12, 1, 23, 59, 19, 847, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5196), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5180), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5207), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5199), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(4719), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5213), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5191), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5210), new DateTime(2021, 12, 1, 23, 59, 20, 20, DateTimeKind.Utc).AddTicks(5211) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramUsername",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "e2c55f77-fa6e-4fc8-b61f-4bc9ec36fbc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "8d5e5f3b-b043-4a5c-9fc8-cc5a42af77f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a46d3e0-8adb-4a05-92a8-7c8ee9ed642e", "AQAAAAEAACcQAAAAEPfZSItp087GF3c6em0pwdxP9k4GRQ9pJVB/+5gtCAdOnHGHQHyjWr4jqlDnEOVeJA==", "b4541cb9-9883-45ef-9f44-d35d8eeb98cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02bce184-e200-4c6f-b39f-887eb217a543", "AQAAAAEAACcQAAAAEMb4Hq09H6x0jK/brwqCeTdTiU0YiZNsuuDIGFXNyQv93EkavcCwarQZvAKxa9AXVw==", "207e0f2a-dadd-486c-99ec-fd35c5bdfbf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c06f7254-76af-4b85-bfe0-4c11c5961b6f", "AQAAAAEAACcQAAAAEE+qOqQ09PYfiOZDrn7KY2G0PAYfmdfzkV1i4xVaXjDN/Lx8fnLRazo/FQCPi+xS4g==", "a5935e04-727c-4f05-a198-3b3c05cd33fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "934421a0-34bd-4d49-819f-9b949c570273", "AQAAAAEAACcQAAAAEBXoWDzNDjkrPtTEWiCBeSV9Gzrq+aUv6v4QgTPAyJiITTdS4nbOsY9iAu42M1q5Vw==", "6207bf08-3a74-4571-aae6-fe877c2e794d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95f4a9b9-edfd-4feb-95d9-d9950f5e5379", "AQAAAAEAACcQAAAAEB4d/Fs77e1UCwxREuBA+JWX36pAoTeoxbpEveMoqnRxafsI8eGNA8cK15L6VZnGjg==", "9ed24ab2-023c-4d94-a32b-10bedea3ebe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0545d966-ca17-49e7-af41-3e5502706702", "AQAAAAEAACcQAAAAECFRZ8tnDXPsSzG9RBVZByPvAxR2Ek2zcSg9VZ0wDgiwCIUNoF7hIJjsb6fq1qitHw==", "e96a4939-0e34-40a4-b282-db1f2a472c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b022d7-8621-4d9b-b9e7-a55bcb481be7", "AQAAAAEAACcQAAAAEMRi4bPhaJb6IjE/h3AP1Hng5dUXO7Hl6UxZoIGCPmQzcwp+SaUIzNsEoJ9AnjyinA==", "2a54a15d-4cfb-4f4b-83f0-00ddd948d15a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af1dfd7-6623-4c23-abc2-5943c9b96257", "AQAAAAEAACcQAAAAEM9nk66LwR4gIuE3j91kIsxvYucUPU7qRHHd6CHSvKHR+NKwKTZ0T10wRl8lK1e42A==", "f123179a-c2ca-4198-affd-ef5a38779274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1420f6b0-6daf-4d06-b6e2-38359f7150dd", "AQAAAAEAACcQAAAAELCSKdQNpEgF759QB0o3cJbFfY8OOtQo+VUi/iwncAtSsb6IchJPpCSX3nIl61M+Fw==", "03597b6b-038b-44d8-b498-a777c5c595ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e6ea978-6574-44a7-b499-505c580120ec", "AQAAAAEAACcQAAAAELPP8+0niDhQVycvKduaYz0s2etqv3b/+akb8yd4sCELYNb75jOW+ZgXlh4PTj3wmg==", "e62e4b95-3463-48c8-817f-5935f2a6e5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5403e40-92bc-4896-955c-1787acecb690", "AQAAAAEAACcQAAAAEO8fBpNypN5NyVEoZ5MldA1SAgAzCuKNHM3Kf4kdLtlrnyFT8bN60q37qCMjWO7NJQ==", "c1ba6880-3cd0-4b70-bd79-e31d8915e212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c02857b-441e-4706-8e3c-196ee55ddb6c", "AQAAAAEAACcQAAAAEAcdLFtUfYCBVb9Wf2VXfSKdlS0ekjOzeprxCrw10cGpg9bCZJQi17opDbSQGbhdRQ==", "469da485-24ba-464d-9a65-25b2e95d470f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b59d0b35-5a5b-4ce4-9ffa-80ce17520801", "AQAAAAEAACcQAAAAEBaNqCit5HmX8+cDSDQjzRVjdJeaMIsFw/6Lz6aIaKX3gat2s+4L5mvRAT8ee6vbsg==", "e2801f4b-7f2a-465c-95a4-50073545af81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b5c0714-b813-4b88-ab98-f5c9220e47d6", "AQAAAAEAACcQAAAAEJOtiaH97N/sDvu9BC8IaUtaqaHOyMGNNucHoJ96yHsfMDrvaiHFDSClI6yL14RaUg==", "62fd0dbd-bfcd-4486-9745-01dfc5e1fcb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35a47005-218e-456d-a6fc-6b58db9625b8", "AQAAAAEAACcQAAAAEHn0AbKqE43pH8yMXXx6+MZZ9GNbNDYOTDr6MhLBIClH/yoRlKaPA2HT/B+BLVS5hg==", "9c635f90-ef40-40b7-989e-1a59ec10859d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4461cc4f-8d60-4e12-bc02-628c3452a2bb", "AQAAAAEAACcQAAAAEAVAwv06HUwPWeCfgqZegf1dtWwBa6XV2ShwlkZru3gk4rONmFsQroUcf+I+QM1ACw==", "b32573f8-ce4c-4602-8576-ae6402559415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef91160a-5c20-404f-ba7d-376b0b3dfa2b", "AQAAAAEAACcQAAAAEA6UI5h2hidrpKZjd5A1L0XXDW71AH8Y7VRclsB5cZSSgi+d3wM0MeNgdHZN5JSg6w==", "df3519b7-9f8c-4413-ab32-0bd07ef6d8fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ec8755-ecb2-4f5e-92c1-e5c0dfb3edd6", "AQAAAAEAACcQAAAAEO8nRwRN2+STxeiwV/KQKyHh8GhKJUqNjvYZkH1IMfMhUG4dVtiTylb0JE/CjCg/Aw==", "115156ce-4183-4a42-990d-6cbe0ba66af7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c4d6a8-53f7-4fec-b6f4-1fc2848c35a8", "AQAAAAEAACcQAAAAECFxp7/haYnG2B3Hz0JwWvjyg8H+oFWsv7zsfzop+4SuvQnO1jtvRPRFCOMbC2X41w==", "1cb09029-1948-4157-8417-2bbad10b0815" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97956888-8443-461a-b071-91b704e46cc8", "AQAAAAEAACcQAAAAEF2bUwZHUINXa81/zp58xSAON9y2qgIVfYu/EbQ2GvEOGZJplfuLAg/DxPolv6nh5w==", "59c07bf3-6bd0-48c1-ba83-8452965d9c63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112bde1d-e780-4ffe-9141-4ff38fa1fbce", "AQAAAAEAACcQAAAAEEb03Pd0o2+SpGo+1Dv9e5vSVM+KKF/tRvwXyb5DL+jdtMNDYx9lDWueu0tguAYztw==", "33fceb26-3980-48c1-aea4-a2e8ba5524e6" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 20, DateTimeKind.Utc).AddTicks(9731), new DateTime(2021, 11, 28, 22, 38, 18, 20, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 20, DateTimeKind.Utc).AddTicks(8763), new DateTime(2021, 11, 28, 22, 38, 18, 20, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9460), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9440), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9471), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9464), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(8910), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9479), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9456), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9475), new DateTime(2021, 11, 28, 22, 38, 18, 323, DateTimeKind.Utc).AddTicks(9476) });
        }
    }
}
