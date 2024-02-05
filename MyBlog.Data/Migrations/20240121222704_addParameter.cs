using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addParameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParamCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParamDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamValue6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_Parameter", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 56, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 1, 22, 1, 27, 2, 56, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local), new DateTime(2024, 1, 22, 1, 27, 2, 54, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(29), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(733), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(736), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1619), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1633), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 1, 27, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 1, 27, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 1, 25, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3625), new DateTime(2024, 1, 25, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 1, 24, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 1, 23, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 1, 26, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.InsertData(
                table: "Parameter",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ParamCode", "ParamDescription", "ParamType", "ParamValue", "ParamValue1", "ParamValue2", "ParamValue3", "ParamValue4", "ParamValue5", "ParamValue6" },
                values: new object[] { 1, "Admin", new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4164), true, false, "Admin", new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4166), null, "SGKTutari", null, "Tutar Tipi 1", "1000", null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(7975), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "20dcd987-9185-4e2a-94fc-c198d4e9a566");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7549b87d-0f7e-4c74-a123-ce753b1858f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e0143873-452f-4a8d-bd74-2165a377fa37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "edb6a821-71ad-4d8b-8c0a-1159d6ec68ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a5605ea6-3399-478d-8c28-bdc5c8ddafdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "9134d43a-4cb2-494f-ae86-385b5beadf6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "e0bc050f-75be-4c07-a917-95faa1089bd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ce303e85-3cb9-4826-a564-cc7e41712ea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "403f837c-df0d-43bb-aad0-038beff01591");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "4b3c904e-840d-4ab1-8673-f3eac2a864d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "9a2a2fde-dfba-4caa-b58e-4e9a5e365be1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4a869f14-f77e-4d3b-b113-7b95bcd90bda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "50f77cff-d8a4-400b-ac7e-84c117139852");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "1eb1b60f-6c71-4495-ac5e-a242ceaf6ed8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b6d7dd7a-4583-4c5f-ac11-3e6a2e87de6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "9f07857f-630e-443c-8b39-4d1f766ca48c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8563b671-a2e9-49e6-9e79-03476228a630");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d3145b3c-857f-4d94-ac57-2ceb50a9fd98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "4567a30d-7c69-42d3-a186-079805d73a3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "42cf68fb-f115-49c2-88f6-23f0b7eac19a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "22a1308d-d870-4122-bdee-36e90157aacc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "ba468d5b-6d23-4536-9cbe-499a78f91016");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7f977a71-3640-46df-8652-12d7fe328392");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "a4bf0492-45fc-4e5c-ae7c-67313166e509");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "4ee3375b-82f0-4035-bef5-1135d2ae4ac1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "0c8b9ff7-be92-4db2-a233-cf6e42163f55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "0a0ed6e6-4a7c-4c65-8bd9-c3492b4437b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "b00573b1-c1ec-4e03-860a-b34b579a3cf3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "ec1ced1d-cc6c-471c-9c85-b30ac54edb84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "cdb28a4d-2240-4996-b276-5fe098f3d554");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "0850558a-0ad4-4a7c-80d4-ff0e89486acd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "a994afb7-6ecd-47f2-abd8-ed3a5e11b99b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "48cf0082-8b90-49e3-92a5-e21f0e3290ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "b2ada370-f310-4ee4-844b-707c3dc01b0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "cab30588-2f8d-4cb4-8cfe-0b3aa0f10bc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "b18e97f4-591b-4ce4-836c-1596174350dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "5ba6bc7e-d4d9-48e3-984a-e92b07ba5761");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "43d01da7-251c-4ace-8dfa-ae0e160cdc76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "564955ca-e606-43e9-9c02-3f0ecab45e5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "fcdd499d-d959-4920-9a40-32fefa10c4ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "eba4d359-9fa4-4947-8a0e-f968ebe143f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "b8cafe63-2815-4096-8342-df2fcb5389b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "6dd131b7-b862-4f6b-93dc-9ea0433a38e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "9b7de024-b1e1-4816-a29a-94630ce954ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "5aaafc88-1a61-4267-b05d-d45c1efb4ea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "15555e56-aa45-4a54-8d29-6ca71b66df42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "3102bb8d-b563-4419-88dc-9883783661f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "5231f234-650c-4541-a2b7-3a77579a9518");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "1ca45ecd-64f3-4156-88e4-92456d7ef284");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "1fed942d-2aeb-4531-80b9-23990f3a5e4c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "1f870f58-4931-4983-b3bd-bdadf7edabe7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "e0e8dedb-ebbc-4645-baca-b7073a56dcc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "3f93153a-9990-46d2-8e78-deef7fafccd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "b61bcc25-3ae8-44eb-9258-835af94dd844");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "368dbb3d-c37f-4705-b78e-de84f7029832");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "11dae935-5fc5-474d-86f8-a4334f2f18a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "e0ef4fa7-9230-43aa-90b9-abbe1df3d36e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "68b18ad8-1d79-4f54-8439-44470842d168");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "dddef4b7-fe7e-455f-8c63-0365cf8dc8cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "fc3a8eb6-ac14-44e5-875a-e339a48bf547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "ab313ffa-3be2-46fd-b38e-ee9915b4ba0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "4e6188ac-f2d7-4289-883a-dc5d057ee62f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "32a9c41c-991d-4f7b-8941-b9a942226c8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "08fd4e62-12d5-4555-a43e-ad1fa59205b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "fbacfb8b-eac3-4fe4-8184-095365272cc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "661b2319-225f-4402-a6be-6c3e9613b2e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "8dbfb6bc-ab7a-4326-b5ac-2460d06b0fec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "eb3bafaa-f7eb-4f10-b5f7-ee676192bca7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "78e8323a-4c42-4b45-b7a7-f9a7a04ace25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "cbf868c7-5c42-43a2-b0d2-1b9661a7738e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "30487af8-e3fb-4f38-9761-9de732f61017");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "07c492e8-88ce-486e-af17-39c1a280ddb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "90f5ee00-3576-4671-a5ae-764f8fb8f7a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "1f480f31-bba2-4fc9-9cff-6aed8b559005");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "e18dc7f5-7764-4cb0-9603-cf54b23ddaf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "d78b95ff-ec89-46bd-a922-56a3268adb3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "9fe19c6d-70df-4a88-8d3f-1f5b2b54f7f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "645f4d17-d920-40a9-b045-ce1c49820218");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "63e722bd-9789-4149-8607-7fc201b634af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "197cf3a9-0683-4c42-b8fc-565f31e550b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "845f4313-bbe9-44a5-bc66-cb1e81f35724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "6c72974e-6b3c-4fec-a883-fe760865fa50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "8f089dc1-9d1b-4890-bc80-247c03a16699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "bde44a9c-a799-4925-b0c2-34602fa2deb9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "876a4980-96b8-47ea-ad3f-32e009ff1334");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "8e150daf-b420-4363-bb6f-ec9620052ad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "e656b547-1a4b-4d2c-b67d-e20b8954b0cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "0cb5f009-8ed5-4fcc-b11d-2f1e01f46f3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "a50a095d-752e-415b-883e-18a50591cbd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "56a61d8a-609d-46c7-8731-91f508700369");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "0dbfcee9-adf2-4680-9929-75d16902dd6e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "6d159bb1-4e6b-418c-9886-b2656dc5f402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "3b29b039-e3aa-4ed9-b586-d28c3d8b5afa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "3a4bd1d8-3810-4ed2-b0d2-7b6b20e7ca4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "ce8371e6-ee0c-4964-be30-41aede0b7d3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "e220be24-276d-4b81-9d58-29d2ee90bdb6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "1d34b36e-d2ee-43e5-b074-fa0afe101ec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "b5e26950-4d22-4471-905f-9c96df9336f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "e1f6610c-9db9-4743-a0d1-f007a0a26c34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "a05c8edc-43b7-4405-bfa6-56cd5ece4862");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "5528cdf7-e0f6-46a9-971e-29fd011eb6f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "3c4751da-b974-4ed9-acc5-09cc8cce9be7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "c75393b2-4025-407b-9457-a40afebee51a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "7d19f638-9790-498c-bb23-84cc10cc8821");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "e2d96b54-52e6-49e6-9644-fc80fdf13f1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "07820b0f-936b-4a01-aab4-c3d5fc05f055");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "152e4171-8492-4acb-b2d9-f680981e94e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "9ae367bc-2f46-4f54-a5ca-e38f5e05f10e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "f6b1bd6b-2915-46a9-a891-743ee22d0c91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "5b46efc6-48b7-40d0-be0a-063c0789fa58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "22f36f71-4bc0-455a-9bd8-cf6657db3b00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "b9978755-e577-48ac-b015-34aa4f508a26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "f9b801ae-83d6-44e0-86c0-58ce8ef65157");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "126b1596-2101-42da-89e3-f786cf33184c");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4636), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4709), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4733), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606a19d9-7d7d-48c9-b0df-fa1eb2484c68", "AQAAAAEAACcQAAAAEPiluVJfWC8vYQEj+sLUZGsfJbjF4wlUheVMPsaP7W8mOiwJgXU+0sE1e66PRpeXug==", "55ab3b9b-548a-4ff1-8643-00bce58e51ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2d625d-669c-46cb-9e37-9dec82a1ce0d", "AQAAAAEAACcQAAAAECEYh5l9PIx+sUg2IbEuVYr63E5Nb6WY3dqEn24iElMjj43LSifiENs0Y42ZLLHAMg==", "dabe62de-4a8c-4d54-bcb5-18bd85a47f32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d79b5d9-ff18-4779-82c8-047a593b16e2", "AQAAAAEAACcQAAAAEMLV2d3WyGzuFmObZ0/BCCLcFj2/vzrBmWivvx/LNudlVpOov6zmgMytnZ1FYmmyrw==", "646b8a19-068a-4ee0-896e-afa8a2da259c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cceb2878-3832-4520-8e70-271c22d14f75", "AQAAAAEAACcQAAAAEK5EqaDd6CNWihY4Jsr9I5QdDEBLzagdI5Fa91wpvDdAks3akHFflA+mxpoisl6Fcw==", "aae8b87b-03c6-4418-99ff-eed8c55d5766" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da6c910-56a6-41c7-85ed-5f92b88d7c37", "AQAAAAEAACcQAAAAEEfokPkpd92N/m5cP9Jg+yuK6MLwDxvVQueOolakvXZ2cfNezj0BsRvU9279oRh8yQ==", "a910d632-c76a-4d28-8e8b-6302b623449b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cd60555-ddf1-4d2a-8932-b41aa9afbd28", "AQAAAAEAACcQAAAAEHAWBFx+qzuAxfJN0OKsUtzLC+efYdoA+73r7RqKuHwujdWVWyC4XIDO6VCDbv1s8A==", "a6592dbf-3c32-43d4-9548-2f627c40c836" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09966a6-264c-4790-b0b5-2f89dadbbc00", "AQAAAAEAACcQAAAAEKbyUS8OKZ2Pbmeca2Xy/PvkFVndCGCr1oaIrfXyuyuxFauus9xrWoGFrqhKFH+mMQ==", "e433ea75-47ea-4964-9322-a8666c73ca23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbbd4d98-fdfe-4787-b0d5-4120b2a7affa", "AQAAAAEAACcQAAAAEHOr6G3ZVwVfBfQmo2iy48f4OcDo8imCArDEIxUCymaO6BxQhLKO+5lubR4HTqPw9g==", "72724547-d147-4b1d-bc13-a08107af7a74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bd6cbaa-acbd-4daa-a297-ce107f1585e5", "AQAAAAEAACcQAAAAEHMfidHvFYFsuL6S7jGPtrU6qr+ZjI4XrabqIA3Vr2ecO+qrqe6z7njNlxl2KsuTRA==", "21a55213-bb0e-40df-8290-624517b851c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameter");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(6678), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 170, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 1, 22, 0, 21, 16, 170, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1719), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1718), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1722), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1734), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1733), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2530), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2540), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2542), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7355), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 1, 27, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 1, 27, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 1, 25, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 1, 25, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 1, 24, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 1, 23, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 1, 26, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9867), new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2819), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6243), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d966162b-1e88-404e-aeea-86db4a1bada7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "efb64fea-3916-4729-858f-e480ecb17e84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9e107391-eb6b-4507-ba2d-8e03ca79fd5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "70ef263b-6d42-47e9-95f4-3e02b27c7e46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "02130c62-5807-41fb-bcb7-442bf5de56d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "f430e11d-9653-4b2b-9bd6-bb1051eb1917");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "de53bfd7-b030-4a48-bd41-d37a32e77edb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "030c9613-fbda-4f20-98fc-612c527f646b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2943d438-6395-4fa8-86de-eca41e3b89fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "e11e19bd-a043-4c46-ad66-3b81c88ba199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "35967672-ee73-4402-9a4e-457e896a27af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c6c71291-9415-4ddd-8600-16b007ade705");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "9767019e-6a51-4009-9944-6dfe29ede42a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "01e59323-485e-4936-8905-1f9f4b4829bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "f61d3422-a95d-4dad-b3e6-025d5b84ed1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "8f98bd9d-3331-4144-bc8e-9097e953ced1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "af36fb13-4421-4e00-b3ae-454c1a39821f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "8ab8361d-5899-417c-99cc-5016eda97486");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "10902450-3c08-4643-a7d6-d9549684cf63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "8abe83c8-9a4a-40e6-a65a-89658128d1e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "37ae46ce-a1b7-46f6-8400-d7900ad76066");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "224c6bbe-7094-449a-8d3e-08aef7167ce0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7f53e15f-bbef-42f0-9b2b-dfe25e6b62ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "e507f73d-4c99-40a1-967e-cb7c43689fba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "dfc13ce1-b613-4a40-b67c-e6ae695e39cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "ec9cd8c4-d6bf-4aa3-96ca-fcd5f0b29fbb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1a4cc926-3df5-4164-94a4-0a907eb22b6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "852e8806-49d6-4521-9801-7f896fa96b70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "4b37548f-c593-408c-a20d-caede51d0a5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "9c572b2c-89bd-4e36-a7f5-39184cbb7352");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "8ac5517a-bef3-4178-add0-541d169c4548");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "c2c611f4-c480-4827-b129-0f03b23907c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "6b406e0e-dbd7-4880-9137-7e1d18856198");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "7f38b5d7-489c-4c5d-a211-90d1dfae1e9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "d911767d-5bea-4a7e-aa16-2d51c0ca051c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "9302579a-d7a5-4835-9694-51fdb1b462eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "2d07a1ba-c75f-45b4-9f2e-4ebc876762eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "bf877acb-5d83-4312-8868-2f12ad4fb037");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "5e08ffd7-39fd-456d-b920-1ce848c9db70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "332d6e1e-a2fc-480c-97f8-ca9519eca3b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "f908a3aa-f675-4db2-add8-8fa0e1442c24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "afff12e0-1f96-4721-9a9e-7aab3879fcd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "932130a1-a686-4cfb-95cc-c5154e4e4f21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "c5e1a067-e73c-4f7c-8955-77cb184a7d1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "af2abfac-990e-4070-872f-3d8d27410bd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "781f259a-5f5d-4cf4-8f47-47c7bccd596a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "ed6d7928-b5ae-4845-b0eb-916b92c0c178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "4c56576f-8ea5-49fc-9ad3-e90003a5fb37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "fad5d729-a23b-4715-86aa-8256e0bf5388");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "fda0bf23-68c9-4489-99fa-401e92e89b80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "0e7f9e54-8c82-48dc-b8fd-48e50f0e1b9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "2173d0f1-232a-438c-b752-b6bd70e3384f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "7ab0e6ec-6089-4eb4-b367-947fc840eae2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "ae7c45c2-d96a-496f-8d49-649d19735000");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "9473bc09-b480-4715-ae57-b116c4273426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "d4dae555-ed72-4d95-9478-f30574b36673");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "00e90780-9820-465f-b5c8-61f849cfc6fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "edef845d-6ce5-44e5-9a93-62924733d50f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "6d328db9-dcbb-466a-9d96-518e28249948");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "bbac0534-030d-4e90-a50c-196b13f1d439");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "75c03c9f-66fc-4352-8be2-e7ec0158a237");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "37de9560-ccaa-4a60-b215-05f96f20089c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "1bdd5903-973c-4091-b3fb-15a51438a022");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "cf3586b4-2b4d-4dfb-8a26-c98057328ba6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "cc273186-498b-45ba-987d-1cd302316660");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "cb521e46-a593-4780-b4e2-18a56f109d86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0408ea44-3671-4c74-b9ef-a35f242edc7d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "11995391-c8b7-41a2-a4de-364c5836fc2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "e99b1445-ecd7-46d1-94e6-21af3a07e1ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "f60c2db8-fda6-4ed6-8abc-591b0ecf0da6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "a738435b-0a90-4cb4-a93b-9a032b51fdf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "016afa8f-a3b9-4f45-b2e2-7a3f5c1ff40f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "d3b87712-e391-4d63-8fdb-930ad72cfaaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "da7e7e66-29d0-4de7-9ebb-a9f232563bc4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "46f9df14-e376-4625-ab4b-4a2604fe196a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "39f6d8a1-0f8b-49f9-b06d-a838aa1d7ddf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "bc186b29-64dd-442f-974d-47a60889c131");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "c41e83aa-c4c7-44b7-ab94-87c3ee40be81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "969d806d-7647-4d1d-9df1-a5b1441c4b4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "97118617-357a-4d6d-bbaf-35174e83ef10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "abd8fc31-8afc-474a-800e-f8a2464eae13");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "a3a4bbbf-078c-4bc5-a2ab-25ee3cc66e94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "e051fbd4-086f-45cc-b4a6-bbce2cef18ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "b79c06c9-5476-4adb-a8db-633bec3a66c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "99c47e67-c3a4-4daf-bc60-997c3b950ff5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "c58564a6-a49c-4daf-aff1-c21d6f662664");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "6b98e28e-b71a-4b0d-95d2-a62a27ea773a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "90e616b3-eefd-499b-a265-3b8bd3710a2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "d8d9367e-3ba2-4bdf-a3d5-442551608d01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "cf17119a-addf-45c0-ba87-95528ee2bf3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "75dd193c-e2eb-47e7-805c-e787bd0d09b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "79bb7d70-1dbf-457e-8143-b692904d8370");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "36558ae9-7431-4613-9ac5-30ad6555a12f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "bd7087c0-a354-465b-8e19-2667db219e07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "ce22e7ba-319b-487e-b73f-a91017e145c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "58d8ee19-c115-42ca-8be8-aaad61136b04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "4cb66249-fac0-4eb5-adda-67eb49d07346");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "1a90a775-a44b-4a97-b990-8daa98e56bc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "dbab7a68-372f-40f8-be2a-e30ac9feb6bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "a637040c-b6af-4f94-9233-5aea8aa8285a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "f56323d1-aa93-4f08-a183-888db28e17bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8cae6260-90da-4b8b-8cb6-9631541caaea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "c4eac499-44c6-4bcf-8825-400836cae49b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "7e10c480-adc8-44c6-ad8c-8381c2b109aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "98684171-deda-42d4-a187-6f39909eeb1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "32d8aca6-a71b-407a-a694-8b1de820f7db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "e36b90ef-634b-42c6-97e5-aa0679c37f8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "a5a9064b-6bcb-4a54-bd60-0f8fd82e565f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "deaf15ba-af86-4a37-b2fb-c78bb5fecdc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "e122a9ba-a755-4814-8609-d47dab2e265b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "a24075b4-9b65-4105-8538-507788661b73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "4dea543f-11c3-492d-be8a-cab28de50bb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "869d8356-6b3a-43da-a0e3-bb5f8b30f083");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "2af8fb0c-55de-40c8-8b60-bed5d2f0ba74");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(1132), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6724), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6726), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6736), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6765), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6815), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6826), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6847), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eac6f58-5335-478a-8b6a-31d87ed76d64", "AQAAAAEAACcQAAAAENEfB1qTAvxFMpfWRGsFYj7oYKCgdYWOBLFGdW6ia9Lx05c7ECvdLGk2CGFpIQDmaw==", "3d809c2b-bef2-459b-bdae-9b2edf99f57d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc6cdee4-ea7b-4ae4-b0ff-f6cf41dc0d76", "AQAAAAEAACcQAAAAEGBDy99mcq6nB0Ybt83G6btks7FY7B2g8mYWbHU3VuCOyY+pKBE84L5zQDrIZ5GHLA==", "612e72c5-46dc-4f3b-a86b-8a8153afb2b5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36064451-d133-4d60-9681-3f55a7fcca9c", "AQAAAAEAACcQAAAAEK34J6OPM5YgLgMHLnPKL1rBLzNAek1s9sugl3E8vdhXibJvh5payUICtB7Id2jiPg==", "655f2dc3-ebc1-4382-a6d0-f887fa45df05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "575237eb-9d81-45b3-a484-936c1c960290", "AQAAAAEAACcQAAAAEFX/19wSX0rpTqH1fbHBhC2Qq9kaYMcQ8BBNsQE8f80MO81+5FjUiQo4VNcA/WQLNQ==", "5a476258-061a-47ef-a9c3-42bee15c8175" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3461a10e-f128-4d9a-8688-9f24ec23b120", "AQAAAAEAACcQAAAAEMnTOnF2K2f56QsMbs2UsOBA/7QM5707ODaB6uh9/bDXPdxDaMxuHOPoWpJOLD8fIg==", "ddbda3cc-b142-473e-b3cd-10d2477d0b47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449f205a-237a-4886-aac6-784f194d9ab7", "AQAAAAEAACcQAAAAEEUFXfXKBOtqLDVTGWoCZYBMXCkcIUCUOs/7l/hFRMzW2SFtbt4VDUu1Od8/79lj4A==", "2f85b9cf-1257-4c61-8336-e125d68c2eb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e679be99-9f9f-4466-9139-0f1842bdb24c", "AQAAAAEAACcQAAAAEHOaYteq/JasLEf3ifvbfRNddj6AxthZcbhimF7/rQnj3KPFOshh7jj7xK9414x7Kw==", "b2f93aa0-c5b8-4d14-960e-f387b4e3eba6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a3a48a-dc1d-40be-8948-da3ffc9cb53e", "AQAAAAEAACcQAAAAEMoR9DHhoKtCBQC4e3jROGEq6eKI3scbmuaBjSLRKlnD+CAe3p+dULxe12LOTsfNog==", "1e7b58e5-8975-4a4a-b28c-4a9dad6645e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda31830-07c7-4f78-8ae8-c45a6d346a0f", "AQAAAAEAACcQAAAAENVxn7wL/ITIITkkIceSxHhiN3ozkX/x6jFHESUB7oFrASXpaHvWtm/Q4qIcJ6hERA==", "437128bf-8d7c-4c8a-851e-08d564350c4a" });
        }
    }
}
