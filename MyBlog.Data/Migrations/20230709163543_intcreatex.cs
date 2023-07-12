using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class intcreatex : Migration
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
                name: "OutPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebtAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaidPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_OutPayments", x => x.Id);
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
                name: "OutPaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OutPaymentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_OutPaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutPaymentDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutPaymentDetails_OutPayments_OutPaymentId",
                        column: x => x.OutPaymentId,
                        principalTable: "OutPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AssociatedInstitutionsId = table.Column<int>(type: "int", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Payments_AssociatedInstitutions_AssociatedInstitutionsId",
                        column: x => x.AssociatedInstitutionsId,
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
                        name: "FK_Payments_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
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
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6350), "Test", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6351), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6353), "Test", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6354), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(5563), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(5564), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9716), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9716), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9719), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9720), "C++", "C++ Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9722), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9723), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9725), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9726), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9728), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9729), "Java", "Java Blog Kategorisi" },
                    { 6, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9731), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9732), "Python", "Python Blog Kategorisi" },
                    { 7, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9734), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9735), "Php", "Php Blog Kategorisi" },
                    { 8, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9737), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9738), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9740), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9741), "Swift", "Swift Blog Kategorisi" },
                    { 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9743), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9744), "Ruby", "Ruby Blog Kategorisi" }
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
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4072), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4073), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4077), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4078), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4903), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4903), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4906), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4907), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 2" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4909), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4910), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4778), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4779), "Not", "Title" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4781), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4782), "Not", "Title" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4782), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4783), "Not", "Title" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4786), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4786), "Not", "Title" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CreatedByName", "CreatedDate", "IsActive", "IsDaily", "IsDeleted", "IsIncome", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 100, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1555), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1556), "TEST" },
                    { 2, 122, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1559), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1559), "TEST" },
                    { 3, 21, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1562), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1563), "TEST" },
                    { 4, 341, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1565), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1566), "TEST" },
                    { 5, 422, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1568), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1569), "TEST" },
                    { 6, 122, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1571), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1572), "TEST" },
                    { 7, 322, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1574), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1575), "TEST" },
                    { 8, 422, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1577), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1578), "TEST" },
                    { 9, 522, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1580), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1581), "TEST" },
                    { 10, 122, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1583), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1584), "TEST" },
                    { 11, 232, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1587), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1587), "TEST" },
                    { 12, 122, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1590), true, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1591), "TEST" },
                    { 13, 222, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1593), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1594), "TEST" },
                    { 14, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1596), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1597), "TEST" },
                    { 15, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1599), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1600), "TEST" },
                    { 16, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1602), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1603), "TEST" },
                    { 17, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1605), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1606), "TEST" },
                    { 18, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1608), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1609), "TEST" },
                    { 19, 22, "InitialCreate", new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1612), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1612), "TEST" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9518), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9519), "AgendaProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9521), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9522), "CustomerModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9524), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9525), "RoleModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9527), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9528), "RoleModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9530), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9531), "RoleModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9533), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9533), "RoleModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9535), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9536), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[,]
                {
                    { 1, 0m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1493), 15000m, "TEST desc 1 ", new DateTime(2023, 7, 13, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1498), true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1494), null, "Ödemenin Yapılacağı yer" },
                    { 2, 0m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1506), 10000m, "TEST desc 1 ", new DateTime(2023, 7, 13, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1508), true, false, true, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1507), null, "Ödemenin Yapılacağı yer" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3375), "Point of Sale", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3376), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3378), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3378), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3379), "Point of Sale", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3380), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5878), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5879), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5883), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5884), "Product Kategori 2", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(81), "Ürün Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(82), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "f69a630a-d09f-401f-b301-825412467ae5", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 3, "e95b0b11-2811-4eb9-8fc3-0ac6ecf9b9be", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 3, 3, "c4626207-65d8-4c88-83b4-18b6ce964860", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 4, 3, "e95db7a7-d5af-426a-aa23-dae2c0aa3d76", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 5, 3, "ceaf07cd-17cb-4f29-a4ab-481a55fb25d9", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 6, 3, "8475a65c-f7da-4071-92fc-45f359411350", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 7, 3, "3d4000bd-3d21-4a7e-9cbc-84d3874e970e", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 8, 3, "62d42071-d39c-48a5-bc28-aaee6f208c4b", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 9, 3, "203e8c5f-e3d0-4679-8b84-3606893c33ed", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 10, 3, "314fa597-a125-44b8-83e1-de4a1f02051d", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 11, 3, "d3a68733-edd4-4d50-8312-7c949ee67db9", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 12, 3, "e8a2c68a-a5c8-44b2-87f0-105a30991de1", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 13, 3, "11677a66-695a-4f51-b7a9-67d1d2f1cd11", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 14, 3, "18488d26-7aea-4503-927f-2f0a94f8328f", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 15, 3, "87da20d0-0e11-49e4-a8d8-452d7ca1a1fd", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 16, 3, "d65ef4c8-567e-481c-83bf-14cf0efd1ef4", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 17, 3, "d5b469ea-e073-496d-8bbc-5e4510b6a97f", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 18, 3, "3ad1c363-db10-4281-8bae-c87ca6573076", "Çalışan Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 19, 3, "e7541d52-e885-4195-ab1d-da02037a4ce6", "Çalışan Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 20, 3, "ce78b735-ec48-4bef-bf1b-135c6d6ef438", "Çalışan Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 21, 3, "d45cee2f-a721-4a3c-a49e-237570ce3da5", "Çalışan Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 22, 3, "5bad4a3a-23a9-4622-80ef-6931f3a92ebd", "Çalışan Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 23, 3, "9507b36a-8959-44d1-8485-bb172e0da4a5", "Çalışan Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 24, 3, "3c8967a0-e83b-4961-8b07-061e2cd4b633", "Çalışan Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 25, 3, "514b1bd2-1193-4a80-aaef-e64c416523dc", "Çalışan Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 26, 3, "56e56b4f-fd10-4bb6-a6fc-7ec26516d48b", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 27, 3, "2fbbdb1f-792b-480a-a1d2-2c18dd52529b", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 28, 3, "b58e395c-7a9a-4265-bb10-f5860693e5b3", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 29, 3, "46d87dc1-5279-4693-a6bc-b3952b11a621", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 30, 3, "9f2f4b15-ae91-4bd8-bb72-3d349504a99d", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 31, 3, "77f057b7-be61-46cc-9084-8106ea17ceda", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 32, 3, "15ca6a6e-44a0-4dbe-8f93-0c7c75f07d58", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 33, 3, "1d954a1f-a7d4-4af2-b141-f367f7cf4c06", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 34, 3, "0bb2a5d8-757b-4a86-b7d5-8ce0cb60ec51", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 35, 3, "d725f202-e66e-4eb7-a18f-b3f85b12aeb4", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 36, 3, "ea8b9ff8-1b41-45dc-9d43-0cf3d34cca6c", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 37, 3, "04adba40-115f-45d8-ad18-4224a32640f1", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 38, 3, "86847b11-1541-4d33-a6d7-7b37a5a4ab3c", "Marka Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 39, 3, "4c6d6c31-c5a9-492b-92ef-638ca1e753c7", "Marka Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 40, 3, "bc676762-f301-4d34-9be7-21bd78971858", "Marka Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 41, 3, "477cd233-e7f1-418f-a37f-0ef0e267fe92", "Marka Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 42, 3, "5534cfb2-6fc7-4437-93a2-d801b1aa3623", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 43, 3, "399b70f4-9194-42ea-a7fa-552f6d507121", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 44, 3, "d8b425ec-27c7-41eb-98a8-2dfc6c885b61", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 45, 3, "45644134-6d95-430d-af35-1af2216acdb6", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 46, 3, "f754f39f-fab4-4ba8-82f2-454c5886d430", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 47, 3, "f91194f9-307d-40f0-96f4-d06508b65582", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 48, 3, "0fbce8d0-1464-4180-8e63-a1e323721d7b", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 49, 3, "01a10d3c-bb16-4185-9337-5239ddec40cc", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 50, 3, "0e42cdc8-a097-4102-91ed-5557cf717404", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 51, 3, "d4d6ed3a-f7e2-4e20-bdc1-d5241c110082", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 52, 3, "fa5a2c4f-791e-4971-aec3-855829efc7ed", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 53, 3, "74465ef8-cac1-4393-a0ea-519eaa6e5b9c", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 54, 3, "047d4320-3697-4199-a6b6-1dbfd177478f", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 55, 3, "38614dd8-e4b8-44c8-8773-3dfa6eaa9b22", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 56, 3, "bbf22a71-2c73-4bfe-803a-5d39ab093ff4", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 57, 3, "b2ed7eb6-23f0-44c9-af19-e0f044506801", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 58, 3, "87e8e518-0429-41d9-af15-87e26ab03c6f", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 59, 3, "966a84e7-0737-4b2d-93db-5a7196e11d78", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 60, 3, "08084969-07a7-4314-967f-1d57a463774e", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" },
                    { 61, 3, "a9aa96d6-385a-4e50-9d9e-fd80785dc9ac", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 62, 3, "b80dcac5-14bf-4be8-8f1b-5d599a3743d1", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 63, 3, "88d5d815-0b5d-4ca3-a759-74f44dedec28", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 64, 3, "d83f11b6-0215-42d0-b017-767b00a468af", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 65, 3, "d62e9650-dfae-47f6-9bc9-5ac670310524", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 66, 3, "b7725ec2-1589-48c7-a021-bfcda235ecf4", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 67, 3, "e6f36f21-009b-4fb5-9968-806c593ad3ae", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 68, 3, "56041f33-130b-446b-ae5a-2daba7d0f195", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 69, 3, "84fe2c2f-ab81-4155-acce-cbe52a274b98", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 70, 3, "d6428df9-82b3-4d0a-bc44-24f0161458b8", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 71, 3, "77e91438-580a-4731-9828-ccd22c3b8f73", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 72, 3, "b242cb56-1759-4c6b-a9c7-ce0039de571d", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 73, 3, "b43f54d1-cb0e-4e47-9c17-204f044f39f3", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 74, 3, "103ea423-79e3-4a96-9b35-98d0e2cdd928", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 75, 3, "d2c2948f-cd1d-4e0d-a5bd-82d8064e2635", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 76, 3, "33d619fd-2c10-4429-a812-52a6cf75ddd2", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 77, 3, "76016ce2-0e3d-42e5-8aea-19d30c81b0c9", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 78, 3, "5f7219da-6423-472e-9619-bfa4c856a778", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 79, 3, "7da39206-a6f7-4ecf-865a-d2094624f501", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 80, 3, "08915c9b-4bcb-4eae-bda5-fc9de13589e5", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 81, 3, "0049d657-7183-41a2-8d1c-6843bdc6cd02", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 82, 2, "87163784-182c-411f-bfb2-445fb7324b0d", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 83, 2, "ae123afd-5f2f-478a-b413-f8cd2d6f452f", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 84, 2, "15facd4f-a57b-48ac-ae83-66212c4c2864", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 85, 2, "ec442ad0-5d24-4cef-9a04-1d349e4afa63", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 86, 2, "f7b1b976-1abf-4262-86e1-cf589b423923", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 87, 2, "71cc3c50-b8e9-4ddd-b4d1-7be23f466d97", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 88, 2, "2bee6fb0-f11b-4004-a069-dde8e4e804eb", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" },
                    { 89, 2, "e67f1761-26cb-4fdb-8a8c-148c6ff11c4f", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" },
                    { 90, 1, "53635341-4e1f-4fff-b367-981b3826cee4", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 91, 1, "f0e4d1a3-2434-4556-942b-86e2bbc3aac4", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 92, 1, "1887a9dd-3ba4-4476-b4ef-e02e313a2b6d", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 93, 1, "6ef7fad6-13e0-4bd5-9f1c-cb77ea4ce56c", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 94, 1, "eaa5a5f6-820b-4808-a6bb-6d88dc091e74", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 95, 1, "d45e3204-83a6-4b09-b079-2153fe09cec8", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 96, 1, "68d712c5-fbd7-48cd-bbdd-c7b0f33ab230", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 97, 1, "5d06a40b-502f-47e2-86f3-528a39d193cc", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 98, 1, "7625bb2d-c947-4574-a79b-e2d9350ba4fa", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 99, 1, "e3f0a0c0-0d35-42bf-a4c2-77e347ac6efc", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 100, 1, "b59d48dc-c830-449c-aa67-3133866d9384", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 101, 1, "b07d86c6-4621-480a-8dc0-499f58f8a473", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 102, 1, "bb8c1efa-9577-46f4-ab72-55906c045612", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" },
                    { 103, 1, "2720bfb9-199b-45ba-bfcb-9a43e0816036", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 104, 1, "6a2bf722-844d-47a9-b036-452ec6d64d9f", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 105, 1, "ff7346ba-e968-4110-894e-f3e2996d1697", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 106, 1, "be7299c9-29cd-406c-bc45-75ddaa97365f", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 107, 1, "24fabf54-2730-4ed6-895d-43b029b0fc0f", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 108, 1, "fd7a0146-278d-4680-84ca-1f0ed949a9b1", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2434), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2435), null, "Satış Aşamasında" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2437), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2438), null, "Satıldı" }
                });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8341), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8342), null, "Nakit" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8346), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8347), null, "Kart" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8349), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8350), null, "Çek" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8353), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8354), null, "Senet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of MyBlog", 0, "fcad174c-2a99-470a-9fa4-ab0c77a56e3b", "adminuser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEB82V12TXz04VLdBoqUjxg1M/1P6KCOiXZVo3S5REoe0bhSA845CNiAHFirwozkeqA==", "+905555555555", true, "/userImages/defaultUser.png", "d0650bf3-d4f2-41fd-bcb7-e698dc7a8011", false, "adminuser" },
                    { 2, "Editor User of MyBlog", 0, "0991fef8-ffdc-4e2d-929c-2bdded8f2f04", "editoruser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEEvuM7jkb5uGaf7YSSx7xb4PHrEqR69xslVHv/havX1dbKA3p+vyFsI3NHlhduDpAA==", "+905555555555", true, "/userImages/defaultUser.png", "2d26cdb0-a3d5-461c-9433-56ecb6ee2314", false, "editoruser" },
                    { 3, "Editor User 2 of MyBlog", 0, "9030e4e5-1dc2-44a9-8dd8-3d2b91277d55", "editoruser2@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER2@GMAIL.COM", "EDITORUSER2", null, "+905555555555", true, "/userImages/defaultUser.png", "fcdac9eb-3389-4d65-a49a-317f286fa1db", false, "editoruser2" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8278), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8281), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8286), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8287), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8292), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8291), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8293), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8296), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8298), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8303), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8302), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8303), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8307), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8309), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8312), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8314), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8318), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8320), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8323), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8325), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8328), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8330), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1442), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1442), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1444), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1445), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1445), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1446), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1447), "Akbank Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1447), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1448), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1449), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1450), "Sivasot Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1450), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1451), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1452), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4580), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4581), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4583), null, 1, "Ikinci Personel", true, false, "User", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4584), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4587), null, 1, "Ucuncu perosnel", true, false, "User", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4587), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(1608), "Ürün Alt Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(1608), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(273), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(273), 5, "EmployeeProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(276), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(277), 5, "UserModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(279), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(280), 7, "StockModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(282), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(282), 6, "CustomerReferanceModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(285), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(285), 1, "AppointmentModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(287), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(288), 1, "NotificationModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(290), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(291), 3, "PaymentProgram.Read", null },
                    { 8, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(293), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(294), 2, "CustomerProgram.Read", null },
                    { 9, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(296), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(297), 7, "BrandModule.Read", null },
                    { 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(299), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(300), 3, "SaleModule.Read", null },
                    { 11, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(302), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(303), 7, "ProductProgram.Read", null },
                    { 12, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(305), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(305), 5, "RoleModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3319), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3320), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3323), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3324), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3327), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3328), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3332), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3332), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3335), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3336), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3339), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3340), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3343), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3344), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3346), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3347), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3350), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3351), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3354), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3355), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 13, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2413), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2407), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2408), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 14, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2427), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2424), 1, 2, "hasta2@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2425), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 15, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2433), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2431), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2432), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 4, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 16, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2440), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2437), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2438), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 5, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 17, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2446), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2444), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2445), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 6, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 18, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2452), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2449), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2450), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 7, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 19, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2458), "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2456), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2457), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[,]
                {
                    { 1, 1000m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3236), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3236), null, 1 },
                    { 2, 2000m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3240), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3241), null, 1 },
                    { 3, 1500m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3244), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3244), null, 1 },
                    { 4, 2300m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3247), "TEST desc 1 ", 2, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3247), null, 2 },
                    { 5, 1450m, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3250), "TEST desc 1 ", 2, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3250), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8910), true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8911), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" },
                    { 2, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8915), true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8916), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Jabra Signia", 1, 10, "A12BO9930HT3" },
                    { 3, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8918), true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8919), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Apple Signia Motion 1PX", 1, 10, "A12BO9930HT2" },
                    { 4, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8922), true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8922), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Samsung Signia Motion 1PX", 1, 10, "A12BO9930HT1" }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1019), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1020), "User.Create", null, 2 },
                    { 11, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1022), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1023), "User.Read", null, 2 },
                    { 12, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1025), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1026), "User.Update", null, 2 },
                    { 13, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1028), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1029), "User.Delete", null, 2 },
                    { 14, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1031), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1031), "Role.Read", null, 2 },
                    { 15, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1034), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1034), "Role.Update", null, 2 },
                    { 16, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1037), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1037), "Role.Delete", null, 2 },
                    { 17, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1039), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1040), "Role.Create", null, 2 },
                    { 37, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1073), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1073), "Payment.Create", null, 7 },
                    { 38, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1076), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1076), "Payment.Read", null, 7 },
                    { 39, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1078), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1079), "Payment.Update", null, 7 },
                    { 40, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1081), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1082), "Payment.Delete", null, 7 },
                    { 41, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1084), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1085), "PaymentType.Create", null, 7 },
                    { 42, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1087), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1088), "PaymentType.Read", null, 7 },
                    { 43, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1090), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1091), "PaymentType.Update", null, 7 },
                    { 44, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1093), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1093), "PaymentType.Delete", null, 7 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 45, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1096), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1096), "Employee.Create", null, 1 },
                    { 46, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1098), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1099), "Employee.Read", null, 1 },
                    { 47, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1101), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1102), "Employee.Update", null, 1 },
                    { 48, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1104), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1105), "Employee.Delete", null, 1 },
                    { 49, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1107), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1108), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1110), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1111), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1113), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1113), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1116), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1116), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1118), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1119), "Customer.Create", null, 8 },
                    { 54, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1121), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1122), "Customer.Read", null, 8 },
                    { 55, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1124), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1125), "Customer.Update", null, 8 },
                    { 56, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1127), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1128), "Customer.Delete", null, 8 },
                    { 57, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1130), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1131), "CustomerType.Create", null, 8 },
                    { 58, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1133), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1134), "CustomerType.Read", null, 8 },
                    { 59, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1136), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1136), "CustomerType.Update", null, 8 },
                    { 60, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1139), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1139), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1141), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1142), "Notification.Create", null, 6 },
                    { 62, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1144), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1145), "Notification.Read", null, 6 },
                    { 63, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1147), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1148), "Notification.Update", null, 6 },
                    { 64, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1150), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1151), "Notification.Delete", null, 6 },
                    { 65, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1153), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1153), "Brand.Create", null, 9 },
                    { 66, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1156), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1156), "Brand.Update", null, 9 },
                    { 67, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1159), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1159), "Brand.Delete", null, 9 },
                    { 68, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1164), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1165), "Brand.Delete", null, 9 },
                    { 69, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1167), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1168), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1170), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1171), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1173), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1173), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1176), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1176), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1178), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1179), "SaleType.Create", null, 10 },
                    { 74, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1181), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1182), "SaleType.Read", null, 10 },
                    { 75, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1184), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1185), "SaleType.Update", null, 10 },
                    { 76, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1187), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1188), "SaleType.Delete", null, 10 },
                    { 77, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1190), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1191), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1193), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1193), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1196), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1196), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1198), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1199), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1201), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1202), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1204), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1205), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1207), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1208), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1210), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1211), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1161), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1162), "Brand.Read", null, 9 },
                    { 89, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1213), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1213), "AppointmentType.Create", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 90, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1216), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1216), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1218), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1219), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1221), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1222), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1224), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1225), "Sale.Create", null, 10 },
                    { 94, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1227), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1228), "Sale.Read", null, 10 },
                    { 95, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1230), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1230), "Sale.Update", null, 10 },
                    { 96, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1233), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1233), "Sale.Delete", null, 10 },
                    { 97, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1235), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1236), "Product.Create", null, 11 },
                    { 98, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1238), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1239), "Product.Read", null, 1 },
                    { 99, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1241), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1242), "Product.Update", null, 11 },
                    { 100, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1244), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1245), "Product.Delete", null, 11 },
                    { 101, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1247), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1248), "Appointment.Create", null, 5 },
                    { 102, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1250), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1250), "Appointment.Read", null, 5 },
                    { 103, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1253), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1253), "Appointment.Update", null, 5 },
                    { 104, null, null, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1255), true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1256), "Appointment.Delete", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4147), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4148), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 2, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4191), 2, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4192), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 3, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4195), 3, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama3", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4196), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9230), 1, "TEST", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9231), null, "Reminder", new DateTime(2023, 7, 12, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9234), "Title", 1 },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9241), 2, "Doğum günü yaklaşmakta.", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9242), null, "Reminder", new DateTime(2023, 7, 11, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9243), "Doğum Günü!", 2 },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9245), 3, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9246), null, "Reminder", new DateTime(2023, 7, 10, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9247), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[,]
                {
                    { 1, 1m, null, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(285), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(286), null, 1, null },
                    { 2, 1m, null, 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(291), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(292), null, 1, null },
                    { 3, 1m, null, 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(295), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(295), null, 1, null },
                    { 4, 1m, null, 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(300), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(301), null, 1, null },
                    { 5, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(309), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(310), null, 1, null },
                    { 6, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(313), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(314), null, 1, null },
                    { 7, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(316), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(317), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[,]
                {
                    { 1, 500, 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7459), 1, 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7460), null, 1, 1, 1 },
                    { 2, 200, 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7464), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7465), null, 2, 1, 1 },
                    { 3, 500, 10, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7468), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7468), null, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(474), 0, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(475), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 },
                    { 2, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(477), 0, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(478), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 2, 20 },
                    { 3, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(480), 0, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(481), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 3, 20 },
                    { 4, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(484), 0, true, false, "InitialCreate", new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(484), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 4, 20 }
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
                name: "IX_OutPaymentDetails_EmployeeId",
                table: "OutPaymentDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OutPaymentDetails_OutPaymentId",
                table: "OutPaymentDetails",
                column: "OutPaymentId");

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
                name: "OutPaymentDetails");

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
                name: "OutPayments");

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
