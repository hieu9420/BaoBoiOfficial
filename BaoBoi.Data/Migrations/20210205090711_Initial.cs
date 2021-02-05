using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaoBoi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
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
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
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
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsShowOnHome = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoiChuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CauChuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoiChuc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneUser",
                columns: table => new
                {
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Pay = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DatePlay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatePay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneUser", x => x.Phone);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SeoAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplyForAll = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductIds = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryIds = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ShipPhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LanguageId = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAlias = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of Bao Boi Official" },
                    { "HomeKeyword", "This is keyword of Bao Boi Official" },
                    { "HomeDescription", "This is description of Bao Boi Official" }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "4631322c-0ffa-4448-acb4-d6b04dd436d9", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "27726302-02e6-4818-8d5a-4d66e958b543", new DateTime(1996, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hieule.9420@gmail.com", true, "Le", "Hieu", false, null, "hieule.9420@gmail.com", "admin", "AQAAAAEAACcQAAAAEL1ZuAJj5A0L/MJ9uk//+gi47Bk31Qsq33LdrRekcy823pchtN6wQej0lHe6xlakDQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi", true, "Tiếng Việt" },
                    { "en", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "LoiChuc",
                columns: new[] { "ID", "CauChuc", "Type" },
                values: new object[,]
                {
                    { 11, "Let your spirit soar and have a joy-filled new year", 0 },
                    { 10, "Wishing you all the magic of the new year", 0 },
                    { 8, "May all your new year wishes come true", 0 },
                    { 7, "Hãy cùng vẫy tay tạm biệt năm cũ, đón nhận năm mới với nhiều ước mơ, hoài bão và cả hy vọng. Chúc bạn năm mới tràn ngập niềm vui và hạnh phúc", 0 },
                    { 6, "Có thể những niềm vui của năm mới kéo dài mãi mãi trong cuộc sống của bạn. Có thể bạn sẽ tìm thấy được ánh sáng dẫn bạn đến thành công, cái đích mà bạn mong muốn. Chúc mừng năm mới", 0 },
                    { 9, "Best wishes for a happy and successful new year", 0 },
                    { 4, "Tết đến, xuân về, an khang thịnh vượng, phát tài phát lộc, sức khỏe dồi dào, mọi điều như ý", 0 },
                    { 3, "Năm mới với bao điều thú vị đang đến với bạn. Chúc bạn có đủ niềm đam mê để khám phá và tận hưởng từng ngày tươi đẹp của cuộc sống mới", 0 },
                    { 2, "Năm mới đã tới thật gần, chúc cho đại gia đình một năm mới An Khang Thịnh Vượng", 0 },
                    { 1, "Mừng 2021 phát tài phát lộc. Tiền vô xồng xộc, tiền ra từ từ. Sức khỏe có dư, công danh tấn tới. Tình duyên phơi phới,hạnh phúc thăng hoa.Xin chúc mọi nhà một năm đại thắng.", 0 },
                    { 5, "Chúc mọi người năm mới An khang thịnh vượng, tài lộc đầy nhà, con cháu sum vầy, một năm bình an và sung túc", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0354023098", 0.0, null, null, "Quốc Thông", 0 },
                    { "0929207097", 0.0, null, null, "Quốc Thông", 0 },
                    { "0375767266", 0.0, null, null, "Quyền", 0 },
                    { "0396513565", 0.0, null, null, "Sáng", 0 },
                    { "0962744683", 0.0, null, null, "Sơn Xù", 0 },
                    { "0989538072", 0.0, null, null, "Sven", 0 },
                    { "0354601772", 0.0, null, null, "Sumi", 0 },
                    { "0349548560", 0.0, null, null, "Sỹ", 0 },
                    { "1", 0.0, null, null, "Test", 0 },
                    { "0969102120", 0.0, null, null, "Thái", 0 },
                    { "0394204227", 0.0, null, null, "Quốc Hưng", 0 },
                    { "60162175578", 0.0, null, null, "Stephen", 1 },
                    { "0333262399", 0.0, null, null, "Quân", 0 },
                    { "0969853537", 0.0, null, null, "Nghĩa", 0 },
                    { "0978939976", 0.0, null, null, "Phạm Linh Linh", 1 },
                    { "0349925559", 0.0, null, null, "Oanh Cao", 0 },
                    { "0327090718", 0.0, null, null, "Nhung", 0 },
                    { "0934452821", 0.0, null, null, "Nhật", 0 },
                    { "0388855622", 0.0, null, null, "Nhật", 0 },
                    { "0374094726", 0.0, null, null, "Ngoan", 0 },
                    { "0986839804", 0.0, null, null, "Nghĩa", 0 },
                    { "0342829455", 0.0, null, null, "Thảo", 0 },
                    { "0332263410", 0.0, null, null, "Ngân Muội", 0 },
                    { "0375188165", 0.0, null, null, "Mỹ Thanh", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0329003084", 0.0, null, null, "Mỹ Thanh", 0 },
                    { "0359516706", 0.0, null, null, "Mẹ", 4 },
                    { "0978225695", 0.0, null, null, "Phú", 0 },
                    { "0914290456", 0.0, null, null, "Thầy Lộc", 3 },
                    { "0968113772", 0.0, null, null, "Thuý", 0 },
                    { "0382115375", 0.0, null, null, "Thịnh", 2 },
                    { "0368013361", 0.0, null, null, "Yến", 0 },
                    { "0163673765", 0.0, null, null, "Yee Kuan", 0 },
                    { "0353264570", 0.0, null, null, "Xuân Nam", 0 },
                    { "0977811837", 0.0, null, null, "Xuân", 0 },
                    { "0968270836", 0.0, null, null, "Vũ Linh", 0 },
                    { "0886525647", 0.0, null, null, "Vũ Đạt", 0 },
                    { "0376463339", 0.0, null, null, "Vũ", 0 },
                    { "0377377487", 0.0, null, null, "Vĩ", 0 },
                    { "0399658291", 0.0, null, null, "Vĩ", 0 },
                    { "0978086565", 0.0, null, null, "Vân Muội Muội", 0 },
                    { "0987221504", 0.0, null, null, "Ursa", 0 },
                    { "0566820006", 0.0, null, null, "Ù", 0 },
                    { "0376093038", 0.0, null, null, "Tường Vi", 0 },
                    { "0394959832", 0.0, null, null, "Trinh Toeic", 0 },
                    { "0348879740", 0.0, null, null, "Trí Thông", 0 },
                    { "0966785834", 0.0, null, null, "Trang Tuyền", 0 },
                    { "0376545320", 0.0, null, null, "Tráng", 0 },
                    { "0367816473", 0.0, null, null, "Tráng", 0 },
                    { "0986179154", 0.0, null, null, "Toàn", 0 },
                    { "0369712191", 0.0, null, null, "Tô Bướm", 0 },
                    { "0354171005", 0.0, null, null, "Lu", 0 },
                    { "0329979306", 0.0, null, null, "Thuý", 0 },
                    { "0388825432", 0.0, null, null, "Thuý", 0 },
                    { "0363944069", 0.0, null, null, "Thuý", 0 },
                    { "0332950027", 0.0, null, null, "Thuận", 0 },
                    { "0989764925", 0.0, null, null, "Thu Trang", 0 },
                    { "0976393245", 0.0, null, null, "Thơ", 0 },
                    { "0908202983", 0.0, null, null, "Thầy Vĩnh", 3 },
                    { "0774992232", 0.0, null, null, "Lê Thịnh", 1 },
                    { "0962957940", 0.0, null, null, "Hoàng", 0 },
                    { "0339427771", 0.0, null, null, "Huyền Đen", 0 },
                    { "0908991164", 0.0, null, null, "Chị Thúy Vy", 1 },
                    { "0396813296", 0.0, null, null, "Chị Thảo Vy", 1 },
                    { "0909820075", 0.0, null, null, "Chị Phương Anh", 1 },
                    { "0354755733", 0.0, null, null, "Chị Phiên", 1 },
                    { "0342103967", 0.0, null, null, "Chị Mai Anh", 1 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0909047892", 0.0, null, null, "Chị Lành Enrich", 1 },
                    { "0397280420", 0.0, null, null, "Chị Giàu", 4 },
                    { "0397667520", 0.0, null, null, "Chị Dung", 0 },
                    { "0388915223", 0.0, null, null, "Chị Châm", 0 },
                    { "0986522539", 0.0, null, null, "Cậu Tèo", 4 },
                    { "0912298018", 0.0, null, null, "Bò", 0 },
                    { "0359271374", 0.0, null, null, "Bảo Bối", 5 },
                    { "0925347343", 0.0, null, null, "Chị Trâm", 0 },
                    { "0912520927", 0.0, null, null, "Bà Nội", 4 },
                    { "0962857858", 0.0, null, null, "Anh Trung Design", 1 },
                    { "0908233009", 0.0, null, null, "Anh Thi", 2 },
                    { "0935201352", 0.0, null, null, "Anh Quân", 2 },
                    { "0355559738", 0.0, null, null, "Anh Nhanh", 4 },
                    { "0327489656", 0.0, null, null, "Anh Nguyên", 0 },
                    { "0775080990", 0.0, null, null, "Anh khải", 1 },
                    { "0332160345", 0.0, null, null, "Anh Hoà", 1 },
                    { "0907603537", 0.0, null, null, "Anh Hiếu CIMB", 2 },
                    { "0967440028", 0.0, null, null, "Anh Đức Anh", 4 },
                    { "0901239894", 0.0, null, null, "Anh Doanh CIMB", 1 },
                    { "0903754094", 0.0, null, null, "Anh Bình CIMB", 2 },
                    { "0967738406", 0.0, null, null, "Admin", 5 },
                    { "0982848104", 0.0, null, null, "Ba", 4 },
                    { "0329613873", 0.0, null, null, "Chị Trang", 1 },
                    { "0933184113", 0.0, null, null, "Chị Trinh", 0 },
                    { "0968338488", 0.0, null, null, "Chị Trinh", 0 },
                    { "0367257428", 0.0, null, null, "Hương", 0 },
                    { "0976016307", 0.0, null, null, "Hồng", 0 },
                    { "0916789498", 0.0, null, null, "Hợi", 0 },
                    { "0394137496", 0.0, null, null, "Hợi", 0 },
                    { "0563419551", 0.0, null, null, "Hợi", 0 },
                    { "0339610931", 0.0, null, null, "Hoàng", 0 },
                    { "0388991387", 0.0, null, null, "Yến", 0 },
                    { "0978374265", 0.0, null, null, "Hiệp", 0 },
                    { "0337253858", 0.0, null, null, "Hí", 0 },
                    { "0327141466", 0.0, null, null, "Hí", 0 },
                    { "0378015202", 0.0, null, null, "Hí", 0 },
                    { "0344087516", 0.0, null, null, "Hà Trang", 0 },
                    { "0373514988", 0.0, null, null, "Gấm", 0 },
                    { "0358050165", 0.0, null, null, "Duyên", 0 },
                    { "0386884721", 0.0, null, null, "Duyên", 0 },
                    { "0776611227", 0.0, null, null, "Dì Chúc", 4 },
                    { "0378109170", 0.0, null, null, "Đẹt", 4 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0568200441", 0.0, null, null, "Dat La", 0 },
                    { "0989040813", 0.0, null, null, "Đăng Phúc", 0 },
                    { "0963463845", 0.0, null, null, "Đại", 0 },
                    { "0979224841", 0.0, null, null, "Cô Trinh", 3 },
                    { "0938091809", 0.0, null, null, "Cô Sương - PLS", 2 },
                    { "0975723759", 0.0, null, null, "Cô Nhung Trọ", 0 },
                    { "0327370037", 0.0, null, null, "Cô Dung", 3 },
                    { "0984903994", 0.0, null, null, "Chức", 0 },
                    { "0383539845", 0.0, null, null, "Chức", 0 },
                    { "0372303720", 0.0, null, null, "Chong Yau CIMB", 1 },
                    { "0386586120", 0.0, null, null, "Ka Ram", 0 },
                    { "60123836370", 0.0, null, null, "Yew Khai Shing", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_CategoryId",
                table: "ProductInCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CategoryTranslations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "LoiChuc");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PhoneUser");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
