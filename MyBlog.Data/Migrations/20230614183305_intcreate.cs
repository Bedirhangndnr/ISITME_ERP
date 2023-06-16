using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class intcreate : Migration
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
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsDaily = table.Column<bool>(type: "bit", nullable: false),
                    IsIncome = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Expenses", x => x.Id);
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
                name: "AssociatedInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AssociatedInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociatedInstitutions_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
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
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: true, defaultValue: -1),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPaid = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AssociatedInstitutionsId = table.Column<int>(type: "int", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: true),
                    AssociatedInstitutionId = table.Column<int>(type: "int", nullable: true),
                    CustomerId1 = table.Column<int>(type: "int", nullable: true),
                    EmployeeId1 = table.Column<int>(type: "int", nullable: true),
                    PaymentTypeId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Payments_AssociatedInstitutions_AssociatedInstitutionId",
                        column: x => x.AssociatedInstitutionId,
                        principalTable: "AssociatedInstitutions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_AssociatedInstitutions_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "AssociatedInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Employees_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_AssociatedInstitutionsId",
                        column: x => x.AssociatedInstitutionsId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypeId1",
                        column: x => x.PaymentTypeId1,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AmountOfSgk = table.Column<int>(type: "int", nullable: false),
                    IsInvoiceDue = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(7072), "Test", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(7073), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(7076), "Test", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(7077), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(6289), "TEST", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(6290), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2935), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2936), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2938), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2939), "C++", "C++ Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2941), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2942), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2944), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2945), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2947), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2948), "Java", "Java Blog Kategorisi" },
                    { 6, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2950), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2951), "Python", "Python Blog Kategorisi" },
                    { 7, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2953), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2954), "Php", "Php Blog Kategorisi" },
                    { 8, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2956), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2957), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2959), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2960), "Swift", "Swift Blog Kategorisi" },
                    { 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2962), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(2963), "Ruby", "Ruby Blog Kategorisi" }
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
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(9191), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(9191), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(9195), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(9196), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(43), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(44), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(46), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(47), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 2" },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(49), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(50), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4724), "Description", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4725), "Not", "Title" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4727), "Description", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4728), "Not", "Title" },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4729), "Description", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4729), "Not", "Title" },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4732), "Description", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4733), "Not", "Title" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CreatedByName", "CreatedDate", "IsActive", "IsDaily", "IsDeleted", "IsIncome", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2122), true, true, false, true, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2123), "TEST" },
                    { 2, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2125), true, true, false, true, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2126), "TEST" },
                    { 3, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2128), true, true, false, true, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2129), "TEST" },
                    { 4, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2131), true, false, false, true, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2132), "TEST" },
                    { 5, 22, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2134), true, false, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2135), "TEST" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(104), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(105), "AgendaModule.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(108), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(108), "CustomerModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(111), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(111), "FinanceModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(113), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(114), "HomeModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(116), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(117), "InstitutionalModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(119), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(120), "MarketingModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(122), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(123), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3293), "Point of Sale", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3294), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3295), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3296), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3297), "Point of Sale", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3297), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(984), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(985), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(988), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(989), "Product Kategori 2", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(713), "Ürün Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(714), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, 3, "04e6ffd5-6944-47bd-bfa2-9f4dcb3b8ab5", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 2, 3, "98ea06b3-1024-471a-af86-375ba3891671", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 3, 3, "17596ffa-d615-4f4e-af2e-1b4cf1e3328b", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 4, 3, "17ea844e-30e7-43a2-92cb-9fb5b8ff282c", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 5, 3, "35bba43a-0308-4d2d-bb50-2495f38cef54", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 6, 3, "c29d7651-28cf-440d-a197-789720db4f36", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 7, 3, "c64c06aa-fcf4-4bc8-ad3c-e0520fb2a4c0", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 8, 3, "445a1925-7f5d-42b0-a750-f6341134f9dd", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 9, 3, "0707aa8a-efa5-40dd-8612-2a9ddbe7e69b", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 10, 3, "f175dd48-a78b-48ce-b473-2d95717ad592", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 11, 3, "8ac89399-3e9e-4e56-9b36-9b189f5df2ea", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 12, 3, "70c4b69b-0fcd-49ae-8638-a8391be683e1", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 13, 3, "2160731d-f83c-4744-a04f-4b2f3e23b610", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 14, 3, "836713db-a6d0-4588-b031-c5795dde1e5d", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 15, 3, "92a51c3e-69ed-4c6b-8507-16fccc2d5e94", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 16, 3, "ede6a4de-77db-43d5-a1e9-1f823640ffe4", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 17, 3, "30fc9bd9-68c8-461d-9c5a-6aeebeb47b64", "Çalışan Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 18, 3, "2c6a12e5-ab10-4b9c-acb8-95f2f0261b90", "Çalışan Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 19, 3, "1b252a98-ac62-4862-9d1c-7d6f65a85c3f", "Çalışan Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 20, 3, "77da12e4-6b8e-46c3-bfeb-c537aa2781ad", "Çalışan Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 21, 3, "4ab72938-bea3-457f-8e2c-7d95463cd221", "Çalışan Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 22, 3, "0932e788-da92-4be7-aa95-405b222a8fbc", "Çalışan Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 23, 3, "b7302f61-f952-4902-b716-46c91fa40ee4", "Çalışan Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 24, 3, "63e958c8-9813-4db7-8765-cf31a51c37c1", "Çalışan Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 25, 3, "c1f454cd-0d55-414d-a06d-7069660e7d67", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 26, 3, "c2a2c887-185a-44fe-ad43-7c6f26ad9c12", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 27, 3, "777f6d38-5cf6-4cbf-b749-4ec690d9bac6", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 28, 3, "f781c50c-cc72-47d8-b981-e3dc8b60216e", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 29, 3, "3edf85b9-c4b2-4e47-bb9f-3a1067231ec1", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 30, 3, "53b2b696-baf1-468a-afcd-d08beaf3ae69", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 31, 3, "34f191b6-e725-4f9e-b5b1-3d750efbc83d", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 32, 3, "255369ae-0d09-431e-8bf3-ecfe7c06358c", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 33, 3, "7a250a29-43e2-4aab-a06d-15f8c3d94488", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTİFİCATİON.CREATE" },
                    { 34, 3, "b1673358-36c8-46a8-8d06-e410bf718eb9", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTİFİCATİON.READ" },
                    { 35, 3, "a8ac98db-72f4-4d01-aa00-64adbae11b39", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTİFİCATİON.UPDATE" },
                    { 36, 3, "3a607632-d904-4f3f-a546-05fd51e63485", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTİFİCATİON.DELETE" },
                    { 37, 3, "619768a4-0bb7-448f-9362-ca61a6e60061", "Marka Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 38, 3, "0de41fb6-da7b-4c55-a6d6-53d1b82633a0", "Marka Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 39, 3, "c4cf58a1-e55d-4117-905d-8b4442b56690", "Marka Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 40, 3, "dfbf7db0-47cb-4228-af77-c0b08e66f775", "Marka Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 41, 3, "07898486-8ba8-49c6-b51f-1ca18408785e", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 42, 3, "eae58d21-4037-478a-bf48-4092074ccb04", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 43, 3, "1c8e6184-246b-40cf-8b78-734d19a2df3d", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 44, 3, "d04376db-0777-4533-a2dd-c9e1ce20df5c", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 45, 3, "48666629-5007-4e30-8c8f-2c169a4031b7", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 46, 3, "38aac2cc-6232-495a-a187-f30737e00c2a", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 47, 3, "a82b5443-f225-4c58-accb-b62641e91cae", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 48, 3, "9e7b9f42-2ac2-483e-9ff0-eaf40029c1e4", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 49, 3, "6f03d4ad-6ae5-4f1a-a8a9-d3156e25f4e5", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 50, 3, "bef28c67-4865-4199-ad08-100fd30632c9", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 51, 3, "5891a83e-2a4a-4f50-92fd-b986de44eaf3", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 52, 3, "af6570d7-bcca-4099-acd3-e6eb3774d701", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 53, 3, "35e8630e-04eb-40f8-ba11-55cf118687f3", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 54, 3, "57f547af-662d-4505-b121-f626cf3c10c8", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 55, 3, "01b06186-57ae-4871-9923-2700502d3912", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 56, 3, "3196112c-c613-4745-94b2-85cfd3d6c847", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 57, 3, "e9ccedcc-0b90-4c3d-8ea7-1530e723c0d4", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOİNTMENTTYPE.CREATE" },
                    { 58, 3, "9408bac9-25ae-4772-94c2-686a00882ca4", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOİNTMENTTYPE.READ" },
                    { 59, 3, "6fdeaf96-ac25-4058-92d8-b94ace87fbce", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOİNTMENTTYPE.UPDATE" },
                    { 60, 3, "b7dff5bb-16f7-46f4-abcc-7c90f7e4f442", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOİNTMENTTYPE.DELETE" },
                    { 61, 3, "a449fe30-4ecf-4e36-b689-6681570f8ad6", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 62, 3, "d62ac05b-b98b-4f1e-9ac8-500621e221ee", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 63, 3, "5d3d1def-8d9e-44c4-9242-54991baee011", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 64, 3, "c91d7a4c-02ea-4f23-a89a-9ad64359747e", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 65, 3, "78569e82-681d-46ff-9cd1-f94513880915", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 66, 3, "2fde359a-f73f-4aed-9074-a1d4651701d9", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 67, 3, "8713a440-80bb-4161-aa1a-7e106529bd1c", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 68, 3, "2f77598a-9501-400f-b0f1-b1416514175a", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 69, 3, "c1ba2cf0-4b02-4b28-a5d9-5f37ebd71e10", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOİNTMENT.CREATE" },
                    { 70, 3, "ea4e423f-4583-438d-9fdf-a798e848eab5", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOİNTMENT.READ" },
                    { 71, 3, "60c96008-82cf-4250-a797-15c71fba970f", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOİNTMENT.UPDATE" },
                    { 72, 3, "b2669f16-797e-4654-9c83-43b35c774f20", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOİNTMENT.DELETE" },
                    { 73, 2, "d032bea8-b761-46e4-8738-efdc3f88736d", "Markalar Programı Görüntüleme", "BrandProgram.Read", "BRANDPROGRAM.READ" },
                    { 74, 2, "7ef7f21a-0ba1-40a6-bcbb-7de970912af2", "Randevular Programı Görüntüleme", "AppointmentProgram.Read", "APPOİNTMENTPROGRAM.READ" },
                    { 75, 2, "9975ce64-57cd-429f-96ac-8b0bf471407d", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 76, 2, "5c182c8d-2b48-4a33-8d02-36b9f9df7a1a", "Referanslar Programı Görüntüleme", "CustomerReferenceProgram.Read", "CUSTOMERREFERENCEPROGRAM.READ" },
                    { 77, 2, "172ae70e-bf7a-45cc-93f9-1d6f9c626b25", "Personeller Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 78, 2, "46e6baef-0c56-48df-8235-d086cca23284", "Bildirimler Programı Görüntüleme", "NotificationProgram.Read", "NOTİFİCATİONPROGRAM.READ" },
                    { 79, 2, "b1b6df20-8e97-422c-867d-4d72741265d9", "Ödemeler Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 80, 2, "040efa43-df90-4384-a0d7-90552025848d", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 81, 2, "b444b250-b2bc-4d5f-95ad-59bf2bec574d", "Roller Programı Görüntüleme", "RoleProgram.Create", "ROLEPROGRAM.CREATE" },
                    { 82, 2, "e7ea9e81-0046-4484-ad90-0a6e2895d264", "Satışlar Programı Görüntüleme", "SaleProgram.Read", "SALEPROGRAM.READ" },
                    { 83, 2, "cae4f84d-10fb-438a-893e-788068ec369c", "Stok Programı Görüntüleme", "StockProgram.Read", "STOCKPROGRAM.READ" },
                    { 84, 2, "970c9b6b-db47-480b-85ac-57ea1e09ef3d", "Kullanıcılar Programı Görüntüleme", "UserProgram.Read", "USERPROGRAM.READ" },
                    { 85, 1, "3d2b30e5-08c0-44db-b71c-52c8475942e9", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 86, 1, "f8d2d8a1-2c61-4206-b75e-251f60e4b77d", "MArketing Modülü Görüntüleme", "MarketingModule.Read", "MARKETİNGMODULE.READ" },
                    { 87, 1, "fb9e2bd5-34ac-439f-935b-46cfecf2be1d", "Ajanda Modülü Görüntüleme", "AgendaModule.Read", "AGENDAMODULE.READ" },
                    { 88, 1, "b5e8d09d-7137-45a4-b0a8-b2f8f09cddce", "Kurumsal Modülü Görüntüleme", "InstitutionalModule.Read", "INSTİTUTİONALMODULE.READ" },
                    { 89, 1, "17e32d5d-82ed-4185-ada5-eaa695ea36a7", "Müşteri Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 90, 1, "98c4ebee-a76e-4496-bb61-616a470c98d5", "Finans Modülü Görüntüleme", "FinanceModule.Read", "FİNANCEMODULE.READ" },
                    { 91, 1, "9178d122-5c29-4668-bf04-59dbe7f974c1", "Anasayfa Görüntüleme Yetkisi", "HomeModule.Read", "HOMEMODULE.READ" },
                    { 92, 1, "27c27b0f-e365-492a-a683-0167eba5a63e", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMİN" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(3062), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(3063), null, "Satış Aşamasında" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(3066), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(3067), null, "Satıldı" }
                });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9065), "TEST", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9065), null, "Nakit" },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9068), "TEST", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9069), null, "Kart" },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9071), "TEST", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9072), null, "Çek" },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9074), "TEST", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(9075), null, "Senet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of MyBlog", 0, "103d7dc2-cd13-4a67-81c2-bd372a4f7fe4", "adminuser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEKj2CY9JJCylVXgcZymjF5eZpBDQLubCHmk8DqbNNX99XqCjelchffL4tAczT3pa+A==", "+905555555555", true, "/userImages/defaultUser.png", "b2be25db-747e-4831-8d56-2203232f34dc", false, "adminuser" },
                    { 2, "Editor User of MyBlog", 0, "c30bab9a-19cd-4425-8ade-5caf67c94d2a", "editoruser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEN81WsfzYosanqoOmWbqCVf0yoWg2uTSVv/McegkKyQqI2JmYVPgiLqwx5Bn5Iz/ZQ==", "+905555555555", true, "/userImages/defaultUser.png", "2a0505ef-37b0-4013-a230-f069c048578f", false, "editoruser" },
                    { 3, "Editor User 2 of MyBlog", 0, "882b091d-439a-462b-8990-e7d2e9df95ae", "editoruser2@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER2@GMAIL.COM", "EDITORUSER2", null, "+905555555555", true, "/userImages/defaultUser.png", "83b0cadb-f091-4436-bbf8-1f272b855525", false, "editoruser2" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1836), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1834), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1837), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1840), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1841), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1844), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1845), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1848), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1850), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1853), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1852), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1854), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1856), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1858), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1860), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1862), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1865), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1867), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1870), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1871), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1874), new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1874), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(1875), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2005), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2005), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2007), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2008), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2009), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2009), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2010), "Akbank Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2010), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2011), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2012), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2013), "Sivasot Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2013), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2014), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(2015), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4565), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4566), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4569), null, 1, "Ikinci Personel", true, false, "User", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4569), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4572), null, 1, "Ucuncu perosnel", true, false, "User", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(4573), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(2177), "Ürün Alt Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(2178), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(862), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(863), 5, "EmployeeProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(866), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(866), 5, "UserProgram.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(869), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(869), 7, "StockProgram.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(872), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(872), 6, "CustomerReferenceProgram.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(874), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(875), 1, "AppointmentProgram.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(877), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(878), 1, "NotificationProgram.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(880), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(881), 3, "PaymentProgram.Read", null },
                    { 8, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(883), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(884), 2, "CustomerProgram.Read", null },
                    { 9, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(886), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(887), 7, "BrandProgram.Read", null },
                    { 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(889), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(890), 3, "SaleProgram.Read", null },
                    { 11, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(892), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(893), 7, "ProductProgram.Read", null },
                    { 12, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(895), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(895), 5, "RoleProgram.Create", null }
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
                    { 1, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4709), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4710), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4713), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4713), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4716), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4716), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4719), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4719), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4722), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4723), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4725), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4726), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4728), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4729), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4731), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4732), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4734), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4735), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4737), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(4738), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 18, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8140), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8135), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8136), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 19, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8150), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8148), 1, 2, "hasta2@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8149), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 20, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8155), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8153), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8153), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 4, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 21, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8160), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8157), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8158), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 5, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 22, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8164), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8162), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8163), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 6, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 23, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8169), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8167), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8167), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 7, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 6, 24, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8173), "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8171), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 308, DateTimeKind.Local).AddTicks(8172), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3701), true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3702), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" },
                    { 2, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3706), true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3706), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Jabra Signia", 1, 10, "A12BO9930HT3" },
                    { 3, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3709), true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3710), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Apple Signia Motion 1PX", 1, 10, "A12BO9930HT2" },
                    { 4, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3712), true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(3713), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Samsung Signia Motion 1PX", 1, 10, "A12BO9930HT1" }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1625), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1626), "User.Create", null, 2 },
                    { 11, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1629), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1629), "User.Read", null, 2 },
                    { 12, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1631), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1632), "User.Update", null, 2 },
                    { 13, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1634), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1635), "User.Delete", null, 2 },
                    { 14, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1637), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1638), "Role.Read", null, 2 },
                    { 15, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1640), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1641), "Role.Update", null, 2 },
                    { 16, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1643), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1644), "Role.Delete", null, 2 },
                    { 17, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1646), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1647), "Role.Create", null, 2 },
                    { 37, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1649), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1650), "Payment.Create", null, 7 },
                    { 38, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1652), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1653), "Payment.Read", null, 7 },
                    { 39, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1655), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1656), "Payment.Update", null, 7 },
                    { 40, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1658), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1658), "Payment.Delete", null, 7 },
                    { 41, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1661), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1661), "PaymentType.Create", null, 7 },
                    { 42, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1663), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1664), "PaymentType.Read", null, 7 },
                    { 43, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1666), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1667), "PaymentType.Update", null, 7 },
                    { 44, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1669), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1670), "PaymentType.Delete", null, 7 },
                    { 45, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1672), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1673), "Employee.Create", null, 1 },
                    { 46, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1675), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1676), "Employee.Read", null, 1 },
                    { 47, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1678), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1679), "Employee.Update", null, 1 },
                    { 48, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1681), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1682), "Employee.Delete", null, 1 },
                    { 49, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1684), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1684), "EmployeeType.Create", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 50, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1687), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1687), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1689), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1690), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1692), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1693), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1695), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1696), "Customer.Create", null, 8 },
                    { 54, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1698), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1699), "Customer.Read", null, 8 },
                    { 55, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1701), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1702), "Customer.Update", null, 8 },
                    { 56, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1704), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1705), "Customer.Delete", null, 8 },
                    { 57, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1707), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1708), "CustomerType.Create", null, 8 },
                    { 58, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1710), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1710), "CustomerType.Read", null, 8 },
                    { 59, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1713), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1713), "CustomerType.Update", null, 8 },
                    { 60, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1716), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1716), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1718), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1719), "Notification.Create", null, 6 },
                    { 62, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1721), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1722), "Notification.Read", null, 6 },
                    { 63, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1724), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1725), "Notification.Update", null, 6 },
                    { 64, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1727), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1728), "Notification.Delete", null, 6 },
                    { 65, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1730), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1731), "Brand.Create", null, 9 },
                    { 66, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1733), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1733), "Brand.Update", null, 9 },
                    { 67, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1735), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1736), "Brand.Delete", null, 9 },
                    { 68, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1741), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1742), "Brand.Delete", null, 9 },
                    { 69, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1744), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1745), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1747), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1748), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1750), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1750), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1753), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1753), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1756), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1756), "SaleType.Create", null, 10 },
                    { 74, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1759), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1759), "SaleType.Read", null, 10 },
                    { 75, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1762), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1762), "SaleType.Update", null, 10 },
                    { 76, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1765), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1765), "SaleType.Delete", null, 10 },
                    { 77, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1767), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1768), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1770), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1771), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1773), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1774), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1776), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1777), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1779), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1780), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1782), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1782), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1785), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1785), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1787), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1788), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1738), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1739), "Brand.Read", null, 9 },
                    { 89, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1790), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1791), "AppointmentType.Create", null, 5 },
                    { 90, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1793), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1794), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1796), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1797), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1799), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1800), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1802), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1802), "Sale.Create", null, 10 },
                    { 94, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1805), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1806), "Sale.Read", null, 10 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 95, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1808), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1809), "Sale.Update", null, 10 },
                    { 96, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1836), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1836), "Sale.Delete", null, 10 },
                    { 97, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1839), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1839), "Product.Create", null, 11 },
                    { 98, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1841), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1842), "Product.Read", null, 1 },
                    { 99, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1844), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1845), "Product.Update", null, 11 },
                    { 100, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1847), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1848), "Product.Delete", null, 11 },
                    { 101, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1850), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1851), "Appointment.Create", null, 5 },
                    { 102, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1853), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1854), "Appointment.Read", null, 5 },
                    { 103, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1856), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1856), "Appointment.Update", null, 5 },
                    { 104, null, null, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1859), true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 320, DateTimeKind.Local).AddTicks(1859), "Appointment.Delete", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8577), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8578), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 2, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8583), 2, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama", 1, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8583), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 3, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8586), 3, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama3", 1, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(8587), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9788), 1, "TEST", null, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9789), null, "Reminder", new DateTime(2023, 6, 17, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9792), "Title", 1 },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9798), 2, "Doğum günü yaklaşmakta.", null, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9798), null, "Reminder", new DateTime(2023, 6, 16, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9799), "Doğum Günü!", 2 },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9802), 3, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9802), null, "Reminder", new DateTime(2023, 6, 15, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(9804), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[,]
                {
                    { 1, 1, null, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3051), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3052), null, 1, null },
                    { 2, 1, null, 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3057), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3057), null, 2, null },
                    { 3, 1, null, 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3060), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3061), null, 3, null },
                    { 4, 1, null, 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3063), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3064), null, 4, null },
                    { 5, 1, null, 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3066), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3067), null, 5, null },
                    { 6, 1, null, 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3070), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3070), null, 6, null },
                    { 7, 1, null, 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3073), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 318, DateTimeKind.Local).AddTicks(3074), null, 7, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[,]
                {
                    { 1, 500, 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8189), 1, 1, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8190), null, 1, 1, 1 },
                    { 2, 200, 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8195), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8195), null, 2, 1, 1 },
                    { 3, 500, 10, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8198), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 319, DateTimeKind.Local).AddTicks(8199), null, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5187), 0, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5188), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 },
                    { 2, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5191), 0, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5191), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 2, 20 },
                    { 3, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5194), 0, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5194), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 3, 20 },
                    { 4, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5197), 0, true, false, "InitialCreate", new DateTime(2023, 6, 14, 21, 33, 4, 309, DateTimeKind.Local).AddTicks(5197), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 4, 20 }
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
                name: "IX_AssociatedInstitutions_PaymentTypeId",
                table: "AssociatedInstitutions",
                column: "PaymentTypeId");

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
                name: "IX_Payments_AssociatedInstitutionId",
                table: "Payments",
                column: "AssociatedInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AssociatedInstitutionsId",
                table: "Payments",
                column: "AssociatedInstitutionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId1",
                table: "Payments",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployeeId",
                table: "Payments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployeeId1",
                table: "Payments",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeId",
                table: "Payments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeId1",
                table: "Payments",
                column: "PaymentTypeId1");

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
                name: "Expenses");

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
                name: "AssociatedInstitutions");

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
                name: "PaymentTypes");

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
