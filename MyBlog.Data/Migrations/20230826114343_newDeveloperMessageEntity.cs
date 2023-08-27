using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class newDeveloperMessageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsMultiple",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "MessageToDevelopers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Progress= table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(4994), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3633), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1336), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(992), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5433), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 5, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(441), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1485), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2002), new DateTime(2023, 8, 31, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2004), true, false, false, "TEST", "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2003), null, 3, "MessageToDeveloper Title Test" });

            migrationBuilder.InsertData(
                table: "MessageToDevelopers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "EstimatedCompletionDate", "IsActive", "IsDeleted", "IsRead", "Message", "ModifiedByName", "ModifiedDate", "Note", "Progress", "Title" },
                values: new object[,]
                {
                    { 2, "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 8, 31, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2008), true, false, false, "TEST 2222222222222222", "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2008), null, 1, "MessageToDeveloper Title Test" },
                    { 3, "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 8, 29, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2012), true, false, false, "TEST 2222222222222222", "InitialCreate", new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2011), null, 4, "MessageToDeveloper Title Test" }
                });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(30), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 8, 29, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 8, 28, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 8, 27, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9227), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9233), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 8, 30, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 8, 30, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8585), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9328), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7667), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7673), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7676), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(249), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "eafead8b-30be-4990-9054-f4fb89cac04f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0aa38a94-5073-4682-ab06-59a66cc2d76c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "555bb88e-7ba0-4090-9557-e9a769d42045", "Developer Yetkisi", "Developer", "DEVELOPER" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ed6db875-2283-4877-aa14-2a80719650ed", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "95db4f02-c194-4847-b2dd-f9b643c02b9f", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "32139de2-294f-4807-8bdd-d2b377c546a0", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4a9492b1-39ed-4a0e-b63d-743225d6003c", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "af702c7f-4d50-4f4f-9db7-aeeda5d119de", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c7c93ba6-218e-4e1b-99d7-4535e0348547", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "14f9f2c4-e0d1-4f31-99b5-8e7679886675", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "08359312-0bad-460d-a79e-286c1aa019b3", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "cdd63ae0-b326-4f32-ab24-1bfdf5c4b707", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fcc6f0d0-9d7d-465b-8ca6-4486176adc7a", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0e42d3ef-cd82-4971-b869-aa6a03370d0f", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8431d1fa-525f-42ed-abc7-2fcd5d253d7a", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bc0180ba-fb17-4932-8888-00ec0dede4e6", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d422146e-7103-4e58-8247-8b041086d355", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dfefb769-9d78-4644-8bb2-2cfdd437ce41", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a716c705-b5d1-4258-ad24-11709aac756b", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7eb7d31d-670d-4f71-bb73-ae11975c7c98", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4c9e91d9-b0fa-4989-ba4e-56c206d955a0", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c53dbb3e-18b4-4dbb-8cab-64e7fb31d089", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "eb48bbf1-bdfa-443b-9a66-85592b5e4da0", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "05bff3b6-3f56-40e5-acf3-cda24c0be071", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "05a25d20-ba9e-4e8c-96b9-7df5c459c69d", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a7317469-c9f1-40ba-ba99-16b17e7ec19c", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0fe22e59-7d35-4dca-bf10-5752b4ce1fbe", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "52ad0a19-879e-4e14-8b37-6e4e8dc5da95", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "54c56cf7-4cb6-4d52-ad6a-9dfb93ed4c4e", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "53181876-4515-4ce8-8fbc-d6a619d21278", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5c9c100a-8cf2-47d1-b947-e25a7ade1a09", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6f316dc1-1c85-4ae8-9f06-e82b771588cc", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e4963f3e-574f-4d1f-9163-df8e7dfa45ee", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1f645473-3757-4920-b673-be91e07233c0", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b5f2bf17-8bfe-404e-980f-0cb7ecd69008", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "13bc0583-c573-44c7-b7e4-1d64087e4d5f", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7e1cc732-3c3f-466b-8435-2678a4140a72", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a29e92f0-4417-4771-86dc-a768b83b94dc", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ac814f27-c8c8-4eba-bb08-3d10017992a0", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d2d11396-422e-4622-9f1e-867847215bf0", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a4efd455-0af5-45c1-a212-0b60fcf00104", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dabfef5a-0c0e-4085-b638-bf35d384597a", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b9f95225-e1e0-4dcd-88c7-2c4d6dfb5c36", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "258540be-2475-4cda-9186-ab687ef1d129", "Brand Ekleme Yetkisi", "MessageToDeveloper.Create", "MESSAGETODEVELOPER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "53976aea-675f-48ad-9801-f853d7bdd485", "Brand  Yetkisi", "MessageToDeveloper.Read", "MESSAGETODEVELOPER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a61e2e5e-3821-4ed0-96f7-819da5b89734", "Brand  Yetkisi", "MessageToDeveloper.Update", "MESSAGETODEVELOPER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "221b2df3-849f-4c5a-827f-0f402197d9e3", "Brand  Yetkisi", "MessageToDeveloper.Delete", "MESSAGETODEVELOPER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "53fd9f08-960d-4a6c-ae65-3e2a83c41df9", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4f17b21c-1972-4a07-9046-5a95807d239c", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f86ed54f-dd2c-4962-93b7-2adde426aa5f", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4462b7c1-290b-446f-b96d-5c1a1326731a", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f6de0802-c816-493e-84bc-163245cf2b86", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "67c13017-04c3-4dfe-a50c-9e48cb947c37", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "900252db-bb6b-41f1-bb93-90fdd83dc804", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c8b23fe7-688b-46aa-837f-ffbbec4be82f", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5c20568d-0522-49d5-ba43-d19dd8ede480", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "df5d1fd1-b69e-4943-8d3c-d8b9a7204e0d", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c912b6a2-d364-4027-a596-3ec94572ffea", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8c378f01-79f0-4ddb-9c42-8536b1f64095", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2f98ba81-1f23-4936-953e-54da156fc693", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fcbca198-653e-49a6-bc00-f0752fff9cd3", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2fbee04f-165b-48df-9f1d-9049db8b2b0c", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9a7ad41a-18f1-4f72-a3ff-ea00f8b58c8d", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5a79972e-f8e4-47f4-b00b-ef0315d36de5", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "40860860-65df-4eb8-9bf6-28b2d539cc07", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "40119977-cbd3-4e46-9dbd-e2bcff350588", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "646514a6-efc2-439b-a466-233bb82cb384", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9e3356f2-6512-4288-b37f-b412936214c6", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ef4334f5-00d3-481d-912b-3722ceb072a7", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4ae1aeda-2fae-41d1-96db-93c56f8d5c74", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e5b42ac1-ca54-4402-b59b-801d4976e89d", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bc7a5687-1cfb-4faf-b075-b4d807bf31ef", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d870742c-bd76-477d-8938-8b90a973a7b8", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "df674d68-b50f-4c4e-bc5c-cf99351d1bab", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "027c5fa6-fc00-4705-be5e-89e1ee3d4f32", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c99b1238-d99f-4377-acb9-d5101f85e5a7", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9ef3ffae-ca70-48c4-b51a-b16533bbe36e", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a065c7ae-140b-43f0-bff1-a1651b67a5a2", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f66a4250-1e6a-4b66-8862-ec213f4f5cf6", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5c1ad8d6-bbcc-46e8-9f9c-850fad804ea6", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b83031bd-55cc-4a48-b9df-a17e847e20b6", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4cf223ad-32dc-49ab-8e32-7a0c3779f17a", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "fa6e32f6-28d9-4f58-ac30-6eb9a7f826a7", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "7506f123-b857-48f3-a701-6418deb8468b", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "6af0964a-6c6e-48cb-b989-7fcc8b768b6d", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "aafe2dd9-475a-460d-8e2c-8035228cd4b4", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "7aab353d-062b-4e68-99ac-b8f67c6904ee", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4a906ad5-364b-4a90-aa94-3b68065126db", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0ad314ec-4826-4520-b6ca-6661b6055cca", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3eb1e8c2-98d8-4424-b1ce-887f4c01e185", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "cd93da74-bb4d-4561-b727-81b5ccb63936", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "32916f45-b85b-4629-ad99-c5f84c33d504", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "3208ec65-291d-4ae6-9374-5479f8dc78ae", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "de17efed-f109-400a-a2b2-9f01e601b986", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "d1317325-9e23-4c3f-915a-f7efb1a7360c", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bc340b6f-41d8-4569-9a8f-976a528c9b6b", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "11480c1a-643c-4c5a-b24b-8c62083454d4", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "33f5c8e4-2f27-488b-b04e-22e5283972aa", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8525c837-c8f4-4d3d-9084-f763914e116a", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ce534d0d-b5d0-4f74-a08e-3a09664d41eb", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "547f28b6-edf8-4d0d-ad2c-c9d23380a269", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "928bf41d-ae44-44de-870b-ca4b7ee5debc", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "249dd211-6b11-4266-9a27-56db326cbbf2", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e9ea083e-efff-491b-9b92-49f594711000", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c79b9081-0497-41d3-b2b8-36c61fbd6a48", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b15722bf-1c57-469e-966a-73f7b8318dc9", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dc49477d-1862-4c32-971f-945d103d1132", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fa519836-8c78-4180-a58b-f576726dc017", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5c6dfa27-1723-4215-ad67-232205abbd8e", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 110, 1, "ba363e11-fb6f-411a-b7d2-796200dd4843", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" },
                    { 111, 1, "3fe7f6ab-958b-4caf-8f60-88e4526a498a", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" },
                    { 112, 1, "f3613f79-259b-42cc-a565-279ea0d073c8", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" },
                    { 113, 1, "12c2a77c-9bbb-4b93-83fb-88f1a2e76612", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" },
                    { 114, 1, "e8972fdd-d0e6-432b-9e06-e55a7323a96a", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" }
                });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9341), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9347), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3157), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(952), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(959), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(961), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(966), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(971), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(978), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(993), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1043), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1063), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1065), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1068), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1070), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1073), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1075), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1080), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1085), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1088), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1097), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1114), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1083), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165ed241-f00b-435d-a891-979874bb034d", "AQAAAAEAACcQAAAAEEThf7VtQhVG5iAsLLe0P0IrjBBS+osrclDE0OijFISCQ/QFewnvQp4E0TJsBAsUJg==", "965b6e80-b9fe-473e-8b01-782eccede55b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25addb03-c41b-4d79-8ca8-480ce76cd2b5", "AQAAAAEAACcQAAAAENmphyuMoE9hQctJWNRroArAeQjxaCp2ZuEj7k6jnPTD0l+gvLtGMq4h3zyucFAD9A==", "a17f4f7a-4cbd-464e-b9c6-0a97b25d2636" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7b3c622-6f7e-47e1-ba63-b9f006af3c0c", "AQAAAAEAACcQAAAAELoGOSzO5PVX6n+H1XAD3alHJ0EAwoV5BLH03Q4/pkOYuR49dnVawnpZiuEvxds4Eg==", "41b1233a-4699-456a-ac0c-3278905bb78b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00d861fc-ef18-4cc6-ad52-5e9d3079ac77", "AQAAAAEAACcQAAAAEIciA1fg9HEVjnKzj6Ctv9t2uaIl2Me1v2mnLhQMBhofRu5+ZcZ6Zfl/q5v0yU3Ixg==", "59aeaf32-3482-4977-b8af-d3cec82243f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a74f895-cd74-4ece-b630-629cf49f02dc", "AQAAAAEAACcQAAAAEEHY7aS3q1ZtfxzK8zowLRbrzUw3seJljUlawAlTBwy+eNN9zsczsRIsHE1uLHAAew==", "0610a738-6924-49f5-96b4-1001fb0edadc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1ed9c0-0b3a-4c16-a7da-06b401f1a9a0", "AQAAAAEAACcQAAAAEKes0P/rfDisb05O6qqyb0hTMiz0tdSRFUvYh19UwgzN7yJjhud3TteOBX7/NxO+oQ==", "99a70ab0-b720-4df1-954f-f196cb947e12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageToDevelopers");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DropColumn(
                name: "IsMultiple",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(607), new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(615), new DateTime(2023, 8, 25, 22, 23, 6, 145, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6983), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6985), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6987), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3461), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4987), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4983), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5001), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 4, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5010), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8285), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7084), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7089), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7093), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7095), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7130), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7135), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7142), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7146), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7148), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5808), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 8, 28, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 8, 27, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(815), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(816), new DateTime(2023, 8, 26, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7503), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7506), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6947), new DateTime(2023, 8, 29, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6953), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 8, 29, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6959), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7581), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7583), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6297), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6314), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 8, 25, 22, 23, 6, 153, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8466), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8473), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(7253), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(7256), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(1256), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4d825e8f-391b-4742-bf51-6d8f48638098");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "693efedf-c99c-46a9-8ce6-745443abdb95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "603e4229-6249-4aa3-b14c-45d5a8a54a7c", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f923202b-4d56-4cf0-b128-53d13bd62762", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "974f5070-ebbb-4b22-bdf9-89769ad6df63", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4ebfaf5f-d22f-4128-97c5-dbf129a0c166", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "11269534-a757-41fb-be01-98586472463b", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "52678fd6-2883-441c-98a0-a188649c4f04", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8bee7e14-0a8b-467c-b9ea-dd045f10b7c7", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c5058861-c852-41f1-98e6-b4476eea0fa2", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8abea24e-9337-4419-a126-86132a9cf10f", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f3dc6713-7c19-4c44-9631-4b53ebde1503", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "92405edf-cb69-4ba3-89bf-6576d6fd5e60", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4f491f41-f43d-4f53-92fc-27dc583b017c", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c0c49231-29a1-4243-aa80-8f761b0beea8", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "40b82507-9162-4722-8d64-47d7f6c29c79", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1861f09c-0b49-48ab-958b-1a810feffca0", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "52b7cd83-90bd-4a81-8b5c-0d1cab781fcb", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c68bd7ca-970e-43e3-907f-e59a3adda42b", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8df95c68-28cf-4169-bf04-5e9d1e13ecac", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "70e4d6df-c85d-443d-adde-8dc5c29a1af3", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e08ab948-1314-4957-b95c-9b5659d83fa2", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "41b3048f-7a7d-47c7-9496-e4ecbf258c65", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7193c4fb-4180-4f2d-8fc2-f32996d6a49a", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9e1dae72-28aa-4397-8033-a7fe5048035e", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8d661292-20c1-4a22-b02a-102836e8eec7", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7e97508f-8a13-4df1-bd4e-5c51ec3a19b3", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0f604bf8-7f98-4e98-a02b-14089a47b9e1", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "560b33c3-70f0-43f5-8186-ab1e75c4412f", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1f9103f9-462e-40a5-9b7d-8d823a7fde56", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "19f180ae-eeb1-4c0a-85a3-e15378b2ee51", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "41c511ac-4264-4050-999a-dffc3ceffff3", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "41388111-3ac6-4f91-bf49-462a34c7c13b", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "550a372d-6eb0-418f-b3f5-c0bfad0c0df5", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9632f4ab-a2c1-44a1-95a2-ff384f7bef00", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "70669cc3-3af1-4d7a-8dcc-6523303da605", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f51fe4d8-6598-4725-975e-dda602d47a34", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "787508d6-5594-4142-aaab-ead0a5b99993", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "77d7b195-95cc-4192-863f-3d77e83a3cc2", "Brand Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "37f0b6b5-d83d-49fa-b2e5-369493c85eef", "Brand Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0c6824e3-56f5-4299-b26e-09fd472541a6", "Brand Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4041a7e3-6464-4092-8bb4-e11cdb4ba123", "Brand Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f2b09ce9-61f4-4164-87b2-e00d43a38f06", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "03961922-21fa-4a89-a2b5-183839de1508", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7f777d7e-4b86-4a3f-9f9f-14c7c73fcdea", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "19d99656-5e73-4cf6-8a1f-6e6239675b7a", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d266041e-ae34-46f3-806d-e364f502ba26", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "934d2677-b258-4a4e-8e65-e9e10c74683b", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7400d1fb-f71c-48f8-99e0-00d9e97ac477", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8771db93-b1cb-420c-9473-959ce883f59f", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bde1fa87-26a7-4090-9d37-ed63c250951c", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d4c4d798-a24b-4255-ad12-54453d5fadc9", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a94dbd89-01e3-46f0-903a-ad4960d9908a", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "215e4657-89a6-4eba-8b01-eac99b4bc12b", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dde88e9f-2d78-4e35-8b3a-01da88c52b75", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6d3bca40-c902-4d2f-8f11-9cc5bb24dbab", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fae5f545-e626-407e-a215-14f58f5e4831", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7b86e233-2a02-4c90-97f7-2def18575dcc", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f903887e-1dd4-4316-b1cc-96808f6e183c", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a91d19fb-f0f0-4f41-9ada-89c011979625", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1e1f45a5-e909-41a3-8c48-43c39b77d130", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "61012286-289d-440d-969f-4644d2ad25cd", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "12cc7235-9146-48be-8fee-e55f7bf05711", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c41e20a5-fc14-40eb-8778-6e8f1634e239", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3863dfcc-32a4-4c06-8921-3402616e65aa", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2516c599-149a-45e9-809a-216e95300f51", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3ba48350-6f2e-436b-be76-e1ea2a778386", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "cd5d2407-6a44-4112-ab01-91e925cf5f51", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f325b5e1-34c0-4f6f-b737-dd8dc80b6fcd", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6773f1e6-5946-4040-86ba-c2f77841f804", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "562c8a97-c2e0-41fa-96f1-76cab23c37c3", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dd8326e9-6ac6-469f-9ce3-01579b661144", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "607edb19-9275-48e9-aa98-8cd8823ea785", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8cc3aa7b-87d4-455d-9fc2-a44ce03c63ff", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "919ba576-4bb5-4c20-b909-e0144ef6e13a", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d6c70249-8863-4ff1-b221-0b1146080628", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2d080fa4-dcdb-427f-8996-ef97eeece1d1", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b0815c2a-877b-4733-a8c2-c55b6f9b2c53", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4f476b60-3bee-457d-9ddb-520545b01024", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "585f3a71-80a3-48fb-9d59-e61c093509ed", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "74adc637-bf28-4360-91a6-893f57ca5167", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d01d6b26-9a18-4c49-b824-08e720c87bfd", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "f7645071-6ed1-40a7-a40e-e7906ee96d61", "Markalar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "bd574d4d-dd5d-4bf9-943d-745755317e2a", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "827d3767-d140-4ba2-90a3-6bc3ad28de08", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "7d218000-35a2-4c15-a6cf-53fdd672fd46", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "29a3422d-2b91-46bb-b6c6-3ca6b1428fd3", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "22540ae4-77a6-4eca-830b-bcb0a805f718", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3a784efd-7382-4a05-a708-559a1aa46aeb", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "93eabb07-ab11-4de3-9d92-ef36b20d5063", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "cc3f4a81-9b8b-44eb-9a2f-df2c23cb431c", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "73745f27-722f-4500-89a5-b4cb310cec33", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "72f23b83-7ddc-482a-bd6f-8684a7422368", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "c19e269e-8de4-4020-bebe-7384fb32878f", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "d1830361-6731-45ce-8ebe-e46a4ca77066", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "655dbcd7-c98e-449e-99c5-8cf85f9cdcf3", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "17756c15-1d24-49c4-acf9-d5c04beecb32", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3d7a5457-3f0b-4282-b750-ddbbcd5ac53b", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a153708f-3128-4e9d-90ce-f78854ad3f6d", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c101058d-1dca-43e7-bbbf-7f798eaa1079", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "70bbbd58-9b24-4d49-8478-fc5477105379", "Markalar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "204c82e2-a49f-48f3-9f67-f68bf3a2f785", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "767f9e7f-1852-4049-acf5-6a70d3b30d17", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "310693e9-5694-4989-b61f-808746e4307c", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3bee7cce-e61b-475e-aee3-9beab79e9625", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2d77b580-7e29-4787-8b9f-f5ebebf24ce1", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "935fbb72-5bbe-4133-93e7-10b77677a634", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "eecff98f-d8b8-46d0-a303-48ae9b516897", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "cab4073d-e1b5-427e-9b57-a6d4a9eb3d36", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 8, 25, 22, 23, 6, 144, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6654), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6656), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6662), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6674), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6678), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6682), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6684), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6686), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6688), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6692), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6698), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6702), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6704), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6708), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6712), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6721), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6723), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 8, 25, 22, 23, 6, 154, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4456aec-05da-4369-a780-248c0eb7a16f", "AQAAAAEAACcQAAAAEC/zvqvXBtqjHoA+AMuIdXagzsxM/feP+7VGiD+9IZOOk/7HSWzliLzi1J6giPttfQ==", "235748a1-fdb9-4786-b158-40f8dd3705aa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0744faf9-be44-4c25-a412-9f1d152a4980", "AQAAAAEAACcQAAAAEKxHwc1X+XuKNChk2E3jXNtSrT2kX7iA1zYJ5OCrKW5LZYqSdc+UYmU+azxhPlWoPw==", "0023725c-9e9d-4369-ba26-63b85893c173" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f25f9f2a-29e8-4845-b330-2b9ec4daf83a", "AQAAAAEAACcQAAAAEK5h/mN2+kYRqa4Ws+de/2V6E+itvDuRC7fa9Kt+n0Uy2JQzo8WZyvPU1tvvij9rQw==", "7cc6030d-8660-488a-8020-4fdcd74705d8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb87b5c1-32ac-4d4a-9f7d-4fcf2416eab1", "AQAAAAEAACcQAAAAEDKLk6GRefFj31Q5fw91rC03pgdOwGblV2enK1t7aNxvDzDw+a3FaIfD+hg1KIizfg==", "f331b1d3-a6be-4d3a-bd95-42f85381c7e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eda2806-7057-4cfc-ba84-a9b15f9883ab", "AQAAAAEAACcQAAAAEJwVGRFmQD3wpybCb7XTX5wbXZNeSUv9cl6pEb7qYbwqv9gAQMm7Jtrng9UKzi2AxQ==", "49a14af4-1769-4077-9075-115c27061b4d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e409068e-b11f-43c1-8077-eb0b68d0b8f4", "AQAAAAEAACcQAAAAENp0CrPOB5h+PcblWqSYn8SROlIRuyMGLMvBSiENkNCr/c5q+Ork3E5YbuevHVp/pQ==", "6184ba72-1809-4bc3-a6e7-750c380aaf10" });
        }
    }
}
