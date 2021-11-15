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
                    { new Guid("67397b47-b0e9-4e15-8b82-57c0884af92c"), "869e93f6-79a4-45aa-a783-1e89d13554eb", "Admin", null },
                    { new Guid("d821eb23-2337-4e31-a53d-fcec01900507"), "61915774-1c0c-4637-ad0f-2472fd03b20d", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(7822), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(7831), "Man" },
                    { new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(8568), new DateTime(2021, 11, 15, 21, 42, 6, 590, DateTimeKind.Utc).AddTicks(8570), "Woman" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarId", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c6dd1e20-cce1-4299-be0c-862a2b681039"), 0, null, "990095f8-09df-4529-a705-12b3ce59e8e5", new DateTime(2001, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kirill.rylkov.2001@gmail.comm", true, "Kirill", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Rylkov", null, false, null, null, "KIRILL.RYLKOV.2001@GMAIL.COM", "KIRILL.RYLKOV.2001@GMAIL.COM", "AQAAAAEAACcQAAAAEFgtxAmz3oPrie1iCv2vJ7dJEKS1ysB6bOVxxCIQRklVop3v7zXO6NGUTlp1d8I/Zg==", null, false, "560c0673-b1bf-4a14-87ac-e48d83896786", false, "kirill.rylkov.2001@gmail.com" },
                    { new Guid("13765215-c5c6-4dfe-a8e5-5b51300e8f69"), 0, null, "19f5188a-6ed3-48f1-862a-63bf514cabd6", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MilanaErmakova@gmail.com", true, "Milana", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ermakova", null, false, null, null, "MILANAERMAKOVA@GMAIL.COM", "MILANAERMAKOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEBxySSmxTcgMIot0OmTGS3Gq5V7OZ9JwBBIQk6wT4ucA0wEfp97oi0A9W7XJVozxbA==", null, false, "3301082e-c080-4adb-af7a-9015ae87868f", false, "MilanaErmakova@gmail.com" },
                    { new Guid("a3e0cceb-a4b9-4877-b3a0-b7991d1a45f2"), 0, null, "cb9cdad1-db1b-4c8f-a7e3-66cbe5a3a293", new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "EvaAndreevaa@gmail.com", true, "Eva", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Andreeva", null, false, null, null, "EVAANDREEVA@GMAIL.COM", "EVAANDREEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEJTtypZZpsGFOxTPXk+ZufoO873ZbIwvRVjEBOu5eYYAaUYQ8PrpCuaW4+TT335SAQ==", null, false, "db814305-a37a-4e65-bc88-7e21f47c90a4", false, "EvaAndreeva@gmail.com" },
                    { new Guid("1caabeb4-fa16-46c9-8ef0-e8009955d916"), 0, null, "ae7a47ac-a246-4414-be1a-cee9ae592022", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DaryaNikitina@gmail.com", true, "Darya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Nikitina", null, false, null, null, "DARYANIKITINA@GMAIL.COM", "DARYANIKITINA@GMAIL.COM", "AQAAAAEAACcQAAAAEARwsqLWnXf3bvSG6uE6XMutzPkPlCru68WBNZ4omD1/QGVNdK5odPWGbnI0e9dOnQ==", null, false, "d7f099b8-5ddd-487d-ac14-2c4acf234d1e", false, "DaryaNikitina@gmail.com" },
                    { new Guid("ffb5bbe2-debf-4f3f-805e-32167b700e4a"), 0, null, "3ab5a588-25a5-4888-9a47-562a1974dce9", new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaGrishina@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Grishina", null, false, null, null, "POLINAGRISHINA@GMAIL.COM", "POLINAGRISHINA@GMAIL.COM", "AQAAAAEAACcQAAAAEBpI+1w7/4U0AFWTmhQj6YF3r7py0RdEPTIHWM/X9SnIQJ0BXGpkiyr8dmkSwHraHQ==", null, false, "628b2b28-13bf-4666-8baf-a50f6b904386", false, "PolinaGrishina@gmail.com" },
                    { new Guid("7d8780f7-15b4-4b56-91e1-6d6e16012477"), 0, null, "a497aeaa-c099-40b6-b1be-19ee72a1816f", new DateTime(1965, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaKarenina@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Karenina", null, false, null, null, "ANNAKARENINA@GMAIL.COM", "ANNAKARENINA@GMAIL.COM", "AQAAAAEAACcQAAAAELju2523gZzHyDKbFXV2sgm+qogrXM3MsglJTFklL2GRG6/9zMtoFAylVE88eSjjdw==", null, false, "d01d71d6-b9a1-467a-966b-1df575d925e1", false, "AnnaKarenina@gmail.com" },
                    { new Guid("abc953f6-d6ff-464b-9539-c95ee111f006"), 0, null, "d8dab52a-d394-4c63-84ca-9bc68faf6306", new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaSolovyeva@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Solovyeva", null, false, null, null, "ANNASOLOVYEVA@GMAIL.COM", "ANNASOLOVYEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEGbNVXrjNSJLajXj2L95HgPexRkxRImSKh2MCy6eSkKCGtvSsphqt4RVH3QIZCiUww==", null, false, "2c33bfc6-b9a1-48aa-91cf-90fc6b9536d8", false, "AnnaSolovyeva@gmail.com" },
                    { new Guid("bdb4c580-01ee-41c4-93f9-6d64a4778370"), 0, null, "70f84c51-8ff9-4ef1-8792-f375f378ae63", new DateTime(1984, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnnaPopova@gmail.com", true, "Anna", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Popova", null, false, null, null, "ANNAPOPOVA@GMAIL.COM", "ANNAPOPOVA@GMAIL.COM", "AQAAAAEAACcQAAAAECgziCQBENbvdD37UuJcYiluaELKy+6pcT/auHldP5Ptho/Pq/uldZVbZIF5Empyyg==", null, false, "9cee5968-a2eb-48a0-a828-a8032ced77b2", false, "AnnaPopova@gmail.com" },
                    { new Guid("9410107f-8e37-45a7-8d3a-bcabb2abda45"), 0, null, "b7c8bcc1-f212-41ad-a092-f90142246df1", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PolinaFilatova@gmail.com", true, "Polina", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Filatova", null, false, null, null, "POLINAFILATOVA@GMAIL.COM", "POLINAFILATOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEEjpFbSQqm3eDviHBwD5aL1sumphtXuY0JnvAb9w0qJd1vh2gMFAIEplZxqVpjzwVw==", null, false, "49119a9f-33d9-4c15-938c-07a6b2ae995a", false, "PolinaFilatova@gmail.com" },
                    { new Guid("be6f2919-9dca-4b54-a788-02cef50c6b1b"), 0, null, "1adb2ea0-f6a2-4a0a-acd7-3bdaca1d7651", new DateTime(1961, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlisaGorbacheva@gmail.com", true, "Alisa", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Gorbacheva", null, false, null, null, "ALISAGORBACHEVA@GMAIL.COM", "ALISAGORBACHEVA@GMAIL.COM", "AQAAAAEAACcQAAAAEGkf1SS6vnQfbvgO3TZ3JrwUXArcnd/NPwgZn4o+TLY1B+m/GeG+3P5KMCjd7NqolA==", null, false, "ab557a5e-2f9d-4f00-b448-ea23d2e57478", false, "AlisaGorbacheva@gmail.com" },
                    { new Guid("d2d6dc46-025c-4034-80c8-8bb7e1d54098"), 0, null, "2bc50ff8-ef3b-4c72-8508-8eb312dd0a9f", new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MarkMarkov@gmail.com", true, "Mark", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Markov", null, false, null, null, "MARKMARKOV@GMAIL.COM", "MARKMARKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEHxkS1lL7H71eWJAlCMFd4wxSr6o5nrmfXCQtc+Dpa5gWdiCxSlVXDNXbR/Gznq1/g==", null, false, "8ccce7f4-b37c-4ee7-9b43-f24675cad036", false, "MarkMarkov@gmail.com" },
                    { new Guid("ea66d92d-2dba-48dc-a240-5d20b653223b"), 0, null, "012f59c5-f798-46d3-ac6e-ddf776a65e33", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ArtemOvchinnikov@gmail.com", true, "Artem", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Ovchinnikov", null, false, null, null, "ARTEMOVCHINNIKOV@GMAIL.COM", "ARTEMOVCHINNIKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEI8d2TlPvODZy+cBF37wwJKgoXRUXdbesxjYUPvWZzycSAJT3NZEWJ9mBX9cPea/Ig==", null, false, "470e1ff2-b80b-413e-8537-44d23eef3e1d", false, "ArtemOvchinnikov@gmail.com" },
                    { new Guid("424801eb-4028-47de-b02e-b2260e4adbaf"), 0, null, "326d0360-0e5b-4995-b40f-2fc02aa1542b", new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "DmitriiGusev@gmail.com", true, "Dmitrii", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Gusev", null, false, null, null, "DMITRIIGUSEV@GMAIL.COM", "DMITRIIGUSEV@GMAIL.COM", "AQAAAAEAACcQAAAAEGPsHy7s5HRL4eMlMZkLp+sYgmZ8B3uGIlzJ8lK6oEA5HP4FY0Xn4XiUHX5BTih1sg==", null, false, "1b059548-360d-4399-8c30-75020867fdee", false, "DmitriiGusev@gmail.com" },
                    { new Guid("186fdbe7-3b56-47bf-9e4b-3ec743375e8e"), 0, null, "d1ac4bc8-ce3a-4cdb-b0e3-53ea28665315", new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexanderBalashov@gmail.com", true, "Alexander", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Balashov", null, false, null, null, "ALEXANDERBALASHOV@GMAIL.COM", "ALEXANDERBALASHOV@GMAIL.COM", "AQAAAAEAACcQAAAAENF2JBCTLDSQWrfIKHXr6bHOko/osgooOKkTKabFNgrGKEt8OXHz1zD+wKxgnuROvQ==", null, false, "714bd9c7-9fcf-43e8-923a-35c971ad0e27", false, "AlexanderBalashov@gmail.com" },
                    { new Guid("15bce5d6-b3c2-431b-ac4b-7d87d86de00e"), 0, null, "f07d84ff-a462-4d37-af4d-10367145136c", new DateTime(1954, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeorgeKlimov@gmail.com", true, "George", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Klimov", null, false, null, null, "GEORGEKLIMOV@GMAIL.COM", "GEORGEKLIMOV@GMAIL.COM", "AQAAAAEAACcQAAAAEKVb9z0pvNZ0elXjpcgA8QUoMtbpsfErG+NlE0JUNjVLoOk0oZSY8Vi1NJD4iIwtaQ==", null, false, "ce32019e-d9da-4f6d-8402-fa31b7602843", false, "GeorgeKlimov@gmail.com" },
                    { new Guid("a2c8f466-4460-46d9-a3e1-849542257eda"), 0, null, "58aa23db-883a-46d8-921c-9e2892d1b887", new DateTime(1986, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexeyShapavalov@gmail.com", true, "Alexey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Shapavalov", null, false, null, null, "ALEXEYSHAPAVALOV@GMAIL.COM", "ALEXEYSHAPAVALOV@GMAIL.COM", "AQAAAAEAACcQAAAAEF00KqggKrVN7WeIyYYdLtF0H9JXbGDwJgyWG9uXkDS1U0KJ3lueB89pozcWLnE1Ew==", null, false, "93477335-5ae5-4a9d-b8c2-a326786ef14d", false, "AlexeyShapavalov@gmail.com" },
                    { new Guid("959fad98-c404-4b2e-a4b5-2da34b051182"), 0, null, "b23ac5b8-c495-43f9-a281-4b4758b784a7", new DateTime(1964, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NikitaSidorov@gmail.com", true, "Nikita", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Sidorov", null, false, null, null, "NIKITASIDOROV@GMAIL.COM", "NIKITASIDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAENsZb+LUGvL6S0UJBMT1hKD48YyAyBu73zdKzEGoAWOWiyLiJRv3CUQFEmgkoZfL7g==", null, false, "be3a097a-5cae-45e8-a22c-e125bd6cbbce", false, "NikitaSidorov@gmail.com" },
                    { new Guid("19678e73-2240-43c1-bc08-726405e9810f"), 0, null, "50564ce8-fa9c-4bb6-971c-6bbe22d766a8", new DateTime(1970, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "TimofeyFedorov@gmail.com", true, "Timofey", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Fedorov", null, false, null, null, "TIMOFEYFEDOROV@GMAIL.COM", "TIMOFEYFEDOROV@GMAIL.COM", "AQAAAAEAACcQAAAAEBAV+PdkOEr9uSNCln/7jjPpTcUcddeO29dyNtXAHopgq/r0CD99kLm+gEe0Z2HK8Q==", null, false, "177b1cd5-f92b-4b85-9e7c-fd7a5ff5bacc", false, "TimofeyFedorov@gmail.com" },
                    { new Guid("b72abb26-30ee-4fbd-843e-c1c9712f7f2a"), 0, null, "c93e69b4-dea5-4fb5-bfd6-1890052528a9", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "MaximSkvortsov@gmail.com", true, "Maxim", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Skvortsov", null, false, null, null, "MAXIMSKVORTSOV@GMAIL.COM", "MAXIMSKVORTSOV@GMAIL.COM", "AQAAAAEAACcQAAAAECIY8dsWCk5j2YSi9wZXoY1vqGOrLEGGF9wA8Wkjnw5LUkWMLtVixyPJj+vjvGJGig==", null, false, "0a8ea673-0946-4396-b2bd-a3a61741f1f1", false, "MaximSkvortsov@gmail.com" },
                    { new Guid("9041f759-c64b-4320-b85b-2332fff4ed85"), 0, null, "287afd54-8274-4c47-a6e8-dd5205613591", new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeonidTarasov@gmail.com", true, "Leonid", new Guid("f71bcbe8-2f30-4f63-be7d-a90f46f39178"), "Tarasov", null, false, null, null, "LEONIDTARASOV@GMAIL.COM", "LEONIDTARASOV@GMAIL.COM", "AQAAAAEAACcQAAAAECMdz4cd+jV81XKJp4KkFrpoBodAHQHnPPqb82W8/5hEWcniIxmjkJ+Y+heUSvwXlA==", null, false, "a588b6d2-1080-49f2-8cca-93f1c09cad75", false, "LeonidTarasov@gmail.com" },
                    { new Guid("b587585c-344b-4e35-9df0-90723c5114ba"), 0, null, "fab5435e-8fb9-477a-a9fd-cf78b885cb40", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "SofiyaIvanova@gmail.com", true, "Sofiya", new Guid("b50075d8-0379-4b95-b0c2-50bba4509dab"), "Ivanova", null, false, null, null, "SOFIYAIVANOVA@GMAIL.COM", "SOFIYAIVANOVA@GMAIL.COM", "AQAAAAEAACcQAAAAELnrPJD2MVRdI412f+5qtN3Kq08yGUEemSHb5SoVRPCkWOZPC48AlO4qW/N+nCWQ8A==", null, false, "c834b9a6-cf99-48c4-8d43-213033335a57", false, "SofiyaIvanova@gmail.com" }
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
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Chats");

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
