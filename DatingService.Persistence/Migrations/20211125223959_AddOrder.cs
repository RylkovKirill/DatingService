using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "f8683f2c-378e-46f3-bf6d-86ac4707efc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "1be08bec-4734-490c-8c5f-6669855f3d8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dfdecb3-c002-433b-a204-53825af19ea5", "AQAAAAEAACcQAAAAEFfahWwvccqyCFSHwzjPsv71Mpjz2/xAje2lvsZvL8cebKFAsSh5skzzh0SHlnnkew==", "9d14718f-64a9-481f-93ae-a1c2d0a5dc75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6b421ee-6d43-4316-80b6-696685d0241c", "AQAAAAEAACcQAAAAEBylI6zfLJPwFUlsBJ+Rt2L3VdPFCVj7fQdX5pZolDBpUQIdGvs5TRscVFbNCJatQw==", "657c6866-1088-4626-adf9-9377f20d9739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a662a7d-fe4c-4e8d-937b-255c4b77b7e0", "AQAAAAEAACcQAAAAEDO+jETclVtml3oV7IJQqtAg5UQ2rHR2vbpm/p17842/0kdys3O32kXmp5esXCfYjA==", "958d4fe8-7f62-43ca-b02f-0c31af717aa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5906585-5c3f-47fa-9c39-7ab7fbfa98c6", "AQAAAAEAACcQAAAAECk/E9uTeeu6fdQpL9lkDc5wNYpwdUB8pUzuDJFvvNDsJ741HdLAG4seOXO9IACOCQ==", "21294c74-3b80-438a-bb6a-4ad632ee3e27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e70c3a3c-59a1-4e06-9abe-b6d9ae0c2315", "AQAAAAEAACcQAAAAEFUcLT4/7hWMywJaDbfSoDi2UJ9Tbx/FjwAGQnz+9kBIt12/h5GKKk37J04NG1f9KA==", "f0cbede3-2b03-4e7d-b55d-2777afc553f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6e2123f-0db5-409a-b5e2-b438540cadc6", "AQAAAAEAACcQAAAAEFmOBZyluaOm1dOm1kbU/IM1jlEbs68U9atJql/QxGLzi49U/Qvy3bZcGlq0pSfvZw==", "f3c0e486-7faf-4854-a3c3-5ece49395b26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da9f4938-74f2-40e2-8e38-682e171a65d1", "AQAAAAEAACcQAAAAEL1qCcmocuss3QFhGS4lug8pkZ/hsQUtYVYP0BQ4adnZwCAT/g2yGeBCyjycu7CGcA==", "0b1b1692-465a-49de-9dca-e23f72bbf3e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fd3e494-28d4-464d-a090-bf497af30a74", "AQAAAAEAACcQAAAAEGezc38Ff4/ONH6h9MbQRonashxkZGMByHh/yugGHgY7TNCXqQR8eDfMSPY1ifC9Sg==", "d839b48b-4054-4ffe-9aa2-910356814be9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06c49c7-bd81-4c38-a824-ebf76ffdac7e", "AQAAAAEAACcQAAAAEEmxwe27cj81fT2FjsWEkZiA+HwsE+nrdQorXjxK4jrE601VLvgmjFqB1MdTscGnzQ==", "7951a53d-0a59-4887-97d6-b9a9bb500cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3a4492-c23e-4e2c-b08d-1fe7a3d116f3", "AQAAAAEAACcQAAAAELmeYYBMpM4GY7X2mknmXC+uLrGsbmhrtIyM6C3+qnVr5Xu+w9i8sDHnwhafbllw5A==", "2a4e6c89-3850-4388-bbdb-bd78d7ab55a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5e44f34-9d24-456a-8f97-df21640b4d8b", "AQAAAAEAACcQAAAAEHoPc5HZYVUDd2oUEdcT3xU9/Hm6QIuEORrNJez5hSjEs0K83lgQgXIi3gaiF0KxkA==", "cf755729-192e-4397-bd9d-85b39663a6e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5572623-beaa-4bf4-8805-687f4409f57e", "AQAAAAEAACcQAAAAEEav6Ohga4JpQrqThSI87ACgJd4UZImQPOXYTmr56BGNIpD101KpVIObHiqV21nRbw==", "7b69f3e9-7817-48d8-9353-8dcee8fb9fd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c15ac3bf-a16b-436c-ba86-8106721d9c69", "AQAAAAEAACcQAAAAEIiSp9SggpDhsQ92J18yy5fJgw+tKseu5ZAEAweqSIBmWb3OrG986pzUzmJpJptXPQ==", "d3fd094e-c808-48a5-8202-ee8ea9784017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19fd5cbf-d5a4-4b66-9ab7-1e0a88415615", "AQAAAAEAACcQAAAAEEdxS1+TZu0dPBiJy3JPcHy/HVXDQQQVloYgTypZNhsRc29/dEegS8PWRxnLbH1sXw==", "7af6620d-99fd-4b32-a3fb-e554bb35bcbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4383b0c0-c870-4bee-b178-5c70c4983604", "AQAAAAEAACcQAAAAEDBwb3FPwnLp/Wm25lMShcsJz7ruLkr/ZZELrLSZ4VgO7x0Eoe0AWMz4CU3OjDT0PQ==", "0e0f871b-4ea9-4b1d-a494-7d1220cf18e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "149baf00-bde5-42ab-b5d9-83785be58e28", "AQAAAAEAACcQAAAAENoKnMmtxE1BQ8eVffznLMmj8H8+jgL1RWPBDATLiStwsZnA0pi8YXT64eq+OAbJYA==", "74104db1-10e2-4df8-be9a-01b4b0015f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "635b1e2d-e9f3-4753-bb13-27a76bd691db", "AQAAAAEAACcQAAAAELsyISHUrmlXNV7qwkB/Jd/dDUyage6izVlKWCiRMGjPVHGmjAbY7yLOjS7XJFlv6A==", "1b08651e-2ae6-4f9e-8990-3c34b8085be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e47f811e-e92d-4fde-8616-6d643c3ba998", "AQAAAAEAACcQAAAAEGcCSaCLkYXaSTLzXj3swGzjjGp3Nt2MQ6szXE4AThf+GE2nu5zdj1jKCpLHuQN9Tg==", "6bdb6631-9b70-4f4b-a8e7-74d0782ba5c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a288bb5d-5d07-454b-a93f-d4e450b95875", "AQAAAAEAACcQAAAAEGBylzTsavdWa2K6bNizmAoDzm+/qPQ3w8DFNIufswmcpZA7PcP1xwzOsaWthHXwyg==", "bf35eb74-c5da-41ce-8441-798c4b812485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bb772d9-aacf-4c92-a595-6f07a8f28120", "AQAAAAEAACcQAAAAEDZAJADfx2hfuGYwWphM40ZNgw2lNvKjOMjr0gd62zJ30y7xiv44uo/n54ZgH70IGQ==", "2098a44a-b11e-4593-8ddc-d41e12b136bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bbc6f44-0f18-434b-a059-7395e0a34e3b", "AQAAAAEAACcQAAAAED/6sgKyELRJGk0dr7XQXUn8+Fr5qImF171xm6D0aTm2K1P4KeBGDPV98aT2Vd8wZg==", "e57d3ef7-bf76-4a8a-903c-9601f58dc99d" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 449, DateTimeKind.Utc).AddTicks(4548), new DateTime(2021, 11, 25, 22, 39, 57, 449, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 449, DateTimeKind.Utc).AddTicks(3432), new DateTime(2021, 11, 25, 22, 39, 57, 449, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9966), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9941), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9977), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9970), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9312), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9988), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9960), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9983), new DateTime(2021, 11, 25, 22, 39, 57, 863, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "bdb28b9b-72f1-44af-a630-593480dcfcc4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "c9da1ccd-9d8b-461e-9e83-5d7ec4a1e6de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b099600b-c748-46be-b1d4-ec8a5e48fe92", "AQAAAAEAACcQAAAAEP9pqhQFLqq1FKy7a5pg8s0R7BpOlculEc8LDlAF/b3OMrZTYNphmXtPOuJoBgmtiA==", "bbc7aad7-431c-438e-9863-9191faa8afbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0949d5-b0d9-4f02-953d-a55aab39d29e", "AQAAAAEAACcQAAAAEJI9A6g6FjegN6/+XsUGjFB2SmGL3h3Mgck2fpVMm2NlNzGqbbJAJgcAvvHt0ZqGGA==", "b78fb836-e37a-4e2e-83c2-d3e7c5eaf120" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51212b42-cdb9-42ba-9eb1-d8c74199da10", "AQAAAAEAACcQAAAAECipSyeFILb/rlNbgWNbTSawRVzxuAyF/X2BssP/hcT/ZVV0PcStHbgw4eBEGJh2PQ==", "9caeeda3-93cb-4222-81ca-f27430893f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab0f32e0-0226-49e9-988d-e394052a5b5a", "AQAAAAEAACcQAAAAEAEQPDZiK4GA2+RZ9NA6Gx44wn/F40b1XwITQluiF4Dsah8t4kxet3AR3UmVA6ardQ==", "cf486d14-d503-4d4c-a471-cd7284ed1c68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f13d809f-6bd7-4625-b882-def4e4555cc1", "AQAAAAEAACcQAAAAECGjatImBJt05hx93f031G0pTCN7BYi+qAZ83m8Df1upZFwWpwmnmoQAStWMvK/7EA==", "a65ec25b-f55e-4822-beaa-c4670537bfcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8d608c-50c1-4f64-ba46-87ef1b698ccb", "AQAAAAEAACcQAAAAEJsrQS1EiTFMxgXhBlpn3l+Gkuv2mD14qABxATnB7Ah4qXl1t05bIWYIkB1R2JIhZw==", "d4d42878-d515-4ade-a5f1-32b24ae73a3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3d108e-6053-47de-a097-96f9e28fa0c4", "AQAAAAEAACcQAAAAELflKZwbqIuedj8F4J+qAHIqYUe9tPik8B8TpDmZR+sPiD+SFfqo0AxgcO2znPHm0A==", "cab56144-37cc-4e79-8948-0d80a9f978fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e7076b-0c48-4d84-8b72-6fe3935d7b46", "AQAAAAEAACcQAAAAEKM6jjPcKTiGaJgNScmbLofNDCyYXaRupfZU2YrmTR9G5Npcf+5q4h3JJFBFE9z45Q==", "7eaa8beb-cecb-40c0-b9bb-76383ba22483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5577bbc6-88cc-4257-8bb6-d24c05e5b623", "AQAAAAEAACcQAAAAEHnLyIJ6jr1CIO/mYaQEsen3lBWA0HhMhdlZV53wVMvvSXyieP/R1AcJSvp0l2uVkw==", "c3d6432a-2624-42bc-9362-cb6200635653" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "663e4d7c-2357-4649-be63-ec6b240db660", "AQAAAAEAACcQAAAAELw793ywF8duddfXHqxKsdQGFQoJaBwcdcfeLjPhDKiFJQjwUGCmzE+Mtasc/uZ9xw==", "57ff7b0c-3da6-47d2-beb8-392c21ae187c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a869e68e-654e-428c-9aa1-d087f63ae280", "AQAAAAEAACcQAAAAEAuo7x8tx2CgMl2bViKMO+8ObTJbqzylOntdQhHTXM/LUSXq92cBUl4nGUuttDKOzg==", "da1aa84c-e1ab-4758-b8e6-6b2d5fc68149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2daeb4fa-8e29-402f-916c-4c47d98c2278", "AQAAAAEAACcQAAAAEEdwv/BUw78GjqTW82ZEH3gkRpLRFOWvndhka9almmpW4Er2OOXj9So6PKkC9/NhBw==", "78897ce8-385b-4b85-8420-47f004b3f5cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7401c6ee-4476-4867-a3fe-c34b13511206", "AQAAAAEAACcQAAAAEIy/2BCnqWYaeiCAFQIi0Nj32sroiVAVqDA8sKTYfpWzt93A1zwzNsSW+H4pifY92A==", "78e00561-246b-4c85-957f-184a78d6bafd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "150fb857-2a42-4f98-8948-25261d91cdc0", "AQAAAAEAACcQAAAAEKN0hnU6VWimEF0yCQLwTo41g8dgrH4wS+zLsSA79otDN5/yh/I1vkiJVE4mExdUlQ==", "b824c2e3-0faa-4029-ab0e-dc109b76b379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ac2679-c87d-49fc-a44b-326ff4d96fe3", "AQAAAAEAACcQAAAAEKekMNmsAvS3LOCTqQdazcfEQ66/YBmcVNq++TwG7/wS+l+yhbisXrfOBXhDDJMG7g==", "c59a047c-e2ea-4cdd-9e3b-7e6db2acd9fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a589e1-b154-43a2-91da-a7a49bbf2c9a", "AQAAAAEAACcQAAAAEGFUjH1dPel3YTBEL/j11gK+n5TakJdz3kV7EzOgHyKPH0eOWonaHbXzrA2omVG0/A==", "c27d761d-01b4-47cd-9baa-4667f10166f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d698be1c-c0ca-4107-8a2d-84e65aa90838", "AQAAAAEAACcQAAAAEG2oReSYgvMxU+mMfiUm1EHAo47ZH526cBDqfudvKjkMOi57/PKXs6/1xtrKin5+nQ==", "f069212e-010e-4c8f-8d5b-54f87e025598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b50490-9962-4cf2-b6a4-0709d0399be2", "AQAAAAEAACcQAAAAEBJveURNE8dQFC/agkOoCYFSGID0iulIuRVclKTZB57Fxlw5tNGKl2f6fAyoKd5QZA==", "fc0a9613-4e14-42fb-9731-e1680f8d94c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e559bef-bb91-4171-87b4-5e92aa6ad06a", "AQAAAAEAACcQAAAAEMhXAwa3Avccx4iaMFBynTI86wsoBlTorjt2xsHGerjYlfykMFYFuEV3JOq3yQiolQ==", "160b8b15-9322-46be-b6f9-6e9da8b4caab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42136e49-939d-45ac-a951-3668d49866a7", "AQAAAAEAACcQAAAAEEYqrKkMIOQg8x61B7ZTITDta7jAoZr/hVA+9rXmrTvbC4+4SjSdud9Jq6+AsMolIQ==", "43b8b9f3-74f8-4e7b-bd75-60ad45f43131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d619097b-87c5-4e99-b351-ea2c511056c8", "AQAAAAEAACcQAAAAEKqv6frQ8JuYG16+stMFV/Idd2rg7PrZV978uN8ZqK0STeGoO/exju47/fQhzn5w/Q==", "bb01aa93-9112-4720-b818-1a1cbfee3d0b" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(8093), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(6956), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8903), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8868), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8918), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8908), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(7693), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8927), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8897), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8922), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8923) });
        }
    }
}
