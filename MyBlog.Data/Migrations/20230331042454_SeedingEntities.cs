using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class SeedingEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReferances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReferances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    About = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: true),
                    About = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubGroups_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerReferanceId = table.Column<int>(type: "int", nullable: true),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    About = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalOfReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerReferances_CustomerReferanceId",
                        column: x => x.CustomerReferanceId,
                        principalTable: "CustomerReferances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "SubPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPrograms_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    ProductSubGroupId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ProductSubGroups_ProductSubGroupId",
                        column: x => x.ProductSubGroupId,
                        principalTable: "ProductSubGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentTypeId = table.Column<int>(type: "int", nullable: true),
                    IsMade = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AppointmentTypes_AppointmentTypeId",
                        column: x => x.AppointmentTypeId,
                        principalTable: "AppointmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Appointments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Notifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: true),
                    AmountPaid = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Payments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SaleTypeId = table.Column<int>(type: "int", nullable: true),
                    SaleStatusId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Sales_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Sales_SaleStatuses_SaleStatusId",
                        column: x => x.SaleStatusId,
                        principalTable: "SaleStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Sales_SaleTypes_SaleTypeId",
                        column: x => x.SaleTypeId,
                        principalTable: "SaleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppointmentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8752), "Test", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8753), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8756), "Test", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8757), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8004), "TEST", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(8005), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6544), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6545), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6547), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6548), "C++", "C++ Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6550), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6550), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6553), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6553), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6556), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6556), "Java", "Java Blog Kategorisi" },
                    { 6, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6559), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6559), "Python", "Python Blog Kategorisi" },
                    { 7, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6562), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6562), "Php", "Php Blog Kategorisi" },
                    { 8, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6565), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6565), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6568), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6568), "Swift", "Swift Blog Kategorisi" },
                    { 10, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6570), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(6571), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "Action", "DateTime", "NewValues", "OldValues", "TableName" },
                values: new object[] { 1, "act Manuel", null, null, null, null });

            migrationBuilder.InsertData(
                table: "CustomerReferances",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(2224), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(2225), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(2228), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(2229), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3001), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3001), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3004), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3005), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 2" },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3007), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3008), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7153), "Description", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7153), "Not", "Title" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7155), "Description", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7156), "Not", "Title" },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7157), "Description", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7157), "Not", "Title" },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7160), "Description", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(7161), "Not", "Title" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1867), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1868), "AgendaModule.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1870), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1871), "CustomerModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1873), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1874), "FinanceModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1876), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1876), "HomeModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1879), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1879), "InstitutionalModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1881), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1882), "MarketingModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1884), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(1885), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Admin", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5828), "test description", true, false, "Admin", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5828), null, "test" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3931), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3932), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3935), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(3936), "Product Kategori 2", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(1361), "Ürün Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(1362), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 3, "712d46f2-4d97-4244-8fe7-3c250933a7c4", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 2, 3, "bcdccfb4-5196-4850-a494-6386f72585f4", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 3, 3, "fac59916-a971-4894-8f7e-f0f4e45a447b", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 4, 3, "ee9001bb-9dfa-4a88-bd07-1adad27db025", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 5, 3, "bdc12395-aafe-4970-a460-2f81ec1c66f9", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 6, 3, "685f9933-99c3-4402-a666-d6f092257cbc", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 7, 3, "d5ebc03c-5e58-487e-b462-7f25168cb79b", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 8, 3, "7556cfe3-4e9e-45e3-8a23-7380c5511b93", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 9, 3, "397ea4ce-fdba-4f60-bcb4-4d9b7fb3a85c", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 10, 3, "76b643d3-6a07-439f-9012-1380b8e1da9a", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 11, 3, "a6a568a9-6141-4c8d-86f1-0e9e37dca17f", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 12, 3, "df280359-054b-43e0-9155-f31533ac7da1", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 13, 3, "55553df7-6696-4dfb-8be5-9072b96cae6b", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 14, 3, "3e7b7c14-648b-4f5e-9326-ed28819e6408", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 15, 3, "c994cae3-5cf8-4857-9d83-c6c301580ae5", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 16, 3, "9816d0c3-291b-462e-802d-d51f77a9e726", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 17, 3, "de07959f-f8b1-4c01-8adb-a516aee4cd59", "Çalışan Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 18, 3, "1a8e13ab-7b96-4fa2-8b10-ed0b5a1ccf51", "Çalışan Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 19, 3, "1564d251-5c03-4989-97d7-192d7246f36f", "Çalışan Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 20, 3, "bd2ec8a5-d1c9-4555-8244-487cbba96145", "Çalışan Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 21, 3, "6028ea13-1425-4029-90c8-c111a6b1a550", "Çalışan Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 22, 3, "60023225-f655-479b-ac30-dc64c0ed3c45", "Çalışan Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 23, 3, "c6ebc77f-a992-46cf-b106-874144132a3b", "Çalışan Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 24, 3, "aab0c9df-9bbb-4771-8ede-0980d0e5273a", "Çalışan Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 25, 3, "638e19d0-e3c7-4433-a11e-9eb0c9c1d507", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 26, 3, "722f8d10-be42-4a96-8091-e00d4c9ae423", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 27, 3, "d2cf2f45-570c-4d57-b235-018b568d4589", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 28, 3, "035bb806-d2b0-494c-851b-3f450e5af563", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 29, 3, "a12e4121-96c5-44ea-9f0a-aa002c0e623c", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 30, 3, "25b4e898-1c2b-4ff5-b367-93ffcd699b5b", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 31, 3, "02064e4d-524d-4c1d-89e7-5ffc619b7942", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 32, 3, "340925a4-9247-431d-9317-9c47898f508e", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 33, 3, "0c652bb7-3682-483f-96f5-0dc1909069be", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTİFİCATİON.CREATE" },
                    { 34, 3, "aebda01f-0b14-45b3-849e-052c7ea4aeb7", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTİFİCATİON.READ" },
                    { 35, 3, "ba424639-ce25-4296-a4ef-dd6d0acf3995", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTİFİCATİON.UPDATE" },
                    { 36, 3, "e3970787-bf9f-4421-be5f-0617793929dd", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTİFİCATİON.DELETE" },
                    { 37, 3, "2a86d8c4-6832-4d8a-8c67-b56de8efd889", "Marka Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 38, 3, "4e54fb92-c3df-46a9-bf30-e60c40c98341", "Marka Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 39, 3, "198135b2-1170-4da4-bdda-ca5d64a2e2e9", "Marka Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 40, 3, "be44e991-674b-4597-9767-ca02895ec559", "Marka Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 41, 3, "6d1a8498-1e47-4d36-bff2-98bde8bb279a", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 42, 3, "190d76f6-7418-48cb-a107-f191d7c48da2", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 43, 3, "2bbddde7-fcf9-4ee5-9e02-1350fb737a80", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 44, 3, "447a4f0a-edc3-4a53-8da5-2208e517753b", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 45, 3, "eb5aff8f-6d55-4f24-99f5-dbe50803fe2a", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 46, 3, "1e7f5536-cda1-45e3-958a-4c91c989fc08", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 47, 3, "ff1a051a-917f-4a64-9d3b-7d1d12394341", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 48, 3, "29af0355-0270-42df-b701-e73ced30ea09", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 49, 3, "3d2f34c8-3569-4377-acc7-6e288887d201", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 50, 3, "0692f39c-4c3d-43f7-8cd5-5ebf1949ca7e", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 51, 3, "bbb0b629-18dd-4d18-852e-c6e9935a2cb9", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 52, 3, "d00a52a6-6c5d-4afa-aed4-43050b25829d", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 53, 3, "26e69be4-a84f-4f2a-b7f4-9702258f9937", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 54, 3, "a0719f32-f775-43a7-a066-a03c8acd6232", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 55, 3, "f7028e21-0428-40be-b3b5-4113010b17bb", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 56, 3, "2330a9d3-0671-476e-829b-c1074fbc8ec8", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 57, 3, "6de638aa-b0ef-4024-b6ef-715751273d93", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOİNTMENTTYPE.CREATE" },
                    { 58, 3, "1d291ba0-4eaa-438e-a1ba-9240fb2925c2", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOİNTMENTTYPE.READ" },
                    { 59, 3, "dae31bb6-b72b-4144-8b83-0691cb764937", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOİNTMENTTYPE.UPDATE" },
                    { 60, 3, "42c92115-d90f-4b83-818c-691912e3a5b3", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOİNTMENTTYPE.DELETE" },
                    { 61, 3, "46dcc118-33c0-493c-9d1f-1b48c47efd88", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 62, 3, "a6523c79-b233-486d-9463-1be5a7ea9145", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 63, 3, "c1c04e9b-eece-4857-9eca-3485c737d523", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 64, 3, "7ed3eb92-5438-48fd-b3cb-3b6448226f46", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 65, 3, "f5575d98-3457-4943-8d87-69edf219a5b4", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 66, 3, "457b35bd-718e-4e62-b7bc-96df559579d9", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 67, 3, "36e14c97-552e-4656-a9aa-844227bc5092", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 68, 3, "4b3333a0-c3d7-4c2a-9de2-687f529e5d37", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 69, 3, "bdc9705c-0d14-43ad-ac24-704b108c250e", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOİNTMENT.CREATE" },
                    { 70, 3, "35ec62b4-9ce3-4855-b7cf-0ecb0f853885", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOİNTMENT.READ" },
                    { 71, 3, "db83d765-edfc-432f-89a9-d64373f799fe", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOİNTMENT.UPDATE" },
                    { 72, 3, "53e068c6-b568-4ffc-9773-846592d6f367", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOİNTMENT.DELETE" },
                    { 73, 2, "fa8a68ce-4ac4-43fd-87e5-155ca959c6b1", "Markalar Programı Görüntüleme", "BrandProgram.Read", "BRANDPROGRAM.READ" },
                    { 74, 2, "6a7e7f3c-440a-40a6-b9fc-3f9a93e892c2", "Randevular Programı Görüntüleme", "AppointmentProgram.Read", "APPOİNTMENTPROGRAM.READ" },
                    { 75, 2, "7bdd8cc9-4c05-4763-b4bd-14582ef2839b", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 76, 2, "744da1f7-beb1-460f-b922-73ab6fee6b8c", "Referanslar Programı Görüntüleme", "CustomerReferenceProgram.Read", "CUSTOMERREFERENCEPROGRAM.READ" },
                    { 77, 2, "70cc2473-a972-46d5-81d0-722489851a6d", "Personeller Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 78, 2, "093742bf-1b7d-4e0a-aaec-670f45ee7a9c", "Bildirimler Programı Görüntüleme", "NotificationProgram.Read", "NOTİFİCATİONPROGRAM.READ" },
                    { 79, 2, "104231f1-2768-414b-881d-46bd0a49a7a8", "Ödemeler Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 80, 2, "a6cad038-85e5-4ff3-b31e-c6fc6e90b9dd", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 81, 2, "f17f1aae-27f2-4f84-8271-039ddbecd0b1", "Roller Programı Görüntüleme", "RoleProgram.Create", "ROLEPROGRAM.CREATE" },
                    { 82, 2, "ad468e16-198a-4102-a28f-a378bf8b834a", "Satışlar Programı Görüntüleme", "SaleProgram.Read", "SALEPROGRAM.READ" },
                    { 83, 2, "2c5ba872-a306-4782-b4a9-8e97b45465dc", "Stok Programı Görüntüleme", "StockProgram.Read", "STOCKPROGRAM.READ" },
                    { 84, 2, "9a5efee7-d80e-4df1-9552-0dfe55772de6", "Kullanıcılar Programı Görüntüleme", "UserProgram.Read", "USERPROGRAM.READ" },
                    { 85, 1, "93dc0bc8-9913-4389-933f-b150b807ef9b", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 86, 1, "9728f666-1b2d-4670-be55-ec927d9c92fa", "MArketing Modülü Görüntüleme", "MarketingModule.Read", "MARKETİNGMODULE.READ" },
                    { 87, 1, "6b9a8c5c-ed8a-4b6f-9474-3184e2078246", "Ajanda Modülü Görüntüleme", "AgendaModule.Read", "AGENDAMODULE.READ" },
                    { 88, 1, "bf5def11-04fe-4a45-a4f9-e64185f51cfc", "Kurumsal Modülü Görüntüleme", "InstitutionalModule.Read", "INSTİTUTİONALMODULE.READ" },
                    { 89, 1, "e1fa388d-ffb8-42bd-af5a-2195ee618ed9", "Müşteri Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 90, 1, "8e90031b-b09f-4305-86c0-a6c21bd882a1", "Finans Modülü Görüntüleme", "FinanceModule.Read", "FİNANCEMODULE.READ" },
                    { 91, 1, "8b59726e-c929-4e48-9c9d-45d3c60dd5ee", "Anasayfa Görüntüleme Yetkisi", "HomeModule.Read", "HOMEMODULE.READ" },
                    { 92, 1, "d6e20d18-461a-484a-be7d-a2c2ef539d44", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMİN" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(3575), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(3575), null, "Satış Aşamasında" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(3579), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(3579), null, "Satıldı" }
                });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(849), "TEST", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(850), null, "Nakit" },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(853), "TEST", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(853), null, "Kart" },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(855), "TEST", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(856), null, "Çek" },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(858), "TEST", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(859), null, "Senet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of MyBlog", 0, "9790076d-001e-419c-8da7-202de0737dea", "adminuser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEFwMmMMK0SpAdwWyg40Ikg7y1bpP8Vg5w0QAbptpxdn5KJVI/9W7kGzTWFrwrUz3mA==", "+905555555555", true, "/userImages/defaultUser.png", "6cf84892-efb7-4079-b895-17bc84101268", false, "adminuser" },
                    { 2, "Editor User of MyBlog", 0, "59b8cded-d7ef-4605-b008-1bb6eaa70f40", "editoruser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEFwNElngSMm1Omb+eTm7iZFosvKEjNyAHSxz8rAe5c4yntdMrVHvNA/pkkMl+diPRg==", "+905555555555", true, "/userImages/defaultUser.png", "ff5362d4-e2cd-4fcf-a66e-48fe6332e7c5", false, "editoruser" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5546), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5544), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5546), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5550), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5551), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5554), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5555), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5558), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5559), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5562), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5563), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5565), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5567), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5569), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5571), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5573), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5575), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5577), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5579), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5581), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(5583), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6982), null, 1, "Personel 1", true, false, "User", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6982), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6985), null, 1, "Ikinci Personel", true, false, "User", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6986), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6989), null, 1, "Ucuncu perosnel", true, false, "User", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(6989), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(2796), "Ürün Alt Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(2797), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2601), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2601), 5, "EmployeeProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2604), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2604), 5, "UserProgram.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2607), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2607), 7, "StockProgram.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2609), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2610), 6, "CustomerReferenceProgram.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2612), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2613), 1, "AppointmentProgram.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2615), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2616), 1, "NotificationProgram.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2618), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2618), 3, "PaymentProgram.Read", null },
                    { 8, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2621), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2621), 2, "CustomerProgram.Read", null },
                    { 9, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2624), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2624), 7, "BrandProgram.Read", null },
                    { 10, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2626), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2627), 3, "SaleProgram.Read", null },
                    { 11, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2629), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2630), 7, "ProductProgram.Read", null },
                    { 12, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2632), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(2632), 5, "RoleProgram.Create", null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 92, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8069), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8070), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8072), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8073), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8075), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8076), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8078), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8079), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8081), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8082), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8084), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8085), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8087), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8087), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8090), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8090), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8093), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8093), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8095), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 859, DateTimeKind.Local).AddTicks(8096), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 4, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1233), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1229), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1230), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 5, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1242), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1240), 1, 2, "hasta2@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1240), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 6, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1246), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1244), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1245), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 4, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 7, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1250), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1248), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1249), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 5, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 8, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1255), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1253), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1254), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 6, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 9, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1259), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1257), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1258), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 7, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 4, 10, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1264), "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1262), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(1262), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductCategoryId", "ProductName", "ProductSubGroupId", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6459), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6460), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, "Siemens Signia Motion 1PX", 1, "A12BO9930HT4" },
                    { 2, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6463), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6464), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, "Jabra Signia", 1, "A12BO9930HT3" },
                    { 3, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6467), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6467), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, "Apple Signia Motion 1PX", 1, "A12BO9930HT2" },
                    { 4, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6470), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(6470), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, "Samsung Signia Motion 1PX", 1, "A12BO9930HT1" }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3381), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3382), "User.Create", null, 2 },
                    { 11, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3385), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3385), "User.Read", null, 2 },
                    { 12, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3387), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3388), "User.Update", null, 2 },
                    { 13, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3390), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3391), "User.Delete", null, 2 },
                    { 14, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3393), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3394), "Role.Read", null, 2 },
                    { 15, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3396), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3397), "Role.Update", null, 2 },
                    { 16, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3399), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3399), "Role.Delete", null, 2 },
                    { 17, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3402), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3402), "Role.Create", null, 2 },
                    { 37, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3404), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3405), "Payment.Create", null, 7 },
                    { 38, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3407), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3408), "Payment.Read", null, 7 },
                    { 39, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3410), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3411), "Payment.Update", null, 7 },
                    { 40, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3413), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3414), "Payment.Delete", null, 7 },
                    { 41, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3416), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3416), "PaymentType.Create", null, 7 },
                    { 42, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3419), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3419), "PaymentType.Read", null, 7 },
                    { 43, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3421), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3422), "PaymentType.Update", null, 7 },
                    { 44, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3424), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3425), "PaymentType.Delete", null, 7 },
                    { 45, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3427), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3428), "Employee.Create", null, 1 },
                    { 46, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3430), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3431), "Employee.Read", null, 1 },
                    { 47, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3433), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3433), "Employee.Update", null, 1 },
                    { 48, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3436), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3436), "Employee.Delete", null, 1 },
                    { 49, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3439), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3439), "EmployeeType.Create", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 50, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3441), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3442), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3444), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3445), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3447), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3448), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3450), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3450), "Customer.Create", null, 8 },
                    { 54, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3453), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3455), "Customer.Read", null, 8 },
                    { 55, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3457), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3459), "Customer.Update", null, 8 },
                    { 56, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3462), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3463), "Customer.Delete", null, 8 },
                    { 57, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3466), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3467), "CustomerType.Create", null, 8 },
                    { 58, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3469), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3470), "CustomerType.Read", null, 8 },
                    { 59, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3472), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3473), "CustomerType.Update", null, 8 },
                    { 60, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3475), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3476), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3478), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3479), "Notification.Create", null, 6 },
                    { 62, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3481), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3481), "Notification.Read", null, 6 },
                    { 63, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3483), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3484), "Notification.Update", null, 6 },
                    { 64, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3486), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3487), "Notification.Delete", null, 6 },
                    { 65, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3489), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3490), "Brand.Create", null, 9 },
                    { 66, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3492), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3492), "Brand.Update", null, 9 },
                    { 67, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3495), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3495), "Brand.Delete", null, 9 },
                    { 68, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3500), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3501), "Brand.Delete", null, 9 },
                    { 69, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3503), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3503), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3506), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3506), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3508), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3509), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3511), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3512), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3514), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3515), "SaleType.Create", null, 10 },
                    { 74, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3517), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3518), "SaleType.Read", null, 10 },
                    { 75, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3520), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3520), "SaleType.Update", null, 10 },
                    { 76, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3522), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3523), "SaleType.Delete", null, 10 },
                    { 77, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3556), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3557), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3559), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3560), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3562), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3562), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3565), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3565), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3567), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3568), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3570), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3571), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3573), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3574), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3576), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3576), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3497), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3498), "Brand.Read", null, 9 },
                    { 89, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3579), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3579), "AppointmentType.Create", null, 5 },
                    { 90, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3581), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3582), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3584), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3585), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3587), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3587), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3590), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3590), "Sale.Create", null, 10 },
                    { 94, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3593), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3593), "Sale.Read", null, 10 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 95, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3595), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3596), "Sale.Update", null, 10 },
                    { 96, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3598), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3599), "Sale.Delete", null, 10 },
                    { 97, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3601), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3601), "Product.Create", null, 11 },
                    { 98, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3604), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3604), "Product.Read", null, 1 },
                    { 99, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3606), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3607), "Product.Update", null, 11 },
                    { 100, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3609), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3610), "Product.Delete", null, 11 },
                    { 101, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3612), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3613), "Appointment.Create", null, 5 },
                    { 102, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3615), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3615), "Appointment.Read", null, 5 },
                    { 103, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3618), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3618), "Appointment.Update", null, 5 },
                    { 104, null, null, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3620), true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(3621), "Appointment.Delete", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1086), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1087), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 2, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1092), 2, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama", 1, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1092), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 3, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1095), 3, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama3", 1, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 861, DateTimeKind.Local).AddTicks(1096), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(510), 1, "TEST", null, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(511), null, "Reminder", new DateTime(2023, 4, 3, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(513), "Title", 1 },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(519), 2, "Doğum günü yaklaşmakta.", null, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(520), null, "Reminder", new DateTime(2023, 4, 2, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(521), "Doğum Günü!", 2 },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(523), 3, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(524), null, "Reminder", new DateTime(2023, 4, 1, 7, 24, 53, 866, DateTimeKind.Local).AddTicks(525), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5538), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5539), null, 1 },
                    { 2, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5544), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5544), null, 1 },
                    { 3, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5547), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5547), null, 1 },
                    { 4, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5550), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5550), null, 1 },
                    { 5, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5553), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5554), null, 1 },
                    { 6, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5556), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5557), null, 1 },
                    { 7, 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5559), 1, "TEST", 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 865, DateTimeKind.Local).AddTicks(5560), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[,]
                {
                    { 1, 500, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(17), 1, 1, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(18), null, 1, 1, 1 },
                    { 2, 200, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(22), 1, 2, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(22), null, 2, 1, 1 },
                    { 3, 500, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(25), 1, 2, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 867, DateTimeKind.Local).AddTicks(26), null, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7843), 0, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7844), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 },
                    { 2, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7875), 0, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7876), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 2, 20 },
                    { 3, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7878), 0, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7879), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 3, 20 },
                    { 4, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7881), 0, true, false, "InitialCreate", new DateTime(2023, 3, 31, 7, 24, 53, 860, DateTimeKind.Local).AddTicks(7882), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 4, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentTypeId",
                table: "Appointments",
                column: "AppointmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EmployeeId",
                table: "Appointments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerReferanceId",
                table: "Customers",
                column: "CustomerReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeId",
                table: "Customers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CustomerId",
                table: "Notifications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_EmployeeId",
                table: "Notifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployeeId",
                table: "Payments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeId",
                table: "Payments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSubGroupId",
                table: "Product",
                column: "ProductSubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubGroups_ProductGroupId",
                table: "ProductSubGroups",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_ModuleId",
                table: "Programs",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SaleStatusId",
                table: "Sales",
                column: "SaleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SaleTypeId",
                table: "Sales",
                column: "SaleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubPrograms_ProgramId",
                table: "SubPrograms",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChangeLogs");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "SubPrograms");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "AppointmentTypes");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SaleStatuses");

            migrationBuilder.DropTable(
                name: "SaleTypes");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CustomerReferances");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductSubGroups");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "ProductGroups");
        }
    }
}
