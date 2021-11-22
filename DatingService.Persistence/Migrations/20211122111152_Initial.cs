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
                name: "Avatars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatars", x => x.Id);
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
                    AvatarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_AspNetUsers_Avatars_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"), "b2e275d4-89e9-4e34-9c4a-667696f4d712", "Admin", null },
                    { new Guid("d821eb23-2337-4e31-a53d-fcec01900507"), "f626c9bb-d2d2-41b5-ab79-4646b1bc9e76", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), new DateTime(2021, 11, 22, 11, 11, 51, 404, DateTimeKind.Utc).AddTicks(2432), new DateTime(2021, 11, 22, 11, 11, 51, 404, DateTimeKind.Utc).AddTicks(2445), "Man" },
                    { new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), new DateTime(2021, 11, 22, 11, 11, 51, 404, DateTimeKind.Utc).AddTicks(3455), new DateTime(2021, 11, 22, 11, 11, 51, 404, DateTimeKind.Utc).AddTicks(3459), "Woman" }
                });

            migrationBuilder.InsertData(
                table: "ReportCategory",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6c8b430f-99bf-460d-903e-198728353a72"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7160), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7170), null, "Контент сексуального характера" },
                    { new Guid("0d50b5d6-2274-4f74-a478-7671242e1348"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7640), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7643), null, "Жестокие или отталкивающие сцены" },
                    { new Guid("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7655), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7656), null, "Оскорбления или проявления нетерпимости" },
                    { new Guid("06568472-51b4-4292-b7e0-a220b789c885"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7661), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7662), null, "Вредные или опасные действия" },
                    { new Guid("520eeb61-256a-4edd-9476-5fbe69cc3f20"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7665), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7666), null, "Жестокое обращение с детьми" },
                    { new Guid("516fff94-dfd1-4c94-bebd-9498048eac3d"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7671), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7672), null, "Нарушение моих прав" },
                    { new Guid("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7675), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7676), null, "Пропаганда терроризма" },
                    { new Guid("7eca2608-2bf8-482b-a630-8e7eb2bc8724"), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7679), new DateTime(2021, 11, 22, 11, 11, 51, 614, DateTimeKind.Utc).AddTicks(7680), null, "Спам или ложная информация" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"), 0, null, "1560d324-817f-4cbb-830f-2ca34f3b4c6a", new DateTime(2001, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kirill.rylkov.2001@gmail.comm", true, "Kirill", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Rylkov", null, false, null, null, "KIRILL.RYLKOV.2001@GMAIL.COM", "KIRILL.RYLKOV.2001@GMAIL.COM", "AQAAAAEAACcQAAAAENpT3z0wj34PnfPjjvm3OD/TSc4G3ER4c4+jQpdc/YvjJcLVWL5aBzx2UHWZnef/BA==", null, false, "9b3c0277-b21c-4a28-928e-2c00053c597e", false, "kirill.rylkov.2001@gmail.com" },
                    { new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"), 0, null, "cad6fc99-6d2c-4973-ae03-cdbde98dcf40", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MilanaErmakova@gmail.com", true, "Milana", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ermakova", null, false, null, null, "MILANAERMAKOVA@GMAIL.COM", "MILANAERMAKOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEIlAv2Sp0asY9RNS/Cts4rF1i7R8/TFG0ocEsvtw3uWckfy07h+LVCeC4oet6bj/lw==", null, false, "3c5c3f31-15a2-4930-a471-0c94ace8e4be", false, "MilanaErmakova@gmail.com" },
                    { new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"), 0, null, "7abe89a3-8cf6-4547-95d8-ba778b775834", new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EvaAndreevaa@gmail.com", true, "Eva", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Andreeva", null, false, null, null, "EVAANDREEVA@GMAIL.COM", "EVAANDREEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEAvDQ8mn2wyynLlYnECsclsmCvJGRCOuUbxH2VjEO57OYGwxjt947rGHCnGD+Q+D4w==", null, false, "ccbd0ae4-0a06-4f82-9120-c882d87d75b3", false, "EvaAndreeva@gmail.com" },
                    { new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"), 0, null, "08122719-9880-42a6-aaae-db7f40c9363a", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DaryaNikitina@gmail.com", true, "Darya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Nikitina", null, false, null, null, "DARYANIKITINA@GMAIL.COM", "DARYANIKITINA@GMAIL.COM", "AQAAAAEAACcQAAAAEOirO85KzlF0DCavKj8PUV1BLA2nt7tuICntrNaYD7FIkX+HRq0bhzOiV1AcR5CbGg==", null, false, "74ae0a2e-13f5-4cd7-ab21-7b3bc7b3ae8a", false, "DaryaNikitina@gmail.com" },
                    { new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"), 0, null, "d63f4f78-e715-4ab3-9818-1bdd25f74e7b", new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaGrishina@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Grishina", null, false, null, null, "POLINAGRISHINA@GMAIL.COM", "POLINAGRISHINA@GMAIL.COM", "AQAAAAEAACcQAAAAEHudsRwMnKcfx7g8oqtj+iCyN4qg3Gu13y9uXjwNAzHwdy1vcxo2WPVfbWGpwzsalQ==", null, false, "fee1182e-7455-43ed-a1a3-1eaf618ead3e", false, "PolinaGrishina@gmail.com" },
                    { new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"), 0, null, "7bb5c17c-0d3a-4156-9a03-4fcbf7ec353a", new DateTime(1965, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaKarenina@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Karenina", null, false, null, null, "ANNAKARENINA@GMAIL.COM", "ANNAKARENINA@GMAIL.COM", "AQAAAAEAACcQAAAAEK7jpCs1d5Gar+DB5J0E/4y2f9BThSL9ha8DJZ7J3I/iM7b4Zk+d3intLW8Rkeo+/A==", null, false, "c8ba63f4-0a5b-48c1-8f50-e5ba798c2e75", false, "AnnaKarenina@gmail.com" },
                    { new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"), 0, null, "36fe1d1f-fdd8-42d0-9512-456963bbe456", new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaSolovyeva@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Solovyeva", null, false, null, null, "ANNASOLOVYEVA@GMAIL.COM", "ANNASOLOVYEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEIOD5GJghsWpT2XpaJvLAktp17HofV/9xkxPuqlZ6VgDjj54CYnJCodhXw6hs8lLjw==", null, false, "bfb9a24e-e1dc-4e07-98a8-480ef957e20f", false, "AnnaSolovyeva@gmail.com" },
                    { new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"), 0, null, "7a69de9f-9ba6-4d1f-b28e-897ad69bad52", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaPopova@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Popova", null, false, null, null, "ANNAPOPOVA@GMAIL.COM", "ANNAPOPOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEN3gDjv1oLtehHvopHm/Uz/q/5Hw0CKOXT6Rt3rWo1icj2lTWuWB6F7AMRyMxu6mXw==", null, false, "360402af-c8e9-4fc7-aee1-0da9991592ad", false, "AnnaPopova@gmail.com" },
                    { new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"), 0, null, "822360f2-822a-4433-b862-5e4fc14fa2a4", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaFilatova@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Filatova", null, false, null, null, "POLINAFILATOVA@GMAIL.COM", "POLINAFILATOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEDEVxT9KkDaw3Fbocrn3tqUcDZj2nZ0P7cemQ4Km6X/t2y9E9X4J66C9x7680Cvz4w==", null, false, "3feff3e5-9fb7-4097-a401-831cb93c4f1b", false, "PolinaFilatova@gmail.com" },
                    { new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"), 0, null, "a97f0a1b-12ac-45b1-b5b7-41e3b9676b5f", new DateTime(1961, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlisaGorbacheva@gmail.com", true, "Alisa", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Gorbacheva", null, false, null, null, "ALISAGORBACHEVA@GMAIL.COM", "ALISAGORBACHEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEI6/knZ/sfaewq/JUWV/zZs5ns6tw8RgA3BxkPqfhEnyIXegvptl3oXwsFdGutSL3Q==", null, false, "515c95ff-80c6-480d-a74e-c87a9c28b710", false, "AlisaGorbacheva@gmail.com" },
                    { new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"), 0, null, "7154b59e-fcb3-414c-aa04-9ba96ee33081", new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MarkMarkov@gmail.com", true, "Mark", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Markov", null, false, null, null, "MARKMARKOV@GMAIL.COM", "MARKMARKOV@GMAIL.COM", "AQAAAAEAACcQAAAAED5OjWKmjmH01B5lGDI2LbnPWqYTOxowHmIMZDBuBlgP7mvqDok/JkVNBsZo+1F2aQ==", null, false, "a1405de6-dcc4-4a0c-9934-95bcaae6efbe", false, "MarkMarkov@gmail.com" },
                    { new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"), 0, null, "cda9de53-070b-4bba-8c55-24a2ca5ec59b", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ArtemOvchinnikov@gmail.com", true, "Artem", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Ovchinnikov", null, false, null, null, "ARTEMOVCHINNIKOV@GMAIL.COM", "ARTEMOVCHINNIKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEL4nTUKgSiUO+4ljqgcv5/AoXgUrCg0yjvZfGrbcXepEVoNdFkIBjyleL53bIxd0UA==", null, false, "385e2b40-c6c3-4a7d-8daa-ec0812ba52ac", false, "ArtemOvchinnikov@gmail.com" },
                    { new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"), 0, null, "792cb35d-14f0-49c5-9928-71f51c44a876", new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DmitriiGusev@gmail.com", true, "Dmitrii", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Gusev", null, false, null, null, "DMITRIIGUSEV@GMAIL.COM", "DMITRIIGUSEV@GMAIL.COM", "AQAAAAEAACcQAAAAEL9lfwy5Ao4KqumYqwZXnkeLv8OWksFS/73oxATDBZBKYg6/dXjTLXX1mg/B7hqNMQ==", null, false, "0db0200a-c774-4711-bf86-a448839604a8", false, "DmitriiGusev@gmail.com" },
                    { new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"), 0, null, "4c96d668-b30c-4453-9af9-38fc2aaf461e", new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexanderBalashov@gmail.com", true, "Alexander", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Balashov", null, false, null, null, "ALEXANDERBALASHOV@GMAIL.COM", "ALEXANDERBALASHOV@GMAIL.COM", "AQAAAAEAACcQAAAAEKlgbRfk5v4x6MXMqAvLRvcOybKygDYRv5AvVkln1FkJZrz6tEHWfnLO8zU/rkUUUA==", null, false, "81b17e0c-91ac-43ef-b923-4c172fcbfe8e", false, "AlexanderBalashov@gmail.com" },
                    { new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"), 0, null, "98e6dbc6-148c-47b3-a2d4-ee6abe7a39a5", new DateTime(1954, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeorgeKlimov@gmail.com", true, "George", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Klimov", null, false, null, null, "GEORGEKLIMOV@GMAIL.COM", "GEORGEKLIMOV@GMAIL.COM", "AQAAAAEAACcQAAAAEItCwXP+34Wlf1gWc5QPz3wo6+zJvI+KCJKEgxYSmHD/SvWClSmzEn9E9T5sSN1Sxg==", null, false, "870c10d4-9b61-461f-8742-c609b5429acd", false, "GeorgeKlimov@gmail.com" },
                    { new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"), 0, null, "807db56e-1052-4f32-8cf1-bfa0aa48f042", new DateTime(1986, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexeyShapavalov@gmail.com", true, "Alexey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Shapavalov", null, false, null, null, "ALEXEYSHAPAVALOV@GMAIL.COM", "ALEXEYSHAPAVALOV@GMAIL.COM", "AQAAAAEAACcQAAAAEAEu62VcEpTNY9IlzoAxtiprbsOUvHimg9pdAFxaDvIvNiXpLxh8pWLhbBq+WIVykg==", null, false, "90a610a1-2387-45eb-a49a-fa8ce88d96cc", false, "AlexeyShapavalov@gmail.com" },
                    { new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"), 0, null, "c43b7099-28fe-4e9a-a9f8-14b165801158", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NikitaSidorov@gmail.com", true, "Nikita", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Sidorov", null, false, null, null, "NIKITASIDOROV@GMAIL.COM", "NIKITASIDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAEEEAqE1XyA8l5i/MSl3xucfnmOlgSBMoMUEpBl7Jy5wERtf6b0PpuIPfBiNKb0orvA==", null, false, "b85747f0-7d7d-4245-acad-7b74b9aac8db", false, "NikitaSidorov@gmail.com" },
                    { new Guid("19678e73-2240-43c1-bc08-726405e9810f"), 0, null, "f0196f17-029a-4c24-a042-521e62adea81", new DateTime(1970, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TimofeyFedorov@gmail.com", true, "Timofey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Fedorov", null, false, null, null, "TIMOFEYFEDOROV@GMAIL.COM", "TIMOFEYFEDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAEEqToBLpmERRJGKb6gWYUnRCh3iM8Q+RiGLzZUeoUJ62kEXdyYQFps8cA0m98qUCUw==", null, false, "f9e4aa83-5a32-480d-a5ae-3c2da81f1ce2", false, "TimofeyFedorov@gmail.com" },
                    { new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"), 0, null, "c9a1396b-73ca-4685-aeec-143233bb7dc6", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MaximSkvortsov@gmail.com", true, "Maxim", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Skvortsov", null, false, null, null, "MAXIMSKVORTSOV@GMAIL.COM", "MAXIMSKVORTSOV@GMAIL.COM", "AQAAAAEAACcQAAAAEIpSKxMoo9zP/IekJlj3TwuwQN56MEv+lhumtniAfa1kfKWV/w/+tLaxmEES3zkcdQ==", null, false, "c72c1e27-4042-4182-ade3-f754009a3d7f", false, "MaximSkvortsov@gmail.com" },
                    { new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"), 0, null, "b85473fc-d9c4-44e7-959c-f0d2827f1859", new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeonidTarasov@gmail.com", true, "Leonid", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Tarasov", null, false, null, null, "LEONIDTARASOV@GMAIL.COM", "LEONIDTARASOV@GMAIL.COM", "AQAAAAEAACcQAAAAEAhJA47aeOS2OnWOM1R1qJlWCd4e8HG+803kCg5VJ1MAvRJJ4LhWYl2M/WCoSv+sXQ==", null, false, "ce12bdfa-dd4e-494c-83de-7fd476048258", false, "LeonidTarasov@gmail.com" },
                    { new Guid("b587585c-344b-4e35-9df0-90723c5114ba"), 0, null, "265c6d18-94e2-4b04-a898-a0e1221ed28c", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SofiyaIvanova@gmail.com", true, "Sofiya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ivanova", null, false, null, null, "SOFIYAIVANOVA@GMAIL.COM", "SOFIYAIVANOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEJSehmxTbtsHnFCtBZ8UhuR8Zr69E8RckpzBj8DpAyUMvIrQPGb7P5oVmVGhhTh0vQ==", null, false, "4d4415ba-9931-42f7-b903-9f3efc8d2e67", false, "SofiyaIvanova@gmail.com" }
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
                name: "IX_AspNetUsers_AvatarId",
                table: "AspNetUsers",
                column: "AvatarId",
                unique: true,
                filter: "[AvatarId] IS NOT NULL");

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
                name: "IX_Avatars_Path",
                table: "Avatars",
                column: "Path",
                unique: true);

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
                name: "Avatars");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
