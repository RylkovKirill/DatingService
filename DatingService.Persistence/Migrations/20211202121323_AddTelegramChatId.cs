using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddTelegramChatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramUsername",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<double>(
                name: "TelegramChatId",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "e0cd29b3-95e3-43e3-bd54-0e91c8c13163");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "d2ce677b-ef7a-40bd-a92d-463aaea8de9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef65cc6-179d-4f33-896a-0699660d266c", "AQAAAAEAACcQAAAAENEoA4V81glxXJJmcGpjmZ0oV7Sae167FZt5yV7SENBFvKU4YFuDxFUFkunKnVbwTQ==", "7d57c900-14ce-4575-9475-55a67a91d948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16de0b65-155c-491c-a05d-c898d69a4692", "AQAAAAEAACcQAAAAEAwAxp44qGd/96XkAxObA+tHw/IjB1C1tw2NnocD31rfE5aJYd3xVNkOoDV7XNsqsw==", "9c08c5e2-5619-4750-8559-16ef18664bf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6c254d-e045-4f6b-ab03-64ec5d65f80d", "AQAAAAEAACcQAAAAEAe2Gd46rNea3zxVaqVM5HDEuT4o9VTXDK3ThL43uLSnVfo4Wnj2Vg0/2ThV+0OcTw==", "66f70eef-d706-4195-b28d-35658cc5a341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8084b114-94a0-4871-8b80-e826d7b0a3c9", "AQAAAAEAACcQAAAAELlZGVTdWyxWoCB2AiD0nJG7SIUuYf1wzzbbJ3/pirWN+qHWtypVYxZcKzlm/Ex49Q==", "274889f6-1958-4198-a58c-91910664162c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6733a3ea-62b3-4225-8bec-a924197468de", "AQAAAAEAACcQAAAAEK5C2IX2CWngabLT486+u2GKnNrdXPOzfxWLmrsQMN26Sp0+BkiFXo01Ub7OG7JqfA==", "966a6a86-4595-4f61-8951-9dfe3a9a3418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1be1a7fe-2d3c-4727-a996-712d17c5c312", "AQAAAAEAACcQAAAAEPsl2i9bGzpS8vMA4fC15tOVPKchJtZ1rFm4Ls2gr6aeb7XuSdqxJF/sqOv5q23PLg==", "780a264b-d7ce-474e-8bbd-2f6cc0d28752" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b840b12-5525-412b-840f-24a3907a26ef", "AQAAAAEAACcQAAAAEDBGQQYR2MMiWVI/JSr+selN66e3Sae9Su9j1/t5vUhe+HG/XJhW54mU63KhmQffVw==", "841fa8c5-81a2-422b-a38b-af0617b4d12e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36807705-5f86-4913-b4cc-e706c8b0849e", "AQAAAAEAACcQAAAAEDM7EcvhacqiGyrRpIFvfvx5D6Wr27wdFhbVSfiOvHaMHcWk94t6rrYfTYOTo2l65Q==", "f663f162-c259-4192-819a-855ed5bc1e56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d6272c7-5fcb-4105-b076-846381355213", "AQAAAAEAACcQAAAAEAR0jRc3s9C1OLHaAuo8yNknnxfdjP28H50SbFxNf3yHfHw8AgcNO+M2WAjogE+4kA==", "018862bf-69c7-4774-838f-baed5c6e4b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "297b2405-68b6-4a25-bda0-2dadf17423df", "AQAAAAEAACcQAAAAEGHK1zO+fftk9djek5eY7kjK9eBlJyI2Akd+FWgnUH9Sgl7n0mTFJ1FXwYt24KY6Vw==", "bffe0ed5-a8a8-408c-8260-ebbbe55b3f2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dc71668-6085-4a95-a332-00cd088c8958", "AQAAAAEAACcQAAAAEJ7YQiAARbxN82iNmOgAeWNDq8luHn8R5dpnPj8l9bLiF8jT/MfMXxKui3rf4hlttg==", "8bb373fc-b5dd-462f-9628-e539dcdf9310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3afdf184-43cd-4ece-96ab-b4d838f31685", "AQAAAAEAACcQAAAAEMvy2FkRmOu9oDIrDslk98KW36DUSpGWzo+aNC46wWIYpdt753xe9RcLFViCgNGKHg==", "461fed8d-a431-42e3-92f3-96494a2c3294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22213d39-b3a1-4c73-ba63-c5ea08c5e95d", "AQAAAAEAACcQAAAAEI1BJKJDrMrVBLDUpy/mGBx0xOuA1+45HGegv3kohryuVoK/Lw/o3JYYM0V3yrPyMw==", "b0239f04-6405-414c-ba45-178605352b6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5be65932-45eb-46fa-a4ce-dd8e4f862541", "AQAAAAEAACcQAAAAEGOHs79wvLuvGRlDLBlv9CzSlr1D8KpRhXRs3UfQoXhSiVbkk0/o9RqDAM4iSsJYlg==", "45d72e72-6a5f-4be4-8c3b-4c40584609a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a39abc-42aa-41da-9263-751e11d74004", "AQAAAAEAACcQAAAAELp+IpUcxLePB5YA3agDxR//G9kLyyd7LCbhSGlhE7CjmxAFTTm2CTrssX23c9B1Ug==", "83b9a724-aca3-4242-a253-af01066342cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "280bbbfe-df4f-411f-b7c3-aab532f0e26f", "AQAAAAEAACcQAAAAEEiKGSE/IUkyF+9R+UWVG1Ik5330m6dFKsn3CjKoT9LjXOeOYURPFybND/1nriDBeg==", "84a6105c-9991-4485-9648-ca7a538ec0ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c26c1a06-c330-42c7-8091-7ae53cc949ca", "AQAAAAEAACcQAAAAEEjuo8lJdYaZpacPQh61je+lfCuxedI10DJ2vk7I2eThyfRczB/uFYkytUCIpKmx4Q==", "417a8ba0-cc1b-4683-a897-283b35edc7cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d00a7cac-45fe-4866-92a6-311ef89f171a", "AQAAAAEAACcQAAAAEOXVZaov3+AKjJ014kaNjJ2X+ukfBBCaXjgr7/3sOc9jw/QNkYzJel5HTAO3rZPQSQ==", "814d2fc9-0574-480b-8683-b4257ef11587" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe102f75-4fd6-4d56-a257-6afe94206ba0", "AQAAAAEAACcQAAAAEGjUaRYJ+8udyvfEGtV+aHZMsRgSCCZIeJhpLwTwlyPDvf3aHr4DPnYHoIb45kfCaA==", "5e92c549-36c5-424a-8828-9950c390d8ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52120a70-9c73-4b8e-b6d8-431d70f03506", "AQAAAAEAACcQAAAAEFIUfW0eRZE2s3oSWWk3LrzjiRQLpVjPUGch1fJly3Zr8pRYwa1iILLB6rrzp+wkYw==", "7ad29ef0-a370-4e0a-bc94-54333d048fc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f07d18-c13c-48f8-aee3-a6c6a67cd543", "AQAAAAEAACcQAAAAEAT8UdVLKbJJsV0Sgx+L9bSzvB21jnzBFtGvntxxKqqFdU/Gc9YEZCp/WogO/CWr8Q==", "bbc2242e-268f-4cc6-a2c8-8f81d9f5a5ff" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 21, 867, DateTimeKind.Utc).AddTicks(7043), new DateTime(2021, 12, 2, 12, 13, 21, 867, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 21, 867, DateTimeKind.Utc).AddTicks(5488), new DateTime(2021, 12, 2, 12, 13, 21, 867, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2286), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2252), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2306), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2293), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(1409), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2320), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2279), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2314), new DateTime(2021, 12, 2, 12, 13, 22, 177, DateTimeKind.Utc).AddTicks(2315) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramChatId",
                table: "AspNetUsers");

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
    }
}
