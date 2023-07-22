using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class intcreate123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8477), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8487), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8491), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8502), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8507), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8514), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8520), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6196), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(722), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9537), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9540), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9549), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 7, 22, 17, 6, 17, 182, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1082), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1085), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1088), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1091), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1098), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6394), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4625), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 30, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4634), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 1, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6314), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 7, 25, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 7, 24, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4238), new DateTime(2023, 7, 23, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8407), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8413), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 7, 26, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 7, 26, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 7, 22, 17, 6, 17, 192, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 7, 22, 17, 6, 17, 183, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(6543), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5035), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5041), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "131bdcfd-43da-4346-96a2-1b292288b4ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ef2d3f5f-42c8-4091-af9b-57939e0904f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ae74451c-f02a-4e79-b55a-554c09a36275");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "33a70169-603b-4441-a477-a537b04b374b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8fbb0753-cd00-434e-a719-5e85a3c676f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "173e363c-4d0c-4286-824a-00f092b3d866");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "df6e07c1-8037-4d35-8033-527c16eb4ebc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "246d33bb-8620-4bce-b94c-82816480e7dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2de80bd7-f905-4890-bb98-1e186717aaea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "fe5981b9-5d7b-46c8-8f6b-de85bdd2b747");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "f0b3afe6-3c32-4d63-a518-3c4d89c98dab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c35a7d63-f6cf-42e4-8c9c-9922981f1492");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "8acb2535-d1f0-43cf-a1ef-d2ba99917c6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "b501c5a4-f3d8-447f-a0a9-6ab6545e132b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "1dbad5fb-3e78-48a8-aac3-01c9d8c6145c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "7cfd9f78-2bf6-4d64-9686-4d383e6bc7b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "e6b4df09-15d1-461f-9dfa-0949b33c11f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "28d2ed0f-9074-4e07-9b09-3a45913f2bd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "faa79c03-cc4a-46c3-8ad8-ac0a20f1c880");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "86539134-c6cd-4934-90d6-b9af5cb1dfbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "5cd78d03-3b45-4917-ab62-21ab5c7e3275");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "e2d891cb-7391-4622-9241-0d0edef2a484");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "1e18a439-7d04-4704-8f23-eafda7397968");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "7efec787-d3c2-4137-8062-93c86b99c854");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "e6623a2d-0398-4c27-bb0f-26b037759378");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "4e241c1c-2b3c-4ba4-b5c3-957f6ebdd813");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "59af2675-1c03-464b-8a02-d3171623fc45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "019304a0-8b5a-4b26-bc72-d585974df713");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "64ec317e-faf6-444c-9b22-5924770ecbc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "bd954227-1557-40aa-b9bb-9cc31ad036f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "328b7998-be2b-4720-a877-e13fd18564cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "39fe6b17-b9e4-49bf-93e9-26b7b760e1e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "b9560663-fdf5-4253-86c7-bfc72caa526f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "28570af6-8eb5-4b0c-aacd-1cc9512789c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "56f94e30-7cfe-4859-9b2d-d3c082d25cf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "f7f16da5-8003-42fc-9057-836456e1e397");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "231ce615-149f-4372-824e-0583d4c6117e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "b4f36ac5-1565-43fb-8030-c3d4217dfeb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "a3128200-9485-4554-ac48-3ab2650fe8b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "e0be672a-e6f5-45a9-bcdc-047c8284e05c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "0d801576-1f9f-4f3e-b4d9-918fe4a1bed9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f909b1c7-4ce4-4396-b9f1-c992c0bd3703");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "b15fbe3f-8e3c-4075-9264-ee333305ab99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "8f222a77-398b-46c4-ac53-523cda37f4c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "bfc2a0bd-fd81-4231-9d56-786d70527ead");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "14f6e75c-2285-40f0-b6d5-eabca6806a36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "164e5680-84e7-47d0-8ed4-8fe0cb3effed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "2c39b38d-05c7-4fe3-a5d1-6f835fd1efc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "0e44920a-fa59-4dce-8681-c3421aac8f0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "556b8c95-12de-4dda-b056-04e1d61629aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "76e5f7f6-518a-4e9f-b462-3eeda70b7bf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "b31ff2c3-4117-4134-a358-c0fdd38f7a07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "00f47f5b-5483-42c7-bf5c-8e0c5ed31c7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "1a53dff7-a48e-4112-8a9b-be2c50b92d0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "62ca58a5-239d-405f-99da-9e4beee3f1cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "491be56e-60d7-4b41-966d-c7e15241db0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "454d55ad-981a-463f-86d1-b14d565b4d39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "8c438bfd-f98a-4895-afb3-6c32a3672539");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "18228175-5638-40a7-8dd7-0deca39b2e8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "215d56d2-0369-4278-b2e0-62f8342c3273");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "59848035-d236-4aac-88a5-70b842330223");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "a51e907e-07b0-4875-ba5b-aa6aa3ebbe9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "c6b3add8-8c2c-4de6-bb9d-759d4601b08e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "fe5c6099-687a-49c9-98c8-5e601df8f27f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "564478e5-f935-4e71-88e3-a5821b41fd86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "bdb3d4f8-a991-49cf-9164-f2c66ea97b43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "5cd62f03-46b9-47e0-83e2-ecd60c221e73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "660cabec-a91b-47bd-8676-dce36fd61325");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "3b9b3022-99b9-4218-adb1-e2f3c63213e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "aef961e9-5f93-45b2-b607-58f0cc1d72f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "4a7f9f3a-301b-41fb-902a-828863d684ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "0e561570-b7e2-4015-bedf-60e8f93dcd65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b098d7ff-62fb-40b7-bda8-bf2f41367af8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "838bc1d3-6ec1-416a-9f68-9b7c0b5fa0be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "6a9e9e38-977e-40c2-81d0-9f86fe3a9579");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "05ec1d27-ff6c-4e9a-8b8b-851eef1ab140");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "d490df6a-5ae5-4c0d-bb79-979875af35c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "3ac9113f-a0df-4e60-bde2-e5121f5deed9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "5be53f9c-054b-4f77-8d2c-1a805eae9bde");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "4429b835-1634-4f1c-99b9-12ede0db2391");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "01963372-b684-4d96-a008-33afc1ce550d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "a8d3d2ae-0a88-4295-b989-874d24dabfe5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "f903c5d2-5d86-4294-a0c7-7f3eee2d0505");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "4baaa634-8370-4cb2-af60-8d3cb49fd078");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "af0e7d35-614a-4b36-bd45-1bef397719a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "baca7aa8-cc4a-440a-8b37-91661dc0ec3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "e90145cc-97a7-4406-b9e2-c7f030c040a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "db8f85f2-f4d5-4a64-ad7e-a077ed8bd2d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "d33e3248-af0f-463f-a1d6-6faed86352d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "cc64a1f9-ebea-48fe-92ce-523d9aff250b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "cc4054f2-69cf-43bc-b316-a5dbdb18c944");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "83664267-b468-42de-ae3f-7abe529db116");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "896287e7-b7b7-4131-ae50-3ad1b9726318");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "380c19f9-9556-4e6e-be67-f491612fd2e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "42223220-2720-4316-81d0-22dc8f1fee18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "55eda31b-61c5-4b29-8ab5-43f89d309c12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "cbdcfec3-7a27-4385-9f75-c62f1db540e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "cbeaffe7-61c3-4192-a804-9cba6cd532a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "ca30d3b4-37e0-4d34-9796-2be435fb84ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "2802dc99-21c2-4a7d-898e-ee0fa7e1505b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "3b0b1c35-e342-434c-bda3-d607d6e2eb37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "1271ed39-b12c-477e-91b8-07714def0079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "d4eb9519-a65d-4f4c-8335-52eac1749406");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "5736e3b7-7ddb-4fad-8597-d8d4831e3038");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "4a9ac783-3072-4c56-9a3c-3a2b9092d0c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "5b011ae1-6b02-46b7-9879-344a0aa1e243");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "51410703-d903-480d-9196-20d93dff1454");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "4e83202c-b8b3-403d-9047-8ba6617ac739");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 7, 22, 17, 6, 17, 193, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2355), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 7, 22, 17, 6, 17, 184, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5778), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5781), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5792), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5798), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5809), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5844), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5858), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5952), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5955), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5960), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5966), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5969), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5980), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5983), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5986), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6000), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6008), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 7, 22, 17, 6, 17, 194, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87a4dc6d-15cc-4dc4-9963-9a7c5b01c959", "AQAAAAEAACcQAAAAEFbScrvlLotEw0j44hS7m6KculQuaciGw4sAtscgy0+ll8L+XSKaNJCPpVZqnPgfvw==", "6062fa37-1ca3-45c9-96fd-ef6bc278f6f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a34d66a8-20cf-4ea6-a91b-dd0381afd520", "AQAAAAEAACcQAAAAEO94GtJO3NQeX9dK+MRFdt7Ad+XMmH4EK9XAHDGGnsDgwx6A1o6rrg4VKK1SEQyBrw==", "bef59cde-71a8-4f06-820b-0ca73101fcef" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "829c0b98-1c6f-4123-be3c-30be621d7282", "9ac84f36-df22-4698-91d5-250ab7d3d660" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9423), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4016), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3814), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3818), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3820), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3822), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3826), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3828), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8084), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5231), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6701), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3539), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3565), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3562), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 30, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3573), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3569), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 1, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7186), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7191), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(820), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(824), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(846), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 25, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4631), new DateTime(2023, 7, 24, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4635), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 7, 23, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 7, 26, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 7, 26, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5265), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2031), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2035), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fa134d4a-38f6-4f59-b454-8aeeb1a12efa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "58fbc4a1-6f78-4e30-894c-87cf50c9a6c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "671f9488-e47d-4a81-8442-733dd9ddff72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a42edeaf-5b52-44ad-9cbe-22e9eba43ebd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e1e05776-d6f0-4487-867c-6e7b2e09a079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5935254b-508a-4a52-a44b-47650aa4fdce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "a1b55f93-a65c-4bad-9501-0acba87c789a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "3e71d7ae-b6d3-4bbb-bce3-1029840a5f84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "53412033-eb23-483e-86f8-13112b9607cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "59297656-7e5a-4797-a2c7-b5fd07aa335c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "54a1b230-35ee-48c2-9310-02131a703a18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d8d13225-14ed-408f-b104-60348c8cbc03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "f63aca7c-86d4-49d4-a3ef-0c8b9cb4d4c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "007d2e42-404b-4366-af64-f8687ac5a87d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "df310a97-2c0f-4263-9b06-a8f49c0b1034");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "9baa8a56-0e17-4437-8ab2-19d41dbd34ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "9733250f-49cc-4c93-b77b-d666e590a44b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "b41e6fff-2120-4e15-ba3d-f47836ec7dce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "0d14cd9f-63bb-4ac0-b8eb-a31fcfea0089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "a15e381f-a4b2-46e9-a297-62e38a4af9e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9308b5be-214f-4e1b-9c95-33c0f0620f85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "a3ded53b-1ff9-4e49-8ddb-4d9d1ab24171");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "dcf9b888-7cd5-4af3-846e-3c6b1a6519ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "f4bff8fc-2535-4c3b-88b5-0f66830ca4fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "7362dff2-8555-406e-9aa1-5d41c0968acd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "2b6b01f8-3acf-4d83-9519-2ea4d802f670");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1a25faff-8d05-42d9-bfac-8298723234b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "d5df4554-4606-4c7f-a224-d32ee31ed314");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "220aebf7-1762-4b12-a5ed-c8aebc30079e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "789a035b-3db5-45d8-a32c-b5bb1fa391b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "7963bf52-28a8-4655-a4d2-295f541edf9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "5f2ae3a6-574b-4ab3-9eeb-dbcbd7ac6170");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "71ccc2c5-5dee-4288-8dd1-5aa7e8343401");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "a07f0e4a-ce7a-4f19-8b31-ebedf484a89a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "bb0d6e13-3acf-49e1-ac49-05e2f6685e67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "afe78977-f36b-43f0-9e2a-753366d89786");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "b788f3ae-a28f-4f95-b8f2-f7763d92de1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "57beb246-262a-47cf-aa86-9beda0b8a66d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "f8cf74b6-398f-41f5-8dd0-a55680b33f56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "648d5b0a-7396-42ac-b3bf-36dd53cc411b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "39ae43f0-4cad-423d-8f08-1ffd22746588");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "a6f73eef-1c17-4352-aefa-8c8bf5d97c99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "8dabeddd-28db-47d2-be2a-1e8cd3a3245d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "d18b9352-2c07-4198-a78f-d97fcd5eda52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "8e181155-596f-4ae7-b391-d73e05456884");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "94cafbad-ee9e-45f8-b58f-23d44aa3919d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "3ef5c2dc-bd10-4c59-a7c2-3364a28e3a47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "fa74bccf-199d-4e6e-ad51-94383f48d2c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "2e017694-a382-4def-afb8-b30d4db41c8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "9d6666e3-2f1f-4bee-8b58-4f445bc02976");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "93057ec0-3b1f-444e-901a-1e53f7ac5762");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "79b8f886-ca45-477d-9ed9-8fa17147f2ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "9f3e3102-4f1e-4c14-ab2c-8fb0a67a7044");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "178367c8-4efd-4f01-a7a7-0e2973fec8c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "2c169d3d-d67b-42e7-9065-b0313d58de17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "e855a893-3567-41d8-9955-efc24110b79a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "f73a2d5c-69e3-4160-add0-5b99b35fde96");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "5dc1b83c-fb46-42af-80fe-a7be1b74a162");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "46ce58ec-bdf1-437c-b7ad-07f8ef4bea61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "13226f38-031e-4013-a5ff-046eb36f6730");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "8b405de8-a62a-46cd-adf2-3981ca9da0a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "becdcb3a-790d-4b50-99db-7aebb1d53393");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "b7635b17-6069-42a9-b4cb-4fa1935597d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "1bb84b5d-7784-493a-accf-cc5fb605b97f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "4d75a036-dc5d-4abb-b602-224204f71799");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "f40eb99c-647e-496d-a4ee-2f2a8efbc710");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "42af540f-a1e4-488e-950a-51978aab8461");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "9d42869c-f4d3-42cb-bce9-18f244dc8d86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "8faedf1c-4fec-468d-bee8-664efc60a1ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "816e233b-45c8-4d99-8ab7-554bffd635d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "e62f6790-35bf-42dd-a0a0-7f02e46f856f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "769927c2-fe0c-4234-bbb3-992028bf49aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "13b23f5d-65e4-4898-bd2c-150fb72079d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "09d50e79-fbaf-4214-bede-ed06d4651178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "eab7853f-f9de-463b-b88c-9b992fb324c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "9ab05533-8f80-4cfb-a1e9-31111e9d35f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "7a968784-7ba0-4d8e-9632-2a28bec553ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "9b32a881-9125-4fab-b4df-0eed8d91aad2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "cb58b845-7f88-4c53-9582-2c78e7f8be28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "f33ac1e4-c55f-4977-8626-9b529fc3abb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "c9064eb0-c452-4c5b-a3c5-0191677b0e2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "0e4b8d79-04a7-4589-aea8-056dbecdb2f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "73be497d-c833-4e13-93f5-54f22f4e7ea9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "41b67188-e88a-4e11-98b3-599584450569");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "f6343ab6-c701-437f-93c0-3b6ab6644c35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "9d96c725-7f0a-4fb8-9370-c89d0c97730d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "a701aa64-005d-459b-bf69-9c09a6fb0ed7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "1048596a-1dad-414c-b0fc-a1a866f6cdbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "2ea876cc-c5a5-4fdf-9cc6-1d872227ed87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "84e2edf6-5a89-4a33-a55a-8f5c03f0c4c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "9164789e-975d-42d3-95b8-caf95b29d242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "9313b255-75b9-4211-bdcd-45aabadf6d3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "63885373-b2be-4818-b267-a0b37f1d4031");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "b93094c0-6131-4205-967c-9c28e3199c0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "2e3b775e-0673-4383-8ef3-fae62198e4a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "e7527fd8-4589-40ab-9643-52be44767874");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "4f5e2d3e-4072-49e2-9170-57071e47e950");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "628b4baa-3e49-4bd6-bbc7-768dfe394067");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "80f847eb-66a7-49ac-a550-aec988c1ca98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "40c3ac1a-9c17-42a7-8ab9-7534c883fda8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "88061f8b-ea92-432a-8767-d4c42e8f4577");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "ac372003-2fe9-404c-b0d8-d8dfb6060e04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "5ae7c228-42bc-4f93-bfa5-46543acdf488");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "cbff6735-1320-44d6-9ef7-029c649bb563");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "3f05baf1-f60a-4047-854d-7be66724c940");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1301639c-248f-4384-b9af-20dac2b37dc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "698f9459-7fc4-47a5-8e3b-17138175ecbd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "0e57f095-8136-4618-8c5b-4f1d650801a4");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9363), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3361), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3365), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3369), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3377), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3381), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3390), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3495), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3507), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3542), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3546), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4c29b2b-5d1d-4c8c-b054-add400d75653", "AQAAAAEAACcQAAAAEF2oUZLFP37k8GS4rZw1lNbht9X1nDN11ETlAo5n3Jjt/DR+RpTpTU1I7BjDm8yEWQ==", "e162771f-cb11-41b1-898a-cc17283e2b31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b796a40-0567-4352-9462-5cc46e113e8c", "AQAAAAEAACcQAAAAEOG+Lic4pWL3uO5Ip0aMY6QHDDflVzrwk7Ejit1f7rdImNUmW/R8XeJ4b3t4vOUpdg==", "3c995fc1-fbd3-4940-b396-f25bb9eefc67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b082305-5c50-4d26-b730-0d46e4636229", "a53a964a-825b-49a8-b88e-8463894b5085" });
        }
    }
}
