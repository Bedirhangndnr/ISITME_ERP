using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class initMig : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CustomerReferanceTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    table.PrimaryKey("PK_CustomerReferanceTitles", x => x.Id);
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
                name: "MessageToDevelopers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    EstimatedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_MessageToDevelopers", x => x.Id);
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
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReferances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerReferanceTitleId = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_CustomerReferances_CustomerReferanceTitles_CustomerReferanceTitleId",
                        column: x => x.CustomerReferanceTitleId,
                        principalTable: "CustomerReferanceTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                name: "SubModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_SubModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubModels_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
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
                    AmountPaid = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
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
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    ProductSubGroupId = table.Column<int>(type: "int", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: true),
                    SubModelId = table.Column<int>(type: "int", nullable: true),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: false),
                    IsProduct = table.Column<bool>(type: "bit", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
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
                    table.ForeignKey(
                        name: "FK_Product_SubModels_SubModelId",
                        column: x => x.SubModelId,
                        principalTable: "SubModels",
                        principalColumn: "Id");
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
                    AmountPaid = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
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
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AmountOfSgk = table.Column<int>(type: "int", nullable: false),
                    IsInvoiceDue = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SaleTypeId = table.Column<int>(type: "int", nullable: true),
                    SaleStatusId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(4382), "Test", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(4383), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9504), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9504), "C#", "C# Blog Kategorisi" },
                    { 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9507), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9507), "C++", "C++ Blog Kategorisi" },
                    { 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9509), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9510), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9512), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9512), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9514), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9515), "Java", "Java Blog Kategorisi" },
                    { 6, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9517), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9517), "Python", "Python Blog Kategorisi" },
                    { 7, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9519), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9520), "Php", "Php Blog Kategorisi" },
                    { 8, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9521), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9522), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9524), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9524), "Swift", "Swift Blog Kategorisi" },
                    { 10, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9526), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(9527), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "Action", "DateTime", "NewValues", "OldValues", "TableName" },
                values: new object[] { 1, "act Manuel", null, null, null, null });

            migrationBuilder.InsertData(
                table: "CustomerReferanceTitles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(2963), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(2964), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Referans Unvan 1" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(4366), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(4367), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(3041), "Description", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(3042), "Not", "Title" });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 11, 18, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9314), true, false, false, "TEST", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9312), null, 3, "MessageToDeveloper Title Test" },
                    { 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 11, 18, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9319), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9318), null, 1, "MessageToDeveloper Title Test" },
                    { 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 11, 16, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9322), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(9321), null, 4, "MessageToDeveloper Title Test" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7140), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7141), "AgendaProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7143), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7144), "CustomerModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7146), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7146), "RoleModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7148), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7149), "RoleModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7150), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7151), "RoleModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7152), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7153), "RoleModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7154), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(7155), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[] { 1, 0m, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(1323), 15000m, "TEST desc 1 ", new DateTime(2023, 11, 17, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(1328), true, false, true, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(1324), null, "Ödemenin Yapılacağı yer" });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2042), "Point of Sale", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2042), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2043), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2044), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2044), "Point of Sale", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2045), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(4860), "Product Kategori 2 Açıkama", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(4860), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(8226), "Ürün Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(8227), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "686f1b7c-b851-4fdd-9d5f-615526a5f9fa", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 1, "85f42308-7985-4866-a25a-5fb7092d02eb", "Standart Kullanıcı Yetkisi", "DefaultUser", "DEFAULTUSER" },
                    { 3, 1, "df04027c-eaf6-4ce6-b343-a81863b62027", "Developer Yetkisi", "Developer", "DEVELOPER" },
                    { 4, 3, "ae0cba06-292e-4f41-b7cf-4f67574f6036", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 5, 3, "a996ae1f-c6f7-4808-9447-162a293db154", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 6, 3, "c93dbc14-f8a4-4f5e-904c-797d41c57d7f", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 7, 3, "182061c8-40d3-4af7-a9bf-f8a85be26934", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 8, 3, "dab9bb96-7600-4bed-8f7f-ba58a5832ed9", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 9, 3, "d9f8bff3-19dc-4ac4-9f7b-b65b2da3dc38", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 10, 3, "65821680-0801-4a39-b13c-476ffbb2e14d", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 11, 3, "05551857-2d40-4e02-92df-7f6c2cd668d8", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 12, 3, "9483c5bf-a768-4945-a76a-1cb28a297666", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 13, 3, "f7882c88-8abc-4044-9d42-a49e4208f254", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 14, 3, "3394d363-8989-488b-ac8a-48e2ff70b173", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 15, 3, "e4189190-70a2-4260-ab18-36f972c375f4", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 16, 3, "a8b8fa72-877b-40b1-9737-e4e82addc1d8", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 17, 3, "95140cd3-9098-40e8-9358-4015e66ebc61", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 18, 3, "e346fc55-d407-4b3b-8428-8c7c35af11d9", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 19, 3, "0490fc7f-d39f-4de9-a7c4-86a1161701cb", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 20, 3, "f7757767-c3b5-4e8e-add8-48ec632d9c8a", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 21, 3, "3d969f33-3236-40d2-a58f-65fc72772870", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 22, 3, "da1f1e66-7623-429e-8d69-0097381ffd5f", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 23, 3, "ef637d82-7601-4c4f-92dc-db4765a18f6b", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 24, 3, "f59ef0eb-f284-4dfd-9fe9-84ee094793a1", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 25, 3, "b4099d99-aaaa-447e-9b2d-f739ddb89189", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 26, 3, "d03933d5-a08a-4685-97bf-c389e200e5eb", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 27, 3, "ccb1832f-816f-4853-a8c9-9ba9b5e901a2", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 28, 3, "475a7fda-107d-44ac-88a2-db3fea0a0d2a", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 29, 3, "d622276b-6241-46cf-981f-07cbf72305c3", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 30, 3, "9524e536-d218-49c2-8920-bbea0d29314e", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 31, 3, "06b3bf87-b306-4c23-8511-5542803c9561", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 32, 3, "98679b40-9f15-4e7d-b686-5a2768a20444", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 33, 3, "94da0f7a-35c3-468e-924f-a47895018fd7", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 34, 3, "92efd2e5-4397-489c-bf9b-f6be2846823f", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 35, 3, "c78a4636-4f75-4be3-8f3d-6e4de1dbdb56", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 36, 3, "76a97210-24b9-4fbe-97f7-a757ba194f16", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 37, 3, "9d40ce2e-63d1-4c8b-8893-7742c9dc2a73", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 38, 3, "8df6ea2b-7207-4ea1-be79-a37ed704fcfc", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 39, 3, "76f5a56b-7396-4e43-84e4-c4f52ae941b1", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 40, 3, "7e6c1cba-5fc9-4f3e-900f-c5a327df9d28", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 41, 3, "ae63258f-def6-48b3-9d15-cb2dc211cc72", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 42, 3, "621f0181-b37a-4063-912a-494b13cea187", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 43, 3, "c2e06544-155e-45ec-a1a0-2b6017c8252c", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 44, 3, "402db492-7701-4a86-8d0a-c3a4c2a17f57", "Brand Ekleme Yetkisi", "MessageToDeveloper.Create", "MESSAGETODEVELOPER.CREATE" },
                    { 45, 3, "740c5650-f1f2-4ce4-96c1-1ff9692d057f", "Brand  Yetkisi", "MessageToDeveloper.Read", "MESSAGETODEVELOPER.READ" },
                    { 46, 3, "fec13f2e-e319-4873-a44c-5849b51e3d76", "Brand  Yetkisi", "MessageToDeveloper.Update", "MESSAGETODEVELOPER.UPDATE" },
                    { 47, 3, "3d08e401-40d8-4e0a-b5f2-dbb659853a95", "Brand  Yetkisi", "MessageToDeveloper.Delete", "MESSAGETODEVELOPER.DELETE" },
                    { 48, 3, "33fb5790-7d83-46b9-9468-6f8f0f098bd4", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 49, 3, "95dbac8b-6823-41fe-9de7-3fca64907a09", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 50, 3, "d62e6cc9-7bea-428c-87c0-e25fe20b0218", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 51, 3, "8b29c82c-683d-43c4-a100-4c3d9a05428a", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 52, 3, "2497c2ce-52b9-44e5-aa3a-d9db9428a513", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 53, 3, "11e3aaf2-7c71-47e0-9a1f-f063cc11b945", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 54, 3, "b54fba03-b201-4a7b-ad44-dd19a40caa87", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 55, 3, "c9f8bae5-6a3e-462c-9c66-4b95c30e6ee2", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 56, 3, "34625d41-35bd-4cfe-8f43-7261d2d3c874", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 57, 3, "0d7d44ca-1cce-4abb-a32c-2ac6e106cc35", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 58, 3, "84bd9e13-e8e8-4be6-8762-19e9b16359a1", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 59, 3, "a22af4ea-faab-46fc-86bf-d85835748f57", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 60, 3, "daf4ba21-6a76-4052-88c8-315bc0f2ed79", "Model Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 61, 3, "9cf7b27b-2a3c-4316-b631-178842db4420", "Model Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 62, 3, "6e95759b-18b7-46f4-a958-803582383b74", "Model Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 63, 3, "9f0467c0-3795-4107-8462-a4ff7579af67", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 64, 3, "136f557c-59b6-478f-9dce-7e3b3f57660a", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 65, 3, "e2580fbd-3897-40dc-8804-ce13eb51a198", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 66, 3, "b52daa3f-6938-4d35-984f-d4c330781420", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" },
                    { 67, 3, "9fe32e60-4511-4a25-a7bc-3120cd7ed2bd", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 68, 3, "3c37cb1b-c5ab-463e-9612-d100e6a9b3da", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 69, 3, "1777b354-1f6d-42ad-b947-e2214a186386", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 70, 3, "0ac2104e-6900-497d-b98d-4e73e3251360", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 71, 3, "cd5db144-b735-4af2-a91f-b54422109220", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 72, 3, "91f920ed-4b21-4bff-adc1-101ca29b9376", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 73, 3, "f0c835e3-bb14-474a-8b2b-ab78630b7820", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 74, 3, "a027ce40-e99a-421b-88f3-dc137397affe", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 75, 3, "a72c88c2-e9a0-4df5-8dc6-48e8cfebd5c2", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 76, 3, "750a02a9-dcb0-47dc-abe7-2478950b4359", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 77, 3, "9e27e36b-a820-47cf-b623-94b9c6b5158c", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 78, 3, "df427a9c-86ed-4737-83a7-7734b12aada5", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 79, 3, "e3ce476d-5f46-4c47-a124-9e997d1f9873", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 80, 3, "febe4a95-56ee-4da9-a26b-aa23d4f2bac1", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 81, 3, "516fc534-5938-47e2-8702-7679ba180bd5", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 82, 3, "bc93143f-4d52-4b38-a0a7-ac59f51f7a09", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 83, 3, "0a99c161-9b9c-49ba-90b9-95d614a42572", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 84, 3, "113b677c-6470-4f8c-8fc7-63cfac8cb454", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 85, 3, "2dd8dd10-9e0a-4327-a84f-1c63b9b21869", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 86, 3, "44810f59-24cd-4292-beed-81d77e35f246", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 87, 3, "8928828e-a73d-4dad-9383-0343b18f2c09", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 88, 2, "c41db278-9ec8-43e5-87ec-48a08b1633b4", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 89, 2, "6a25d1e8-0c2f-4430-a805-c7ae444d6d3a", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 90, 2, "54a8fd2c-5205-4be1-8c53-732df30bfd9b", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 91, 2, "73c41388-f080-4531-ba51-5980d77ad037", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 92, 2, "d9a4da70-bc58-452f-b037-1b6c20890559", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 93, 2, "c51be3e2-4180-4087-9270-21088d37703c", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 94, 2, "478d79ea-305a-42a8-a883-f170708b13d0", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" },
                    { 95, 2, "d96779f9-b436-4aa3-a42b-68e4cae39883", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 96, 1, "5840f697-99ae-4659-9559-744eba0f3611", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 97, 1, "2d9b2200-897a-49bb-913a-d2e5663d8bf7", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 98, 1, "b4acded2-500b-429a-bf81-bcf6028885aa", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 99, 1, "f4c60e41-9bfd-4339-af2d-1f4a3ce78a5f", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 100, 1, "d69dcd19-80f2-4233-b2a2-7280282f7809", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 101, 1, "3790cfd7-fb6d-4ba5-85e9-12de2962344b", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 102, 1, "d66e398c-896c-4365-a41c-0043479eba22", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 103, 1, "7a0f5029-6952-4e41-8311-399663cef88e", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 104, 1, "14159acf-11df-47bd-8776-6297afacb761", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 105, 1, "e208382d-4d7d-4f5d-92e8-e3dfe44d983b", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 106, 1, "80ceb137-959b-4c84-8f8e-25a83f4ea3fe", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 107, 1, "4cf7a805-6949-47d6-afc0-b66a15f8cdbe", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 108, 1, "7dae550a-4204-4099-9307-12be8887420c", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" },
                    { 109, 1, "ebcd0ce5-4eae-4062-985a-2ad4453466f0", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 110, 1, "50de0f1e-4d1a-4d6f-bbac-6d724cd57dfb", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 111, 1, "2b08e63a-99d2-4000-8906-ce96075fcbe5", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 112, 1, "757fc83d-167a-4ede-b252-b61495dcb8da", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 113, 1, "c1bbaddd-c231-416e-ae76-c4a2fbc7c03d", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 114, 1, "32754f30-3e5c-49da-b713-cb3e9fdb0438", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(1312), "açıklama deneme status sale 1", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(1314), null, "Satış Aşamasında" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(6446), "TEST", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(6447), null, "Nakit" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Institution", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin | Bilal", 0, "20828fd4-eca6-4965-8904-c911fdeef965", "bilalAdmin@gmail.com", true, "Bilal", "Fokus", "Meto", "-", false, null, "BILALADMIN@GMAIL.COM", "BILALADMIN", "AQAAAAEAACcQAAAAEJbtYp19sLsHLszsxXin+2S/frv6KZyvlCenBpnVslekHXv6jT/CrVdv6MO8btoHMQ==", "+905537314131", true, "/userImages/defaultUser.png", "72197a51-653d-41fc-8c38-216790e57fcd", false, "bilalAdmin" },
                    { 2, "Admin | Nazlı", 0, "2b6980d4-76cc-419a-8b33-b495aa382331", "nazliAdmin@gmail.com", true, "Nazlı", "Fokus", "-", "-", false, null, "NAZLIADMIN@GMAIL.COM", "NAZLIADMIN", "AQAAAAEAACcQAAAAEDulDx9Avt8HvcN1DkZjciQmBOVoaYsSXG6UV0u/tvXuzcwCMCIhiaG7GlE3C4vehQ==", "+905398815246", true, "/userImages/defaultUser.png", "d14dff35-e57a-49b3-bdd7-acf1b0e89df1", false, "nazliAdmin" },
                    { 3, "-", 0, "a3f83511-a873-40ac-ba51-9181b05d92f4", "sema@gmail.com", true, "Sema", "Fokus", "-", "https://twitter.com/adminuser", false, null, "SEMA@GMAIL.COM", "SEMA", "AQAAAAEAACcQAAAAEIJ05f35uiHblulB26dWtmE4y37DiHnuWiwdamZfQ7Lg8sDisrO1gFuOmTaS/K0WBA==", "+905071273567", true, "/userImages/defaultUser.png", "e57ce0dd-4035-41f5-8d81-c1b9eeac9318", false, "sema" },
                    { 4, "Geliştirici", 0, "103e855b-6b8c-4a73-85fe-2439a2f0f95e", "x@gmail.com", true, "Bedirhan", "Dev", "Gündöner", "-", false, null, "X@GMAIL.COM", "DEV", "AQAAAAEAACcQAAAAEGivRhfHtdAWt1F57N2+vOrLVyVAPEkOerL0zV1RWqbWVz1MAs821Aqpo+QETC8cAA==", "+905050102249", true, "/userImages/defaultUser.png", "e724a2cc-7fa6-45a4-92a6-5398297b2d7f", false, "dev" },
                    { 5, "-", 0, "9410f3ff-1609-4e88-9100-227d36d2c52a", "berra@gmail.com", true, "Berra", "Ases", "-", "-", false, null, "BERRA@GMAIL.COM", "BERRA", "AQAAAAEAACcQAAAAEBWZaQyrhVEbBFlM3VhhJeOsVDk2YhpMUwPHNrVCIXQ+c/qTMlO63xVogelljN3dYQ==", "+905050102249", true, "/userImages/defaultUser.png", "6ee50f32-4d1c-41f8-8317-7c6bea6bbfaf", false, "berra" },
                    { 6, "-", 0, "d0cdc640-dfa4-417a-9302-4bc31742782e", "Elif@gmail.com", true, "Elif", "Ases", "-", "-", false, null, "ELIF@GMAIL.COM", "ELIF", "AQAAAAEAACcQAAAAEF/UVDA3wpWCxO3zbTle7jidMZdBY7iD6KHseMenyq2T8rCrQqac0BIBc6OvxetjQw==", "+905050102249", true, "/userImages/defaultUser.png", "c9ff014d-3519-4711-ae7f-eba5ee4c815e", false, "Elif" },
                    { 7, "Admin | Bilal", 0, "4a61469b-d090-435d-812a-833653d2e55e", "esmaAdmin@gmail.com", true, "Bilal", "Ases", "Meto", "-", false, null, "ESMAADMIN@GMAIL.COM", "ESMAADMIN", "AQAAAAEAACcQAAAAEMGLIf4IAhEre1F0iGPtyOiIGCEE8D0chnE9Y3Pw+hOvRz3rjcHFYVTFYN9+VpHnSg==", "+905537314131", true, "/userImages/defaultUser.png", "4c77131e-1ed1-4b20-974d-0e944b1da46b", false, "esmaAdmin" },
                    { 8, "Admin | Nazlı", 0, "50abdb20-6707-4026-8e04-33adc1c64ea6", "asiyeAdmin@gmail.com", true, "Nazlı", "Ases", "-", "-", false, null, "ASIYEADMIN@GMAIL.COM", "ASIYEADMIN", "AQAAAAEAACcQAAAAEHApVVd0Ht6LSCaal9T5CvPkaHNDbBxtZKqKZG+WjWEKjT4afeXCIzKjL7sPb5bMMw==", "+905398815246", true, "/userImages/defaultUser.png", "0c7a0b8a-5c1d-403b-a60b-d166e02f0bd0", false, "asiyeAdmin" },
                    { 9, "-", 0, "04d99e96-b7cd-4d34-968b-9dc98b6f4d07", "gulistan@gmail.com", true, "Sema", "Ases", "-", "https://twitter.com/adminuser", false, null, "GULISTAN@GMAIL.COM", "GULISTAN", "AQAAAAEAACcQAAAAEM9P/Kc+5+gn+kv6YwVrLdlp0tGunRv/WFYZmF8EmL5hNAemQMLkgXcRUtL3dUL/3A==", "+905071273567", true, "/userImages/defaultUser.png", "c60b2a2e-f2fb-4116-8543-7ff4e5dad304", false, "gulistan" },
                    { 10, "-", 0, "3f55651d-5b01-4d80-8080-5ac8286b8267", "yeliz@gmail.com", true, "Yeliz", "Ases", "Kılıç", "https://twitter.com/adminuser", false, null, "YELIZ@GMAIL.COM", "YELIZ", "AQAAAAEAACcQAAAAEH3Ji11py7VWlIZV3r/gBkFrQEu2NLvibqcKUZK5M7UmJR26AmhmyX32CK4s/gpgMw==", "+905555555555", true, "/userImages/defaultUser.png", "17587d35-694a-4a6a-b1d5-26032b573f79", false, "yeliz" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8803), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8805), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8810), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8812), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8815), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8816), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8821), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8825), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8830), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8833), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8836), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8837), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8839), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8840), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8842), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8843), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8845), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8846), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8848), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 474, DateTimeKind.Local).AddTicks(8849), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8765), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8766), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8767), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8767), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8768), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8768), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8769), "Akbank Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8770), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8770), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8771), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8771), "Sivasot Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8772), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8772), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8773), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReferances",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceTitleId", "Description", "FirstName", "FromWhere", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "TC" },
                values: new object[] { 1, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(3907), 1, "Description", "Sema", null, true, false, "Gündöner", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(3907), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "StartDate", "TC" },
                values: new object[] { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2918), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(2919), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(377), "Model Açıklaması", true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(378), null, 1, "Model Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8017), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8017), 5, "EmployeeProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8020), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8021), 5, "UserModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8023), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8023), 7, "StockModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8054), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8055), 6, "CustomerReferanceModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8057), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8057), 1, "AppointmentModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8059), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8060), 1, "NotificationModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8061), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8062), 3, "PaymentProgram.Read", null },
                    { 8, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8064), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8064), 2, "CustomerProgram.Read", null },
                    { 9, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8066), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8066), 7, "BrandModule.Read", null },
                    { 10, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8068), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8069), 3, "SaleModule.Read", null },
                    { 11, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8070), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8071), 7, "ProductProgram.Read", null },
                    { 12, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8072), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8073), 5, "RoleModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(336), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(337), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(339), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(340), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(342), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(343), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(346), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(347), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(348), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(349), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(351), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(351), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(353), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(353), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(355), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(356), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(357), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(358), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(360), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(360), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[] { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 11, 17, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(2338), "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(2334), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(2335), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[] { 1, 1000m, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(1863), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(1864), null, 1 });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8460), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8460), "User.Create", null, 2 },
                    { 11, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8462), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8463), "User.Read", null, 2 },
                    { 12, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8465), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8465), "User.Update", null, 2 },
                    { 13, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8467), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8468), "User.Delete", null, 2 },
                    { 14, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8469), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8470), "Role.Read", null, 2 },
                    { 15, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8471), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8472), "Role.Update", null, 2 },
                    { 16, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8474), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8474), "Role.Delete", null, 2 },
                    { 17, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8476), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8476), "Role.Create", null, 2 },
                    { 37, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8478), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8478), "Payment.Create", null, 7 },
                    { 38, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8480), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8481), "Payment.Read", null, 7 },
                    { 39, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8482), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8483), "Payment.Update", null, 7 },
                    { 40, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8484), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8485), "Payment.Delete", null, 7 },
                    { 41, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8486), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8487), "PaymentType.Create", null, 7 },
                    { 42, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8489), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8489), "PaymentType.Read", null, 7 },
                    { 43, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8491), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8491), "PaymentType.Update", null, 7 },
                    { 44, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8523), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8524), "PaymentType.Delete", null, 7 },
                    { 45, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8526), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8526), "Employee.Create", null, 1 },
                    { 46, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8528), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8528), "Employee.Read", null, 1 },
                    { 47, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8530), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8531), "Employee.Update", null, 1 },
                    { 48, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8532), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8533), "Employee.Delete", null, 1 },
                    { 49, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8534), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8535), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8537), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8538), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8540), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8540), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8542), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8542), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8544), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8544), "Customer.Create", null, 8 },
                    { 54, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8546), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8547), "Customer.Read", null, 8 },
                    { 55, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8548), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8549), "Customer.Update", null, 8 },
                    { 56, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8550), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8551), "Customer.Delete", null, 8 },
                    { 57, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8552), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8553), "CustomerType.Create", null, 8 },
                    { 58, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8554), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8555), "CustomerType.Read", null, 8 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 59, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8557), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8557), "CustomerType.Update", null, 8 },
                    { 60, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8559), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8559), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8561), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8561), "Notification.Create", null, 6 },
                    { 62, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8563), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8563), "Notification.Read", null, 6 },
                    { 63, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8565), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8566), "Notification.Update", null, 6 },
                    { 64, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8567), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8568), "Notification.Delete", null, 6 },
                    { 65, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8569), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8570), "Brand.Create", null, 9 },
                    { 66, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8572), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8572), "Brand.Update", null, 9 },
                    { 67, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8574), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8574), "Brand.Delete", null, 9 },
                    { 68, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8578), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8578), "Brand.Delete", null, 9 },
                    { 69, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8580), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8580), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8582), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8583), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8584), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8585), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8586), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8587), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8588), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8589), "SaleType.Create", null, 10 },
                    { 74, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8591), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8591), "SaleType.Read", null, 10 },
                    { 75, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8593), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8593), "SaleType.Update", null, 10 },
                    { 76, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8595), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8595), "SaleType.Delete", null, 10 },
                    { 77, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8597), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8597), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8599), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8600), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8601), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8602), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8603), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8604), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8605), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8606), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8607), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8608), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8610), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8610), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8612), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8612), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8576), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8576), "Brand.Read", null, 9 },
                    { 89, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8614), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8614), "AppointmentType.Create", null, 5 },
                    { 90, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8616), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8616), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8618), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8619), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8620), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8621), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8622), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8623), "Sale.Create", null, 10 },
                    { 94, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8624), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8625), "Sale.Read", null, 10 },
                    { 95, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8626), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8627), "Sale.Update", null, 10 },
                    { 96, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8628), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8629), "Sale.Delete", null, 10 },
                    { 97, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8631), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8631), "Product.Create", null, 11 },
                    { 98, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8633), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8633), "Product.Read", null, 1 },
                    { 99, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8635), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8635), "Product.Update", null, 11 },
                    { 100, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8637), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8637), "Product.Delete", null, 11 },
                    { 101, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8639), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8640), "Appointment.Create", null, 5 },
                    { 102, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8641), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8642), "Appointment.Read", null, 5 },
                    { 103, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8643), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8644), "Appointment.Update", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[] { 104, null, null, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8645), true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 491, DateTimeKind.Local).AddTicks(8646), "Appointment.Delete", null, 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(9223), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(9224), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6296), 1, "TEST", null, true, false, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6297), null, "Reminder", new DateTime(2023, 11, 16, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6300), "Title", 1 },
                    { 2, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6309), 1, "Doğum günü yaklaşmakta.", null, true, false, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6310), null, "Reminder", new DateTime(2023, 11, 15, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6311), "Doğum Günü!", 2 },
                    { 3, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6313), 1, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6314), null, "Reminder", new DateTime(2023, 11, 14, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(6315), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[] { 1, 1m, null, 1, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(575), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 11, 13, 1, 2, 7, 490, DateTimeKind.Local).AddTicks(576), null, 1, null });

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
                name: "IX_CustomerReferances_CustomerReferanceTitleId",
                table: "CustomerReferances",
                column: "CustomerReferanceTitleId");

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
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

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
                name: "IX_Product_ModelId",
                table: "Product",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSubGroupId",
                table: "Product",
                column: "ProductSubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubModelId",
                table: "Product",
                column: "SubModelId");

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
                unique: true);

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
                name: "IX_SubModels_ModelId",
                table: "SubModels",
                column: "ModelId");

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
                name: "MessageToDevelopers");

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
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductSubGroups");

            migrationBuilder.DropTable(
                name: "SubModels");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "CustomerReferanceTitles");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
