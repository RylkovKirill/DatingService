using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class ProfileDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "4e26f56f-e9f3-4c4f-ab00-1b06eec021d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "e64b2a3b-e9b3-4e96-83f7-84324949871d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52f559f-ede5-4ddb-b4cc-e2d720cea122", "AQAAAAEAACcQAAAAEHRPWxUJQ0hCOMWhyuW6vXws1kcRBGt0BFZgh3ZCBxQqA9jSZ9pDCM2fK7eZ7bqTVw==", "520ff758-ee39-475b-aa91-829620f8bf50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c568aad-fea0-4ecd-91df-f35f567f6d53", "AQAAAAEAACcQAAAAEJB6aHhoBnxlVzIdDow5qc8DRWctBcTPfjNpizdY5b9Hn09Etr96N+mGqRBogFgxrQ==", "401f3b25-6f81-4bcf-8787-9f7fd6a60c95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e260f6c-3624-4ffe-a44d-57e5943a0a08", "AQAAAAEAACcQAAAAELglLmfVO8RwgbMle2JPMtXlBQ6jQNzZp2QTSd06ctLlBwNnEEclGsInau+3nsXcFg==", "0f191fd1-8154-4f1d-8c76-2baaa4971c93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7cba80a-2043-4c8b-809b-315f5c07bb75", "AQAAAAEAACcQAAAAEMCvYiSpgN7X4aq4gdTAQUoeXxe7wCYGr1GAnN/9B/4OtXmu8D4IhQE+WYd+uII0jQ==", "6698036f-c9e3-4e9d-802a-2e7b6b6bf4d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c668729-3f0a-481b-9a2c-050885800ec6", "AQAAAAEAACcQAAAAEC6mFTQ8mnNXcAtTvGNkQ7gRXC8wR2xMZ5UFWc89fnGgbvSJdPBq268jNisu2Qhv3w==", "16e8d863-20c5-4d0d-8db5-fe790cc1f7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0668552-1cf8-449b-a706-4741e556abbc", "AQAAAAEAACcQAAAAEC2fWbfXPReGucejd/HJkFybtWeN6NijaKpzr8SSMHPmuR9Ht3KBTFFXFULDv59E4Q==", "6507cd93-c92d-421a-8859-5b982d040581" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62a3ab9-b04b-440f-8f27-d9f21ace63d9", "AQAAAAEAACcQAAAAEDE0HTNKRG3AD40ldus3ZPmKmU1RA9BRHlHrgOOLWxT907719UtzO8cWoqXsDzBLvw==", "9e25013d-fbbf-4dfd-b1b4-9ddb946888e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96a7657b-967b-444f-a773-2b55cf1c2504", "AQAAAAEAACcQAAAAEF5ZhLXCWJU0ZeOb8H8ORdnVgKfyH8yf/qRX4mcem4Tt9KFqnhyGWYzS8m4d2dzbpw==", "3c9d2ee8-c1ac-48f8-a40f-eb447b08d10c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc94c576-bcee-4d7c-9ab8-caac0c62d4f7", "AQAAAAEAACcQAAAAEIaO3mMc09cxoGAst7QtuhLiNSigl9CTztAOXSztDaPb36z5bTJU8dROFugYj7TmWg==", "e3dffbf0-08e3-4459-99b8-7bee14fb57d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e4557d6-c340-4388-9708-21eafc166de4", "AQAAAAEAACcQAAAAEEGip2O/9x79b4UlkjKJjVuwlfy+1UgisfvZu1mrJuhzq0DBUNbxkFfkZr/lfFk9WA==", "27a82f68-768d-4365-85f3-b2795a73087f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af617f76-a439-48ed-b540-4eb2d615e2cb", "AQAAAAEAACcQAAAAEP7Wvee0GdbZ/K/9BFCmMlXLsutB0oAsmlU8sGS5cDosulbG0ReI0dIogtxAZg6gIg==", "89bc9b5f-0501-4f2f-b331-a9cf34c8d8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c430d22-2a3d-4e90-aa6c-76a57b040790", "AQAAAAEAACcQAAAAEJdFZ9t2a3KHosMFdTrPC40GBA5g4u1o4gfWyvBdPKURc+J03AroO/K3gU0JjxjHdA==", "c517a39b-aca6-43e2-ae6e-1864b9071004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bdb5c53-48f0-4d13-a202-f6590e94cf31", "AQAAAAEAACcQAAAAEF3eU0DQ6jGrIhALdq1YTKmWGE9eR86JGS+aL9fDf3sPaKiN8gXDGIz9c9K+5xzbcA==", "129742b8-b2ad-4c31-a03c-723849409f11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ed367a-2be8-4e01-8e18-16bdd5b41c31", "AQAAAAEAACcQAAAAEFKAZhhNaYsuunpEmUQKcEPVuoGmlnYVt22GKnCK5m+UAxpkxbb2nC/nLEU5iKgSuw==", "a2f91077-e7ff-4f51-869b-8134250a5071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288e6596-2090-4546-81ae-40f32fe5b66c", "AQAAAAEAACcQAAAAEIdfQHA3qzlv1YmZ2GJTXlAJDP2T6JPPkAkr12bzyuOLd1KETqYaISjNV9Th0sFXlw==", "294106c7-99dd-48d6-8a62-7cbdd572cb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29b11f58-18fb-4616-9a26-ae6ac60e6af6", "AQAAAAEAACcQAAAAEGZdu9GaqP1ssNgOJXH9rVU4/hehLkv8NLl4PFiN1gkpGYYs16xerMhvaBZjprr4FQ==", "a9c3dac6-0efc-41d9-a498-55703a21272f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69489718-a22c-42ec-90c6-274a3c1dcf38", "AQAAAAEAACcQAAAAEDaqBLlv63y43JrVSEqo9tVg/1JouJ/lxEvU6CPFAyqksfQJ8R4XbM1zmqerYHAqBA==", "6a85f42a-8915-4c79-a5b1-de848c82c7c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d674245d-b19a-4a9a-a1f7-1ed9a0db790c", "AQAAAAEAACcQAAAAEKUe5SN5ROt77lEwDRCsOp6TFe2eX84C+OvMMBWzlXEIYQXhR6qdFIMi1sC4gDf75A==", "10889240-74ea-4f06-9c8c-ab3d11fb8474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "296ca144-7695-4685-aead-1d7fdbef1c52", "AQAAAAEAACcQAAAAEEeu7N+HvI/yX+bCjETiwEPceyAj46KOWNeKgTPTP6+zh7GuC+rp4asHYG8zpiNObQ==", "cce31ea4-8baa-493d-a7a0-5c885963d01b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc32e0b2-a3bd-47cb-91bb-a1423d33d34b", "AQAAAAEAACcQAAAAEGmhhqlo+7NTTESINzCV6fHObGhqxvKpzw0AA18nGSIIZdyUctAVJDEmJA/C/DE3aQ==", "b2a4d059-2fb7-48b8-a274-912c349f9502" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14486d23-9ab0-4307-9f62-4636e9dfeba6", "AQAAAAEAACcQAAAAEPXcIDB7Fjdx5p5N0lEsSiY6aJgounJUPvfdmvfrXwZJKgX9A/Kw2gJ/kbzv+qjgCg==", "b4c84cf9-7973-4d9b-9680-296a4b8669ef" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 4, 874, DateTimeKind.Utc).AddTicks(2658), new DateTime(2021, 11, 21, 14, 17, 4, 874, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 4, 874, DateTimeKind.Utc).AddTicks(1805), new DateTime(2021, 11, 21, 14, 17, 4, 874, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4366), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4353), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4375), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4369), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(3946), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4382), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4363), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4379), new DateTime(2021, 11, 21, 14, 17, 5, 18, DateTimeKind.Utc).AddTicks(4379) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7574), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7553), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7585), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7578), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7051), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7714), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7569), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7708), new DateTime(2021, 11, 18, 21, 32, 5, 538, DateTimeKind.Utc).AddTicks(7709) });
        }
    }
}
