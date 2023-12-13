using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addedColToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortBy",
                table: "SubModels",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CustomerReferances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 720, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 12, 10, 15, 32, 10, 720, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9426), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9425), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9436), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9435), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9445), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9451), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4050), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 15, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 12, 15, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 12, 13, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 12, 13, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5682), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 12, 12, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 12, 11, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 12, 14, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4448), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "445a6175-d12e-43b8-bead-1168d4b9b005");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2f7f773d-768a-4a74-b186-57a466395996");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "22893090-802d-4182-99f1-2cf22b3bfa24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "57102c77-1176-40c8-afb3-26f38d4ef5b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8aea36eb-1f6a-46e2-b4bb-e6b0cb736490");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "dcc92bf8-7c11-46cd-ae80-c6bcb363dc42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "aa21f7bd-c2c5-4f30-bba9-556b705cb913");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "d41a98d8-c289-4694-9b9d-21dc95b59417");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "5d6d1bfc-7d6b-4515-8cf9-17c15e102eb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "3ce566b7-12b4-4ca2-b534-187dc6bdaf83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "b7c24c23-c63c-4e81-b6e9-24ee181ab60f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "bb178df7-b95e-4def-a78b-5e6502c2835f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "51a9e902-8771-425a-a49b-019acaff44dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "27a64ee0-6182-4471-b64f-dc634b4a7bdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "d14fed8c-29cd-455a-adc1-59afe5a05d7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "a454de26-c9a5-42c0-8d7f-a8c0a8ac01f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "666b2ed3-1be8-4d74-ba84-e0fce8e51959");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "be85e5d1-aa42-4a94-a1e8-8f6163a1662e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "ef95eb0d-a126-4905-9982-4c8e7df91f8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "f5b54b15-0642-4dac-92f4-7c713cf642f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "bcb38582-cc9a-44ed-a867-7e3dd2d40cbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "aeacf3b2-9a1d-420e-a258-9cdbc0121702");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "314c1b8a-a2b2-4451-ad09-46caaf92ee50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "c89f902f-6a51-4f31-b491-d64f965347d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "3adb2da1-8618-4fa7-a127-43f4934b686e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "8bdd0cef-2a71-4627-8a1c-d373e7ec406e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "a56421d7-1e12-4323-98fa-2e88ddf5f147");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "2e3a8676-60ea-482b-81a7-b0c329396dd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "390febd0-f91a-435f-bd85-299fcd8a08bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "0fb343c4-0571-4b0c-bed8-c0ff9d215479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "25438a6a-d99a-4436-a57b-1be69bc02086");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "17b0f32c-88e9-449d-81c6-5a7efe0e3fd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "709443dd-e89f-43b4-afd2-ca7196777242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "5644cb02-a558-483c-8700-9abe91b51fcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "65c9a2ac-af0b-4152-89e2-a9c439f973e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "46fe2a4c-a6af-4213-848a-1aa94d59e260");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "d9d02504-337b-4451-a1db-685e7eef44f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "bbad91ce-4522-4a9b-97ba-defac64273d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "147ab446-5e3d-467c-9a85-f573e7bd7f3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "ddba91cd-50b6-467f-a38e-62237469cef8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "5c0179f2-1ca9-41c5-8d0f-30f8db8afb49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "918f7783-9179-440c-959c-74579894c736");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "1f6e49a4-fcad-4027-9233-97be33a83479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "a8f8ce7f-cacd-4896-9232-b29b28276033");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "66d97c85-92fe-4381-ac34-923c7c0e520b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "080bb325-20a2-4589-9f81-a55f51c42699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "b678e667-7f3c-4929-b92c-c1e23ddc042f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "5b4bb8e7-f5be-4a3b-ab25-4d11abad6a09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "a4aaba8a-109e-4c82-b8e7-2a25c6424ced");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "f288ee58-d903-4a4a-91d2-feaaacb5ab00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "b0530ef3-3b5c-4291-9ec7-0d2a1fc22a10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "fed7cbc8-1fbf-49e7-9f38-c83488f830be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "56cca750-4122-4d89-8dc8-8e8ebf6dc8ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "72d54a7e-b78e-4b27-a384-4c1b7b480761");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "c0a47f79-de8e-49fa-9e3a-14e148f2c469");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3e896001-38e4-48cd-975e-c944b7a161be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "d515f1dd-7c2f-4bca-93e0-7c1ddc416488");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "79726980-c8e5-49ce-b12a-2b0657b77d70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "430a5aac-710c-43f6-9a42-151b2c24fec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "58d7947f-496c-4ba4-8ede-de2fd6717469");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "ca865aee-a633-401d-a6c0-ef4f3e0d6d98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "f1f35f10-17e6-41f0-90b3-d80231d3c8cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "db127f46-c8bd-4d05-afcf-e3e58634e41b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "f0d2cdc1-5843-4037-9a79-727e4e22ea1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "ec41a4aa-7f8c-4ac9-b219-3a242abe26ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "b92a0a49-5e30-4f5b-b167-f27166981520");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0c9dfc3b-291e-4c8e-b5ec-7eb3e2c27371");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "a1296367-be4d-4a9d-9ab9-36762f18f4d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "bda314fc-2afd-4dec-94b7-497a93282810");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "e2ad6d6c-ba28-48e6-8f27-282f62363e46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "3407380f-3254-4c48-ac67-d509df8e605a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "1519b7cb-f9c2-4f42-b8b8-d0aa74dba57a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "f4b17b8a-cce1-4be6-9654-8ca15c5d1ff9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "15179ce5-b1bb-40a6-96b7-f80c7434ee3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "4a14ba0b-e757-4ef0-baf3-bc0430d5a2cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "bc3b4ee7-7c5f-4b2c-8fd1-dbd97d901627");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "1ac42840-9b39-48a3-93a5-664ebf85d697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "d3ca090e-2dea-47a9-9642-183d66b45e19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "749945d7-91a4-4ba8-8e8c-dadb9422da45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "41dc38ae-6836-45e8-92ea-6224a623bcb7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "2a4c5e91-b8f0-47d3-86a8-cdd54b3927b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "838004c0-07bd-48be-bd6a-df4f7999b4d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "63f6be25-a4c4-446e-9ed5-183fd5f008c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "65b0e678-681b-4a2c-8037-d347b04b614e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "7112ffd3-e458-4154-bc9f-a055bacc1ba1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "10b7a496-6c7a-4bee-80fc-170acbaebb23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "81f669eb-ad70-43ed-956b-232698be2ba0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "4a096e96-75ae-4ef8-a44d-147a8701e403");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "5da998fa-921c-4fee-a97c-fd6a97d7264b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "26694fcb-dd34-4937-b2d2-e9ff38c75749");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "4fc20963-ca13-4f85-bd1c-a38372cd9426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "9b4d6dc8-1536-4810-a34c-baef2a89b2d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "299ac67b-b82d-4ba0-8fff-b9a34f77122a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "09ce77f0-cd9c-48cf-8b71-eb7dc635c8c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "99c7df65-80e9-44b8-857b-45c6aed83af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "f60ad444-90f9-40d7-8765-fa19c37658e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "81ba79da-23e8-4a86-bc21-f8d42539a8c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "82dc8ff2-7b68-411d-8282-8324e2530ad5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "ff04a365-b52d-45bd-993f-552187ecf5f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "9a511930-9b6b-40df-b323-2658d42758e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "6e1fd94a-6fef-4c7b-bb70-4561fcefccba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8ade9008-6a65-4d24-af81-95ae723805e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "71ed9468-1ad9-4e73-aa1e-4d27f1f58639");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "4199bdc8-5e9f-4aec-bd5a-a433bbc26526");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "350bc8ef-915d-4e8c-86d9-57a41cf47612");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1285fefa-5eec-43d8-a5f8-8f9bb5b4e8ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "a126bda3-fc84-43c9-988e-dfff1857242c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "711cb6cc-8662-4e5f-a304-7a301505dc3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "f66645be-dad4-4344-a0d7-7ac2c4ea6df9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "93716c9e-85ea-49a6-b27b-51f53a486d4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8219f627-24d5-4fee-989c-ff8bb71fcd8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "d0bb01f0-3d18-49fd-bb90-41e5e23118ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "28fc0243-a542-4ee0-a3c3-02a603f3e8f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "1634351e-f980-4165-bbe5-f120216c593c");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(8261), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(2435), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5139), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5293), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5296), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5299), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5307), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9e4618b-ee41-4646-8a0a-52a3ea934311", "AQAAAAEAACcQAAAAEKjnn5ak5A1XE41MuSJ1iy1oxx9aT7N5dAAUdEJhNA7aocwJKqJcvj6mwZ31W+DrpA==", "5d459001-e8ca-4bc7-a602-5f604d3323a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5d40fa0-ca00-449e-8c24-f8cb72ea2cb3", "AQAAAAEAACcQAAAAEHFKh2kkCOmvn9QK+4zSnLFFi0UEe4KdnF24VDKEMsVziXMR2EYEfaGQvj/CswZcCg==", "c14f40ca-513b-4ce4-8380-6b56bc0ac9f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e490629-ef47-433d-9255-e777e7e7121e", "AQAAAAEAACcQAAAAEHsjo8scRS/N5jH9WJVjf5pGRziCv4PgqyZiVcC5gYDs3btUyd+Rh9Ez25GWZbIaMw==", "754584a3-7115-47d8-b6af-9def026348a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "341c54a7-5b3c-45b6-a8aa-66a9d82ce1e0", "AQAAAAEAACcQAAAAEFgNlWdDjw4UOGGb17tdDskjKUDslX7u/cjOcyf/87I6S7Q+oa3HKaPYOwW8fwp5og==", "f38f2b63-e7d7-47ab-ae49-831e6cf8e96c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0dfccdd-3b9b-446f-9dc9-cfe135de805c", "AQAAAAEAACcQAAAAEEi5lKNSPeHgGEvSTtlYOTgGu2GCcQq5WBuybvCyl/8ZehGZBL3oWwB9jeZNkLz5tg==", "0b0ea5a3-f366-4427-a2b6-3a17ec50354b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d661e570-169e-4bd6-8348-6e99bd7a03f5", "AQAAAAEAACcQAAAAEIzwcip7veXtHMooSbE7ruGsOlrQpZGwoMtUuOiq2rdvA/mbwhB2dSZtOWTfyeeZKg==", "3d710762-bc23-4c91-a7b6-ff10fb559c58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b76c8ad-4582-46b4-a88a-3389f8c33ff2", "AQAAAAEAACcQAAAAEEJI/G3NkXy2Q/voaeD7/Cc2KRZmvrGZBjjtvZE7InTLOVAwu9ygcfUT+aw5rCfZOA==", "e992c38a-7121-44af-8b7a-82b1f0520e4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d4c039-8077-429e-bee8-47605f611aff", "AQAAAAEAACcQAAAAEH+xVl2Q4M8evnS9uGnq8UD3KgBtpwCDirraYNmvifiD8oFpNTFRv5vX9b3BXEGvvg==", "26d3e590-14ca-4d71-97d4-8896cf76bc96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69fe86d6-c959-4344-ba34-e3365ee721bd", "AQAAAAEAACcQAAAAEIqsoXYc6PaWut8wNje4OsjJ7SAl4h42T7rLpq2wqM/sgFJZ6cz2+5zohDu9bIwnMA==", "5810262d-2d22-4457-9012-2d093b480c66" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortBy",
                table: "SubModels");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CustomerReferances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 811, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 12, 9, 22, 56, 54, 811, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5790), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2728), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6982), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6994), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7001), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7005), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8401), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8406), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8411), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8418), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8421), new DateTime(2023, 12, 9, 22, 56, 54, 809, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(1021), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(1432), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 12, 14, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3592), new DateTime(2023, 12, 14, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 12, 12, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 12, 12, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6588), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 12, 11, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6594), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 12, 10, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 13, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(110), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(116), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 9, 22, 56, 54, 831, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 12, 9, 22, 56, 54, 810, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 12, 9, 22, 56, 54, 832, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1465), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cc829345-941d-480e-a29d-284557456539");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "39087efa-41e5-4a78-b2f0-bb1b699cc200");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "42d82c23-f1ff-4d46-ad74-abd5a9f39142");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0e847640-56a0-4df1-8b25-b0bcd3c45331");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ce99be85-9f81-41db-9c7e-1f49d32acfb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "d9d6f5ec-acaa-4819-a08f-07c21b5ef578");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "bcc1d4cc-041a-4be5-ac55-4a1e65033f73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "39bdf06d-fe8f-4ac1-9877-e70dcf5f80e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "cae521ed-df97-49c0-9cea-a3f1cacd441a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "b0550e68-a6b7-4f6f-a1e1-0540a0d3f38a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "1403e46b-93ac-496e-9a81-6f662b3e19fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "e443367f-0d57-4fdc-9dc9-114e88117db8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "7be46825-ed5a-40ad-bec5-7b6befe1b2de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "ca6989ce-9cf8-4910-a681-e6dd664d7d0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "baab4e4a-860b-4fe3-ab21-fc8a15534bc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "6e34018c-28f4-4a42-a0c0-593322c37204");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "04affea9-2731-4211-9cfa-afedf4e1aab2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "673ab16d-64a1-4dc6-aecf-d1a19704ce6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "777f586f-375f-48ed-a36e-11200f5a6214");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "57261f98-5d5a-405c-8c48-3568b1c1f890");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "fda7eb53-1b4e-4ec2-9dcc-c870c0596c38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "a7649ad3-0ae5-4f70-8639-6b8a7e8c8e1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "d25fbc47-a932-4b17-ae8e-685e4da8d664");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "1765e9b4-f2c8-4dc3-8879-b82ee6619126");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "70c2511d-d70d-4e58-aa26-921c68ce9ad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "6fe12742-b059-4287-990d-861a5d0b8a73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "dd405b24-0ea9-4ff1-8d64-cb8ef18f1de9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "e8c6bb45-10a4-4444-8e48-415ec47eabee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "ef114fcc-0492-431c-9e2d-db286b41649a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "10621a93-aef2-4e0d-8340-275af6bd33cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "539742f8-7cbd-4e15-b100-0416270bf519");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "94f9405e-66ba-4858-8745-06513f9ad37b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "96e2aa83-688d-4bd0-b57b-a7beeb294178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "24a793e4-af9c-4067-bd47-d19622417484");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "517acbdc-888a-4e92-b22d-95ee85148e81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "d53af3fc-4f71-492c-bea8-82169325b36b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "2ea80654-4846-421a-af89-1bc43a2be8e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "2d94db87-f510-47ce-9be8-9987eef81141");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "d2573e7c-bb37-4bb7-b13e-81004d4fbed2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "8792a1fd-06fc-4ef8-a469-bf32cdbc3424");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "8d632253-2c98-4e14-8394-1bf27a646373");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "d8bfdf50-2d49-4e41-9522-8b3288a6433b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "42694c5d-00c1-4022-8b1c-496ae7a5ec31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "5ae3c3a7-4ba4-4b0a-a64f-287b5b53d45c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "dddd76a8-c913-494e-a2d0-c33a074eeeaf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "5000130a-ebf5-4b16-86ca-09ca667d8c3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "443a25c0-59ef-4342-923a-a21dd9fb21ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "c5f4c716-6442-43cc-8727-c79c53d152fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "f27e00ba-acda-4b47-8e08-fec648a10abe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "2670b41b-1994-4cf4-8021-40d101785f68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "6e64b284-7550-491d-a161-f89de498756b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "d67487b8-eb26-426e-9fe7-afeb16f0bdf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "d0c30032-0d7e-4e64-b01f-0a319a5938f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f1b5ec82-b5cd-467a-bf85-9898b975b08a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "361c4dcb-723a-4207-8478-4d6f031b267e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "439512ee-ccbe-4bdd-96d5-49b2d3de04a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "9ad1cd9f-a475-4c1d-9336-d377a7f6ac3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "f3d3da8a-88cd-4810-949a-89a3c9df97c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "8513d708-3610-4d06-bc22-b2c40b651430");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "004f3ae5-10a0-4e01-b79b-5af934717d70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "3c6b9871-8d34-485d-879c-1506d96a95e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "4a8bfaa4-acc9-4acd-9b86-019e4d2d4031");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "3515223f-e8d3-4684-a777-c8bd52a5c170");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "b1facac1-a8c3-4f0f-ba16-c41c87088423");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "49cda90f-a03a-4405-a71f-45613566d483");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "7f9dd91f-724f-4411-8909-3b29c8387272");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "648d9888-2f4e-4b63-8a5a-a02df2973a0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "84471f38-ebeb-4099-8128-8688f49e0e8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "6f6f93dd-0756-4528-b9da-5f4ed8b30975");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "521a519d-3fad-4767-9850-8f66a0aaeaf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "1c0f9553-e580-4a8c-9c05-5118a1d82ab8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "2d054d94-7750-44b3-8997-6f2fbb490418");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "2b179ea4-e227-4cf5-ba7f-7bd7b13a9d2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "7f4a7be2-5884-4820-a7c0-ab1340bd6ec8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "083b9bcd-fde5-4704-b1e1-9aefe2fbebaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "88808f23-40d5-4aed-9fd1-803e095358fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "a9f08ccb-3edd-403b-9ca0-ad5353a1b0ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "d27398d1-fd84-4ea2-b49d-0be638b15cf3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "e7defe11-9a72-4bc5-b249-18562e33d1eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "b2961fe7-9b1d-4110-aa8c-77ef970b6a2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "2bdae380-df2b-41ed-9f4a-6678731dd429");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "13a75be2-ada9-4a9c-90b4-f0d39a342714");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "30d83ecb-2de0-40fa-a165-27580e5ee158");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "7430693b-868b-4d1f-a960-b0b22edafdad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "84bfe5f8-39da-4cfa-8ac8-454daa84d028");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "1b8fcdcb-f81b-4395-bdfe-0064dbfa0bd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "3762bfe1-f409-4283-8c23-9a33deb68cc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "f44ba171-51c2-457c-a129-0cae9bcf57a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "eb687939-53bd-43e4-b7ce-7ac6fa96bf66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "c520b2b0-b931-40e3-aebc-0a40fe1eb4f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "48bf0c71-b37e-4832-bf91-73e55451f6ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "98f25517-23ef-4ee1-a857-e61cbd74c367");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "a64da231-d370-47a8-9af2-3280f3c7e7ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "6390231f-bcc5-414a-ae38-2713ddce3fce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "3a7a2a88-3cc6-42a0-871f-e0c7e229fb36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "fc12285f-c446-4c76-ba7b-d084fd99e9a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "652a5855-b048-4c4c-bc44-734aa78f8d3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "63d5d0d8-fa9f-4b81-8ab7-6010e9b59ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "a491b375-f60e-4b73-be2a-9a5e71e01a80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "46362e86-15f8-4610-b672-06f08f02bfc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "4cb7ea5e-c576-43a8-9931-0f4b462d03fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "af62ec36-fd24-45db-af43-5d89282a04a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "b77abbb6-c2b5-4207-a96e-026018577148");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "4ba6a177-1499-40e6-bbe5-383ce57d6e6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "99f0262b-2371-4776-87bf-714c351d64a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "f38d0eec-cde0-4f51-a0ff-8b5c9f7f2dcc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "2816fea1-aa23-4547-9aa9-d593032447f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "856191a7-4667-4e72-a258-bb938e8b343f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "7fb8caa1-5aa2-469d-b319-1cb53b29612e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "b147b978-ecbd-44ef-a614-98ca669fe2e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "ddaba7b8-b30f-4eb6-81f0-5273dbcfc48f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "709ef58e-04eb-4ba5-a53d-16af19345f52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "7666a186-94c3-4a3c-839f-bc795dd76cf9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "4dbe50e4-e6a4-4581-87f1-8bc0c0935743");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(8596), new DateTime(2023, 12, 9, 22, 56, 54, 833, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2346), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2363), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2377), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2384), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2412), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2415), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2474), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2509), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 12, 9, 22, 56, 54, 834, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd0c18c-2d39-4b01-b7d5-29a99ec1c08a", "AQAAAAEAACcQAAAAEOPHITwOwXx9zT78vFzkbFSw19K0urPhFEXD3WyHc+XIT0ubQXWgeXhk7G1CzzZQvQ==", "7f667f52-f860-444a-a1ec-efe49e73ea59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba3fcd96-5264-4f41-a9af-2abb734f038d", "AQAAAAEAACcQAAAAEDT+h3eorUTVhjbyMFUqpSbbcsWIKQqehal9vzcMJbIsoFT/8hLFEvHdHc6X4Nv76A==", "b09d57b1-98a8-4b30-b587-abe28cd0d004" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e850c2c-4cf6-44d4-9fb9-36d7479b8769", "AQAAAAEAACcQAAAAEG2/8uvi+Q/l6+I+KqiVN7uVlplgCL6kf+jmDuknO7liCCJIP7iAmGzPPNrphdLotQ==", "07bc7038-6e72-41fe-b3f5-3b8a53dc8919" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "017ac868-904a-4a46-9648-4cc7d6f11624", "AQAAAAEAACcQAAAAEIkNehpobgj6cZRCxEj9E0mo8DjtXANVCg26sACDZRYDwmRuKu/LERotKJ9qEaJqjQ==", "90aadea1-1d51-4628-8a58-8dc4c51b28e4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f3fabd-f530-412a-addc-90726b03c43e", "AQAAAAEAACcQAAAAEDj1L9gaAnQEe1CodXYu6gJ5QhByHt/74/6SQ3PJcsK4ysEI9yLZUpgZjhZL21a01Q==", "4b53f648-f159-4fd3-b829-7f03e84b06bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df7e9378-575b-4cb6-a851-19833090cd60", "AQAAAAEAACcQAAAAEPaPR10U8l/NWUEpitLL2JynooZg3d20DQKzOYNTxwKzS2WXjxrGql9cQ8jlhb7Cbg==", "d0e896c1-4862-44f9-933b-25adef5be12a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60951777-a277-4300-8251-79b078dbf05b", "AQAAAAEAACcQAAAAEBBP2DvPW07Z8SyZwEfWVZNhfWN64+dzdhhYwclUOJ7q2XnjJBDzQWEnwtYSObna1w==", "6850adca-0eab-44f6-b7a8-a00e54613f05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dca62b3-1225-466e-8e68-c15727a58429", "AQAAAAEAACcQAAAAEEm9cr1hbD5DWM9CTT6JTMcoD9CrH++aJ9GWxPFq6vcb4sgtNMyhakgmlucucVnPRw==", "0e513a30-fbbb-46b2-be6f-170efc1a00d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9f823e-2da5-4f9b-b94a-df09f8b1f8db", "AQAAAAEAACcQAAAAEJNSSy0QyHtCCloXfYe4HKcnmf2pmiQ762UjtjAoWSiPT5qw0tcmuoIKyq4xtvuOQw==", "c9dc40a1-85b3-43a0-8b4d-eacebbbcf5b2" });
        }
    }
}
