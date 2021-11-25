using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddAnyLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AnyLocation",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnyLocation",
                table: "AspNetUsers");

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
        }
    }
}
