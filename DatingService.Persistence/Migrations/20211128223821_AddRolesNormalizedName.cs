using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddRolesNormalizedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e2c55f77-fa6e-4fc8-b61f-4bc9ec36fbc0", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "8d5e5f3b-b043-4a5c-9fc8-cc5a42af77f3", "USER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "d41000cd-3cb3-4deb-b2f1-ca51c619f680", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "fb421fa5-4117-4647-a316-2544f9479a8b", null });

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
        }
    }
}
