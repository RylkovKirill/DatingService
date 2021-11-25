using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingService.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostCount = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserChat",
                columns: table => new
                {
                    ChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserChat", x => new { x.ChatsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserChat_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserChat_Chats_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"), "bdb28b9b-72f1-44af-a630-593480dcfcc4", "Admin", null },
                    { new Guid("d821eb23-2337-4e31-a53d-fcec01900507"), "c9da1ccd-9d8b-461e-9e83-5d7ec4a1e6de", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(6956), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(6970), "Man" },
                    { new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(8093), new DateTime(2021, 11, 24, 23, 37, 59, 106, DateTimeKind.Utc).AddTicks(8095), "Woman" }
                });

            migrationBuilder.InsertData(
                table: "ReportCategory",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6c8b430f-99bf-460d-903e-198728353a72"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(7693), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(7707), null, "Контент сексуального характера" },
                    { new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8868), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8874), null, "Жестокие или отталкивающие сцены" },
                    { new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8897), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8898), null, "Оскорбления или проявления нетерпимости" },
                    { new Guid("06568472-51b4-4292-b7e0-a220b789c885"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8903), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8904), null, "Вредные или опасные действия" },
                    { new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8908), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8909), null, "Жестокое обращение с детьми" },
                    { new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8918), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8919), null, "Нарушение моих прав" },
                    { new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8922), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8923), null, "Пропаганда терроризма" },
                    { new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8927), new DateTime(2021, 11, 24, 23, 37, 59, 312, DateTimeKind.Utc).AddTicks(8928), null, "Спам или ложная информация" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPath", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"), 0, null, "88b50490-9962-4cf2-b6a4-0709d0399be2", new DateTime(2001, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kirill.rylkov.2001@gmail.com", true, "Kirill", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Rylkov", null, false, null, null, "KIRILL.RYLKOV.2001@GMAIL.COM", "KIRILL.RYLKOV.2001@GMAIL.COM", "AQAAAAEAACcQAAAAEBJveURNE8dQFC/agkOoCYFSGID0iulIuRVclKTZB57Fxlw5tNGKl2f6fAyoKd5QZA==", null, false, "fc0a9613-4e14-42fb-9731-e1680f8d94c5", false, "kirill.rylkov.2001@gmail.com" },
                    { new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"), 0, null, "b099600b-c748-46be-b1d4-ec8a5e48fe92", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MilanaErmakova@gmail.com", true, "Milana", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ermakova", null, false, null, null, "MILANAERMAKOVA@GMAIL.COM", "MILANAERMAKOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEP9pqhQFLqq1FKy7a5pg8s0R7BpOlculEc8LDlAF/b3OMrZTYNphmXtPOuJoBgmtiA==", null, false, "bbc7aad7-431c-438e-9863-9191faa8afbc", false, "MilanaErmakova@gmail.com" },
                    { new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"), 0, null, "2daeb4fa-8e29-402f-916c-4c47d98c2278", new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EvaAndreevaa@gmail.com", true, "Eva", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Andreeva", null, false, null, null, "EVAANDREEVA@GMAIL.COM", "EVAANDREEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEEdwv/BUw78GjqTW82ZEH3gkRpLRFOWvndhka9almmpW4Er2OOXj9So6PKkC9/NhBw==", null, false, "78897ce8-385b-4b85-8420-47f004b3f5cc", false, "EvaAndreeva@gmail.com" },
                    { new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"), 0, null, "f13d809f-6bd7-4625-b882-def4e4555cc1", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DaryaNikitina@gmail.com", true, "Darya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Nikitina", null, false, null, null, "DARYANIKITINA@GMAIL.COM", "DARYANIKITINA@GMAIL.COM", "AQAAAAEAACcQAAAAECGjatImBJt05hx93f031G0pTCN7BYi+qAZ83m8Df1upZFwWpwmnmoQAStWMvK/7EA==", null, false, "a65ec25b-f55e-4822-beaa-c4670537bfcf", false, "DaryaNikitina@gmail.com" },
                    { new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"), 0, null, "d619097b-87c5-4e99-b351-ea2c511056c8", new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaGrishina@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Grishina", null, false, null, null, "POLINAGRISHINA@GMAIL.COM", "POLINAGRISHINA@GMAIL.COM", "AQAAAAEAACcQAAAAEKqv6frQ8JuYG16+stMFV/Idd2rg7PrZV978uN8ZqK0STeGoO/exju47/fQhzn5w/Q==", null, false, "bb01aa93-9112-4720-b818-1a1cbfee3d0b", false, "PolinaGrishina@gmail.com" },
                    { new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"), 0, null, "4d3d108e-6053-47de-a097-96f9e28fa0c4", new DateTime(1965, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaKarenina@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Karenina", null, false, null, null, "ANNAKARENINA@GMAIL.COM", "ANNAKARENINA@GMAIL.COM", "AQAAAAEAACcQAAAAELflKZwbqIuedj8F4J+qAHIqYUe9tPik8B8TpDmZR+sPiD+SFfqo0AxgcO2znPHm0A==", null, false, "cab56144-37cc-4e79-8948-0d80a9f978fa", false, "AnnaKarenina@gmail.com" },
                    { new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"), 0, null, "7401c6ee-4476-4867-a3fe-c34b13511206", new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaSolovyeva@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Solovyeva", null, false, null, null, "ANNASOLOVYEVA@GMAIL.COM", "ANNASOLOVYEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEIy/2BCnqWYaeiCAFQIi0Nj32sroiVAVqDA8sKTYfpWzt93A1zwzNsSW+H4pifY92A==", null, false, "78e00561-246b-4c85-957f-184a78d6bafd", false, "AnnaSolovyeva@gmail.com" },
                    { new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"), 0, null, "e1a589e1-b154-43a2-91da-a7a49bbf2c9a", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaPopova@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Popova", null, false, null, null, "ANNAPOPOVA@GMAIL.COM", "ANNAPOPOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEGFUjH1dPel3YTBEL/j11gK+n5TakJdz3kV7EzOgHyKPH0eOWonaHbXzrA2omVG0/A==", null, false, "c27d761d-01b4-47cd-9baa-4667f10166f5", false, "AnnaPopova@gmail.com" },
                    { new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"), 0, null, "5577bbc6-88cc-4257-8bb6-d24c05e5b623", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaFilatova@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Filatova", null, false, null, null, "POLINAFILATOVA@GMAIL.COM", "POLINAFILATOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEHnLyIJ6jr1CIO/mYaQEsen3lBWA0HhMhdlZV53wVMvvSXyieP/R1AcJSvp0l2uVkw==", null, false, "c3d6432a-2624-42bc-9362-cb6200635653", false, "PolinaFilatova@gmail.com" },
                    { new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"), 0, null, "d698be1c-c0ca-4107-8a2d-84e65aa90838", new DateTime(1961, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlisaGorbacheva@gmail.com", true, "Alisa", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Gorbacheva", null, false, null, null, "ALISAGORBACHEVA@GMAIL.COM", "ALISAGORBACHEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEG2oReSYgvMxU+mMfiUm1EHAo47ZH526cBDqfudvKjkMOi57/PKXs6/1xtrKin5+nQ==", null, false, "f069212e-010e-4c8f-8d5b-54f87e025598", false, "AlisaGorbacheva@gmail.com" },
                    { new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"), 0, null, "4e559bef-bb91-4171-87b4-5e92aa6ad06a", new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MarkMarkov@gmail.com", true, "Mark", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Markov", null, false, null, null, "MARKMARKOV@GMAIL.COM", "MARKMARKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEMhXAwa3Avccx4iaMFBynTI86wsoBlTorjt2xsHGerjYlfykMFYFuEV3JOq3yQiolQ==", null, false, "160b8b15-9322-46be-b6f9-6e9da8b4caab", false, "MarkMarkov@gmail.com" },
                    { new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"), 0, null, "42136e49-939d-45ac-a951-3668d49866a7", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ArtemOvchinnikov@gmail.com", true, "Artem", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Ovchinnikov", null, false, null, null, "ARTEMOVCHINNIKOV@GMAIL.COM", "ARTEMOVCHINNIKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEEYqrKkMIOQg8x61B7ZTITDta7jAoZr/hVA+9rXmrTvbC4+4SjSdud9Jq6+AsMolIQ==", null, false, "43b8b9f3-74f8-4e7b-bd75-60ad45f43131", false, "ArtemOvchinnikov@gmail.com" },
                    { new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"), 0, null, "4e8d608c-50c1-4f64-ba46-87ef1b698ccb", new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DmitriiGusev@gmail.com", true, "Dmitrii", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Gusev", null, false, null, null, "DMITRIIGUSEV@GMAIL.COM", "DMITRIIGUSEV@GMAIL.COM", "AQAAAAEAACcQAAAAEJsrQS1EiTFMxgXhBlpn3l+Gkuv2mD14qABxATnB7Ah4qXl1t05bIWYIkB1R2JIhZw==", null, false, "d4d42878-d515-4ade-a5f1-32b24ae73a3c", false, "DmitriiGusev@gmail.com" },
                    { new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"), 0, null, "51212b42-cdb9-42ba-9eb1-d8c74199da10", new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexanderBalashov@gmail.com", true, "Alexander", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Balashov", null, false, null, null, "ALEXANDERBALASHOV@GMAIL.COM", "ALEXANDERBALASHOV@GMAIL.COM", "AQAAAAEAACcQAAAAECipSyeFILb/rlNbgWNbTSawRVzxuAyF/X2BssP/hcT/ZVV0PcStHbgw4eBEGJh2PQ==", null, false, "9caeeda3-93cb-4222-81ca-f27430893f78", false, "AlexanderBalashov@gmail.com" },
                    { new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"), 0, null, "ee0949d5-b0d9-4f02-953d-a55aab39d29e", new DateTime(1954, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeorgeKlimov@gmail.com", true, "George", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Klimov", null, false, null, null, "GEORGEKLIMOV@GMAIL.COM", "GEORGEKLIMOV@GMAIL.COM", "AQAAAAEAACcQAAAAEJI9A6g6FjegN6/+XsUGjFB2SmGL3h3Mgck2fpVMm2NlNzGqbbJAJgcAvvHt0ZqGGA==", null, false, "b78fb836-e37a-4e2e-83c2-d3e7c5eaf120", false, "GeorgeKlimov@gmail.com" },
                    { new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"), 0, null, "a869e68e-654e-428c-9aa1-d087f63ae280", new DateTime(1986, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexeyShapavalov@gmail.com", true, "Alexey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Shapavalov", null, false, null, null, "ALEXEYSHAPAVALOV@GMAIL.COM", "ALEXEYSHAPAVALOV@GMAIL.COM", "AQAAAAEAACcQAAAAEAuo7x8tx2CgMl2bViKMO+8ObTJbqzylOntdQhHTXM/LUSXq92cBUl4nGUuttDKOzg==", null, false, "da1aa84c-e1ab-4758-b8e6-6b2d5fc68149", false, "AlexeyShapavalov@gmail.com" },
                    { new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"), 0, null, "663e4d7c-2357-4649-be63-ec6b240db660", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NikitaSidorov@gmail.com", true, "Nikita", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Sidorov", null, false, null, null, "NIKITASIDOROV@GMAIL.COM", "NIKITASIDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAELw793ywF8duddfXHqxKsdQGFQoJaBwcdcfeLjPhDKiFJQjwUGCmzE+Mtasc/uZ9xw==", null, false, "57ff7b0c-3da6-47d2-beb8-392c21ae187c", false, "NikitaSidorov@gmail.com" },
                    { new Guid("19678e73-2240-43c1-bc08-726405e9810f"), 0, null, "ab0f32e0-0226-49e9-988d-e394052a5b5a", new DateTime(1970, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TimofeyFedorov@gmail.com", true, "Timofey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Fedorov", null, false, null, null, "TIMOFEYFEDOROV@GMAIL.COM", "TIMOFEYFEDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAEAEQPDZiK4GA2+RZ9NA6Gx44wn/F40b1XwITQluiF4Dsah8t4kxet3AR3UmVA6ardQ==", null, false, "cf486d14-d503-4d4c-a471-cd7284ed1c68", false, "TimofeyFedorov@gmail.com" },
                    { new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"), 0, null, "b5ac2679-c87d-49fc-a44b-326ff4d96fe3", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MaximSkvortsov@gmail.com", true, "Maxim", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Skvortsov", null, false, null, null, "MAXIMSKVORTSOV@GMAIL.COM", "MAXIMSKVORTSOV@GMAIL.COM", "AQAAAAEAACcQAAAAEKekMNmsAvS3LOCTqQdazcfEQ66/YBmcVNq++TwG7/wS+l+yhbisXrfOBXhDDJMG7g==", null, false, "c59a047c-e2ea-4cdd-9e3b-7e6db2acd9fa", false, "MaximSkvortsov@gmail.com" },
                    { new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"), 0, null, "f5e7076b-0c48-4d84-8b72-6fe3935d7b46", new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeonidTarasov@gmail.com", true, "Leonid", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Tarasov", null, false, null, null, "LEONIDTARASOV@GMAIL.COM", "LEONIDTARASOV@GMAIL.COM", "AQAAAAEAACcQAAAAEKM6jjPcKTiGaJgNScmbLofNDCyYXaRupfZU2YrmTR9G5Npcf+5q4h3JJFBFE9z45Q==", null, false, "7eaa8beb-cecb-40c0-b9bb-76383ba22483", false, "LeonidTarasov@gmail.com" },
                    { new Guid("b587585c-344b-4e35-9df0-90723c5114ba"), 0, null, "150fb857-2a42-4f98-8948-25261d91cdc0", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SofiyaIvanova@gmail.com", true, "Sofiya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ivanova", null, false, null, null, "SOFIYAIVANOVA@GMAIL.COM", "SOFIYAIVANOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEKN0hnU6VWimEF0yCQLwTo41g8dgrH4wS+zLsSA79otDN5/yh/I1vkiJVE4mExdUlQ==", null, false, "b824c2e3-0faa-4029-ab0e-dc109b76b379", false, "SofiyaIvanova@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"), new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039") });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserChat_UsersId",
                table: "ApplicationUserChat",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GenderId",
                table: "AspNetUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_Name",
                table: "Genders",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_Path",
                table: "Images",
                column: "Path",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ImageId",
                table: "Posts",
                column: "ImageId",
                unique: true,
                filter: "[ImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ReceiverId",
                table: "Requests",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SenderId",
                table: "Requests",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserChat");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "ReportCategory");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
