using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class AddTelegramChatIdConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TelegramChatId",
                table: "AspNetUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                column: "ConcurrencyStamp",
                value: "79802bec-9f71-4224-981f-e5e92a6adba8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d821eb23-2337-4e31-a53d-fcec01900507"),
                column: "ConcurrencyStamp",
                value: "fc648821-813f-4228-b87d-53d586f39794");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "8dcd6886-62ca-48d8-8334-26f2370f4280", "AQAAAAEAACcQAAAAEBQpjYBqHomxD7xCcEj8XGP2Cuc4IKLw2I+x/DuqyfjKw3w4Lkr5Ez7DnZfN0OZRVw==", "1b37497a-4a0a-4018-a078-0b2ce28092f4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "0095ebba-6082-403b-a58d-baba5cca0429", "AQAAAAEAACcQAAAAELH+yE1/R2Ntoqo6nSyuHYBMVxFn9GuV9aF4LbzjqZjg9CBld5EPvZ9Tjm97YOzKwg==", "6e6f3942-0582-4ead-803c-1a7e01b45bf5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "16bf97eb-2819-4280-b6a1-ef101320a4fc", "AQAAAAEAACcQAAAAEHHH8XBO+9G0xwtRp48z5Y7mTGXDKDEdp9eUfAaSqIbbX+LzOzVVAGtSs0DgbWNYgg==", "8b1ad3b3-5c5f-4dae-81d3-a94d1b62a7e2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "134235ff-2093-4b81-8bbe-d0664ae88525", "AQAAAAEAACcQAAAAENnT9cJHA6lbkXWHkU5GrlvHAZS9VixIldRwaA6UG5KuIPs++DUkvluTmiqcHwLvwA==", "ba527357-368b-4ecd-89f4-2ac3f8df88c1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "bb1e3360-28d4-4b73-bd1a-fe26c4d4aadc", "AQAAAAEAACcQAAAAEKuCn118JxY369BfmcUut5U2DN5QpUvEZDDuLAd5ZhZMHZVNl6mzb8/zTEFxf77LWA==", "9fcef6e9-1495-463a-bb30-3784424eaca3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "b5627d9a-cdfa-4355-9b63-4c95cc4f07ba", "AQAAAAEAACcQAAAAENBiyTKXcy/ZLBFGgIBQz5h1RyjFTi+EKnGhkJ+9sCzkWSyPHV2vhdCnr1cgehx8aQ==", "d9bd286a-4430-4dfd-83e8-6a6a09347748", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "ab5dbd80-f77c-40b9-a10b-62291a1eff05", "AQAAAAEAACcQAAAAEC2w+fZRfFRhW1JsMwm02QUAt1ucQkrIz2bT/FyeBdIDRTQMJNfvUGXM+mcB+4rfGA==", "f3d4e27b-47d9-45d9-8620-0a8593d43495", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "487283c3-4ba6-4614-9d7a-e2afd7492ebd", "AQAAAAEAACcQAAAAEEURc0P8FXQGHtRXuTSVCKqXVWeMSerJTjHup5NBGVrENSn3n5/Mxrog4toX8JMwog==", "db242478-b239-4e20-81ca-8aa83c57aa7e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "30b3bd96-54fa-4d34-b9ab-de6dc092cbf2", "AQAAAAEAACcQAAAAEES5kxpbA4kqmSV4aWn3jppRJeasLAckJfjYAZSrbKYEgvthQgGtk1aO6TG4XiIcZA==", "9d69c179-dd90-491a-9c24-6557325460ec", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "b6ee70a1-c816-4e4b-9480-6838c5cccc79", "AQAAAAEAACcQAAAAEFBMhBWrH30Z4UCHha1YxGRcGJjaXHulqvJdYTb4ZhljU9NG+rvwKIjKCsKPiCZeTQ==", "2d083900-3350-49b3-9b03-90d593c908c8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "c4916c1a-0577-4286-86e6-c33277bc0f8d", "AQAAAAEAACcQAAAAENeA/aQt513O4GIqT+gNM5TEigGaSuYdUQOdAX2Pe5PbD0MTsGfMHaS6irPnVbvrcw==", "546ef68f-8d0a-4f89-b8ef-f52a29721d8d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "f1fca2b7-a339-463b-948a-f7d10dfbcf5f", "AQAAAAEAACcQAAAAENQgYeB7zoHpmiuihOIkVDpx4N66A/oFfFdbDmUy+VQ2ViJnznDBumny9//+tqtMZQ==", "3a65122c-8499-4cb9-a943-e5cad8fa3ef0", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "105493e5-0890-4948-8099-d6619fc8300d", "AQAAAAEAACcQAAAAELo1GXXyaTR7xQXcq7sdCdt1VHD5la8TfbPIQLw44jr666NUPtsx3OEkpSQ0MaRIkA==", "d8d4f5fa-791a-4a62-8547-6c161764a19b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "9083c4b3-4d74-4acc-966b-c601fb3a8b4b", "AQAAAAEAACcQAAAAENgQJM//RqaAtSGIXPFx34A41v0B3LJkgobtL4iBGFJKg/PzPeHSw7CXTKxizoIdMw==", "2a49c565-b4a1-48b0-b353-d5d58d793c4c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "91c38813-ec2f-4e73-9018-2923bb0e7960", "AQAAAAEAACcQAAAAEOJzxpbQAR7GnClTzqYzfvvYKc+k2b3lz0rl2RbQlL3qNGMg099LQ1pS5IqkR15s2g==", "1f3f739c-cb8d-4093-9b9f-963ab0b0ac77", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "47d19a6e-b1e8-4327-8a74-1dc92eb76bf5", "AQAAAAEAACcQAAAAEP5zN5zhZNAwR6Rsm4F6g0MekzZg/FsWT8iqFdqB3vOgZzLE5063Kv+RNT1ZxWi5OQ==", "e3e08d0a-936b-4f70-807a-93a5703935e3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "d4e4fc15-f67e-49d7-9af0-3de8d5c3fef3", "AQAAAAEAACcQAAAAELwQXzpXY4wwzYtROs7AxgdwhhD96YTR9IrACrqW7BygYoS7tnLSJgDt6bjopYclHQ==", "15b53293-0eb6-4c5e-b5c6-341182fb9f6e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "16f71db0-c263-422e-a707-b37fa15b98a7", "AQAAAAEAACcQAAAAECKuFMYjPlgtrrdlTVmU9Ld2OQ4s16MSpU7SKFKwjciO1RiXQxTzTDYbnouKAqrWkg==", "8e5ca17e-0c9f-49d5-8ad5-f142a7168e47", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "68cdf865-a735-43f2-a247-35c9e3186bb6", "AQAAAAEAACcQAAAAEKzcTP5V9I+fe6gS2Cv1UfHtEtBinc9pYAxh+EfmlWj5lZ90EJzd16PWs/xfxKq60g==", "6ce588a6-c9ba-4b28-860f-0fe0d5d89f78", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "00a10743-7794-4b65-801a-0f1800e7ea80", "AQAAAAEAACcQAAAAEOfVgL0DysIZgEF3eWI4YCUI3MseMoBfFCh0ir/jCCv6me3sULGe52TUQi1KTqaTww==", "92330180-ee2b-4e19-9302-70b5048795e7", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "73d8d8c6-5ee8-457a-9060-e6cbec43ce4d", "AQAAAAEAACcQAAAAEAg6X9GwGiaog5uVVy3k1pAProws0+Z2TuidfSdiH3aq2ImXmjSC0CV0a4AatlPZBw==", "01faf1d4-24e0-4814-9fb5-db31b32ff28a", null });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 38, DateTimeKind.Utc).AddTicks(7221), new DateTime(2021, 12, 2, 12, 22, 39, 38, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 38, DateTimeKind.Utc).AddTicks(6255), new DateTime(2021, 12, 2, 12, 22, 39, 38, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("06568472-51b4-4292-b7e0-a220b789c885"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5771), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5745), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5782), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5775), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("6c8b430f-99bf-460d-903e-198728353a72"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5241), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5790), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5765), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "ReportCategory",
                keyColumn: "Id",
                keyValue: new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5786), new DateTime(2021, 12, 2, 12, 22, 39, 222, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TelegramChatId",
                table: "AspNetUsers",
                column: "TelegramChatId",
                unique: true,
                filter: "[TelegramChatId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TelegramChatId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<double>(
                name: "TelegramChatId",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "fef65cc6-179d-4f33-896a-0699660d266c", "AQAAAAEAACcQAAAAENEoA4V81glxXJJmcGpjmZ0oV7Sae167FZt5yV7SENBFvKU4YFuDxFUFkunKnVbwTQ==", "7d57c900-14ce-4575-9475-55a67a91d948", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "16de0b65-155c-491c-a05d-c898d69a4692", "AQAAAAEAACcQAAAAEAwAxp44qGd/96XkAxObA+tHw/IjB1C1tw2NnocD31rfE5aJYd3xVNkOoDV7XNsqsw==", "9c08c5e2-5619-4750-8559-16ef18664bf7", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "ec6c254d-e045-4f6b-ab03-64ec5d65f80d", "AQAAAAEAACcQAAAAEAe2Gd46rNea3zxVaqVM5HDEuT4o9VTXDK3ThL43uLSnVfo4Wnj2Vg0/2ThV+0OcTw==", "66f70eef-d706-4195-b28d-35658cc5a341", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19678e73-2240-43c1-bc08-726405e9810f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "8084b114-94a0-4871-8b80-e826d7b0a3c9", "AQAAAAEAACcQAAAAELlZGVTdWyxWoCB2AiD0nJG7SIUuYf1wzzbbJ3/pirWN+qHWtypVYxZcKzlm/Ex49Q==", "274889f6-1958-4198-a58c-91910664162c", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "6733a3ea-62b3-4225-8bec-a924197468de", "AQAAAAEAACcQAAAAEK5C2IX2CWngabLT486+u2GKnNrdXPOzfxWLmrsQMN26Sp0+BkiFXo01Ub7OG7JqfA==", "966a6a86-4595-4f61-8951-9dfe3a9a3418", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "1be1a7fe-2d3c-4727-a996-712d17c5c312", "AQAAAAEAACcQAAAAEPsl2i9bGzpS8vMA4fC15tOVPKchJtZ1rFm4Ls2gr6aeb7XuSdqxJF/sqOv5q23PLg==", "780a264b-d7ce-474e-8bbd-2f6cc0d28752", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "0b840b12-5525-412b-840f-24a3907a26ef", "AQAAAAEAACcQAAAAEDBGQQYR2MMiWVI/JSr+selN66e3Sae9Su9j1/t5vUhe+HG/XJhW54mU63KhmQffVw==", "841fa8c5-81a2-422b-a38b-af0617b4d12e", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "36807705-5f86-4913-b4cc-e706c8b0849e", "AQAAAAEAACcQAAAAEDM7EcvhacqiGyrRpIFvfvx5D6Wr27wdFhbVSfiOvHaMHcWk94t6rrYfTYOTo2l65Q==", "f663f162-c259-4192-819a-855ed5bc1e56", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "8d6272c7-5fcb-4105-b076-846381355213", "AQAAAAEAACcQAAAAEAR0jRc3s9C1OLHaAuo8yNknnxfdjP28H50SbFxNf3yHfHw8AgcNO+M2WAjogE+4kA==", "018862bf-69c7-4774-838f-baed5c6e4b53", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "297b2405-68b6-4a25-bda0-2dadf17423df", "AQAAAAEAACcQAAAAEGHK1zO+fftk9djek5eY7kjK9eBlJyI2Akd+FWgnUH9Sgl7n0mTFJ1FXwYt24KY6Vw==", "bffe0ed5-a8a8-408c-8260-ebbbe55b3f2e", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "4dc71668-6085-4a95-a332-00cd088c8958", "AQAAAAEAACcQAAAAEJ7YQiAARbxN82iNmOgAeWNDq8luHn8R5dpnPj8l9bLiF8jT/MfMXxKui3rf4hlttg==", "8bb373fc-b5dd-462f-9628-e539dcdf9310", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "3afdf184-43cd-4ece-96ab-b4d838f31685", "AQAAAAEAACcQAAAAEMvy2FkRmOu9oDIrDslk98KW36DUSpGWzo+aNC46wWIYpdt753xe9RcLFViCgNGKHg==", "461fed8d-a431-42e3-92f3-96494a2c3294", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "22213d39-b3a1-4c73-ba63-c5ea08c5e95d", "AQAAAAEAACcQAAAAEI1BJKJDrMrVBLDUpy/mGBx0xOuA1+45HGegv3kohryuVoK/Lw/o3JYYM0V3yrPyMw==", "b0239f04-6405-414c-ba45-178605352b6a", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b587585c-344b-4e35-9df0-90723c5114ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "5be65932-45eb-46fa-a4ce-dd8e4f862541", "AQAAAAEAACcQAAAAEGOHs79wvLuvGRlDLBlv9CzSlr1D8KpRhXRs3UfQoXhSiVbkk0/o9RqDAM4iSsJYlg==", "45d72e72-6a5f-4be4-8c3b-4c40584609a3", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "a2a39abc-42aa-41da-9263-751e11d74004", "AQAAAAEAACcQAAAAELp+IpUcxLePB5YA3agDxR//G9kLyyd7LCbhSGlhE7CjmxAFTTm2CTrssX23c9B1Ug==", "83b9a724-aca3-4242-a253-af01066342cf", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "280bbbfe-df4f-411f-b7c3-aab532f0e26f", "AQAAAAEAACcQAAAAEEiKGSE/IUkyF+9R+UWVG1Ik5330m6dFKsn3CjKoT9LjXOeOYURPFybND/1nriDBeg==", "84a6105c-9991-4485-9648-ca7a538ec0ce", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "c26c1a06-c330-42c7-8091-7ae53cc949ca", "AQAAAAEAACcQAAAAEEjuo8lJdYaZpacPQh61je+lfCuxedI10DJ2vk7I2eThyfRczB/uFYkytUCIpKmx4Q==", "417a8ba0-cc1b-4683-a897-283b35edc7cb", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "d00a7cac-45fe-4866-92a6-311ef89f171a", "AQAAAAEAACcQAAAAEOXVZaov3+AKjJ014kaNjJ2X+ukfBBCaXjgr7/3sOc9jw/QNkYzJel5HTAO3rZPQSQ==", "814d2fc9-0574-480b-8683-b4257ef11587", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "fe102f75-4fd6-4d56-a257-6afe94206ba0", "AQAAAAEAACcQAAAAEGjUaRYJ+8udyvfEGtV+aHZMsRgSCCZIeJhpLwTwlyPDvf3aHr4DPnYHoIb45kfCaA==", "5e92c549-36c5-424a-8828-9950c390d8ef", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "52120a70-9c73-4b8e-b6d8-431d70f03506", "AQAAAAEAACcQAAAAEFIUfW0eRZE2s3oSWWk3LrzjiRQLpVjPUGch1fJly3Zr8pRYwa1iILLB6rrzp+wkYw==", "7ad29ef0-a370-4e0a-bc94-54333d048fc4", 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TelegramChatId" },
                values: new object[] { "a0f07d18-c13c-48f8-aee3-a6c6a67cd543", "AQAAAAEAACcQAAAAEAT8UdVLKbJJsV0Sgx+L9bSzvB21jnzBFtGvntxxKqqFdU/Gc9YEZCp/WogO/CWr8Q==", "bbc2242e-268f-4cc6-a2c8-8f81d9f5a5ff", 0.0 });

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
    }
}
