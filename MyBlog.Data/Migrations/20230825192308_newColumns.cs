using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class newColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductSubGroups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "CustomerReferances",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromWhere",
                table: "CustomerReferances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TC",
                table: "CustomerReferances",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "ConcurrencyStamp",
                value: "603e4229-6249-4aa3-b14c-45d5a8a54a7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f923202b-4d56-4cf0-b128-53d13bd62762");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "974f5070-ebbb-4b22-bdf9-89769ad6df63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "4ebfaf5f-d22f-4128-97c5-dbf129a0c166");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "11269534-a757-41fb-be01-98586472463b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "52678fd6-2883-441c-98a0-a188649c4f04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "8bee7e14-0a8b-467c-b9ea-dd045f10b7c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "c5058861-c852-41f1-98e6-b4476eea0fa2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8abea24e-9337-4419-a126-86132a9cf10f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "f3dc6713-7c19-4c44-9631-4b53ebde1503");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "92405edf-cb69-4ba3-89bf-6576d6fd5e60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "4f491f41-f43d-4f53-92fc-27dc583b017c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "c0c49231-29a1-4243-aa80-8f761b0beea8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "40b82507-9162-4722-8d64-47d7f6c29c79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "1861f09c-0b49-48ab-958b-1a810feffca0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "52b7cd83-90bd-4a81-8b5c-0d1cab781fcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "c68bd7ca-970e-43e3-907f-e59a3adda42b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "8df95c68-28cf-4169-bf04-5e9d1e13ecac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "70e4d6df-c85d-443d-adde-8dc5c29a1af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "e08ab948-1314-4957-b95c-9b5659d83fa2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "41b3048f-7a7d-47c7-9496-e4ecbf258c65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "7193c4fb-4180-4f2d-8fc2-f32996d6a49a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "9e1dae72-28aa-4397-8033-a7fe5048035e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "8d661292-20c1-4a22-b02a-102836e8eec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "7e97508f-8a13-4df1-bd4e-5c51ec3a19b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "0f604bf8-7f98-4e98-a02b-14089a47b9e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "560b33c3-70f0-43f5-8186-ab1e75c4412f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "1f9103f9-462e-40a5-9b7d-8d823a7fde56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "19f180ae-eeb1-4c0a-85a3-e15378b2ee51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "41c511ac-4264-4050-999a-dffc3ceffff3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "41388111-3ac6-4f91-bf49-462a34c7c13b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "550a372d-6eb0-418f-b3f5-c0bfad0c0df5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "9632f4ab-a2c1-44a1-95a2-ff384f7bef00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "70669cc3-3af1-4d7a-8dcc-6523303da605");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "f51fe4d8-6598-4725-975e-dda602d47a34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "787508d6-5594-4142-aaab-ead0a5b99993");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "77d7b195-95cc-4192-863f-3d77e83a3cc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "37f0b6b5-d83d-49fa-b2e5-369493c85eef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "0c6824e3-56f5-4299-b26e-09fd472541a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "4041a7e3-6464-4092-8bb4-e11cdb4ba123");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "f2b09ce9-61f4-4164-87b2-e00d43a38f06");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "03961922-21fa-4a89-a2b5-183839de1508");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "7f777d7e-4b86-4a3f-9f9f-14c7c73fcdea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "19d99656-5e73-4cf6-8a1f-6e6239675b7a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d266041e-ae34-46f3-806d-e364f502ba26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "934d2677-b258-4a4e-8e65-e9e10c74683b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "7400d1fb-f71c-48f8-99e0-00d9e97ac477");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "8771db93-b1cb-420c-9473-959ce883f59f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "bde1fa87-26a7-4090-9d37-ed63c250951c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "d4c4d798-a24b-4255-ad12-54453d5fadc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "a94dbd89-01e3-46f0-903a-ad4960d9908a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "215e4657-89a6-4eba-8b01-eac99b4bc12b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "dde88e9f-2d78-4e35-8b3a-01da88c52b75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "6d3bca40-c902-4d2f-8f11-9cc5bb24dbab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "fae5f545-e626-407e-a215-14f58f5e4831");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "7b86e233-2a02-4c90-97f7-2def18575dcc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "f903887e-1dd4-4316-b1cc-96808f6e183c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "a91d19fb-f0f0-4f41-9ada-89c011979625");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "1e1f45a5-e909-41a3-8c48-43c39b77d130");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "61012286-289d-440d-969f-4644d2ad25cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "12cc7235-9146-48be-8fee-e55f7bf05711");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "c41e20a5-fc14-40eb-8778-6e8f1634e239");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "3863dfcc-32a4-4c06-8921-3402616e65aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "2516c599-149a-45e9-809a-216e95300f51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "3ba48350-6f2e-436b-be76-e1ea2a778386");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "cd5d2407-6a44-4112-ab01-91e925cf5f51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "f325b5e1-34c0-4f6f-b737-dd8dc80b6fcd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "6773f1e6-5946-4040-86ba-c2f77841f804");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "562c8a97-c2e0-41fa-96f1-76cab23c37c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "dd8326e9-6ac6-469f-9ce3-01579b661144");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "607edb19-9275-48e9-aa98-8cd8823ea785");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "8cc3aa7b-87d4-455d-9fc2-a44ce03c63ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "919ba576-4bb5-4c20-b909-e0144ef6e13a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "d6c70249-8863-4ff1-b221-0b1146080628");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "2d080fa4-dcdb-427f-8996-ef97eeece1d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "b0815c2a-877b-4733-a8c2-c55b6f9b2c53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "4f476b60-3bee-457d-9ddb-520545b01024");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "585f3a71-80a3-48fb-9d59-e61c093509ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "74adc637-bf28-4360-91a6-893f57ca5167");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "d01d6b26-9a18-4c49-b824-08e720c87bfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "f7645071-6ed1-40a7-a40e-e7906ee96d61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "bd574d4d-dd5d-4bf9-943d-745755317e2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "827d3767-d140-4ba2-90a3-6bc3ad28de08");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "7d218000-35a2-4c15-a6cf-53fdd672fd46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "29a3422d-2b91-46bb-b6c6-3ca6b1428fd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "22540ae4-77a6-4eca-830b-bcb0a805f718");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "3a784efd-7382-4a05-a708-559a1aa46aeb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "93eabb07-ab11-4de3-9d92-ef36b20d5063");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "cc3f4a81-9b8b-44eb-9a2f-df2c23cb431c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "73745f27-722f-4500-89a5-b4cb310cec33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "72f23b83-7ddc-482a-bd6f-8684a7422368");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "c19e269e-8de4-4020-bebe-7384fb32878f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d1830361-6731-45ce-8ebe-e46a4ca77066");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "655dbcd7-c98e-449e-99c5-8cf85f9cdcf3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "17756c15-1d24-49c4-acf9-d5c04beecb32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "3d7a5457-3f0b-4282-b750-ddbbcd5ac53b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "a153708f-3128-4e9d-90ce-f78854ad3f6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c101058d-1dca-43e7-bbbf-7f798eaa1079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "70bbbd58-9b24-4d49-8478-fc5477105379");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "204c82e2-a49f-48f3-9f67-f68bf3a2f785");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "767f9e7f-1852-4049-acf5-6a70d3b30d17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "310693e9-5694-4989-b61f-808746e4307c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "3bee7cce-e61b-475e-aee3-9beab79e9625");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "2d77b580-7e29-4787-8b9f-f5ebebf24ce1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "935fbb72-5bbe-4133-93e7-10b77677a634");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "eecff98f-d8b8-46d0-a303-48ae9b516897");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "cab4073d-e1b5-427e-9b57-a6d4a9eb3d36");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "CustomerReferances");

            migrationBuilder.DropColumn(
                name: "FromWhere",
                table: "CustomerReferances");

            migrationBuilder.DropColumn(
                name: "TC",
                table: "CustomerReferances");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductSubGroups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7083), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7084), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7089), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3831), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3836), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4323), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4329), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7463), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7364), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7200), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7205), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7207), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7210), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7215), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7218), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7220), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7236), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7238), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7241), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7246), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 8, 25, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 8, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 8, 23, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 8, 26, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 8, 26, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5272), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5292), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2f3fea98-1dba-4a3d-9f13-1e8026256c59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7d38e081-da20-4fbe-9c52-ff5975896d49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0d212dbd-5664-4bce-b9d8-54d1f3a5b82e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c14313e2-a81b-4b72-89c6-f442b8879aea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c6af9a17-8428-4537-adfe-65de7430427f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "329ed17d-1332-493e-b452-defc4abb11d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d285aeea-98b9-4651-b230-9171a1f4c6dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "4f24cbb9-4618-4985-92cd-02ae8d5672f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "dff82ebe-efbd-45f0-9ee6-72229442a4d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "11051320-52cc-451e-9ad1-41bc23d62889");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "c0ceec4e-03e9-4a8c-8dc1-20137883baa7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "83eea199-a980-40d6-a53c-369a32150748");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "b96a7d5c-1681-4dde-ab05-3071dbd021ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "f3342b7d-df57-40f7-9e69-17a9c46d47bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "bdb73b12-e5bf-43a6-984a-7f6bc3b459f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "3d716c2d-9ce7-49d2-a928-177a4688f872");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "c14a3e34-3fc7-42cb-b06b-b87bae2cf950");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d18e8356-dfdd-42d0-a502-a43feb6acf1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "453447da-6cab-4346-8e84-6bf26601e002");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "aea9e855-794f-4bfd-a578-3ccaedf151c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4f3332bc-8850-45ea-aa2c-4d3edfe4b407");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8110e949-61eb-42b0-a775-987b7c9a2747");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "139c6e23-3e3f-4dcb-b944-ca7c6cf571d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "c0b35be1-b885-43d0-8e24-3581c5ad51d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "bb8c1672-e52b-49df-97b6-4d5ae23b3e51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "a1c998bb-7f84-4522-b7eb-d2e82346a415");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "f4a2c4db-930b-4d3b-86be-324b5f5644ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "bf4e63e1-0bd8-48cb-83e0-e019780d73df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "0a758c29-a05a-4c62-9bdd-dd0f8986f79d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "8626faf8-fe66-42ea-8aed-e27fc8b1571d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "031b69e7-a85b-4f15-bfbe-beb34d4700dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "e7ad5b14-b3c8-4245-a892-ceaf576e5880");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "60fa1285-71cf-4af5-a7e9-fd1df49a3bd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "bf7ab069-5632-4e66-9f21-0737c38cf74c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "5725bd8e-f771-498b-9434-844f45f78927");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "82b8b249-e6f0-4f9d-a202-2566097e8692");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "0e6cd074-11e6-486b-8c7a-519f756f3fd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "1285b0d5-d0b9-4d94-83ff-9ec81a582276");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "2621b2f3-b1c0-4f4c-a234-634ca184a1aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "79d8653f-e457-410b-aa89-c27d8183aeb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "4dca4ef6-5b4d-4bd0-ba27-f17e121517dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "642f28d8-85bc-4c67-8007-7e82f7fb36ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "7aea2c80-a729-4a45-8874-b6d9a87b7a6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "6a820f49-460b-4d62-a4f8-0127cdde81d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "8cdb716d-2f00-45ff-8e84-30b44d95667e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "7ca70a37-7f9d-46d8-8d30-1e467a3436a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "531bd7bc-0873-4b09-a09d-695389acf6d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ec80163a-958f-49d5-b317-1817a087ca50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "fbf32f39-942a-4356-b86d-d5a55236a766");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "44f60f15-761a-49d5-b455-498333d4085e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "ee006b08-c0a9-4c99-bc19-04b94362d033");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "f8c35359-ad55-4f41-97ac-7d8f50714a4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "0334fa26-7703-4950-8145-e8a259f2a874");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "02960e57-cbc6-4d7e-9780-c0c67aef11aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "31256a9b-a9cb-4244-a244-26057f67edf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3af3f196-a784-41d1-a5b3-10ef18e198f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "b7fbedd7-7d3f-4f14-b461-037d22301719");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "fc5be028-c188-4339-9d5b-3c5c42c58383");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "af6405eb-1104-44f1-be31-0d1cac506645");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "0d5a7a5b-815b-4aa7-b504-6558da36d448");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "484db1d2-7a23-467b-a032-5772a100d71a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "506ac815-43c6-46d2-9ff4-df6462bec980");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "a9267b59-c58a-438c-b1ae-665fcbf6e857");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "ea497886-15c8-4ed0-b30e-c70df4e1fd9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "d14f393f-f15a-4de4-a12e-0017125bba16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "e51ae1f2-8c58-4be3-b665-bf99c2adecff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "f81ac488-96b5-4a12-8da0-d0a995ee6d5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "27c9df6e-f5db-4829-965b-d0220ec8d23e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "52ff0736-5eb9-4525-bed5-c68c1d9df88f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "a97bd812-3ffd-4e4a-9b67-9d29a9c503df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "aa679fcf-58a1-4d07-84ee-f547a27d0e52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "667c121e-8f68-4198-ae1d-8f8de64b7ce0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "1b2e7136-4575-4bfc-be36-50bab99c57e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "10cf215f-8e54-4f95-9b82-1e41b9f843e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "ce24e1fc-ae1b-4c78-a4ff-0705115e4114");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "39301f7d-a16b-4e53-871d-d08d5159bcca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "7a154cd6-158e-4985-9a19-b7bfbc781daf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "dc1c89de-9282-4357-84b7-d2fbb8181969");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "da7c761b-64ec-4c3a-894f-83afcc5f8199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "46711ace-cfb2-4d4c-9496-0bb2b60051f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "de21b9f0-da04-43f2-835f-5d9df1b45bba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "4f9cdbec-fcc6-42dc-ac9b-0a02fd19fa90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "043fddb7-5cd6-480c-937c-0bd34169907e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "3362c119-bdfa-4986-8467-8cc9dbd8f77f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "967f2ecb-7867-4fa6-be3e-600d3aae92f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "a67aba07-8f2d-4ebd-8c49-a05b6813baff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "f758ea3a-daeb-4c99-b7cd-e34500f08d4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "af8ac1ec-b4e4-4f1e-bd0f-5eddb856943b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "a3c9b888-4892-4b89-9147-5d8594449f9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "a2fdf4bb-2e4b-474c-9b7f-04c1f8faa386");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "719df217-835f-46c0-8b56-5f7c82fc1665");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "94215de9-0a9e-4607-8c96-5823eec951d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "aed9407c-a4d6-421f-b6f6-83fb123ec499");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "f4a04086-adc6-4dd0-aa02-a0634301626b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "23423238-2a8a-4b39-945e-4a984e3e1ce2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "bf16ebb6-65c1-47ae-85b5-3e0813584d37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "c554d09e-0f03-4c38-b928-e1efe720eefa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "03ce29fe-396f-4fc1-a5db-a8ff09db4a6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "0a9974c1-1c1b-47f0-b5c1-85f49c22b778");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c2248479-aa18-46cb-bf77-e3bbe93386f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "dcaf1881-3cee-42bf-a1bc-261ed2bd8402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "f038c6af-b5fb-45cf-8b8d-58a64a2e40d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "ddfd25b1-9ae2-4b40-8c45-57bf2571ba53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "fe55237d-c0ae-4182-9c65-6d71f951cc09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "29dfc40b-93ce-4e7a-8c2a-4a890f33ae81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "277eceae-f78d-452e-b1b0-71bece2fbbe1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "723d160b-e024-4b65-a74f-e226c6ed8dcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "35cd081f-d450-4222-bb34-1a6ba1746127");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "a5993a7d-8716-49d3-ae5e-b8f6a8507c1f");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7145), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7148), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7154), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6783), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6876), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6881), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6897), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6899), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6912), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f10f1fb7-9b3c-4bcc-8e7e-1bafe10ce371", "AQAAAAEAACcQAAAAEJ4fVSojDeLJJCZc3lcJoL1AG1nRGsi+33ZlMrq412RSJr1dEsTD0XM6enwJE+XN2g==", "fc2928bb-8cb7-49cb-ae82-7c54fa98f059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7441b832-093e-4e71-8b12-dc84ed300371", "AQAAAAEAACcQAAAAELvmjq3YZqo5DTF7YIbAZG5Fv2e106jee4axWt2X4sBtYZT8xCoSTghbscQzVVM7Xw==", "0f56580f-4220-4d40-b705-ac8599086b55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8298ec-9c47-4e43-b8bb-31284e83026e", "AQAAAAEAACcQAAAAEGH+Jg4vqrAAGWQTeICK6c5MP7RiVzhGUx8aGu1l5xXSQFpNDAdgn2aOUxFkBfw+SQ==", "9af4b27a-c40f-4282-91c4-dff8edad9626" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f37cc568-9e9d-472a-9f2f-fffda914fb5a", "AQAAAAEAACcQAAAAENGfDqHozwRR8prpgVtoKWRmkuYWhBBgMxc1r8W9pwPpmDJA5tCSkip0HAyzvKX3kA==", "67073047-8907-4681-85ce-e7e0cda67a91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07885704-4ede-42f8-b418-ab2d2f1c2968", "AQAAAAEAACcQAAAAEHEdsm2zC7Nwx8ho4Yl0q7f/CSIyYi5SRpAtpTmPbCzVOXQt9k1y7+Kydh4tvDf06g==", "c9afc6a4-1159-4325-b613-c367646eec66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c56f2db-775f-418f-adcb-fa9dda4bfd27", "AQAAAAEAACcQAAAAEChQqsE+HwhB1oFxDaen/dJttYLCeOtysc/6AZa8+kVat/EZmh7VPT+WgiVgyarVMA==", "1659c4b6-0087-4d68-9ee4-b666ad7ce2f8" });
        }
    }
}
