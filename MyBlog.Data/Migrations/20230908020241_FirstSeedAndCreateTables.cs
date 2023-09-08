using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class FirstSeedAndCreateTables : Migration
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
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: false),
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
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(9388), "Test", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(9388), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(9391), "Test", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(9392), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8960), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8960), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4623), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4623), "C#", "C# Blog Kategorisi" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4626), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4626), "C++", "C++ Blog Kategorisi" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4628), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4629), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4631), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4631), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4633), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4634), "Java", "Java Blog Kategorisi" },
                    { 6, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4637), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4638), "Python", "Python Blog Kategorisi" },
                    { 7, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4641), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4641), "Php", "Php Blog Kategorisi" },
                    { 8, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4643), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4643), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4645), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4645), "Swift", "Swift Blog Kategorisi" },
                    { 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4647), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(4648), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "Action", "DateTime", "NewValues", "OldValues", "TableName" },
                values: new object[] { 1, "act Manuel", null, null, null, null });

            migrationBuilder.InsertData(
                table: "CustomerReferanceTitles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(7406), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(7407), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Referans Unvan 1" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(7409), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(7410), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Referans Unvan 2" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8969), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8969), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8972), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8972), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 2" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8974), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8974), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8510), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8510), "Not", "Title" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8512), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8513), "Not", "Title" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8514), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8514), "Not", "Title" },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8516), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8517), "Not", "Title" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CreatedByName", "CreatedDate", "IsActive", "IsDaily", "IsDeleted", "IsIncome", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 100, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7432), true, true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7434), "TEST" },
                    { 2, 122, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7436), true, true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7437), "TEST" },
                    { 3, 21, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7439), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7440), "TEST" },
                    { 4, 341, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7441), true, false, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7442), "TEST" },
                    { 5, 422, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7444), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7444), "TEST" },
                    { 6, 122, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7446), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7446), "TEST" },
                    { 7, 322, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7448), true, true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7449), "TEST" },
                    { 8, 422, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7450), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7451), "TEST" },
                    { 9, 522, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7453), true, true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7453), "TEST" },
                    { 10, 122, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7455), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7455), "TEST" },
                    { 11, 232, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7457), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7457), "TEST" },
                    { 12, 122, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7459), true, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7460), "TEST" },
                    { 13, 222, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7461), true, false, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7462), "TEST" },
                    { 14, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7463), true, false, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7464), "TEST" },
                    { 15, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7466), true, false, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7466), "TEST" },
                    { 16, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7468), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7468), "TEST" },
                    { 17, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7470), true, true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7470), "TEST" },
                    { 18, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7472), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7472), "TEST" },
                    { 19, 22, "Test Verisi", new DateTime(2023, 8, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7474), true, false, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7475), "TEST" }
                });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 9, 13, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7864), true, false, false, "TEST", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7863), null, 3, "MessageToDeveloper Title Test" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 9, 13, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7867), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7867), null, 1, "MessageToDeveloper Title Test" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 9, 11, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7870), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7870), null, 4, "MessageToDeveloper Title Test" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6247), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6248), "AgendaProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6250), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6251), "CustomerModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6252), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6253), "RoleModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6255), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6255), "RoleModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6257), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6257), "RoleModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6259), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6259), "RoleModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6261), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6261), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[,]
                {
                    { 1, 0m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6965), 15000m, "TEST desc 1 ", new DateTime(2023, 9, 12, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6970), true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6966), null, "Ödemenin Yapılacağı yer" },
                    { 2, 0m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6974), 10000m, "TEST desc 1 ", new DateTime(2023, 9, 12, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6975), true, false, true, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6974), null, "Ödemenin Yapılacağı yer" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7649), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7649), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7650), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7651), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7652), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7652), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(9423), "Product Kategori 2 Açıkama", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(9424), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(9427), "Product Kategori 2 Açıkama", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(9427), "Product Kategori 2", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(1470), "Ürün Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(1471), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "616df0d9-023d-4ef1-81e8-e2b258f9a7ec", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 1, "f0f0c40d-b95f-4939-92f9-b24b02bae9ca", "Standart Kullanıcı Yetkisi", "DefaultUser", "DEFAULTUSER" },
                    { 3, 1, "2ace472a-64de-42af-9ed2-42d339a006e3", "Developer Yetkisi", "Developer", "DEVELOPER" },
                    { 4, 3, "6973e65e-69d2-44b5-973f-fb2d339c3fe7", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 5, 3, "964a13cc-e0b3-4002-96db-94e6352678a6", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 6, 3, "cceee166-f8a5-4f3d-a6d8-cefab3c449e9", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 7, 3, "687bf6a4-a4e7-4d82-b5da-6306b93cb893", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 8, 3, "87643896-fa37-4ed6-8fc2-d95d8e4163d2", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 9, 3, "fc4c5f3d-af4a-4b5b-b7fe-7a758f310336", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 10, 3, "8a5447a0-0603-43c2-adb8-47f0d26c5547", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" },
                    { 11, 3, "44c6d2bd-08f8-4d09-bff0-4c9f8f0b90c8", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 12, 3, "8b61d6a9-2de0-4d86-ae94-9d792d841071", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 13, 3, "bc31316b-54ff-4222-9bab-202988209ef0", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 14, 3, "1ff8a96a-42a3-418d-945e-2d8e4bd84280", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 15, 3, "316c8602-55d9-4ba6-9786-f37ac45d2dce", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 16, 3, "89529556-a652-4e65-b997-279821b4a704", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 17, 3, "214b8b16-595d-4fe5-9889-4f77bdb34689", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 18, 3, "e1145db9-5633-4381-ae14-2cbb336b05da", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 19, 3, "a36f3c1b-0464-458c-b78c-623781290b4c", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 20, 3, "2e350f69-37f8-4b7f-b231-21c68f481766", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 21, 3, "05916cc4-3a41-48ed-8cef-0a9a50b0c675", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 22, 3, "ce316e47-e682-45a5-bd14-8a13f806a570", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 23, 3, "9bc3087b-0e4e-4735-8422-091171652b99", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 24, 3, "fde854c0-8f84-4fd7-9f20-d2fb7e83e705", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 25, 3, "e733da6a-1fb6-495b-9543-010389519e5a", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 26, 3, "53b17ad8-c985-4ada-9a39-fad12fc624ed", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 27, 3, "a916b32a-1ba8-4004-86b2-d7017aee56cc", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 28, 3, "5b40205d-ce65-4744-b19b-f467cea14410", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 29, 3, "ad6baf80-5cd9-4260-ad1e-a22a7dd7abf2", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 30, 3, "be9bb000-a409-40ff-ba93-c1b96ab343b2", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 31, 3, "75b9b879-ba04-4f7f-a29f-4d082de441d9", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 32, 3, "aa6e4a88-162b-4a29-9f1e-4e29f5e0c124", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 33, 3, "74f4c1cc-dd7e-45f4-9d48-9a1cef2bda04", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 34, 3, "156f426e-d5e4-4a30-8c8f-da32b28df63e", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 35, 3, "67e24c91-2b8c-4c19-ab65-3af1a97ff15c", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 36, 3, "a88f9a52-c59e-48c1-876b-ca9a3fd323bd", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 37, 3, "0f752b81-d8c1-4517-b750-133a22dc6e8c", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 38, 3, "2383a5ed-1d53-41a2-99d3-2bd125cc1a3a", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 39, 3, "8473067a-a8bb-4663-b53a-d95d58b3bd03", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 40, 3, "f31d09bd-fe4c-4a08-a73f-ee1d7aa78751", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 41, 3, "3c0fb971-0c3a-42f7-aae2-a723ec8797fe", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 42, 3, "dc8d135a-e913-4a88-a3a2-e2771fd62035", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 43, 3, "2eced17b-1b79-4562-bad8-bf814a970b30", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 44, 3, "5b9b1dcd-c948-42b2-a11f-4d45ef94bf4a", "Brand Ekleme Yetkisi", "MessageToDeveloper.Create", "MESSAGETODEVELOPER.CREATE" },
                    { 45, 3, "7bf62125-cdd3-4632-888c-ecb7c2c3a583", "Brand  Yetkisi", "MessageToDeveloper.Read", "MESSAGETODEVELOPER.READ" },
                    { 46, 3, "2fad91a6-ce1b-4a31-8c8e-d79fc64af4c7", "Brand  Yetkisi", "MessageToDeveloper.Update", "MESSAGETODEVELOPER.UPDATE" },
                    { 47, 3, "456a921b-706d-4bf7-828e-0eec6931c512", "Brand  Yetkisi", "MessageToDeveloper.Delete", "MESSAGETODEVELOPER.DELETE" },
                    { 48, 3, "11f2e11c-787b-41e5-b896-455c6d01f210", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 49, 3, "6a994637-6b26-4435-86ef-c73929e0c8e1", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 50, 3, "b62c4008-6b68-4061-88c0-9c5a2a3906fd", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 51, 3, "f8cea51c-568b-4be0-bf1e-017f8681ddb8", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 52, 3, "ca69d0ba-18ef-4e6a-9c14-100553ed9a6d", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" },
                    { 53, 3, "19a8acfd-9d9b-4324-a423-0bcdd669d043", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 54, 3, "ecd33469-934a-4652-89c0-c8540c85b1b8", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 55, 3, "bcac7cd3-c18b-43fa-a2d9-7be3ddf7f709", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 56, 3, "4508baa5-7b96-41a1-9360-13004ef5b8ec", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 57, 3, "05505671-758e-4152-8205-6e5dfe4482ff", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 58, 3, "426237b2-de35-49be-a522-f17d51e48a7f", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 59, 3, "eadb609e-6717-4af8-b5b3-100f4fe7c4e8", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 60, 3, "df86faa4-0698-447b-8774-ae3d9e9b86fb", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 61, 3, "d533aadb-9424-461f-8d94-f971ee14d330", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 62, 3, "a22dc3cf-93a4-4c55-ace0-99009f9961ac", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 63, 3, "a46d579f-abd6-4d0f-adac-9fd733a20a90", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 64, 3, "3d72b311-2c9c-4c25-89c3-da0e9ec01fc3", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 65, 3, "efe9b3af-64f8-469f-b2ad-1074b242c4de", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 66, 3, "317c16c0-b020-4399-952c-19a4f50fdb95", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 67, 3, "0e495cfa-efd6-428d-8e6f-68194a9aad92", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 68, 3, "0959f771-56d4-49fe-a7a4-5b4cacbece83", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 69, 3, "6dfe1ac4-2c75-4b03-b382-a052f7ef5606", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 70, 3, "c67e7d02-b287-490f-b4d5-f105600328a6", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 71, 3, "7814057f-7e17-4213-8dd4-e090deb97daf", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 72, 3, "312d8d1b-9274-41cb-8a8a-6c3e87435ccb", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 73, 3, "8152783f-4c40-4e4d-a8e2-0555bde2bafc", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 74, 3, "af1a0143-2f56-4679-8ec3-0a1887443ee8", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 75, 3, "c60b4b2a-e313-4fef-8383-8b9ccf25fb1d", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 76, 3, "55dccfdb-6d76-42ff-a3a9-2f429555f0b9", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 77, 3, "845b248d-f545-4d91-9302-0034c4ab2c97", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 78, 3, "63d827b1-9e89-459e-a8d4-31272d42e50e", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 79, 3, "2851ea02-f432-4265-8407-162608a7a3da", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 80, 3, "7f3cf96d-bce3-4964-8a35-1ad6b30c1c92", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 81, 3, "c06ec2ea-50fb-43e7-b98b-a0543ac3cac8", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 82, 3, "d28255cb-cde8-45ab-88cb-d273221c9a9d", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 83, 3, "beb163f6-8c04-4518-97a1-49695a59fcf7", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 84, 3, "14fe9d36-4be5-4ed3-adf0-ac9754a92ca8", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 85, 3, "c3243c40-9ade-4227-a5da-e017d75ee3d9", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 86, 3, "9187c576-a3e4-4344-9f31-841f8bba4635", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 87, 3, "f581445e-b49d-4158-998e-d0744657d841", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 88, 2, "e4525751-597a-412b-ae6d-a17aa4d300bc", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 89, 2, "6b8aec11-42e7-4b7e-9a80-0ad23502c9f2", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 90, 2, "62f06657-a347-42fd-ace8-e8d123e12ddc", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 91, 2, "4b47b5b6-a7d9-493b-be01-628eece89baf", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 92, 2, "cd800a14-236e-4f95-9b38-bff188db2552", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 93, 2, "e8f07295-361d-4fe3-9179-03cf5d6b5e77", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 94, 2, "610ca5aa-47d4-4ba5-8b5f-9c8fdf9ff51b", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" },
                    { 95, 2, "dcd6fe23-561a-4642-a830-672a978d17d8", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" },
                    { 96, 1, "e3fd429a-c960-4431-8afe-65706b0c0e42", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 97, 1, "0b5852b9-5c3a-441d-b670-7ba87f3776df", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 98, 1, "09ae110c-d178-46ba-8358-479f15d47d73", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 99, 1, "acbd5130-1a40-40c2-82d0-05781525bd0a", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 100, 1, "4cde6887-802f-4016-945f-28bb0d1dc209", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 101, 1, "ad8b5f02-80aa-4330-bcbf-9e8f0b06bb7d", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 102, 1, "3f97f965-dd33-42c9-a8f8-d6f486a57a8f", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 103, 1, "5cc8cb54-e8ae-4cb4-93f8-5b7e76e0083d", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 104, 1, "e50332ad-12df-4d63-a273-50c7f09aff66", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 105, 1, "1f617636-2d00-43f6-bdc5-d51856df0ec1", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 106, 1, "2830553b-40bd-4b6f-9873-0c6b1aeda87e", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 107, 1, "360fd0cc-d62e-472e-8027-72a0971c631d", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 108, 1, "28e5363f-9e34-45fa-b717-3e027c20aeb5", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 109, 1, "6524d4ce-a2c6-4c6d-a432-2e4d16f83243", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 110, 1, "e379fff5-d441-4746-9312-bc3b2e462fcd", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 111, 1, "75026495-a41f-4a2c-b6b9-573d538deb98", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 112, 1, "52714ce1-ab12-43f0-9734-c939eca1be3a", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 113, 1, "d4b9b9e3-d3d9-4e64-92f9-d48bc53cbd6a", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 114, 1, "3b25f32f-fefa-473b-90c6-b5ecf110c6ed", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2809), "açıklama deneme status sale 1", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2809), null, "Satış Aşamasında" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2811), "açıklama deneme status sale 1", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2812), null, "Satıldı" }
                });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5692), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5693), null, "Nakit" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5697), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5697), null, "Kart" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5699), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5700), null, "Çek" },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5701), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5702), null, "Senet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Institution", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin | Bilal", 0, "7afe39dc-fb46-4ad4-83ed-fc02ae9ec6fa", "bilalAdmin@gmail.com", true, "Bilal", "Fokus", "Meto", "-", false, null, "BILALADMIN@GMAIL.COM", "BILALADMIN", "AQAAAAEAACcQAAAAED0nVN2OU0XEFKlQ2QhMPryter3EbCpj7fNGH0Wb1WJjLXDRsJFwkvYHCqZIOAudcg==", "+905537314131", true, "/userImages/defaultUser.png", "1198965e-b6a0-4a7a-b33b-67ace81ea220", false, "bilalAdmin" },
                    { 2, "Admin | Nazlı", 0, "a78957b5-7ada-49b2-b43f-e229f918b100", "nazliAdmin@gmail.com", true, "Nazlı", "Fokus", "-", "-", false, null, "NAZLIADMIN@GMAIL.COM", "NAZLIADMIN", "AQAAAAEAACcQAAAAECaU1MS0CnH3G0/VahXaUzMZKimM/iuGnTnnubWAr/P7FKdXqrYE2ey/PmSy2jMVag==", "+905398815246", true, "/userImages/defaultUser.png", "0086f404-21c7-4c1a-8aa2-b6d5a3d36a2d", false, "nazliAdmin" },
                    { 3, "-", 0, "48370760-79b2-487e-881a-e349c4bd8206", "sema@gmail.com", true, "Sema", "Fokus", "-", "https://twitter.com/adminuser", false, null, "SEMA@GMAIL.COM", "SEMA", "AQAAAAEAACcQAAAAEDEKEpXMU/JQOzuyLo3oAkUbayy58dys/EzNydHikWvMlqoSQjTowbSQxUsDQVfljQ==", "+905071273567", true, "/userImages/defaultUser.png", "97005f51-5ad5-4051-a796-17a81856fe40", false, "sema" },
                    { 4, "Geliştirici", 0, "b667878a-d83b-4ada-a4a2-3bd3fba87e60", "x@gmail.com", true, "Bedirhan", "Dev", "Gündöner", "-", false, null, "X@GMAIL.COM", "DEV", "AQAAAAEAACcQAAAAELKAKMLHOZheG3srSKiw9WGZC18v73l5vdwmYp9YAYcfUb6viZ+cIM1wjzbauHya6A==", "+905050102249", true, "/userImages/defaultUser.png", "e8975b8b-abed-4c4f-ba9f-f91f788c1cd7", false, "dev" },
                    { 5, "-", 0, "08f739b1-55d3-4d16-8539-14ab74a258aa", "berra@gmail.com", true, "Berra", "Ases", "-", "-", false, null, "BERRA@GMAIL.COM", "BERRA", "AQAAAAEAACcQAAAAECM/5lo9j3CzG31hgpn4rzNkbs9ObyA2FmlSWA6N5q3ZiDTsE0GmSRJxyWa6mnt2Vg==", "+905050102249", true, "/userImages/defaultUser.png", "db750c31-c2f5-4198-b8c9-9c5ecd0fca12", false, "berra" },
                    { 6, "-", 0, "7753b552-de01-48cc-b39a-19dcdf0fa4ab", "Elif@gmail.com", true, "Elif", "Ases", "-", "-", false, null, "ELIF@GMAIL.COM", "ELIF", "AQAAAAEAACcQAAAAEN26Fdy9kUb5Q1rVNPUo1Dl9aa0i3GS3RfgU/OGD7sAAn4kn1BGC3xXVNwpm2BbU1A==", "+905050102249", true, "/userImages/defaultUser.png", "b23a26f9-a336-4aeb-bd41-00cd84cae22c", false, "Elif" },
                    { 7, "Admin | Bilal", 0, "85d0b58f-2abd-41c8-9345-a34ed5127e31", "esmaAdmin@gmail.com", true, "Bilal", "Ases", "Meto", "-", false, null, "ESMAADMIN@GMAIL.COM", "ESMAADMIN", "AQAAAAEAACcQAAAAEJ9Vo+j1NoqByHx1kaCGRa/mIfSiQ4e3fmqhUvgl7JRG06MXMRT7M9Ql1WBOgPfoIQ==", "+905537314131", true, "/userImages/defaultUser.png", "3f64267c-b945-4cb1-b95e-2ce1bd8f9f39", false, "esmaAdmin" },
                    { 8, "Admin | Nazlı", 0, "31753705-f5c7-4d18-a5d3-68a0f81e34c2", "asiyeAdmin@gmail.com", true, "Nazlı", "Ases", "-", "-", false, null, "ASIYEADMIN@GMAIL.COM", "ASIYEADMIN", "AQAAAAEAACcQAAAAEJ5arlZy7OQQwxM0I+jKQzAZVUVbTKs7/i05lHZVGa5srMeoWfzR3kwJhL2MnUhRWg==", "+905398815246", true, "/userImages/defaultUser.png", "c6bb733a-3ab5-4a78-bb89-671b0120096d", false, "asiyeAdmin" },
                    { 9, "-", 0, "aa6f44eb-49d5-4a2f-b7c6-ad00204c37fc", "gulistan@gmail.com", true, "Sema", "Ases", "-", "https://twitter.com/adminuser", false, null, "GULISTAN@GMAIL.COM", "GULISTAN", "AQAAAAEAACcQAAAAEKE+Klohd0MtwQBcLdyYv1l+PG7WsT1qGH80Jnj6CBTHbzSjKIBBxEgd3JmcN4oqXQ==", "+905071273567", true, "/userImages/defaultUser.png", "15a8f22a-fbc9-48f0-8b96-07abb226d7f6", false, "gulistan" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3940), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3942), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3946), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3948), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3951), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3952), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3954), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3955), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3958), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3957), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3958), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3960), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3961), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3963), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3964), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3966), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3967), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3969), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3970), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3972), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(3973), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7334), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7335), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7336), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7337), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7338), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7338), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7338), "Akbank Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7339), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7339), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7340), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7340), "Sivasot Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7341), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7341), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7342), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReferances",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceTitleId", "Description", "FirstName", "FromWhere", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "TC" },
                values: new object[,]
                {
                    { 1, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8536), 2, "Description", "Sema", null, true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8537), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249", null },
                    { 2, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8542), 2, "Description", "Sema", null, true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(8543), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "StartDate", "TC" },
                values: new object[,]
                {
                    { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8420), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8421), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" },
                    { 2, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8424), null, 1, "Ikinci Personel", true, false, "User", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8424), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" },
                    { 3, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8426), null, 1, "Ucuncu perosnel", true, false, "User", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(8427), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2359), "Ürün Alt Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(2360), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6633), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6633), 5, "EmployeeProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6636), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6637), 5, "UserModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6638), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6639), 7, "StockModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6640), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6641), 6, "CustomerReferanceModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6642), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6643), 1, "AppointmentModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6645), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6645), 1, "NotificationModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6647), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6647), 3, "PaymentProgram.Read", null },
                    { 8, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6649), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6649), 2, "CustomerProgram.Read", null },
                    { 9, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6651), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6651), 7, "BrandModule.Read", null },
                    { 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6653), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6653), 3, "SaleModule.Read", null },
                    { 11, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6655), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6655), 7, "ProductProgram.Read", null },
                    { 12, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6657), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(6657), 5, "RoleModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5384), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5385), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5387), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5388), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5390), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5390), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5393), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5393), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5396), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5397), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5400), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5401), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5404), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5405), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5406), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5407), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5409), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5410), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5411), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(5412), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[,]
                {
                    { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 12, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6954), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6947), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6948), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 2, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 13, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6962), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6960), 1, 2, "hasta2@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6960), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 3, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 14, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6966), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6964), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6965), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 4, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 15, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6969), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6968), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6968), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 5, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 16, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6973), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6971), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6972), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 6, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 17, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6976), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6974), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6975), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" },
                    { 7, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 18, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6979), "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6978), 2, 3, "hasta3@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 765, DateTimeKind.Local).AddTicks(6978), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" }
                });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[,]
                {
                    { 1, 1000m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7570), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7570), null, 1 },
                    { 2, 2000m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7574), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7574), null, 1 },
                    { 3, 1500m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7576), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7577), null, 1 },
                    { 4, 2300m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7579), "TEST desc 1 ", 2, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7579), null, 2 },
                    { 5, 1450m, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7581), "TEST desc 1 ", 2, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(7581), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsMultiple", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(652), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(653), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" },
                    { 2, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(656), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(656), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Jabra Signia", 1, 10, "A12BO9930HT3" },
                    { 3, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(659), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(659), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Apple Signia Motion 1PX", 1, 10, "A12BO9930HT2" },
                    { 4, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(661), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(662), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Samsung Signia Motion 1PX", 1, 10, "A12BO9930HT1" }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7071), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7071), "User.Create", null, 2 },
                    { 11, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7073), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7074), "User.Read", null, 2 },
                    { 12, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7076), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7076), "User.Update", null, 2 },
                    { 13, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7078), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7078), "User.Delete", null, 2 },
                    { 14, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7080), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7081), "Role.Read", null, 2 },
                    { 15, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7082), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7083), "Role.Update", null, 2 },
                    { 16, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7084), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7085), "Role.Delete", null, 2 },
                    { 17, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7086), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7087), "Role.Create", null, 2 },
                    { 37, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7088), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7089), "Payment.Create", null, 7 },
                    { 38, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7090), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7091), "Payment.Read", null, 7 },
                    { 39, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7093), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7093), "Payment.Update", null, 7 },
                    { 40, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7095), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7095), "Payment.Delete", null, 7 },
                    { 41, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7097), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7097), "PaymentType.Create", null, 7 },
                    { 42, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7099), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7099), "PaymentType.Read", null, 7 },
                    { 43, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7101), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7101), "PaymentType.Update", null, 7 },
                    { 44, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7103), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7103), "PaymentType.Delete", null, 7 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 45, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7105), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7105), "Employee.Create", null, 1 },
                    { 46, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7107), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7107), "Employee.Read", null, 1 },
                    { 47, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7109), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7109), "Employee.Update", null, 1 },
                    { 48, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7111), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7112), "Employee.Delete", null, 1 },
                    { 49, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7113), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7114), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7115), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7116), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7117), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7118), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7119), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7120), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7121), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7122), "Customer.Create", null, 8 },
                    { 54, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7123), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7124), "Customer.Read", null, 8 },
                    { 55, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7126), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7126), "Customer.Update", null, 8 },
                    { 56, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7128), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7128), "Customer.Delete", null, 8 },
                    { 57, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7130), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7130), "CustomerType.Create", null, 8 },
                    { 58, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7132), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7132), "CustomerType.Read", null, 8 },
                    { 59, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7134), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7134), "CustomerType.Update", null, 8 },
                    { 60, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7136), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7136), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7138), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7138), "Notification.Create", null, 6 },
                    { 62, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7140), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7141), "Notification.Read", null, 6 },
                    { 63, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7142), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7143), "Notification.Update", null, 6 },
                    { 64, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7144), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7145), "Notification.Delete", null, 6 },
                    { 65, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7146), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7147), "Brand.Create", null, 9 },
                    { 66, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7148), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7149), "Brand.Update", null, 9 },
                    { 67, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7150), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7151), "Brand.Delete", null, 9 },
                    { 68, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7154), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7155), "Brand.Delete", null, 9 },
                    { 69, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7156), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7157), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7158), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7159), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7160), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7161), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7162), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7163), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7164), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7165), "SaleType.Create", null, 10 },
                    { 74, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7166), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7167), "SaleType.Read", null, 10 },
                    { 75, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7168), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7169), "SaleType.Update", null, 10 },
                    { 76, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7170), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7171), "SaleType.Delete", null, 10 },
                    { 77, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7172), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7173), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7174), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7175), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7176), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7177), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7178), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7179), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7180), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7181), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7182), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7183), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7184), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7185), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7186), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7186), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7152), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7153), "Brand.Read", null, 9 },
                    { 89, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7189), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7189), "AppointmentType.Create", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 90, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7191), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7191), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7216), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7216), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7218), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7218), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7220), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7220), "Sale.Create", null, 10 },
                    { 94, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7222), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7222), "Sale.Read", null, 10 },
                    { 95, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7224), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7224), "Sale.Update", null, 10 },
                    { 96, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7226), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7227), "Sale.Delete", null, 10 },
                    { 97, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7228), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7229), "Product.Create", null, 11 },
                    { 98, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7230), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7231), "Product.Read", null, 1 },
                    { 99, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7232), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7233), "Product.Update", null, 11 },
                    { 100, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7234), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7235), "Product.Delete", null, 11 },
                    { 101, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7236), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7237), "Appointment.Create", null, 5 },
                    { 102, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7238), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7239), "Appointment.Read", null, 5 },
                    { 103, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7240), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7240), "Appointment.Update", null, 5 },
                    { 104, null, null, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7242), true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(7242), "Appointment.Delete", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3248), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3249), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 2, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3255), 2, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama", 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3255), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null },
                    { 3, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3257), 3, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama3", 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(3258), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(857), 1, "TEST", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(857), null, "Reminder", new DateTime(2023, 9, 11, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(861), "Title", 1 },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(866), 2, "Doğum günü yaklaşmakta.", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(867), null, "Reminder", new DateTime(2023, 9, 10, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(868), "Doğum Günü!", 2 },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(870), 3, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(870), null, "Reminder", new DateTime(2023, 9, 9, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(871), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[,]
                {
                    { 1, 1m, null, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6273), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6274), null, 1, null },
                    { 2, 1m, null, 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6280), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6281), null, 1, null },
                    { 3, 1m, null, 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6283), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6283), null, 1, null },
                    { 4, 1m, null, 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6285), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6286), null, 1, null },
                    { 5, 1m, null, 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6288), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6288), null, 1, null },
                    { 6, 1m, null, 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6290), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6291), null, 1, null },
                    { 7, 1m, null, 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6292), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 777, DateTimeKind.Local).AddTicks(6293), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[,]
                {
                    { 1, 500, 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5108), 1, 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5109), null, 1, 1, 1 },
                    { 2, 200, 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5113), 1, 2, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5114), null, 2, 1, 1 },
                    { 3, 500, 10, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5116), 1, 2, true, false, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 778, DateTimeKind.Local).AddTicks(5117), null, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1406), 0, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1407), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 },
                    { 2, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1409), 0, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1410), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 2, 20 },
                    { 3, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1412), 0, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1413), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 3, 20 },
                    { 4, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1414), 0, true, false, "Test Verisi", new DateTime(2023, 9, 8, 5, 2, 40, 766, DateTimeKind.Local).AddTicks(1415), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 4, 20 }
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
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductSubGroups");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "CustomerReferanceTitles");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "ProductGroups");
        }
    }
}
