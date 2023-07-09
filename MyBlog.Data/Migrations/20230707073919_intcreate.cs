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
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(980), "Test", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(981), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(984), "Test", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(985), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(129), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(130), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4322), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4323), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4325), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4326), "C++", "C++ Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4328), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4329), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4331), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4332), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4334), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4335), "Java", "Java Blog Kategorisi" },
                    { 6, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4337), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4338), "Python", "Python Blog Kategorisi" },
                    { 7, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4340), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4341), "Php", "Php Blog Kategorisi" },
                    { 8, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4343), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4344), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4346), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4347), "Swift", "Swift Blog Kategorisi" },
                    { 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4349), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(4349), "Ruby", "Ruby Blog Kategorisi" }
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
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9994), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9995), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9999), "Description", "Sema", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9999), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(763), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(764), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(770), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(771), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 2" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(773), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(774), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9184), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9185), "Not", "Title" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9187), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9188), "Not", "Title" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9189), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9190), "Not", "Title" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9193), "Description", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(9194), "Not", "Title" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CreatedByName", "CreatedDate", "IsActive", "IsDaily", "IsDeleted", "IsIncome", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 100, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6077), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6078), "TEST" },
                    { 2, 122, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6081), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6082), "TEST" },
                    { 3, 21, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6084), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6085), "TEST" },
                    { 4, 341, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6087), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6088), "TEST" },
                    { 5, 422, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6090), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6091), "TEST" },
                    { 6, 122, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6093), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6094), "TEST" },
                    { 7, 322, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6097), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6097), "TEST" },
                    { 8, 422, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6100), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6100), "TEST" },
                    { 9, 522, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6103), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6104), "TEST" },
                    { 10, 122, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6106), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6107), "TEST" },
                    { 11, 232, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6109), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6110), "TEST" },
                    { 12, 122, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6112), true, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6113), "TEST" },
                    { 13, 222, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6115), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6116), "TEST" },
                    { 14, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6118), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6119), "TEST" },
                    { 15, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6121), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6122), "TEST" },
                    { 16, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6124), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6125), "TEST" },
                    { 17, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6127), true, true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6128), "TEST" },
                    { 18, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6130), true, false, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6131), "TEST" },
                    { 19, 22, "InitialCreate", new DateTime(2023, 6, 8, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6133), true, false, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(6134), "TEST" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3992), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3993), "AgendaProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3996), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3997), "CustomerModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3999), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3999), "RoleModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4001), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4002), "RoleModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4004), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4005), "RoleModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4007), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4007), "RoleModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4009), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4010), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[,]
                {
                    { 1, 0m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5544), 15000m, "TEST desc 1 ", new DateTime(2023, 7, 11, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5548), true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5544), null, "Ödemenin Yapılacağı yer" },
                    { 2, 0m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5556), 10000m, "TEST desc 1 ", new DateTime(2023, 7, 11, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5558), true, false, true, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(5557), null, "Ödemenin Yapılacağı yer" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7534), "Point of Sale", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7535), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7537), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7537), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7538), "Point of Sale", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7539), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(1623), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(1623), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(1628), "Product Kategori 2 Açıkama", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(1629), "Product Kategori 2", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(4810), "Ürün Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(4811), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "17ac24db-b2f0-43e5-b09c-0b91893ff45f", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 3, "9453886c-b352-495e-b9d0-da6664818352", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 3, 3, "395b8534-3116-40bd-b5e9-6f07ea14ab2d", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 4, 3, "01d71550-5488-4031-9622-67db9e7d13a1", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 5, 3, "28de2225-5949-4dc7-b52d-3d233be6aae2", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 6, 3, "9e8d2886-7976-43c1-a6d0-4b70beca40f7", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 7, 3, "035f69b7-9462-4164-8958-d27f620aaec5", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 8, 3, "7c6f7b9c-5d8a-46a4-a092-8becdc5bbc72", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 9, 3, "2b8131d0-0d4a-4f82-8e8d-c4f94ec2d240", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 10, 3, "88c36aff-2635-458e-8f08-1b31626d374c", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 11, 3, "afcdc03c-3e2d-4958-8a31-ec0102befa7f", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 12, 3, "2068e56f-2a5f-4334-9d79-0e8a181b4851", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 13, 3, "d0e0563b-884b-41e5-8612-2584cfce262a", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 14, 3, "7bc4dae5-c65a-41d0-932e-f53f6de5b5ca", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 15, 3, "a4c9a669-4b1b-41c3-b855-2ee885d287ba", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 16, 3, "5505b01e-269d-4e0b-b19f-e3dad98b878c", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 17, 3, "17c88b34-39cd-412e-9cfd-755ad7b9cf95", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 18, 3, "3bcf7e9b-af54-437f-9b4f-57c135189425", "Çalışan Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 19, 3, "f2429003-f60c-4f23-bddf-c840e99ed1ed", "Çalışan Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 20, 3, "b958b835-fbe1-4432-ad53-00173ae127c4", "Çalışan Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 21, 3, "2677c005-8786-4909-9274-f73b18b1c362", "Çalışan Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 22, 3, "8c5675d5-1414-4f6e-957e-3c3740b3c9f7", "Çalışan Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 23, 3, "c8224357-0d4d-41c5-9649-c91694b5d93a", "Çalışan Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 24, 3, "9aa5943a-3c6d-4c50-a24f-025a19de43a7", "Çalışan Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 25, 3, "9429ed77-881f-4c57-8ef7-869e36c5975c", "Çalışan Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 26, 3, "d53f43a7-28c6-4e2c-8cb5-feb9f5303f9b", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 27, 3, "edb3c94c-ea97-4a62-ad60-b2b79574ce41", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 28, 3, "690785ce-38aa-4e55-8287-ccb0c210adeb", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 29, 3, "4658754a-47f2-4597-9e70-5dbf0d84d9e0", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 30, 3, "d4072df5-3a1f-42a9-b19a-58acb1f1c98d", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 31, 3, "3f9dd79d-5cb0-4840-a403-03c54d99a62e", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 32, 3, "d81748e2-cfa7-4fd8-83e1-dfdc1a82ff39", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 33, 3, "fc8c6ea5-ce90-473b-935e-f394a43167cd", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 34, 3, "0e5b8682-a7a4-4155-8a99-ca8f71a27020", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 35, 3, "cf29ef20-cd54-4295-b29f-0b6dafa9c34f", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 36, 3, "d8cb1410-492b-4352-8a88-dc02d78c3eb2", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 37, 3, "0cd1bf67-b05c-4e80-9d94-3840f2f87b7c", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 38, 3, "a8d2b554-f715-4a9e-a1b0-dd58b40045aa", "Marka Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 39, 3, "e1cbf2aa-f076-408e-9f05-8d9e66f4f13c", "Marka Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 40, 3, "054ddf68-1882-4e42-a7b0-f07b2eb7b5e2", "Marka Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 41, 3, "e606de36-e67f-4a0b-9f7e-addfe992b222", "Marka Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 42, 3, "6bda34aa-6f46-4623-893d-3c74f0c81f01", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 43, 3, "6dea2a18-7a87-4c1c-9dc7-9bdbde7fb138", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 44, 3, "b6c6bfc3-692c-4616-9d4e-b882b7a6b25f", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 45, 3, "243feff2-4487-44df-be5b-86ebdf79c304", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 46, 3, "ee685823-900d-42f4-940e-bb6d7ea2ec51", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 47, 3, "69f5ecd3-a8fc-4845-85b2-e94568df3452", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 48, 3, "52287e41-f4ff-4492-ae78-a50338702fda", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 49, 3, "86908c55-6609-4ef7-981a-9b1e90a521c9", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 50, 3, "c8a6f807-369f-4143-b962-27105d63345f", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 51, 3, "699354fc-cfd3-4980-87a1-3178491afc77", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 52, 3, "85c86eda-f9c3-4340-a267-74a552714101", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 53, 3, "d3753558-9705-42ec-a547-9f68c7440cc9", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 54, 3, "cfdfd505-984c-4fa3-9006-01be96953399", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 55, 3, "56e83728-d297-45cd-8c33-251969556950", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 56, 3, "02363551-0859-423b-9ea4-6442cb056e24", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 57, 3, "aa4c70eb-5cbe-4bcd-8df6-1b17ae70a6c2", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 58, 3, "41192c77-9189-4405-aff9-a76f1eec3ce1", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 59, 3, "40ba2574-bdc4-426e-a743-53afc266059f", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 60, 3, "bb478da3-578c-413b-a76c-bc020442ff28", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" },
                    { 61, 3, "771954dc-4447-45be-8420-28aad2b79aa3", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 62, 3, "d1058b82-ca6e-43ad-9188-6d33399a1067", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 63, 3, "f93e2c3b-1bf1-4259-8ccd-a36861d99224", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 64, 3, "94fd166e-3176-47ea-851e-914ac41d3e25", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 65, 3, "4ace8709-0ed8-472b-8702-20a842dbf1a9", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 66, 3, "849ace0e-361b-4552-a42d-a062dbb1dbde", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 67, 3, "c43d68a1-5e7b-464c-b95f-4595fff7c0d5", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 68, 3, "1721140d-80b3-4eb0-b0b6-66e14b485e29", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 69, 3, "a8855bbc-cdc4-4013-b2a9-caf360170ec2", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 70, 3, "d39313f1-8168-411e-87d2-f12e26c64c77", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 71, 3, "382c1b68-20f3-4192-ac39-33b9452cfbf7", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 72, 3, "74cfce63-ee97-4761-8174-05ac4af0d3f7", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 73, 3, "0a954662-6dc1-46a8-b725-3913a147a88b", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 74, 3, "e2126923-9448-419d-bed4-74233027ee13", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 75, 3, "72af6410-4cd5-4382-b23a-1e5a24dd60a6", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 76, 3, "a699b40b-7240-4cbd-915b-d41cc6bb7847", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 77, 3, "b4a6939d-ffca-402e-b57b-cb713fe24aeb", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 78, 3, "78344553-cb28-4283-b5e2-4334b66d83ca", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 79, 3, "87a7d3dc-096c-48d9-a150-c81e23e94cb2", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 80, 3, "dd653c78-f0df-494f-83f9-47fb096c7be3", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 81, 3, "68f32817-5c0d-4f8b-8d44-e2ab99bcd5f9", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 82, 2, "e3cbac30-bc52-4cd4-a29b-02b11670ec14", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 83, 2, "3406268a-a8c3-4cd8-9c77-c326177e0c5e", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 84, 2, "9b0f5822-800d-4278-9e41-04c7ea707f24", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 85, 2, "0e3a750b-c775-4904-b57b-b5206780ad1f", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 86, 2, "ef5d61e6-8c06-41b0-b282-c2f2e1f4ac4f", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 87, 2, "dfc4d4bc-0ea6-4cab-855c-710d467a11c9", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 88, 2, "da0ddae3-51cf-4f15-a0be-57d73c1dcffc", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" },
                    { 89, 2, "8da71b05-0093-443c-ac3d-0a276f2fefbb", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" },
                    { 90, 1, "17af7966-db73-4c31-b995-5f50cd8131e3", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 91, 1, "d5cb1769-69e0-4739-a0ec-ba7b01564b08", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 92, 1, "c2e5ae3a-63c6-4fa4-9406-fd27715eef48", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 93, 1, "5664c365-400a-438f-b3f7-26ef626d6a02", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 94, 1, "c79af4eb-d3be-4681-8cae-92631dd38823", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 95, 1, "2c67ffd8-2930-4e5a-bd80-cc4acde51e3e", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 96, 1, "29f33846-a598-4fa0-ba74-f2b7eb0f08fb", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 97, 1, "9da758a3-d351-4998-b32c-a88c31295e6d", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 98, 1, "848e8201-a573-4f20-9131-9d986f9c61fc", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 99, 1, "bf44923c-1a12-497e-9358-bfb6abdaf667", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 100, 1, "25cc2ecf-30be-4210-88f5-44147511035d", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 101, 1, "6a309397-f37c-43c1-860a-eef17fa8d2a2", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 102, 1, "8f77f394-0180-487c-95e8-15522505fb5c", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" },
                    { 103, 1, "9f716b46-4d16-4821-a623-69e7affd3082", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 104, 1, "07975740-d0fa-4fb9-b6f0-876a4b85e2a1", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 105, 1, "ae553619-37b7-4b6c-908b-7c213b7dcdd0", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 106, 1, "363f0293-823a-470e-ac7a-53af51613c99", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 107, 1, "11677f8f-b6ec-4f79-9d77-f9d926fbba7a", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 108, 1, "6cb69f10-8023-4a6d-a0bf-102bebf02e64", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(7149), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(7150), null, "Satış Aşamasında" },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(7152), "açıklama deneme status sale 1", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(7153), null, "Satıldı" }
                });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3014), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3014), null, "Nakit" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3017), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3018), null, "Kart" },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3020), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3021), null, "Çek" },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3023), "TEST", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(3024), null, "Senet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of MyBlog", 0, "6f4d38e4-56bf-4f2b-b83e-6e252c7df5a6", "adminuser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEOO54BMgPDFf4xSWOTgdOTN3rmQP4IL2xfXp8T3eKl2bIr8N8cYkRweSZUHMq6/mTg==", "+905555555555", true, "/userImages/defaultUser.png", "89ef0f6d-fd9b-47dc-9262-b7b85d8f0bec", false, "adminuser" },
                    { 2, "Editor User of MyBlog", 0, "3a0b6737-4107-4b1a-96d1-c02c0e0887a9", "editoruser@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEJ+xKv4fIGw66Q4fHWZk4gwlegW6abJuXag1ZahKbLQlRUavpYzvlG2rSXOwXOxtHA==", "+905555555555", true, "/userImages/defaultUser.png", "130dba40-ee6b-4287-bd4d-e78c345ff71f", false, "editoruser" },
                    { 3, "Editor User 2 of MyBlog", 0, "d1ad968f-9972-4737-af0f-ff08b5f77d00", "editoruser2@gmail.com", true, "Admin", "User", "https://twitter.com/adminuser", false, null, "EDITORUSER2@GMAIL.COM", "EDITORUSER2", null, "+905555555555", true, "/userImages/defaultUser.png", "b9cea381-8dfc-4d3c-809e-2b5b5f5f68d9", false, "editoruser2" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3214), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3216), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3219), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3221), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3223), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3225), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3227), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3228), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3231), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3232), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3235), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3236), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3239), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3240), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3243), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3244), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3247), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3248), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3251), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(3252), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5910), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5911), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5913), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5913), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5914), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5914), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5915), "Akbank Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5916), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5917), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5917), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5918), "Sivasot Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5919), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5919), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5920), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8987), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8988), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8992), null, 1, "Ikinci Personel", true, false, "User", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8992), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8996), null, 1, "Ucuncu perosnel", true, false, "User", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(8996), null, "+905555555555", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(6319), "Ürün Alt Grubu Açıklaması", true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(6320), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4765), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4766), 5, "EmployeeProgram.Read", null },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4768), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4769), 5, "UserModule.Read", null },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4771), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4772), 7, "StockModule.Read", null },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4774), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4775), 6, "CustomerReferanceModule.Read", null },
                    { 5, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4777), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4778), 1, "AppointmentModule.Read", null },
                    { 6, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4780), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4780), 1, "NotificationModule.Read", null },
                    { 7, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4782), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4783), 3, "PaymentProgram.Read", null },
                    { 8, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4785), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4786), 2, "CustomerProgram.Read", null },
                    { 9, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4788), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4789), 7, "BrandModule.Read", null },
                    { 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4791), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4792), 3, "SaleModule.Read", null },
                    { 11, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4794), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4794), 7, "ProductProgram.Read", null },
                    { 12, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4797), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(4797), 5, "RoleModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 96, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5850), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5851), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5853), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5854), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5856), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5857), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5859), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5860), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5862), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5863), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5865), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5865), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5868), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5868), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5871), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5871), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5873), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5874), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5876), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(5877), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 11, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9075), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9071), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9071), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 12, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9084), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9082), 1, 2, "hasta2@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9082), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 13, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9088), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9086), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9087), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 4, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 14, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9092), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9090), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9091), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 5, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 15, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9097), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9095), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9096), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 6, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 16, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9101), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9099), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9100), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 7, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 7, 17, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9106), "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9104), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 961, DateTimeKind.Local).AddTicks(9105), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[,]
                {
                    { 1, 1000m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7297), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7298), null, 1 },
                    { 2, 2000m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7304), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7305), null, 1 },
                    { 3, 1500m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7308), "TEST desc 1 ", 1, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7308), null, 1 },
                    { 4, 2300m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7311), "TEST desc 1 ", 2, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7312), null, 2 },
                    { 5, 1450m, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7315), "TEST desc 1 ", 2, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(7315), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4150), true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4151), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" },
                    { 2, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4154), true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4155), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Jabra Signia", 1, 10, "A12BO9930HT3" },
                    { 3, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4158), true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4158), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Apple Signia Motion 1PX", 1, 10, "A12BO9930HT2" },
                    { 4, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4161), true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(4162), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Samsung Signia Motion 1PX", 1, 10, "A12BO9930HT1" }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5542), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5543), "User.Create", null, 2 },
                    { 11, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5547), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5548), "User.Read", null, 2 },
                    { 12, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5550), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5551), "User.Update", null, 2 },
                    { 13, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5553), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5554), "User.Delete", null, 2 },
                    { 14, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5556), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5556), "Role.Read", null, 2 },
                    { 15, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5559), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5559), "Role.Update", null, 2 },
                    { 16, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5561), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5562), "Role.Delete", null, 2 },
                    { 17, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5564), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5565), "Role.Create", null, 2 },
                    { 37, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5567), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5568), "Payment.Create", null, 7 },
                    { 38, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5570), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5571), "Payment.Read", null, 7 },
                    { 39, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5573), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5573), "Payment.Update", null, 7 },
                    { 40, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5575), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5576), "Payment.Delete", null, 7 },
                    { 41, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5578), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5579), "PaymentType.Create", null, 7 },
                    { 42, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5581), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5582), "PaymentType.Read", null, 7 },
                    { 43, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5584), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5585), "PaymentType.Update", null, 7 },
                    { 44, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5587), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5587), "PaymentType.Delete", null, 7 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 45, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5590), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5590), "Employee.Create", null, 1 },
                    { 46, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5592), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5593), "Employee.Read", null, 1 },
                    { 47, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5595), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5596), "Employee.Update", null, 1 },
                    { 48, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5598), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5599), "Employee.Delete", null, 1 },
                    { 49, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5601), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5601), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5604), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5604), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5607), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5607), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5609), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5610), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5612), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5613), "Customer.Create", null, 8 },
                    { 54, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5615), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5616), "Customer.Read", null, 8 },
                    { 55, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5618), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5619), "Customer.Update", null, 8 },
                    { 56, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5621), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5621), "Customer.Delete", null, 8 },
                    { 57, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5624), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5624), "CustomerType.Create", null, 8 },
                    { 58, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5626), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5627), "CustomerType.Read", null, 8 },
                    { 59, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5629), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5630), "CustomerType.Update", null, 8 },
                    { 60, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5632), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5633), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5635), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5636), "Notification.Create", null, 6 },
                    { 62, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5638), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5638), "Notification.Read", null, 6 },
                    { 63, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5641), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5641), "Notification.Update", null, 6 },
                    { 64, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5643), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5644), "Notification.Delete", null, 6 },
                    { 65, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5646), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5647), "Brand.Create", null, 9 },
                    { 66, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5649), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5650), "Brand.Update", null, 9 },
                    { 67, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5652), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5653), "Brand.Delete", null, 9 },
                    { 68, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5680), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5680), "Brand.Delete", null, 9 },
                    { 69, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5683), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5683), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5685), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5686), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5688), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5689), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5691), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5692), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5694), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5694), "SaleType.Create", null, 10 },
                    { 74, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5697), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5697), "SaleType.Read", null, 10 },
                    { 75, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5699), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5700), "SaleType.Update", null, 10 },
                    { 76, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5702), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5703), "SaleType.Delete", null, 10 },
                    { 77, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5705), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5706), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5708), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5708), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5710), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5711), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5713), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5714), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5716), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5717), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5719), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5719), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5721), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5722), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5724), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5725), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5655), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5655), "Brand.Read", null, 9 },
                    { 89, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5727), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5728), "AppointmentType.Create", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 90, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5730), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5730), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5733), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5733), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5736), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5736), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5738), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5739), "Sale.Create", null, 10 },
                    { 94, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5741), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5742), "Sale.Read", null, 10 },
                    { 95, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5744), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5745), "Sale.Update", null, 10 },
                    { 96, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5747), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5747), "Sale.Delete", null, 10 },
                    { 97, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5749), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5750), "Product.Create", null, 11 },
                    { 98, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5752), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5753), "Product.Read", null, 1 },
                    { 99, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5755), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5755), "Product.Update", null, 11 },
                    { 100, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5758), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5758), "Product.Delete", null, 11 },
                    { 101, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5760), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5761), "Appointment.Create", null, 5 },
                    { 102, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5763), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5764), "Appointment.Read", null, 5 },
                    { 103, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5766), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5767), "Appointment.Update", null, 5 },
                    { 104, null, null, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5769), true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(5769), "Appointment.Delete", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8825), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8826), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 2, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8830), 2, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8831), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 3, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8833), 3, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama3", 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(8834), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3907), 1, "TEST", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3908), null, "Reminder", new DateTime(2023, 7, 10, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3911), "Title", 1 },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3917), 2, "Doğum günü yaklaşmakta.", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3918), null, "Reminder", new DateTime(2023, 7, 9, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3919), "Doğum Günü!", 2 },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3921), 3, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3922), null, "Reminder", new DateTime(2023, 7, 8, 10, 39, 18, 972, DateTimeKind.Local).AddTicks(3923), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[,]
                {
                    { 1, 1m, null, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4477), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4478), null, 1, null },
                    { 2, 1m, null, 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4483), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4484), null, 1, null },
                    { 3, 1m, null, 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4487), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4487), null, 1, null },
                    { 4, 1m, null, 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4490), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4491), null, 1, null },
                    { 5, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4494), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4495), null, 1, null },
                    { 6, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4498), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4499), null, 1, null },
                    { 7, 1m, null, 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4501), 1, null, "TEST", 1, null, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 971, DateTimeKind.Local).AddTicks(4502), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[,]
                {
                    { 1, 500, 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2156), 1, 1, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2157), null, 1, 1, 1 },
                    { 2, 200, 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2161), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2161), null, 2, 1, 1 },
                    { 3, 500, 10, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2164), 1, 2, true, false, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 973, DateTimeKind.Local).AddTicks(2165), null, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5540), 0, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5541), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 },
                    { 2, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5544), 0, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5544), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 2, 20 },
                    { 3, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5547), 0, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5547), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 3, 20 },
                    { 4, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5550), 0, true, false, "InitialCreate", new DateTime(2023, 7, 7, 10, 39, 18, 962, DateTimeKind.Local).AddTicks(5550), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 4, 20 }
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
