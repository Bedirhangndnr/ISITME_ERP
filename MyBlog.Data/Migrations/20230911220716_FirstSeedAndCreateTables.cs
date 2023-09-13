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
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(980), "Test", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(981), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(436), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(437), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5400), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5401), "C#", "C# Blog Kategorisi" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5403), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5404), "C++", "C++ Blog Kategorisi" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5406), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5407), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5408), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5409), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5411), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5414), "Java", "Java Blog Kategorisi" },
                    { 6, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5416), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5416), "Python", "Python Blog Kategorisi" },
                    { 7, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5418), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5419), "Php", "Php Blog Kategorisi" },
                    { 8, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5421), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5421), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5423), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5424), "Swift", "Swift Blog Kategorisi" },
                    { 10, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5426), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(5426), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "Action", "DateTime", "NewValues", "OldValues", "TableName" },
                values: new object[] { 1, "act Manuel", null, null, null, null });

            migrationBuilder.InsertData(
                table: "CustomerReferanceTitles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(4555), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(4557), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Referans Unvan 1" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(7044), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(7045), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(9936), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(9937), "Not", "Title" });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 9, 17, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(256), true, false, false, "TEST", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(255), null, 3, "MessageToDeveloper Title Test" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 9, 17, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(260), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(259), null, 1, "MessageToDeveloper Title Test" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 9, 15, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(263), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 469, DateTimeKind.Local).AddTicks(263), null, 4, "MessageToDeveloper Title Test" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8353), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8353), "AgendaProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8359), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8360), "CustomerModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8365), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8367), "RoleModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8370), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8371), "RoleModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8372), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8373), "RoleModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8374), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8375), "RoleModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8376), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8377), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[] { 1, 0m, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(7949), 15000m, "TEST desc 1 ", new DateTime(2023, 9, 16, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(7956), true, false, true, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(7950), null, "Ödemenin Yapılacağı yer" });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8848), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8849), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8850), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8851), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8852), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8852), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(7827), "Product Kategori 2 Açıkama", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(7828), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(3141), "Ürün Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(3142), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "536ba64a-3cbb-4972-935d-880ae5c9154e", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 1, "c44e103b-65a3-4376-949a-d8e6f25f95f3", "Standart Kullanıcı Yetkisi", "DefaultUser", "DEFAULTUSER" },
                    { 3, 1, "6609e8cf-e7ef-4e8e-b596-cc0b1868e1de", "Developer Yetkisi", "Developer", "DEVELOPER" },
                    { 4, 3, "f968c9e4-6f5f-4c22-86ac-426a871c0172", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 5, 3, "009ea783-9513-47b3-8969-a32cf1166a33", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 6, 3, "0281696a-5875-4b1f-807e-520bd3e093f6", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 7, 3, "120349d1-d3c6-4a4d-9aaf-7a161373263e", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 8, 3, "f6d0f86b-010a-4aae-bb50-6e95b85687f6", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 9, 3, "8d2edaba-1de2-4417-9521-900fde865914", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 10, 3, "9b59de2d-3933-4ac5-bdeb-21180b5e796c", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 11, 3, "680d7c82-de3e-4694-9ffa-e64083194172", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 12, 3, "4163c8f2-613c-4db8-a582-94900db9e76e", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 13, 3, "6681c96f-6a23-4790-a62f-9e63e1d88189", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 14, 3, "6ab0871d-2810-4ac9-925c-fc7319c1d160", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 15, 3, "6050df81-09bb-4fb8-aa40-2c1705fcce58", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 16, 3, "fb34aed7-64b9-4f7b-99be-f7bc453ceaeb", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 17, 3, "678be7ee-516b-41c5-abf2-134249d74656", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 18, 3, "2d805848-9fb1-4aa8-80f1-ff0c1f3f48d4", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 19, 3, "56ab5f81-20ed-440f-a739-ec98aa15c0e1", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 20, 3, "6961cdc6-ce17-4d25-b6c6-c7b11d5c0ed9", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 21, 3, "94354b05-78d9-4c49-ad38-fef039c6933a", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 22, 3, "dc2b22de-5dec-4f6d-8f3f-8731486a9209", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 23, 3, "6ad02e5e-ddd0-46d9-a125-4dee45744a9b", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 24, 3, "5b16afdd-1260-47ef-b10b-0b91f5d5a399", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 25, 3, "a5001010-f457-4b13-97a6-519eba3d3a2d", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 26, 3, "72e94566-aadb-475c-ba06-d9634ed5a692", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 27, 3, "9b78f3a3-c7fb-40b8-9770-37c5c4426e01", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 28, 3, "98360a1e-11ef-4200-b8b5-84ab796f494b", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 29, 3, "2994f0db-4501-4b78-a371-c63a8b3ad8cd", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 30, 3, "6375f501-d4a6-4b78-bce7-9dea51a69e2c", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 31, 3, "9418c387-7a18-4f29-ad13-31bdf3b05e38", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 32, 3, "3f95e120-6acb-4597-a1b5-66fded81226b", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 33, 3, "67ebd1a6-c12a-45da-b19f-514af8df9a50", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 34, 3, "f148cee6-f17a-4b05-877d-98fd82a2d3b3", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 35, 3, "e2e54c90-9b66-4386-845c-76b793f3a666", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 36, 3, "7d33999a-31bd-4dcc-9286-0807b4a90a96", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 37, 3, "425965d2-3569-4031-ab49-0679194010d8", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 38, 3, "f4943736-b46c-4a7a-8891-c0f1d9a4ed0f", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 39, 3, "91b30e6d-9c00-4bec-9cc9-2c2e02a6a01c", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 40, 3, "4642081e-b2e1-4d2c-85ba-03498169510b", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 41, 3, "eae9af4c-a189-4ede-af38-0cdd8f99812c", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 42, 3, "8bf4bacd-1842-4608-a918-cb9a35e56b30", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 43, 3, "b235dc14-187f-4dae-84d7-282ace10a564", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 44, 3, "557888a8-0b12-4476-8c5d-d60f2b2a4e92", "Brand Ekleme Yetkisi", "MessageToDeveloper.Create", "MESSAGETODEVELOPER.CREATE" },
                    { 45, 3, "c864d314-8399-414a-8164-c254f9c67f6a", "Brand  Yetkisi", "MessageToDeveloper.Read", "MESSAGETODEVELOPER.READ" },
                    { 46, 3, "4fb631fd-9d1e-4884-88a2-cba595779ccc", "Brand  Yetkisi", "MessageToDeveloper.Update", "MESSAGETODEVELOPER.UPDATE" },
                    { 47, 3, "0b92c32f-e334-4ed7-b4f7-b4866c339304", "Brand  Yetkisi", "MessageToDeveloper.Delete", "MESSAGETODEVELOPER.DELETE" },
                    { 48, 3, "93a65a50-c009-46fb-9c75-9336b80e75e5", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 49, 3, "977b2a41-73db-48b4-bd8e-877abfcb3e82", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 50, 3, "6c21d16e-aa71-4a9e-b6c8-d1d46a934980", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 51, 3, "cb216865-e425-4ffa-b753-6f7509c2f896", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 52, 3, "fd996f60-1e92-447e-ac5a-b9e1b4a27156", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 53, 3, "4dd23115-d4c1-4177-b7b7-f7aabb172453", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 54, 3, "eb2bcd17-730e-469e-959a-a958fb379708", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 55, 3, "78c67a40-be2a-4eae-9133-5ab7fb1bafe7", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 56, 3, "f97e5677-df72-4a84-94cb-0740fda92986", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 57, 3, "40e1c270-6427-4aff-bfe3-1b4ca6015b91", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 58, 3, "7bafca10-7d42-4a17-9674-ed2d0e86ed6f", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 59, 3, "a51e2b57-59f2-4d0e-b144-e9956449a979", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 60, 3, "f459525d-21b2-446e-a5db-6e9159bab7d0", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 61, 3, "ccc66b66-9d55-4fa8-984d-d85583897afc", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 62, 3, "ac9fb7af-35d5-41d2-8bbf-4451b334c639", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 63, 3, "125d8504-e3dc-4090-b1e2-c1a8de245b37", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 64, 3, "f092ec78-cf8c-4970-9928-8208762eb95e", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 65, 3, "9b3a6eea-9559-427e-a506-a0fdc2abd26f", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 66, 3, "ee9b3cd7-5dab-43b9-acd2-6a86b2e48309", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" },
                    { 67, 3, "b6107757-a258-4bef-8de0-8218ea21299c", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 68, 3, "94e0a83d-4312-4da1-a65e-3f921bb2d1cd", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 69, 3, "d5b832fc-e6b7-4974-9878-26de586eaa79", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 70, 3, "121ebeba-77ea-41cd-a389-0b7d2b7d814b", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 71, 3, "0e3202aa-3306-4c46-b59e-409b76a3f9c4", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 72, 3, "02d11d7a-68d1-4353-acf2-04c49a632ec2", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 73, 3, "1352adc4-f5a5-4326-98a6-09657bbb28a6", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 74, 3, "7298c52a-bf3a-488a-acad-d187d2701440", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 75, 3, "0ec62278-df6c-4748-8e15-2a94bff9fc53", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 76, 3, "5f7f8391-cf96-4808-bc85-dff82e36dd3a", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 77, 3, "f21d66dd-5ba9-4311-b399-93513062ad17", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 78, 3, "28e56771-247a-4aff-a583-d20d94526771", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 79, 3, "955d5f78-ba1b-4d9a-b19a-e33046f8c44e", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 80, 3, "fb97a37d-57c4-4f7f-80a9-75a7fd19f63e", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 81, 3, "e4969887-58cf-4899-b60c-fed16bef9f5e", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 82, 3, "62f9081e-2be5-4326-8465-79134f38d53c", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 83, 3, "a5da2eee-2f90-45eb-89c4-d0e0ced8bfab", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 84, 3, "02a79842-6255-425d-8f12-9597b1c2ec9c", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 85, 3, "8b5f9ad6-9418-4f0e-9b7f-96da5341bc9e", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 86, 3, "55ce4e81-ae6e-4a2a-a7a4-ff6f39597261", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 87, 3, "e8a56435-c5e8-4d6a-a17f-185e0098f264", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 88, 2, "1049c1ce-e79b-4bf0-b9bf-c7b7cff58ed2", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 89, 2, "e3919733-0961-465d-be45-db84f8950502", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 90, 2, "8b315c73-1401-4cd5-bf91-7a7a40e2c485", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 91, 2, "60352e1e-bb40-4417-86a1-66163b7c503c", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 92, 2, "91d213d5-e891-4064-8b78-ded9be5b9ad5", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 93, 2, "915b0aa2-41ec-4b75-a9ef-6909ef378bf0", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 94, 2, "43034d48-99ea-4ff1-a19d-eac3c0cef8cf", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 95, 2, "4a3d9f3c-d453-4e29-bf1b-62d60cd231d9", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" },
                    { 96, 1, "170b8008-16cf-46ff-a983-2eaaacc44ac6", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 97, 1, "ed1e4689-37df-478f-a8b5-634ccb651b9d", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 98, 1, "9cf30dc5-601f-4a38-bcc1-7be820de5a87", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 99, 1, "90f880a0-bc03-463e-8e05-0334c1baa4fb", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 100, 1, "c5a53441-6438-45e2-a9f7-f9493238c851", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 101, 1, "d1a975e7-86be-43b5-9faa-a62272a0849b", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 102, 1, "cb04e2c5-f3ff-484e-b43d-9a01bcf662cc", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 103, 1, "a96c57fa-b0b7-4cda-9e9b-c84e617c8011", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 104, 1, "f8eaee35-6abe-4d7d-ae7c-1356748faf7c", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 105, 1, "619b3207-27fa-435c-b1d3-ef77b6343622", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 106, 1, "bab3ba9e-f763-4125-b200-055c999d8eca", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 107, 1, "3fe4642c-f359-4769-97ac-a477807629cb", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 108, 1, "088d36f1-0ab3-4c2a-a605-23fb5a2c142b", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" },
                    { 109, 1, "20ebe4e3-e19c-4da9-b0ae-09291cc23e75", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 110, 1, "3eb99d0f-d50b-44a5-bb2d-ac32463cdbb3", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 111, 1, "470cf1e9-66a6-4d16-b859-61693b93467f", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 112, 1, "ed8a5e3f-c0c7-4db4-8a68-597a1368d1e3", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 113, 1, "1112841b-804b-43ed-8eb8-64dbc3910402", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 114, 1, "70e936c7-db89-430b-af84-218d67ab1381", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(4469), "açıklama deneme status sale 1", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(4470), null, "Satış Aşamasında" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(7744), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(7745), null, "Nakit" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Institution", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin | Bilal", 0, "f816c091-1345-4bb5-8aac-a27faf77db03", "bilalAdmin@gmail.com", true, "Bilal", "Fokus", "Meto", "-", false, null, "BILALADMIN@GMAIL.COM", "BILALADMIN", "AQAAAAEAACcQAAAAECuhIbAxlb+21vaj9jbbfp0tFtNFjI2GUfxSkCZ48shMCUFcHM5O/6vrNvLFZjU0LA==", "+905537314131", true, "/userImages/defaultUser.png", "78e8a7c0-42d8-4192-804e-76af5bc6b61f", false, "bilalAdmin" },
                    { 2, "Admin | Nazlı", 0, "73bd5620-13bf-4f5f-b06a-a78d1c638aff", "nazliAdmin@gmail.com", true, "Nazlı", "Fokus", "-", "-", false, null, "NAZLIADMIN@GMAIL.COM", "NAZLIADMIN", "AQAAAAEAACcQAAAAEHh2NmtPjQgYKGbBrDPr3jCxkU7Uub2vLiuFPwwTrXZOmp5J1V+llvQHt8y62xDdMw==", "+905398815246", true, "/userImages/defaultUser.png", "b17ddd55-f4d9-433a-a610-f29aaa3c107c", false, "nazliAdmin" },
                    { 3, "-", 0, "259ed75e-da62-45a7-8d59-211167bb2746", "sema@gmail.com", true, "Sema", "Fokus", "-", "https://twitter.com/adminuser", false, null, "SEMA@GMAIL.COM", "SEMA", "AQAAAAEAACcQAAAAEITkQIbYnCFEVYCycAo5lFcF1ssXxtmPi8IdHEDbylIXtTqi9XRGttO/RZ0peqf/ng==", "+905071273567", true, "/userImages/defaultUser.png", "8484617e-5b6b-497f-8b5d-d5a0f86afa2b", false, "sema" },
                    { 4, "Geliştirici", 0, "70be892c-68be-40a8-9eaa-861f5e9e37f3", "x@gmail.com", true, "Bedirhan", "Dev", "Gündöner", "-", false, null, "X@GMAIL.COM", "DEV", "AQAAAAEAACcQAAAAEFGR25o5oP4BXLbDla4B/tJsNxVwfV08JKB2EQei3ob2xr6Yv0A2OWHdWFWA7N+t5Q==", "+905050102249", true, "/userImages/defaultUser.png", "f7521660-7599-42c8-8da9-c5c0fc017900", false, "dev" },
                    { 5, "-", 0, "e8c1cdc2-579e-40fc-82c2-9c3e090fdcbc", "berra@gmail.com", true, "Berra", "Ases", "-", "-", false, null, "BERRA@GMAIL.COM", "BERRA", "AQAAAAEAACcQAAAAEE2kKeaXrXBr2+3m6+1RciPjsxZUKaohTR9XHo8LpXd6C3mvaRcH/cYM5UJW9uQA9w==", "+905050102249", true, "/userImages/defaultUser.png", "936e98f2-db46-4d68-859c-3a57b18cbbce", false, "berra" },
                    { 6, "-", 0, "a2c1bd22-25a6-49b5-8b23-512210c34354", "Elif@gmail.com", true, "Elif", "Ases", "-", "-", false, null, "ELIF@GMAIL.COM", "ELIF", "AQAAAAEAACcQAAAAENB4gsL6uNd7OaqIaTXPWvIz7zzpfxZfP3Fd60CRX1z5UGG/E9I1/P/9cbO+xMHs8g==", "+905050102249", true, "/userImages/defaultUser.png", "b85c1466-6255-4228-937b-5d65da89beea", false, "Elif" },
                    { 7, "Admin | Bilal", 0, "51f13d30-cadc-4337-a367-e20d90e5c923", "esmaAdmin@gmail.com", true, "Bilal", "Ases", "Meto", "-", false, null, "ESMAADMIN@GMAIL.COM", "ESMAADMIN", "AQAAAAEAACcQAAAAEBcgcPJXJY3k4A6R+z8Gqq0DX8bl6VimTv2ocXwA1AeVpypmVyxAwzBSTmTfPr30JQ==", "+905537314131", true, "/userImages/defaultUser.png", "5a43e034-195d-4d3a-a1a9-23cedbbc608a", false, "esmaAdmin" },
                    { 8, "Admin | Nazlı", 0, "0ea1e60a-73b6-4001-b998-a8bf43448eeb", "asiyeAdmin@gmail.com", true, "Nazlı", "Ases", "-", "-", false, null, "ASIYEADMIN@GMAIL.COM", "ASIYEADMIN", "AQAAAAEAACcQAAAAEHE9D4nFvMizCdCjq7OpGErTtjbDX2GibyQT4E45brI4jLlQkpYYa7UoU5aZGGStGQ==", "+905398815246", true, "/userImages/defaultUser.png", "efe36958-60cf-4a6e-a5bb-232d6cf3de12", false, "asiyeAdmin" },
                    { 9, "-", 0, "c1ede890-e490-4dff-932f-0bb7417d8bba", "gulistan@gmail.com", true, "Sema", "Ases", "-", "https://twitter.com/adminuser", false, null, "GULISTAN@GMAIL.COM", "GULISTAN", "AQAAAAEAACcQAAAAEGJRUiX+Td6MZufqENPo7bAFhxAwwrqk64u7w6Stncvblzc4+kvH+EOaBJvETJgfmQ==", "+905071273567", true, "/userImages/defaultUser.png", "4f9cd699-5510-4fcf-bc0c-11a589be5a25", false, "gulistan" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3973), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3983), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3987), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3988), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3991), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(3992), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4006), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4007), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4010), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4010), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4011), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4013), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4014), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4016), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4017), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4019), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4021), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4023), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4024), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4026), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(4027), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9665), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9665), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9667), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9667), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9668), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9668), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9669), "Akbank Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9669), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9670), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9670), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9671), "Sivasot Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9671), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9672), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9672), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReferances",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceTitleId", "Description", "FirstName", "FromWhere", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "TC" },
                values: new object[] { 1, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(6303), 1, "Description", "Sema", null, true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(6304), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "StartDate", "TC" },
                values: new object[] { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(9831), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(9832), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(3959), "Ürün Alt Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(3960), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8854), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8855), 5, "EmployeeProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8857), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8858), 5, "UserModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8860), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8860), 7, "StockModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8862), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8863), 6, "CustomerReferanceModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8864), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8865), 1, "AppointmentModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8866), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8867), 1, "NotificationModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8869), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8869), 3, "PaymentProgram.Read", null },
                    { 8, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8871), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8871), 2, "CustomerProgram.Read", null },
                    { 9, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8873), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8873), 7, "BrandModule.Read", null },
                    { 10, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8875), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8875), 3, "SaleModule.Read", null },
                    { 11, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8877), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8878), 7, "ProductProgram.Read", null },
                    { 12, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8879), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(8880), 5, "RoleModule.Read", null }
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
                    { 1, 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7243), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7244), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7247), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7248), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7250), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7251), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7253), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7254), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7256), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7257), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7259), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7260), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7262), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7264), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7266), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7267), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7271), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7272), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7275), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 452, DateTimeKind.Local).AddTicks(7275), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[] { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 16, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(3609), "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(3605), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 453, DateTimeKind.Local).AddTicks(3606), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[] { 1, 1000m, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8586), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(8587), null, 1 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsMultiple", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(39), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(40), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9343), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9344), "User.Create", null, 2 },
                    { 11, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9346), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9347), "User.Read", null, 2 },
                    { 12, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9349), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9349), "User.Update", null, 2 },
                    { 13, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9351), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9351), "User.Delete", null, 2 },
                    { 14, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9353), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9353), "Role.Read", null, 2 },
                    { 15, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9355), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9356), "Role.Update", null, 2 },
                    { 16, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9357), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9358), "Role.Delete", null, 2 },
                    { 17, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9359), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9360), "Role.Create", null, 2 },
                    { 37, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9361), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9362), "Payment.Create", null, 7 },
                    { 38, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9363), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9364), "Payment.Read", null, 7 },
                    { 39, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9366), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9366), "Payment.Update", null, 7 },
                    { 40, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9368), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9368), "Payment.Delete", null, 7 },
                    { 41, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9370), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9371), "PaymentType.Create", null, 7 },
                    { 42, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9372), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9373), "PaymentType.Read", null, 7 },
                    { 43, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9374), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9375), "PaymentType.Update", null, 7 },
                    { 44, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9376), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9377), "PaymentType.Delete", null, 7 },
                    { 45, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9379), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9379), "Employee.Create", null, 1 },
                    { 46, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9381), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9381), "Employee.Read", null, 1 },
                    { 47, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9383), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9383), "Employee.Update", null, 1 },
                    { 48, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9385), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9386), "Employee.Delete", null, 1 },
                    { 49, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9387), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9388), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9389), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9390), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9391), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9392), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9393), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9394), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9396), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9396), "Customer.Create", null, 8 },
                    { 54, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9398), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9398), "Customer.Read", null, 8 },
                    { 55, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9400), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9400), "Customer.Update", null, 8 },
                    { 56, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9402), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9402), "Customer.Delete", null, 8 },
                    { 57, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9404), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9404), "CustomerType.Create", null, 8 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 58, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9406), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9407), "CustomerType.Read", null, 8 },
                    { 59, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9408), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9409), "CustomerType.Update", null, 8 },
                    { 60, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9410), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9411), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9413), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9413), "Notification.Create", null, 6 },
                    { 62, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9415), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9415), "Notification.Read", null, 6 },
                    { 63, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9417), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9418), "Notification.Update", null, 6 },
                    { 64, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9419), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9420), "Notification.Delete", null, 6 },
                    { 65, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9421), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9422), "Brand.Create", null, 9 },
                    { 66, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9423), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9424), "Brand.Update", null, 9 },
                    { 67, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9426), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9426), "Brand.Delete", null, 9 },
                    { 68, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9430), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9431), "Brand.Delete", null, 9 },
                    { 69, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9432), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9433), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9434), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9435), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9437), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9437), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9439), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9439), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9441), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9441), "SaleType.Create", null, 10 },
                    { 74, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9443), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9444), "SaleType.Read", null, 10 },
                    { 75, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9445), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9446), "SaleType.Update", null, 10 },
                    { 76, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9447), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9448), "SaleType.Delete", null, 10 },
                    { 77, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9450), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9450), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9452), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9452), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9454), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9455), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9456), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9457), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9458), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9459), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9461), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9461), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9463), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9463), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9465), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9466), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9428), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9428), "Brand.Read", null, 9 },
                    { 89, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9467), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9468), "AppointmentType.Create", null, 5 },
                    { 90, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9469), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9470), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9472), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9472), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9474), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9474), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9476), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9476), "Sale.Create", null, 10 },
                    { 94, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9478), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9479), "Sale.Read", null, 10 },
                    { 95, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9480), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9481), "Sale.Update", null, 10 },
                    { 96, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9482), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9483), "Sale.Delete", null, 10 },
                    { 97, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9485), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9485), "Product.Create", null, 11 },
                    { 98, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9487), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9487), "Product.Read", null, 1 },
                    { 99, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9489), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9489), "Product.Update", null, 11 },
                    { 100, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9531), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9531), "Product.Delete", null, 11 },
                    { 101, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9533), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9534), "Appointment.Create", null, 5 },
                    { 102, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9535), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9536), "Appointment.Read", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[] { 103, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9538), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9538), "Appointment.Update", null, 5 });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[] { 104, null, null, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9540), true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(9540), "Appointment.Delete", null, 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(2878), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(2879), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2621), 1, "TEST", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2622), null, "Reminder", new DateTime(2023, 9, 15, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2625), "Title", 1 },
                    { 2, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2632), 1, "Doğum günü yaklaşmakta.", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2632), null, "Reminder", new DateTime(2023, 9, 14, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2634), "Doğum Günü!", 2 },
                    { 3, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2635), 1, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2636), null, "Reminder", new DateTime(2023, 9, 13, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(2637), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[] { 1, 1m, null, 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(7114), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 467, DateTimeKind.Local).AddTicks(7115), null, 1, null });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[] { 1, 500, 10, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(7163), 1, 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 468, DateTimeKind.Local).AddTicks(7164), null, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(937), 0, true, false, "Test Verisi", new DateTime(2023, 9, 12, 1, 7, 15, 454, DateTimeKind.Local).AddTicks(938), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 });

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
