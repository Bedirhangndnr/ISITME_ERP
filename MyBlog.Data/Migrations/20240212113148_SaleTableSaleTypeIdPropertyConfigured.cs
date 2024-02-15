using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class SaleTableSaleTypeIdPropertyConfigured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 366, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 2, 12, 14, 31, 46, 366, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(158), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(156), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(162), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(167), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(166), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(185), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(188), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3139), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3145), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3147), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(888), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(891), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(900), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(910), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1799), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(3507), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(3504), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(2808), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3687), new DateTime(2024, 2, 17, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 2, 17, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 2, 15, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1446), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1506), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 2, 15, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 2, 14, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 2, 13, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1841), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 2, 16, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1912), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 2, 12, 14, 31, 46, 365, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2411), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2415), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2423), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2427), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2433), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f9433d9c-a941-4924-82a1-49027c0e21f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "59530cda-a3b1-4594-9011-5b5e18af67af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cccbb011-eb46-424d-aa67-3feecad5f654");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8ab850f3-f4cb-4811-b89e-aa9c9c6ac74b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "add94e31-f74c-4ef3-83e7-2c2992f01664");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "797e3c73-1de3-4e4d-a507-2635b93cbed6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d2f02cb7-6058-469f-bdf3-5aa8302ec381");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "2d1fd69d-033b-4b18-858d-1fadcdff8295");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "ac67cee1-5d25-4396-9260-b2a5316585f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d1cdf3ad-1be6-41ad-8d5a-b6d3a9248b7d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "358bd27b-f43f-4a30-80d5-aa36d5faec0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "3f71837a-bc3f-43fe-81ad-992ef093ced6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "ec4f9a31-c3ad-484c-a7bc-56efba420155");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "10cc3ed4-1edb-450b-abdb-2e2297f738be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "ad1e3cbb-5122-4156-9b88-a3eaaa817ec8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "03f3a5da-2b65-46ad-bdb8-7cfeb4b3985b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "1e5fa4f9-81e6-43ab-8a8b-fc2e4a3f5c30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "a7504565-f904-4b98-962a-7b969670dfbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "7ac8e36c-3818-4300-8788-24254599baa0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "51a68598-c264-4552-948b-03168ad0839a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "c7afbc37-abb9-4fdc-b9b4-67d6f1f274f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "a66ca221-60cd-418b-9676-ed9c732a0d6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "bea0e5a2-4583-4a02-a908-18badee452ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "c0354509-1938-4381-81c2-5ce4438b624e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "530ee4a9-816d-4c64-aa62-ed4c4efa191c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "c881f1c1-5abb-4e83-8af6-1617ab3e0682");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "87c6e44e-1b83-403a-8e84-357077d0bb5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "47779f1b-4dc3-4985-8cd0-19fbe988fa8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "9d18199e-d965-4383-b72d-033137cbecd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "f88de21b-0795-4354-8701-4ca59af114b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "9e4b8a19-4eec-4a76-8f58-7059ddf09c66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d8011393-d392-42f1-894e-3bde6b0503e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "99ac3aaf-8c99-47a4-9227-62c2b34fa3a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "03f43aa3-f258-482e-9d21-ff7da8abc337");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "103423ed-050d-4836-b19e-9a71d39b85a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "9ed5db30-fd97-4aa9-b738-77bee5a877be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "e554f19e-a9b5-47c5-a6f0-7bd5b802ef7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "745382c2-9a54-4309-844f-1f901661614c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "f415333a-7072-4ab3-a672-2c13cd1a15fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "3dc32c5d-ac9a-4b94-83f5-b8b5e8be23ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "793e7fa8-7f56-433d-b283-8e43e8f9e050");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "9803ca1f-036c-4a85-9a0b-146d2a415d25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "4786138c-92fd-4bff-8b30-ef1196261a2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "24cb787a-ffb6-44a3-ba3d-7aee4f8c1987");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "c1c9b222-f89f-4a03-bfd6-1661d86d6c18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "04ed76fe-0d20-4738-acee-1361b3005e2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "54c2ed19-9273-4ecc-afac-9e6e8535eed8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ab7bbf0f-6997-4df5-95ec-a795b7015502");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "04abe5d3-88ed-4010-9802-46392e9f8620");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "d245975d-1f7e-4cf5-b7ea-a27a9b8a9d69");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "a089cc4a-34ce-430c-aefd-702cbc2c8879");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "fd29d0dd-e990-49a5-84f1-72be7fdc8966");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "1215cf2e-1e8b-4817-95f2-db70267432c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "6ebc1f76-62cc-41c0-9bb7-5e7663f781ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "e8be92c0-a499-42ff-ab67-a71dd4fac877");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "4a18174f-a299-46b0-b21e-1fe701f6740c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "377bfe03-0a1d-41e1-9c8e-b6e41d6e5d1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "cdfed9ad-8ee0-489b-ac3b-09be2e7ed610");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "76f5cd8d-9043-4367-b2bf-6459355823a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "65adc0de-455a-4b75-b536-27d029e1b702");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "5ac586a1-89cc-4aad-8fae-0b5268cb8422");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "518b0d76-75f6-4f76-b3d6-65eccdd72ae2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "e6265e9e-02f6-45e7-b633-5866a30727d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "3598ff28-fb68-4f8c-89b7-ada9e83f75c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "3e351b40-4edb-462f-8876-4ecac70c1591");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "ff7511ab-1083-41f4-afe2-bbdf6fde53c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "81f1ef0c-46b4-4563-8674-652258915eec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "c7cba4a0-e540-4fa9-a501-19062d9c984f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "7c8352dc-f7db-4b9a-a299-7127df5668cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "222efd46-9f21-4e11-89e6-4401277e3b76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "51b933fc-f386-4c45-800d-449e9dd942b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "053c2393-6ae6-43bb-878c-eeb3b16625ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "f5de1e69-24a8-4441-a43a-5459b0547d3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "d64af65b-8460-495f-8ef6-d32cfc7cc0a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "42869d46-8d59-4a0a-b4db-bdbbaff93732");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "efd2e6fa-d545-4acf-9ef8-33f43ba9d091");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "f2454d47-74c0-4baf-9240-7c43d45a569a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "9884b541-b339-47b2-b1f1-a08eed614b19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "1685017a-bc3a-45e0-b289-486af1da6dc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "ade06e42-db16-4d57-bf29-b2c60110478d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "e35b0d00-0620-43a6-be53-7aa476adea4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "387927a9-65dc-49c2-9e68-619e793f400e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "cb68923f-aacc-4258-8895-25eb577a0f0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "ca54480c-5cd2-4804-b2e4-c98dce589096");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "0112d171-a601-4aed-878b-7f4f5da46586");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "fa51c854-8941-401f-a645-72605aaf3b38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "6a436f29-07b2-45a9-b800-81770a4b1a74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "dc1b596c-3c3d-4609-83df-deefefd1eebf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "becb15cc-eac9-4e26-a797-da1cd37421ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "ccfdcd24-bc40-43d4-8005-93aa680f4c5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "73da3098-1686-416c-8048-0e6a88a984f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "e1504b30-da3a-45ae-89bf-50941ae84133");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "2ec60aef-83fb-44e8-be8e-ece7427573a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "57d45036-cf04-44ea-8046-580d173ed261");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "6c11018e-963b-4b6a-999a-1cd23424e9e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "90586e5a-4607-42c3-8192-4de30daf0946");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "6dc43c57-0e7b-41eb-84cc-cd205ff0c16b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "29c1cb6c-f310-4304-897a-062639f4a352");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "2f4d547d-5106-4f4b-996a-60e84cbc9982");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "56ce2ce0-8281-4aed-8993-0ce12d0b1643");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "6680de9d-2cb5-4e47-a01e-6bf6cefdd06e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "5d7e0e9e-170b-4e8a-b8c3-df923eff4b32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "6f27a476-3d42-4534-ae6a-90cf734927b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "f0481778-70de-46f2-b45d-65ad2d8f1fe5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "eb2e2366-4806-4d0a-8846-2ee9982f9b10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "91082902-ea5b-4552-ac3e-1e2b79842e9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "876d8f32-cd2b-43e0-abcd-6eaa0fb32b29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "769e2890-0d0a-44db-8a23-031432ee9712");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "e2f6e27f-3c62-4ee4-b424-da51778f7302");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "6e753510-c978-439c-aabe-b2e3e37442bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "6095404e-e490-4990-8d42-a38e0ba8d6d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "c0ed6d00-bf58-49f3-a63d-672d39036988");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "31ab443a-9090-427b-a1ff-0ae668bfc1a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "d138bcbd-30bb-4186-a5af-ac7473ae5721");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(7609), new DateTime(2024, 2, 12, 14, 31, 46, 378, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2869), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2875), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2884), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2906), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2908), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2930), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2934), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2937), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2940), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2945), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2947), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2977), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2981), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2952), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3033), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3039), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3044), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3048), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3054), new DateTime(2024, 2, 12, 14, 31, 46, 379, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50f2ea21-717b-4f62-8eae-7f93f0e126ec", "AQAAAAEAACcQAAAAEBYRAYkrH3UcZmzA66kcIfPx3vJ0eni1sHUEKcnKX3Xd+52D9j2RGQHWUjKm73DYUQ==", "4d0699ee-f088-4909-a340-c04b68fa5961" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ab7779-87be-4af7-a863-1915fe5e3610", "AQAAAAEAACcQAAAAEFQJBBkl8sB/+SmRkAETFkRlhPe4aWPTu5vF4eLjQBHd3ikFviTPMZtVxt6kaNV0pA==", "716be634-b298-42ff-8800-f9df0e3de445" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff0699e-14a8-4936-8086-14bedd92478a", "AQAAAAEAACcQAAAAEJFWqjCZQqRFF4fXx1PWdLy/FboVhOFJONStFHN0ColKcktyCqp8HGI14uf430bVPw==", "ca8cf764-7995-4503-8c44-17b934b0c443" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "917e8b36-23a1-4aef-bf40-c365a305eb08", "AQAAAAEAACcQAAAAEHt7/ttvxIkOk1xCJeX4vSAaLEkMedcCWEm4+htg2HcTBDy/RIg56UsFIIp2OIay6w==", "48dbb806-f58d-4259-bec2-f396f916b663" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b712078f-1b94-4fcb-a2ca-9afcc34b23ae", "AQAAAAEAACcQAAAAEHscr/UM5PWKZjQgdZ/30TROqqWLokuuW1ZgF/EjUifHhxCge7r+1vnSzLNlkLmhMA==", "be05fdfa-b021-4959-b1b5-0780dd66b716" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a39e6bff-d6e8-438b-80c0-de8f21c5a971", "AQAAAAEAACcQAAAAEPGlk25F+Jl61c+kke935aMABSENu8fzdj/iSBsFo23L3bEGp0uld++WxdESLffyDQ==", "ba853884-c8f3-4f5f-9c40-a8a0a12906ef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d420a001-95ac-4dca-991d-4c07793f8ed7", "AQAAAAEAACcQAAAAEBVIaXZBkpL5BWdNXCvCMrF5Mxw5iW85R6DX9sCkwlC9XsAaqurP0NtkBMIbX6XUnA==", "58e7707b-e401-49be-8e5e-c3d07de449dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f21d8a92-9e2c-4ef0-a18e-6590585ae4a3", "AQAAAAEAACcQAAAAEL5cdK1/ootK88HftPxi8dbmD852+jbZHOvwtu5DwiBz87owqgISTac5uTK1HF/OlQ==", "c39816c3-9ccf-472e-b265-0e7ab0532d75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c3a81aa-d8fa-4114-9e4b-bc442643eb11", "AQAAAAEAACcQAAAAEBkqOuua1M0wWBV4cPx/S+gonLMgh/v1fiWEhu/wwAqXuusBgLTvs7YR2JGRv7mvOQ==", "360f1145-758f-46fc-a7e0-833fa6002bd8" });

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(33), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3542), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 2, 17, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1540), new DateTime(2024, 2, 17, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 2, 15, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 2, 15, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 2, 14, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 2, 13, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 2, 16, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3097), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5458), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(316), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(321), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c0df2c0-b2a9-43af-8452-992aaf4db255");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "58180997-3780-4d03-96d1-7388999326ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "91f99943-107e-42c5-82c6-6719e631eb75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "fa209811-f6c0-48c5-b878-e5e5d348c614");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cded6cdb-aaab-445e-8afc-6f3ce55d1f84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3a8d6078-5824-467c-aa48-19027226e4a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "6c59e7b1-a03f-4a45-bdb8-de3e90626ba2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "78d7e625-8918-4a48-aa1f-3497797ea638");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "dfe19c74-8a7a-4b8d-9059-a8e6b10d5a16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "9d899434-716a-4281-ab3a-dba42182e097");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "28ec4958-1d3f-4b5a-b0f7-518c42f27457");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d30ca6df-d0de-47f5-846a-b6bf977c3736");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "0be78b75-3533-4d3b-ad45-69f8bfa5fedb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "c98c9b88-4de9-4531-bad1-c4cc69f8149b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b42e67e1-617d-456e-a4bd-6f0c2d0a0c4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "31144065-af89-4b63-8b6f-79a7f2cd5b6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "ee18b0ea-5cef-4856-aca8-00f153306249");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "3b710821-0507-465b-bfef-811d17871465");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "6818e788-c8c9-4776-bd1d-3cbeab907e17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "36c1c178-82d4-4421-b15b-14cb374ad5cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "a53bb794-6523-4434-8c9d-1ec19e5daabe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "e4e6af32-f15a-4d9f-b441-ec19dc56409e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "e70e3340-2226-4b2d-8242-6f25eec6fe6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "7df045e7-e2dd-42fa-961f-0e06da5573f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "053cdbcf-ffde-4a8d-8b7a-084619999823");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "bede3fd0-b6af-410f-9255-543e4450099c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "c92834af-bd9a-4c49-a444-3bd2b6e48d8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "bcfd4b51-3167-4e77-8a35-ca5fb0134234");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "372a8c1b-fc82-4b0c-8cb9-f10a02391dc3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "8385adc6-4fd8-41d7-9d83-84c57c56d0c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "5bb5a80c-32ce-480d-9d2a-7cab6e610633");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "ae5a5739-cada-424e-86d8-eb00de4d61a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "caef8030-e95c-4b8b-be37-302f4143614b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "f72758d9-68d4-4ea3-a3b7-0d7a0c37dace");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "0f743421-2ecf-41da-a1d7-13ce825cbd0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "404e26a1-d9c7-480d-a2ba-21148daa07d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "4b041278-4145-4028-a3c5-8ab763df3b09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "fbf5cc2c-ec33-46b0-ba8a-3b5c10a6a1d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "da0232ef-e6f8-46af-bf07-0a6e8f41a867");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "341981bd-ddae-4a5f-861d-2ebd09158b8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "33dc43d4-18bb-4e27-854e-f1af309af230");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "3354cf65-1f69-43e3-b99f-8a8ba18d4260");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "18c7f15e-8bbb-43b7-8f81-0a5aec5e0f96");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "dfe7d303-fb2d-4a66-b6ec-defad2f7fc80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "d3adbe1f-2b9f-43e0-8a7b-0c14ca1cfe34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "630b2d0e-bb83-4577-be32-3f8d4c026ac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d8db9476-1563-46b5-bd16-22aa479c6474");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "79a1c49d-0104-4979-ad11-7f7382fa1246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "a3215dd9-6d41-4155-9e35-6a31c19504d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3a49194b-531e-49e7-bdb8-932bf6bd8fa1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "0a45f3b2-7e2e-4a4e-b84f-5d36f9df71c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "876bd250-19f5-4d00-a072-ab651e603776");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "54c78998-df17-4c23-92a5-51d9ecd999e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f173c01d-34c1-45fe-8f1a-3f8e098393e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "fb2eef0e-f786-4fc5-b71a-b3d81fc45482");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3691d141-1445-459a-bc68-b013934ee426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "2db559eb-7bcb-40df-8b1d-319a070dd6ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "b6887be5-24db-4c0b-bab1-bfebccf7f9bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "a217a642-c65b-4847-9287-c200af96cee8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "6a745a1a-250e-432f-88f8-8466f81c7103");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "a2f1a87d-74ab-41ec-93f5-b6a389f8277a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "48664b6c-f378-45db-b791-6a0d26152b31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "0cc0618f-f916-4ae8-8db2-e79735929dd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "c851ded3-61ff-44f6-8cb0-7f7198867fd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "c5bb0910-0a1a-4080-a6d1-63b75acda374");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "1d0c9e81-bdd6-4d8e-bbba-76d6103b8912");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "f054813d-0165-43e2-ada8-f40bd448360e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "821fba4f-08bc-45a5-b0b4-10d6c603d2df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "cac529b0-105f-4bda-9907-5d4726a65c92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "6844bb72-e5c0-42c4-a202-23cf57a016a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "ec1e6154-3c4f-4104-83c4-f10e2f87b5c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "b4737abe-baf8-42cd-8af3-3857ffb80c23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "e10ca184-4ab0-4053-898c-070ec16d9ee3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "ac7b1ea1-b906-48aa-88e3-8c488a6dd998");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "1ccf386b-7939-4ade-9c9c-35296677b2f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "7d12bce3-b024-471a-9f71-a2516c93bdc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "308c3ea3-436b-4eed-8465-f6315da5ff00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "6ed45bdf-aa7b-4693-840b-12ec3bf9757a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "a591ec7b-9177-4034-bbe9-e4067518874b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "273579dd-7728-4f56-a7f1-77c5c3c934fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "3b553761-85b3-4cb9-ac3b-1431a6e3cf87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "f7b8b77d-b516-4bde-bea5-e4630384b1cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "574865f2-99c1-428c-9949-93570e1a2832");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "3b71a7ac-f2b2-4233-9b54-95babadaf9e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "86a16494-6626-4e4f-ada3-71c54b98ca80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "60f975c3-6ae0-4393-be46-2e1d6c92008f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ac87f298-3206-4fa4-8964-93c50070fb30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "b06bc26b-53b1-46ea-bb89-4256c12d65b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "f56e9906-569d-476f-8b12-30f47e6302f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "fb5861f7-ece9-408d-a5ff-5468a0c87e55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "91fd5bf4-2d9f-476f-9139-5530974072ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "409193cb-df0a-40eb-967e-41c876e2c337");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "b3713b5e-2f85-4767-b91f-25c7850a5355");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "7bf4bed8-a6c2-41e5-8b78-23a7d2442051");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "86cddf8b-0983-42db-9dac-e861be4c5fe8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "8812b80d-c094-4d37-aec9-ba338bec5336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "1f672d95-273b-493b-bbe6-41eb8f44b04b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "85e46d6a-aeb2-48da-8738-a90cd66a9a78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "dba7c6c0-ace3-4e9c-840b-b0b282a17bd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "216cdc4d-10db-4d28-a54b-4bf58270e9ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "ebf080a7-de26-4675-9e55-d8bfbf0d2e85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "482ea4c8-9741-46fc-b50c-5293f22fd5b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "81ddd27d-393f-4f7b-8694-14089ee04bb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "e305041f-583e-427d-963d-a757949b9efd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "1da4a92c-8dd9-4fbe-b4f2-cbcbf0cf68e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "d2639f82-bb09-4f10-9b99-45c591c304d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "0d49c309-bd92-4e3b-90a5-8bc0a116cb2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "701ec397-61b0-43e3-bca4-c743338d502a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "09c83a4b-0d9f-4139-a5bc-f437b2d91282");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "2836c242-08d6-419a-bad7-04a73249c2db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "f141ef28-586d-4d6b-995f-2164cde195db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "924d598e-7811-4de4-81e1-b8f879cd2b17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "5b98eda6-e28a-4713-a924-b34e55ebf6a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "d899a049-431e-48a4-856d-e5bb3e4e84e1");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(756), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(758), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(765), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(769), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(771), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(773), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(776), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(783), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(801), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(856), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(876), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(884), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(919), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(925), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1d1383f-d08c-4191-b535-297e1f3f1019", "AQAAAAEAACcQAAAAEF20QZgCEMoayoPxo2ikbNeRqhXlmaXOxAmAdYmB0jqvQeeOC7ScznaAgtj/gy94xQ==", "429c0415-eb30-4b05-9cd6-84c8151d364f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eabe0389-8e3c-49d7-8965-b120261a2c7c", "AQAAAAEAACcQAAAAENyMef8I6yW6OuqygaTsj3XBoTslFQKYAlhgam8psLyDc5OTtmF5nSKKfbJNt6jRwQ==", "62558c3b-1dbe-4478-8901-a2d9a9500928" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "231a85ac-1708-4226-ad6a-4f995a33a294", "AQAAAAEAACcQAAAAELvhyo+FO05/c7b9RsUOXInhKlhw0/oq206eJ0mzjm/KbryGWDQ1dnCW279C4ra1og==", "5eed21ed-90a9-4897-a77c-597a61f12b10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47293b6c-d257-4408-9ff8-55e3400d7bc8", "AQAAAAEAACcQAAAAELe6y/uTtBobltjMZenWDRKzYahp+UG1Tu1G8iy+5LNLweTixV/L1dGHe4ejZLWKiQ==", "e5e77bcd-f584-439e-8462-3992518746bd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367f4b16-692b-47a7-922c-83c3d3af055c", "AQAAAAEAACcQAAAAEAhKNd3Z+ojpj2sSTF00ZHbW3CZuUMfU/SOU9eKhIa+8FH6YzBf4atbCjHkBSbCpbg==", "f2239114-f2c0-4097-bdc7-e1149bd3f1fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b604cf9d-9f07-4df6-8abc-c44082a5218a", "AQAAAAEAACcQAAAAEJ4exJXZkaCz7KkPIdM/THEKGbt4Z/zhV0uP/9rtZH1mFGmG9T8SyYlDOQQpKga7XA==", "688019fd-68ee-4538-b86b-e451db130c75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca9b215-ecea-4881-81be-c41367cbfb36", "AQAAAAEAACcQAAAAEMf/dzlFUEUVQD853ujG9wvCGNlEfz4zyPHitHVL8L7euDJ0Vd8I+8MyW2IpucqkTg==", "5b66a583-828e-44a3-b3af-c673ac0bfef5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e383a5-3cf7-492e-9ad1-338cf2362143", "AQAAAAEAACcQAAAAEJDA6Xg0+xmfy74u84dQ9FP0htmZNRZpQKysHrjESeqM8l5DEpVSlltpRry4IIHyRg==", "2c8a2cbe-ff03-4c15-b74a-7b08fb3b4e29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "047f2be7-1c1f-490c-874a-31b0c15474c2", "AQAAAAEAACcQAAAAEGR3Cc5UMTtdSTop0VD75PSQrJSQnhYYihEJdDT3MymlJwrDLFH/NK7kBDwc86O+fA==", "f7751473-8828-4e92-9f50-59b47541d0dd" });

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
