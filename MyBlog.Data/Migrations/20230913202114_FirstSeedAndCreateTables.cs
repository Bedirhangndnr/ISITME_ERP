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
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(3865), "Test", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(3866), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Test" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(3423), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(3424), null, "Brand Title Test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7640), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7641), "C#", "C# Blog Kategorisi" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7643), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7644), "C++", "C++ Blog Kategorisi" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7645), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7646), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7648), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7648), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7650), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7650), "Java", "Java Blog Kategorisi" },
                    { 6, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7652), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7653), "Python", "Python Blog Kategorisi" },
                    { 7, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7654), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7655), "Php", "Php Blog Kategorisi" },
                    { 8, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7656), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7657), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7658), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7659), "Swift", "Swift Blog Kategorisi" },
                    { 10, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7661), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7661), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "Action", "DateTime", "NewValues", "OldValues", "TableName" },
                values: new object[] { 1, "act Manuel", null, null, null, null });

            migrationBuilder.InsertData(
                table: "CustomerReferanceTitles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(3468), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(3469), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Referans Unvan 1" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(4749), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(4750), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "Type 1" });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2975), "Description", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2976), "Not", "Title" });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 9, 18, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3439), true, false, false, "TEST", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3438), null, 3, "MessageToDeveloper Title Test" },
                    { 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 9, 18, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3444), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3443), null, 1, "MessageToDeveloper Title Test" },
                    { 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 9, 16, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3447), true, false, false, "TEST 2222222222222222", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(3447), null, 4, "MessageToDeveloper Title Test" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1716), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1717), "AgendaProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1719), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1720), "CustomerModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1721), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1722), "RoleModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1724), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1726), "RoleModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1727), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1728), "RoleModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1729), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1730), "RoleModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1731), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1732), "StockModule.Read", null }
                });

            migrationBuilder.InsertData(
                table: "OutPayments",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "DebtAmount", "Description", "DueDate", "IsActive", "IsDeleted", "IsPaid", "ModifiedByName", "ModifiedDate", "Note", "PaidPlace" },
                values: new object[] { 1, 0m, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(1281), 15000m, "TEST desc 1 ", new DateTime(2023, 9, 17, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(1289), true, false, true, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(1283), null, "Ödemenin Yapılacağı yer" });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2010), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2010), null, "KK | POS" },
                    { 2, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2036), "Mail Order Payment", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2038), null, "Mail Order" },
                    { 3, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2038), "Point of Sale", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2039), null, "Peşin" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(5208), "Product Kategori 2 Açıkama", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(5208), "Product Kategori 1", "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek" });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6634), "Ürün Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6635), null, "Ürün Grubu 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, 1, "4c0cc356-d2ce-4594-b89a-92527f8cfa45", "SüperAdmin Yetkisi", "SuperAdmin", "SUPERADMIN" },
                    { 2, 1, "e6b9f4cd-4ac1-480e-9441-e17d8d4cde54", "Standart Kullanıcı Yetkisi", "DefaultUser", "DEFAULTUSER" },
                    { 3, 1, "2684bb33-fcf5-4a47-9d55-7579c5fd3c15", "Developer Yetkisi", "Developer", "DEVELOPER" },
                    { 4, 3, "85fee10c-789e-4cae-8663-a3eeead74f99", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" },
                    { 5, 3, "c862bbad-a111-40c3-a6c5-cf951f17baa9", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" },
                    { 6, 3, "6ed0137b-e180-4202-bdf0-23e39376a97a", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" },
                    { 7, 3, "69277b33-025d-44bb-b53b-7d753b2f4862", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" },
                    { 8, 3, "04d95ea1-7ccd-4f00-a977-fdd61ad24255", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" },
                    { 9, 3, "f97acb37-9daa-4504-ae7d-0dda8da710f8", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" },
                    { 10, 3, "ee6918ff-0cc4-42cb-9819-be657b3f45df", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 11, 3, "ddae4197-9eb7-4e63-b06f-f9064810f370", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" },
                    { 12, 3, "7ecc4188-cd17-43f3-b238-74735084d295", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" },
                    { 13, 3, "01a25b3d-4335-4a82-b699-95706bace929", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" },
                    { 14, 3, "7c07de4c-8b2a-4beb-b40d-e2feaefede5e", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" },
                    { 15, 3, "6caa5f5c-12ec-4748-8c8b-2b38a4564b3d", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" },
                    { 16, 3, "fda91c05-a67f-4e2d-9600-00ef6401b6af", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 17, 3, "9b077261-e3b3-4ca5-acc9-cd3a839439dc", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 18, 3, "4bd9cd4a-b7e6-4338-b9f3-127b1963c402", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 19, 3, "6fa80d2b-df8a-404b-9f1c-5b6c3336b534", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 20, 3, "92016fd1-a0a4-4024-8f49-bc9cd43c90e8", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" },
                    { 21, 3, "ad0d574d-20e4-4125-9c9e-e79e339ddbc7", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" },
                    { 22, 3, "1d90eae8-e6e5-4427-aa92-7af8ba09bb30", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" },
                    { 23, 3, "4acecffb-0b22-4e8e-a9c4-f8ffe84837b9", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" },
                    { 24, 3, "204aeb86-2927-44cf-8a87-d28e03c5dd21", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" },
                    { 25, 3, "8046780b-8404-4923-b36e-48f6da0c8594", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" },
                    { 26, 3, "4527024a-fc58-4753-ac0a-4074b5695403", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" },
                    { 27, 3, "faeb4136-6fcb-465c-9fae-1c6fc5d5bb08", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" },
                    { 28, 3, "36b41be0-0e52-455e-b967-8f48cd51ed08", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" },
                    { 29, 3, "82735f6d-dea3-408b-86ff-eda409b3404c", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" },
                    { 30, 3, "ad684c65-cfee-4141-9891-591ec60af6a4", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" },
                    { 31, 3, "a2411c58-ee62-4cbb-8b12-f8850d3c2c5b", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" },
                    { 32, 3, "1f76d578-500a-4457-894f-8b89f81f825f", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" },
                    { 33, 3, "bb2ed5aa-67b4-4c9e-81aa-d00e59408e79", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" },
                    { 34, 3, "d9997e5a-b386-4a0f-a42c-9a983cec3740", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" },
                    { 35, 3, "c82d5013-050c-49d5-b611-b2f0535b5d93", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" },
                    { 36, 3, "d3b2751a-8739-4ab6-948e-697abd098565", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" },
                    { 37, 3, "44aeab08-6e32-4a47-8c7f-bbac57717467", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" },
                    { 38, 3, "13fbeb33-3bc0-4fa9-b0a4-93eb37a0d02a", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" },
                    { 39, 3, "19c81273-46c3-4ee3-878a-59741b89be5e", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" },
                    { 40, 3, "fc2551df-3986-4fec-aac6-71eae62d4a7f", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" },
                    { 41, 3, "ee318f05-8c6e-4ddb-b922-97c477fbcb19", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" },
                    { 42, 3, "306661c2-f050-410d-901a-11db30f15e49", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" },
                    { 43, 3, "f2d3d859-3998-4756-b7d6-d5e8a0a341cc", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" },
                    { 44, 3, "47ddd5bc-c19c-4b3f-b4ed-dc8b1435cd1c", "Brand Ekleme Yetkisi", "MessageToDeveloper.Create", "MESSAGETODEVELOPER.CREATE" },
                    { 45, 3, "5fdd1ef2-772d-417e-97b2-064e6ecd5b64", "Brand  Yetkisi", "MessageToDeveloper.Read", "MESSAGETODEVELOPER.READ" },
                    { 46, 3, "457d2111-cbf5-4e9d-9a27-9c57300aa0c1", "Brand  Yetkisi", "MessageToDeveloper.Update", "MESSAGETODEVELOPER.UPDATE" },
                    { 47, 3, "20de9908-229d-4001-9444-071a139a735d", "Brand  Yetkisi", "MessageToDeveloper.Delete", "MESSAGETODEVELOPER.DELETE" },
                    { 48, 3, "b7c457ca-5bd5-45f2-901c-144ec09007c4", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" },
                    { 49, 3, "963b095a-ac3b-4fa6-8b08-202c24402a19", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" },
                    { 50, 3, "ffe41c7c-1a0f-4d02-8db4-226196e201ae", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" },
                    { 51, 3, "ea6b76f7-80c6-4a08-a938-a22a3dd75e69", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" },
                    { 52, 3, "39e631e9-6bcc-4249-b278-970f1cd87d87", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 53, 3, "c59cad4c-0ae6-407a-b995-9fe3379737af", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" },
                    { 54, 3, "fcfb54f8-bf64-41cb-a796-a36004c4cc9e", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" },
                    { 55, 3, "f1ecc5fb-efe7-4cf4-a33b-2f31b0209fcc", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" },
                    { 56, 3, "2403b43b-faf9-43d2-9aba-65967be13e90", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" },
                    { 57, 3, "d26543c5-074d-42b1-b72d-4f80bcce7a51", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" },
                    { 58, 3, "e859553b-47f0-4e3e-8da2-5c18cb447b35", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" },
                    { 59, 3, "b9ad2142-3445-4792-9210-7cebdcdc2d18", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" },
                    { 60, 3, "05075dcb-16e6-4e88-96df-a1d9088f8cc4", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" },
                    { 61, 3, "d2c9db1d-3320-4e6c-9f4c-eaf843ccd276", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" },
                    { 62, 3, "6f1d0070-5525-4a77-a390-17e9d4effd5a", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" },
                    { 63, 3, "cd2a0e78-fd7a-4d37-97bd-ad41056cb36e", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" },
                    { 64, 3, "4d4d6c5f-a7d3-47df-a3fe-ee7dd35c5f27", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" },
                    { 65, 3, "f0463484-7411-4ea6-8234-c357bb6d4aa0", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" },
                    { 66, 3, "1c8ee2ce-2368-48d4-a76b-8e9cea03327f", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" },
                    { 67, 3, "5e12c3b3-0dbc-49b6-800c-65b082b8b845", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" },
                    { 68, 3, "a73bd739-d084-4a54-8679-9e15d2db4a9e", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" },
                    { 69, 3, "e7d02511-7646-4f96-b72e-6645d1cbd347", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" },
                    { 70, 3, "8d1a6c1c-a9c9-43b0-9446-c149c8ec5fc7", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" },
                    { 71, 3, "60879033-95c8-4af6-a4db-44f5773827f8", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" },
                    { 72, 3, "73ea8329-e809-4b27-a586-63b0f62a3f07", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" },
                    { 73, 3, "e2e7084e-d207-4617-b7ae-beb35e1e16ec", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" },
                    { 74, 3, "1cc247e8-a847-46d0-bc99-f14aadc13b12", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" },
                    { 75, 3, "fa55a979-7491-41b5-8d0a-6cd457962315", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" },
                    { 76, 3, "f0b00f66-37d6-4c68-bc0a-50b446683ee1", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 77, 3, "97929e9e-c695-4b50-919d-cc7317d1b43d", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" },
                    { 78, 3, "2b90aee3-0a78-4544-88bf-2ea4ad9b5120", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 79, 3, "b44aa47f-be44-4389-8a1e-454f66c87011", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 80, 3, "da908a55-5e3d-4494-a335-5c811414b662", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" },
                    { 81, 3, "6138491a-30b6-43d1-bbef-fccf9b524b80", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" },
                    { 82, 3, "0903bcf3-bcaa-4687-9d30-9223e27f6949", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" },
                    { 83, 3, "f52377ef-2cd6-43f4-919b-84ee82911d95", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" },
                    { 84, 3, "38a8ac49-80d1-49ca-949b-eb8fa742c2aa", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" },
                    { 85, 3, "1b7b53ea-117a-4a5e-9669-199b4364fa4f", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" },
                    { 86, 3, "2b9bc09a-c538-4a95-a8d0-4c5326316089", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" },
                    { 87, 3, "76b0fc78-5c35-4c14-8374-2ae7b6036229", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" },
                    { 88, 2, "22b7cc23-dc7f-473a-b8ca-78a62d705f25", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" },
                    { 89, 2, "af6df96f-37d8-4659-8074-bef112e1f90c", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" },
                    { 90, 2, "1b2cf84e-e9ad-4979-8075-5ce3068e6f69", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" },
                    { 91, 2, "520c8991-c9b5-44ce-babd-7854918ad15d", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" },
                    { 92, 2, "19e529cc-2f8e-44f7-b869-6862a72fbd35", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" },
                    { 93, 2, "34394582-5e8f-4f5d-bc38-4d2fb4089abb", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" },
                    { 94, 2, "1a0f3c32-ecce-4d8a-9180-ddb51a781d4c", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 95, 2, "2747a75b-405e-435d-a27b-8952da278624", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" },
                    { 96, 1, "b01633c4-f6ef-43b0-b613-31004c41f0f8", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" },
                    { 97, 1, "83c33329-de36-4913-ae90-35638a8d33b4", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" },
                    { 98, 1, "f30c813f-d868-478b-9c41-78d29cc7cd33", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" },
                    { 99, 1, "84c19ef4-bec5-4e86-84ff-ba16ef893a3b", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" },
                    { 100, 1, "66cbcac4-6504-44c3-bc6b-1648739c755c", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" },
                    { 101, 1, "46bdaa39-916e-47b9-a25c-31ecc844fb57", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" },
                    { 102, 1, "1f9ee8cc-ceab-42a7-855c-10a0050aff5c", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" },
                    { 103, 1, "2e48a101-5cb7-4644-b569-53fa26ab59a7", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" },
                    { 104, 1, "445336f9-64ea-4ae2-8074-a24ad5487a4c", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" },
                    { 105, 1, "ce602d6c-975d-4aae-a03f-e9acf62158f3", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" },
                    { 106, 1, "a5d2bb24-3547-49a3-9605-256afee3d3ca", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" },
                    { 107, 1, "378d6ae3-1d68-4b0c-8771-07791d0d122f", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" },
                    { 108, 1, "5460008e-c207-42d6-84a5-2e8d05cc468f", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" },
                    { 109, 1, "bb93bcbc-8fa7-40e9-8053-cc550fb86d17", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" },
                    { 110, 1, "84688070-43b7-4b82-a2c1-f29e27992bab", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 111, 1, "2d487ce3-3b3e-4157-9b96-742a31e5bf7a", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 112, 1, "7c6dbc0d-a03c-4983-a0a3-fd82db54e58f", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 113, 1, "be3502bc-69d1-455c-a7b6-a55985b81ee8", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 114, 1, "f8b73592-a085-474b-b21b-9d5a23b686b1", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.InsertData(
                table: "SaleStatuses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(7912), "açıklama deneme status sale 1", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(7913), null, "Satış Aşamasında" });

            migrationBuilder.InsertData(
                table: "SaleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1152), "TEST", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(1152), null, "Nakit" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Institution", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin | Bilal", 0, "cb5800e1-a661-42b7-a166-573a7984984f", "bilalAdmin@gmail.com", true, "Bilal", "Fokus", "Meto", "-", false, null, "BILALADMIN@GMAIL.COM", "BILALADMIN", "AQAAAAEAACcQAAAAELsxnXpMjg6JQZSFXqFE68a9/WoVjGzpGpH7S77ES9/0P9FH9g0QoHAGkUE58+gaQg==", "+905537314131", true, "/userImages/defaultUser.png", "16543143-17ec-430b-ac2a-aae193b5ffd3", false, "bilalAdmin" },
                    { 2, "Admin | Nazlı", 0, "b2ed5776-3370-4ad9-adbf-eb88b4a187fd", "nazliAdmin@gmail.com", true, "Nazlı", "Fokus", "-", "-", false, null, "NAZLIADMIN@GMAIL.COM", "NAZLIADMIN", "AQAAAAEAACcQAAAAEP4aRl+uRnIUEGFX6BD5BdSkT1bvtXKRew+hnlgH+GlnpNPkbko5IA9LBhD5FEnX/A==", "+905398815246", true, "/userImages/defaultUser.png", "9496c0c1-af0e-406d-8ab2-cc4d63cd661b", false, "nazliAdmin" },
                    { 3, "-", 0, "038ff2de-1499-4ba3-8b1f-d237a653ab1f", "sema@gmail.com", true, "Sema", "Fokus", "-", "https://twitter.com/adminuser", false, null, "SEMA@GMAIL.COM", "SEMA", "AQAAAAEAACcQAAAAEDWbr1/bQpuN4UFJoHcnQVlnPLsyUdcj3Ta7ratU7DXMw2EOrftNdSPF1MkpA/ie2Q==", "+905071273567", true, "/userImages/defaultUser.png", "3e90b4d1-319d-4c5a-b1f7-cd4c0d575fb4", false, "sema" },
                    { 4, "Geliştirici", 0, "14fe0941-e08d-4a00-888d-18f26e0863a7", "x@gmail.com", true, "Bedirhan", "Dev", "Gündöner", "-", false, null, "X@GMAIL.COM", "DEV", "AQAAAAEAACcQAAAAEJj6/sWEPpMl3WJzsX0ORrFsauw9cjFG/hyJkkMC1hTRtl8jYQuCC2xIYWDrn/AnUQ==", "+905050102249", true, "/userImages/defaultUser.png", "61c08861-7a5c-460d-82ca-a3c6d2d27dad", false, "dev" },
                    { 5, "-", 0, "07cd6abc-c186-4e05-9dd9-dbe0bb2688a6", "berra@gmail.com", true, "Berra", "Ases", "-", "-", false, null, "BERRA@GMAIL.COM", "BERRA", "AQAAAAEAACcQAAAAEORqgz5c8p0mt175v112eEwsEiHQLuVXfdq5RbZIKeDvA80u/0YkJUTH0lTmh+ZF5w==", "+905050102249", true, "/userImages/defaultUser.png", "26ac30b0-2621-443d-ad86-941869328358", false, "berra" },
                    { 6, "-", 0, "164a8c69-89a9-420c-a651-4ea678d83b62", "Elif@gmail.com", true, "Elif", "Ases", "-", "-", false, null, "ELIF@GMAIL.COM", "ELIF", "AQAAAAEAACcQAAAAEDfoMODyYK3id9JdOdQTK3B40BTkbJ+TJeVGrIqBlAnq0Y6vSEkBT61BaBF9Q/NW4A==", "+905050102249", true, "/userImages/defaultUser.png", "2c325ca7-b737-4184-815c-d422871b72b1", false, "Elif" },
                    { 7, "Admin | Bilal", 0, "517c5c58-f358-4b43-a70a-548f7d5c707f", "esmaAdmin@gmail.com", true, "Bilal", "Ases", "Meto", "-", false, null, "ESMAADMIN@GMAIL.COM", "ESMAADMIN", "AQAAAAEAACcQAAAAEMYLYINIbkvIEA5GyeWtOPJHRdw7WKLMWMqDrqFiRMuNT6nLFk4qc8oCye9xuC4G6Q==", "+905537314131", true, "/userImages/defaultUser.png", "bc84e6e4-582a-42c3-ad25-f5ab7274156d", false, "esmaAdmin" },
                    { 8, "Admin | Nazlı", 0, "37500217-d1d7-4d87-af9f-d9440b525342", "asiyeAdmin@gmail.com", true, "Nazlı", "Ases", "-", "-", false, null, "ASIYEADMIN@GMAIL.COM", "ASIYEADMIN", "AQAAAAEAACcQAAAAEMXHRoTHInAQbfb1mVlxUxCLhjFmvKLwy0tglNoVIjk3FHt6JDAE3NvUPgAo3jcm0Q==", "+905398815246", true, "/userImages/defaultUser.png", "f813c96a-be9f-4181-b460-e3811cf7f774", false, "asiyeAdmin" },
                    { 9, "-", 0, "47394032-c198-4123-bc56-f13e54f92b41", "gulistan@gmail.com", true, "Sema", "Ases", "-", "https://twitter.com/adminuser", false, null, "GULISTAN@GMAIL.COM", "GULISTAN", "AQAAAAEAACcQAAAAEElXWZGzp7TVazI56s0A431Vun/ivg3venVKxd2P3ThmGfmAPtYIJWoGdy+7nhfzfQ==", "+905071273567", true, "/userImages/defaultUser.png", "9137f5fd-13e8-4e01-bcb2-5ca8b8b5f56b", false, "gulistan" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6971), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6969), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6972), "C# 9.0 ve .NET 5 Yenilikleri", "Alper Tunga", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6977), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6976), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6978), "C++ 11 ve 19 Yenilikleri", "Alper Tunga", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6980), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6981), "JavaScript ES2019 ve ES2020 Yenilikleri", "Alper Tunga", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6983), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6984), "Typescript 4.1 Yenilikleri", "Alper Tunga", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6986), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6987), "JAVA", "Alper Tunga", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6989), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6990), "Python", "Alper Tunga", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6992), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6992), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6993), "PHP", "Alper Tunga", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6995), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6995), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6996), "Kotlin", "Alper Tunga", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6998), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6997), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(6999), "Swift", "Alper Tunga", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7001), new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7000), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(7001), "Ruby", "Alper Tunga", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AssociatedInstitutions",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2807), "İş Bankası Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2807), null, 1, "İş Bankası" },
                    { 2, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2809), "Garanti Bankası Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2809), null, 1, "Garanti Bankası" },
                    { 3, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2810), "Yapı Kredi Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2810), null, 1, "Yapı Kredi" },
                    { 4, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2811), "Akbank Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2811), null, 1, "Akbank" },
                    { 5, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2812), "Avrupa Ses Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2812), null, 2, "Avrupa Ses" },
                    { 6, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2813), "Sivasot Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2813), null, 2, "Sivasot" },
                    { 7, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2814), "Timtoptan Description", true, false, "Admin", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2814), null, 2, "Timtoptan" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReferances",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceTitleId", "Description", "FirstName", "FromWhere", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "TC" },
                values: new object[] { 1, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(4356), 1, "Description", "Sema", null, true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(4356), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", "+905050102249", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "Email", "EmployeeTypeId", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "StartDate", "TC" },
                values: new object[] { 1, "Editor User of MyBlog", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2890), "bedirhangn@gmail.com", 1, "Personel 1", true, false, "User", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(2891), null, "+905555555555", "/userImages/defaultUser.png", null, "45677891170" });

            migrationBuilder.InsertData(
                table: "ProductSubGroups",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductGroupId", "Title" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(7451), "Ürün Alt Grubu Açıklaması", true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(7451), null, 1, "Ürün Alt Grubu Başlığı" });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "ModuleId", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2134), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2134), 5, "EmployeeProgram.Read", null },
                    { 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2136), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2137), 5, "UserModule.Read", null },
                    { 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2139), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2139), 7, "StockModule.Read", null },
                    { 4, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2141), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2142), 6, "CustomerReferanceModule.Read", null },
                    { 5, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2143), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2144), 1, "AppointmentModule.Read", null },
                    { 6, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2145), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2146), 1, "NotificationModule.Read", null },
                    { 7, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2147), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2148), 3, "PaymentProgram.Read", null },
                    { 8, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2149), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2150), 2, "CustomerProgram.Read", null },
                    { 9, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2152), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2152), 7, "BrandModule.Read", null },
                    { 10, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2154), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2154), 3, "SaleModule.Read", null },
                    { 11, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2156), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2156), 7, "ProductProgram.Read", null },
                    { 12, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2158), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2158), 5, "RoleModule.Read", null }
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
                    { 1, 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8427), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8428), "C# Makale Yorumu", "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8430), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8431), "C++ Makale Yorumu", "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8432), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8433), "JavaScript Makale Yorumu", "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8435), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8435), "Typescript Makale Yorumu", "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8437), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8437), "Java Makale Yorumu", "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8439), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8440), "Python Makale Yorumu", "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8441), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8442), "Php Makale Yorumu", "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8443), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8444), "Kotlin Makale Yorumu", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8446), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8446), "Swift Makale Yorumu", "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8448), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 76, DateTimeKind.Local).AddTicks(8448), "Ruby Makale Yorumu", "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "About", "Address", "BirthDate", "CreatedByName", "CreatedDate", "CustomerReferanceId", "CustomerTypeId", "Email", "EmployeeId", "FirstName", "HospitalOfReport", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Phone", "Picture", "TC" },
                values: new object[] { 1, "Yazılımcı, 20 yaşında", "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2", new DateTime(2023, 9, 17, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(2929), "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(2926), 1, 1, "hasta1@gmail.com", 1, "Bedirhan", "Kadıköy Hastanesi", true, false, "Gündöner", "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(2927), "TEST", "05050102249", "/userImages/defaultUser.png", "45677891170" });

            migrationBuilder.InsertData(
                table: "OutPaymentDetails",
                columns: new[] { "Id", "AmountPaid", "CreatedByName", "CreatedDate", "Description", "EmployeeId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "OutPaymentId" },
                values: new object[] { 1, 1000m, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(1810), "TEST desc 1 ", 1, true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(1811), null, 1 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsMultiple", "IsSold", "ModifiedByName", "ModifiedDate", "Note", "Price", "ProductCategoryId", "ProductName", "ProductSubGroupId", "Quantity", "SerialNumber" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(6519), true, false, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(6520), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 100, null, "Siemens Signia Motion 1PX", 1, 10, "A12BO9930HT4" });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 10, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2549), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2549), "User.Create", null, 2 },
                    { 11, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2551), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2552), "User.Read", null, 2 },
                    { 12, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2553), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2554), "User.Update", null, 2 },
                    { 13, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2556), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2556), "User.Delete", null, 2 },
                    { 14, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2558), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2558), "Role.Read", null, 2 },
                    { 15, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2560), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2560), "Role.Update", null, 2 },
                    { 16, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2562), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2562), "Role.Delete", null, 2 },
                    { 17, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2564), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2564), "Role.Create", null, 2 },
                    { 37, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2566), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2566), "Payment.Create", null, 7 },
                    { 38, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2568), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2568), "Payment.Read", null, 7 },
                    { 39, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2570), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2570), "Payment.Update", null, 7 },
                    { 40, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2572), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2572), "Payment.Delete", null, 7 },
                    { 41, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2574), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2574), "PaymentType.Create", null, 7 },
                    { 42, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2576), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2576), "PaymentType.Read", null, 7 },
                    { 43, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2578), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2578), "PaymentType.Update", null, 7 },
                    { 44, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2580), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2580), "PaymentType.Delete", null, 7 },
                    { 45, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2582), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2582), "Employee.Create", null, 1 },
                    { 46, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2584), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2584), "Employee.Read", null, 1 },
                    { 47, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2586), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2586), "Employee.Update", null, 1 },
                    { 48, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2588), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2588), "Employee.Delete", null, 1 },
                    { 49, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2590), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2590), "EmployeeType.Create", null, 1 },
                    { 50, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2592), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2592), "EmployeeType.Read", null, 1 },
                    { 51, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2594), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2594), "EmployeeType.Update", null, 1 },
                    { 52, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2596), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2596), "EmployeeType.Delete", null, 1 },
                    { 53, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2598), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2598), "Customer.Create", null, 8 },
                    { 54, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2600), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2600), "Customer.Read", null, 8 },
                    { 55, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2602), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2602), "Customer.Update", null, 8 },
                    { 56, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2604), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2604), "Customer.Delete", null, 8 },
                    { 57, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2606), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2606), "CustomerType.Create", null, 8 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[,]
                {
                    { 58, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2608), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2608), "CustomerType.Read", null, 8 },
                    { 59, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2610), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2610), "CustomerType.Update", null, 8 },
                    { 60, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2612), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2612), "CustomerType.Delete", null, 8 },
                    { 61, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2614), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2614), "Notification.Create", null, 6 },
                    { 62, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2616), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2616), "Notification.Read", null, 6 },
                    { 63, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2618), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2618), "Notification.Update", null, 6 },
                    { 64, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2620), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2621), "Notification.Delete", null, 6 },
                    { 65, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2622), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2623), "Brand.Create", null, 9 },
                    { 66, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2624), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2624), "Brand.Update", null, 9 },
                    { 67, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2626), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2627), "Brand.Delete", null, 9 },
                    { 68, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2630), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2630), "Brand.Delete", null, 9 },
                    { 69, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2632), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2632), "SaleStatus.Create", null, 10 },
                    { 70, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2665), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2665), "SaleStatus.Read", null, 10 },
                    { 71, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2667), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2667), "SaleStatus.Update", null, 10 },
                    { 72, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2669), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2669), "SaleStatus.Delete", null, 10 },
                    { 73, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2671), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2671), "SaleType.Create", null, 10 },
                    { 74, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2673), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2673), "SaleType.Read", null, 10 },
                    { 75, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2675), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2675), "SaleType.Update", null, 10 },
                    { 76, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2677), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2677), "SaleType.Delete", null, 10 },
                    { 77, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2679), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2679), "ProductGroup.Create", null, 7 },
                    { 78, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2681), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2681), "ProductGroup.Read", null, 11 },
                    { 79, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2683), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2683), "ProductGroup.Update", null, 11 },
                    { 80, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2685), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2686), "ProductGroup.Delete", null, 11 },
                    { 81, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2687), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2688), "ProductSubGroup.Create", null, 11 },
                    { 82, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2689), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2690), "ProductSubGroup.Read", null, 11 },
                    { 83, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2691), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2692), "ProductSubGroup.Update", null, 11 },
                    { 84, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2693), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2694), "ProductSubGroup.Delete", null, 11 },
                    { 85, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2628), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2628), "Brand.Read", null, 9 },
                    { 89, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2695), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2695), "AppointmentType.Create", null, 5 },
                    { 90, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2697), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2697), "AppointmentType.Read", null, 5 },
                    { 91, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2699), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2699), "AppointmentType.Update", null, 5 },
                    { 92, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2701), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2701), "AppointmentType.Delete", null, 5 },
                    { 93, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2703), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2703), "Sale.Create", null, 10 },
                    { 94, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2705), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2705), "Sale.Read", null, 10 },
                    { 95, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2707), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2707), "Sale.Update", null, 10 },
                    { 96, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2710), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2710), "Sale.Delete", null, 10 },
                    { 97, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2712), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2712), "Product.Create", null, 11 },
                    { 98, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2714), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2714), "Product.Read", null, 1 },
                    { 99, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2716), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2716), "Product.Update", null, 11 },
                    { 100, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2718), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2718), "Product.Delete", null, 11 },
                    { 101, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2720), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2720), "Appointment.Create", null, 5 },
                    { 102, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2722), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2722), "Appointment.Read", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[] { 103, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2724), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2724), "Appointment.Update", null, 5 });

            migrationBuilder.InsertData(
                table: "SubPrograms",
                columns: new[] { "Id", "ActionName", "ControllerName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "ProgramId" },
                values: new object[] { 104, null, null, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2726), true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(2726), "Appointment.Delete", null, 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTypeId", "CreatedByName", "CreatedDate", "CustomerId", "Date", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsMade", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserId" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(8808), 1, new DateTime(1998, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Açıklama2", 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(8808), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", null, null });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "EmployeeId", "IsActive", "IsDeleted", "IsRead", "ModifiedByName", "ModifiedDate", "Note", "NotificationType", "TargetDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6097), 1, "TEST", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6097), null, "Reminder", new DateTime(2023, 9, 16, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6101), "Title", 1 },
                    { 2, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6107), 1, "Doğum günü yaklaşmakta.", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6107), null, "Reminder", new DateTime(2023, 9, 15, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6109), "Doğum Günü!", 2 },
                    { 3, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6110), 1, "Aylık cihaz bakımı için konuşulacak", null, true, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6111), null, "Reminder", new DateTime(2023, 9, 14, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(6112), "Cihaz Bakımı!", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "AssociatedInstitutionId", "AssociatedInstitutionsId", "CreatedByName", "CreatedDate", "CustomerId", "CustomerId1", "Description", "EmployeeId", "EmployeeId1", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PaymentTypeId", "PaymentTypeId1" },
                values: new object[] { 1, 1m, null, 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(482), 1, null, "TEST", 1, null, true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 91, DateTimeKind.Local).AddTicks(483), null, 1, null });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Amount", "AmountOfSgk", "CreatedByName", "CreatedDate", "CustomerId", "EmployeeId", "IsActive", "IsDeleted", "IsInvoiceDue", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "SaleStatusId", "SaleTypeId" },
                values: new object[] { 1, 500, 10, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(607), 1, 1, true, false, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 92, DateTimeKind.Local).AddTicks(608), null, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Quantity" },
                values: new object[] { 1, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(7250), 0, true, false, "Test Verisi", new DateTime(2023, 9, 13, 23, 21, 14, 77, DateTimeKind.Local).AddTicks(7251), "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek", 1, 20 });

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
