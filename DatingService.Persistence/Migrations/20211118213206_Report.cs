using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class Report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: true),
                    ReportCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Report_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Report_ReportCategory_ReportCategoryId",
                        column: x => x.ReportCategoryId,
                        principalTable: "ReportCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "e3cb38a0-7aad-406e-a8b1-eabf612749af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "5bed4d4a-010f-4b37-8205-261f432cb4ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df4f10c6-6ccb-4b68-bbda-d13bc70d20cd", "AQAAAAEAACcQAAAAEKwXcJkMJ3eEhXv+oNmxYWi8XT4oU/8dCaLAQKtmfezHnFXMvLPcFK+EJoAVmB+ipw==", "240cb39a-0e5d-45d6-8b21-3f5968918ebb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a6a7abb-d9b2-4dd3-b948-769a74d78ff9", "AQAAAAEAACcQAAAAEDb21hAeT5Sshlwzzd9OramFa6CzsuFAU4eIfn0b0eJSUfKlThgg0YAGD7f8SoF6uw==", "bbeb5e85-f85a-45e2-8950-166c9f6d6a75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d5106d5-0490-4791-a429-510b194eeffe", "AQAAAAEAACcQAAAAEIlaHgos3S3FVk5eGqtCTBrJwFCVxqSeruB1Hf23JQN169xxsBENwO9bplCnKl4gIA==", "8a1706e0-ebca-4fb2-951c-a00fd63c9cfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af764266-7f71-4feb-ac48-738432947479", "AQAAAAEAACcQAAAAEDxUD1c+T/iRyBxKg65nz9nRSy69sxqSdjWp4B3tGESFPmOnqbFPGfBWk1ZKcqwePA==", "b73a7da8-87a5-4797-ac1f-4386d964aeb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7533f6e-4f55-4202-9f75-54fa1ed315ac", "AQAAAAEAACcQAAAAEDQM44VQ4H+R79MfZ2EEz7XbbvzENor0G906RQ1ie7O5mPvprTGn9ZC3NDV2OOBixQ==", "e21f7188-fe55-4081-8d39-14aef4befa31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede46070-1e8d-41ee-8ae3-3805e3553b99", "AQAAAAEAACcQAAAAENasKK0eKLgN5D8nkKMSg/cvR2AJrKTzT1HBxwTIZPafRt2+ew1eTk2Rd9sJD9vtyw==", "92a01683-5124-4260-b9f4-120d665fe6cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a96a32-e04e-4ec0-86d6-52090bd546e8", "AQAAAAEAACcQAAAAENL3tE/iIyBRTLGNs1YLJJNfdR0pzBoYqiZnDU6bWAWkhVTWIKgMzm81xUHYF7IZMg==", "b2416729-14e0-4e0b-a280-738d4ca33454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc1eafa7-ef56-453f-8d1e-6454967658ac", "AQAAAAEAACcQAAAAECYLCoQmEIwOca0hm9LMWZwPc1t4R+wfTFCDWUNZ2YiTaGZtEEh2460PTLzB9KnNzw==", "dd6a501f-1970-4a0c-89fc-b6167add6427" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "390d596a-4082-45dc-bfc3-f670ed1cf896", "AQAAAAEAACcQAAAAEPuUpGO26MW7nu1AfmV6FS1JA/iUU8ND/9WDJmQZv7vCJAh1AsON9F21vUf5OEu6DA==", "6ed17dc3-3499-4465-a46d-9bd8c2ca04b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d29bc8e-1efb-479e-ba3d-5bb7568abe45", "AQAAAAEAACcQAAAAEKiRozLjMk9mHyFumXDd4AzAjS3hMAiEsTVIPrhags0K6s29m6z6fpVDKxDogqkNZQ==", "551e2f37-ad68-4a77-9c0d-4c48b19c6f58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b42c2c1-4522-455f-9b66-febffaee1028", "AQAAAAEAACcQAAAAEMzfIgEUClw3TCjBU8ppr/SPz8ZWKX6AEmtNcDe1DDfjlB5B4EICa2X4M79iZA+VtA==", "9e18529f-6833-40c6-8a57-12cfad6bf47a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee67e06-90fb-49cf-929f-cc36cf68b41f", "AQAAAAEAACcQAAAAEA/s5rVNq/HmSiOba3JhwrJZ5E9SeQASRppMOk5cIHWIgUNjOVW3Kw7L3rZ+mvGscA==", "2fc6c232-a7b1-4fd9-b101-6f384031bd4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b9d1c2e-81a8-4936-9423-ef8889c166b2", "AQAAAAEAACcQAAAAEN2nX8AQDq0tD5vZtpM0zKwa6rgYiqqRqliuv2E4wUtxKVOYI+DrzKOr9JzmFmwK4A==", "35e6b9a7-144c-4f20-b493-97975efba81f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41f08b7f-cfb2-4a30-a6db-c08ae87d10d7", "AQAAAAEAACcQAAAAEEoWR8oG3Nb1oYFuLXCDuv8mpQCiRRbQiEC0HL2FS7sZUYx0mxPWrgaViDm6fUew3Q==", "407a306c-f9be-43d2-91d7-1f011d850fb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e49199c7-71b4-43cf-a7a5-0f02387dbd97", "AQAAAAEAACcQAAAAEIhfUuZL0eU043vACgr3pQ3Ivd9o3vBsr7+4jGPGCYIDdqTX+5Z0VyZ0jd2bd8CysQ==", "cb80b309-8b1e-456a-969b-f7c22d7250ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34d5cbb-5f81-41b1-8423-263d9a149781", "AQAAAAEAACcQAAAAEKtJRyPO/M2cnm/yoSoEg/v4Wt+1bxtK3/XbUZVAms5GhULUChShoRv/8O5Sbo0D/g==", "fb7657d5-d53d-4cd0-a1a6-29b7094e11e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b0ce409-7179-475f-869d-a6c357f14ef9", "AQAAAAEAACcQAAAAEGbRXL2GgDXK/nLE7HHWr/yWJ0P3H5Ke35E/yJ055Wjqt0YR8lpP4758N5YwSf8VkA==", "8be66d23-f2a1-4daa-943d-52365c8d9d6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64d2e30f-9d7b-4fee-87e9-96708fb8b7e9", "AQAAAAEAACcQAAAAEFbNNYt33eOGU2jbUaium+1e44Gnv7fiM9GKpw5w/P0bPA8DEnCBe9Xcm2LbVzr79A==", "a0d1f3f7-0aa5-4865-9f80-f3624363a980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e70d9f0c-a2bb-4b85-b8cb-9df8e2d0d1d5", "AQAAAAEAACcQAAAAEHUnf1ZzD9eVesv8mWwkLm7ZWIfUlOYyUD0Thra6mFRSE9W1DL1NdQXFPRBcp+L1lA==", "05ef9b41-6a26-4ecf-ae8e-da5421aa11e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62d7666-a8d0-49e2-a45e-253072ebe352", "AQAAAAEAACcQAAAAEOtY5G1ymNPfIe9K9x88Np7HOx3HJFZGwgwkpELzaIjpVoHROsPcC15jQ9lSCLzUFg==", "93686821-b431-4739-94cb-55931a1abdef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c68b6ad-1df1-47a7-9bd3-13e270dcbe43", "AQAAAAEAACcQAAAAEH53PM646V3PMRz6/C+1xEN9cx3oV6KsFzJFY5AbXmm3i4caeEZUS1VCq+ZK+jY8Mw==", "b09f5567-2050-4d0a-a5b3-11571f1e3560" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 250, DateTimeKind.Utc).AddTicks(4890), new DateTime(2021, 11, 18, 21, 32, 5, 250, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 250, DateTimeKind.Utc).AddTicks(3768), new DateTime(2021, 11, 18, 21, 32, 5, 250, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.InsertData(
                table: "ReportCategory",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7708), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7709), null, "Пропаганда терроризма" },
                    { new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7585), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7585), null, "Нарушение моих прав" },
                    { new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7578), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7579), null, "Жестокое обращение с детьми" },
                    { new Guid("06568472-51b4-4292-b7e0-a220b789c885"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7574), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7575), null, "Вредные или опасные действия" },
                    { new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7569), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7570), null, "Оскорбления или проявления нетерпимости" },
                    { new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7553), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7556), null, "Жестокие или отталкивающие сцены" },
                    { new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7714), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7715), null, "Спам или ложная информация" },
                    { new Guid("6c8b430f-99bf-460d-903e-198728353a72"), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7051), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7062), null, "Контент сексуального характера" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReceiverId",
                table: "Report",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReportCategoryId",
                table: "Report",
                column: "ReportCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_SenderId",
                table: "Report",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "ReportCategory");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "869e93f6-79a4-45aa-a783-1e89d13554eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "61915774-1c0c-4637-ad0f-2472fd03b20d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19f5188a-6ed3-48f1-862a-63bf514cabd6", "AQAAAAEAACcQAAAAEBxySSmxTcgMIot0OmTGS3Gq5V7OZ9JwBBIQk6wT4ucA0wEfp97oi0A9W7XJVozxbA==", "3301082e-c080-4adb-af7a-9015ae87868f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f07d84ff-a462-4d37-af4d-10367145136c", "AQAAAAEAACcQAAAAEKVb9z0pvNZ0elXjpcgA8QUoMtbpsfErG+NlE0JUNjVLoOk0oZSY8Vi1NJD4iIwtaQ==", "ce32019e-d9da-4f6d-8402-fa31b7602843" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ac4bc8-ce3a-4cdb-b0e3-53ea28665315", "AQAAAAEAACcQAAAAENF2JBCTLDSQWrfIKHXr6bHOko/osgooOKkTKabFNgrGKEt8OXHz1zD+wKxgnuROvQ==", "714bd9c7-9fcf-43e8-923a-35c971ad0e27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50564ce8-fa9c-4bb6-971c-6bbe22d766a8", "AQAAAAEAACcQAAAAEBAV+PdkOEr9uSNCln/7jjPpTcUcddeO29dyNtXAHopgq/r0CD99kLm+gEe0Z2HK8Q==", "177b1cd5-f92b-4b85-9e7c-fd7a5ff5bacc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7a47ac-a246-4414-be1a-cee9ae592022", "AQAAAAEAACcQAAAAEARwsqLWnXf3bvSG6uE6XMutzPkPlCru68WBNZ4omD1/QGVNdK5odPWGbnI0e9dOnQ==", "d7f099b8-5ddd-487d-ac14-2c4acf234d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "326d0360-0e5b-4995-b40f-2fc02aa1542b", "AQAAAAEAACcQAAAAEGPsHy7s5HRL4eMlMZkLp+sYgmZ8B3uGIlzJ8lK6oEA5HP4FY0Xn4XiUHX5BTih1sg==", "1b059548-360d-4399-8c30-75020867fdee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a497aeaa-c099-40b6-b1be-19ee72a1816f", "AQAAAAEAACcQAAAAELju2523gZzHyDKbFXV2sgm+qogrXM3MsglJTFklL2GRG6/9zMtoFAylVE88eSjjdw==", "d01d71d6-b9a1-467a-966b-1df575d925e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "287afd54-8274-4c47-a6e8-dd5205613591", "AQAAAAEAACcQAAAAECMdz4cd+jV81XKJp4KkFrpoBodAHQHnPPqb82W8/5hEWcniIxmjkJ+Y+heUSvwXlA==", "a588b6d2-1080-49f2-8cca-93f1c09cad75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7c8bcc1-f212-41ad-a092-f90142246df1", "AQAAAAEAACcQAAAAEEjpFbSQqm3eDviHBwD5aL1sumphtXuY0JnvAb9w0qJd1vh2gMFAIEplZxqVpjzwVw==", "49119a9f-33d9-4c15-938c-07a6b2ae995a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b23ac5b8-c495-43f9-a281-4b4758b784a7", "AQAAAAEAACcQAAAAENsZb+LUGvL6S0UJBMT1hKD48YyAyBu73zdKzEGoAWOWiyLiJRv3CUQFEmgkoZfL7g==", "be3a097a-5cae-45e8-a22c-e125bd6cbbce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58aa23db-883a-46d8-921c-9e2892d1b887", "AQAAAAEAACcQAAAAEF00KqggKrVN7WeIyYYdLtF0H9JXbGDwJgyWG9uXkDS1U0KJ3lueB89pozcWLnE1Ew==", "93477335-5ae5-4a9d-b8c2-a326786ef14d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb9cdad1-db1b-4c8f-a7e3-66cbe5a3a293", "AQAAAAEAACcQAAAAEJTtypZZpsGFOxTPXk+ZufoO873ZbIwvRVjEBOu5eYYAaUYQ8PrpCuaW4+TT335SAQ==", "db814305-a37a-4e65-bc88-7e21f47c90a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8dab52a-d394-4c63-84ca-9bc68faf6306", "AQAAAAEAACcQAAAAEGbNVXrjNSJLajXj2L95HgPexRkxRImSKh2MCy6eSkKCGtvSsphqt4RVH3QIZCiUww==", "2c33bfc6-b9a1-48aa-91cf-90fc6b9536d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fab5435e-8fb9-477a-a9fd-cf78b885cb40", "AQAAAAEAACcQAAAAELnrPJD2MVRdI412f+5qtN3Kq08yGUEemSHb5SoVRPCkWOZPC48AlO4qW/N+nCWQ8A==", "c834b9a6-cf99-48c4-8d43-213033335a57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c93e69b4-dea5-4fb5-bfd6-1890052528a9", "AQAAAAEAACcQAAAAECIY8dsWCk5j2YSi9wZXoY1vqGOrLEGGF9wA8Wkjnw5LUkWMLtVixyPJj+vjvGJGig==", "0a8ea673-0946-4396-b2bd-a3a61741f1f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f84c51-8ff9-4ef1-8792-f375f378ae63", "AQAAAAEAACcQAAAAECgziCQBENbvdD37UuJcYiluaELKy+6pcT/auHldP5Ptho/Pq/uldZVbZIF5Empyyg==", "9cee5968-a2eb-48a0-a828-a8032ced77b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1adb2ea0-f6a2-4a0a-acd7-3bdaca1d7651", "AQAAAAEAACcQAAAAEGkf1SS6vnQfbvgO3TZ3JrwUXArcnd/NPwgZn4o+TLY1B+m/GeG+3P5KMCjd7NqolA==", "ab557a5e-2f9d-4f00-b448-ea23d2e57478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990095f8-09df-4529-a705-12b3ce59e8e5", "AQAAAAEAACcQAAAAEFgtxAmz3oPrie1iCv2vJ7dJEKS1ysB6bOVxxCIQRklVop3v7zXO6NGUTlp1d8I/Zg==", "560c0673-b1bf-4a14-87ac-e48d83896786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc50ff8-ef3b-4c72-8508-8eb312dd0a9f", "AQAAAAEAACcQAAAAEHxkS1lL7H71eWJAlCMFd4wxSr6o5nrmfXCQtc+Dpa5gWdiCxSlVXDNXbR/Gznq1/g==", "8ccce7f4-b37c-4ee7-9b43-f24675cad036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "012f59c5-f798-46d3-ac6e-ddf776a65e33", "AQAAAAEAACcQAAAAEI8d2TlPvODZy+cBF37wwJKgoXRUXdbesxjYUPvWZzycSAJT3NZEWJ9mBX9cPea/Ig==", "470e1ff2-b80b-413e-8537-44d23eef3e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab5a588-25a5-4888-9a47-562a1974dce9", "AQAAAAEAACcQAAAAEBpI+1w7/4U0AFWTmhQj6YF3r7py0RdEPTIHWM/X9SnIQJ0BXGpkiyr8dmkSwHraHQ==", "628b2b28-13bf-4666-8baf-a50f6b904386" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(8568), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(7822), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(7831) });
        }
    }
}
