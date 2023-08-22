using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class updateUsersDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3924), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8246), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8253), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(423), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(439), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5363), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5364), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5367), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5369), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1287), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1291), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1294), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1303), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1306), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1315), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2364), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2367), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2379), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(9385), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(921), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1787), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1790), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8405), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8398), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8412), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8422), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8419), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8428), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8431), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8442), new DateTime(2023, 8, 22, 20, 49, 32, 828, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5537), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5559), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3755), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3758), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 8, 25, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 8, 24, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 8, 23, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1254), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 8, 26, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(298), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 8, 26, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1373), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9400), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9404), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 8, 22, 20, 49, 32, 839, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(2515), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4342), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4357), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a688868c-22a9-441a-a509-65067a7f22f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f06b4706-9f79-40e0-bdca-3ecc59e4ce81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "91cb0a36-1c89-4a6a-9923-e4b4ff432fb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "adfde366-99d0-4e92-af1a-f5e949affe48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c4ab56c1-6f45-4c4e-af1b-5938a5417292");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "8795b9ba-bc23-4f9c-9c95-176ab616cbf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "1316baa6-800c-4e15-9b4d-cb5d289de726");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "1e5d714c-1ddd-494c-a893-6fa724ce0480");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "db0262c6-f4b6-41d7-99a3-6b1d878f66bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "ed6b689b-2d47-4ff5-b249-b82ca783450f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "59f1ecfd-c26b-4ca4-b6ae-55ace0ac0833");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "38923131-da5c-453b-b900-97b9ed5c794b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "81bad898-72d4-465e-be74-fc39aebe7639");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "83313fbd-b58c-43cb-b735-ddedcd304d08");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "894c12b7-14b8-419d-8730-d08a6b1c8f52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "c9abce22-7463-4444-b057-2ad82dfa9a20");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "7bd38597-9c43-429a-a7b9-e2f883a3ed1b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "179ab705-030d-4c4a-bfab-755b0277bae2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "c820e5f8-d964-41d8-b29d-10551e6267c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "3363b9ea-d730-4c14-9ab2-ac8767528405");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "81753f16-902d-4297-a7db-42ea3db2825d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "3554d75c-329f-4b38-a039-dd80fb0c2055");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "f6581b44-86c6-4ecc-90f0-72f00d421b29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "6075e9da-17ad-4d07-a47c-376cc9c81864");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "2d9c38c6-d8d1-4ecc-9c4f-7b514d0886a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "b387504e-3770-4a99-86a1-0960127846fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "cddf25e3-a49a-44c5-bd45-c324071aaff8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "5e20895f-d0d3-4d52-842d-ddea5442df40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "34631ab7-d6ec-4b8b-b570-2ffb81352418");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "4ba27d0d-31db-47f0-9628-2164a7313592");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "766db832-3024-48cd-bba8-c5d7b3dfb2b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "82c79f64-7633-4622-8c1b-6a6fce6feae1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "50742085-041d-4c70-be36-9c7ca34fe097");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "d3ffdc22-a3aa-44be-8921-97787b205b91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "01a4e18c-ac13-4269-ae3c-c583df5d91d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "44fae746-15b2-4630-859f-2f7734f42558");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "d7998817-95a0-4d08-ab8b-9c1a47a093a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "7239865f-7230-43bb-b2e9-05c41a714e34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "35da4233-60f7-45ed-830b-a509aecc936c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "a5f2fa44-81f3-44a5-86c9-e4643478af00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "36b8efe8-23d4-4ae0-bcd1-e5b36776780d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "35418bda-2a17-4d7e-91dd-1a0046e64f55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "0e12f108-725f-4712-aed0-810c393eb2f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "196d074b-9209-4eb9-bb32-e112340f0c8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "e13d034f-cf5c-4f01-8e39-6ec92579cf9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "63d2ec76-1730-4457-b0a5-4d6d07cc122e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "1f712931-895a-4747-9f00-262bc73dccb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ba4ea472-fc2e-4d33-8bc7-67202970f7ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "27c5ff53-0e5b-439c-9814-0bafb56cf872");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "ee02cf29-9337-471c-be0e-445cac9471d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "49078fc3-63e6-4246-9fb5-1933f506eb66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "9fb70ca9-4442-45d4-b2d8-197a6bb910cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "02977cdc-815e-4230-9979-a4765f28a27a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "bbd5fa68-4f48-4b0f-b8b8-67a6e4717092");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "0ac6596d-fc34-4f35-ae9a-d5629eee65bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "13e00412-c409-4cdf-a08e-64784dada3a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "a462052d-dc9a-4beb-88c0-d80b89447c05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "74b04cdb-64b0-480b-a73c-073506b5622c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "1e782835-e49c-4eda-94c2-9e0ed70abe1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "00babfb7-fac3-4054-8506-852c822f7b35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "c0d33645-71cb-4134-9131-7fe835ff75d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "b8f8baa6-e25b-49fa-866d-e32e7cb6dc32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "4765611e-916e-4efd-b217-09964dfac9d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "9e2ed698-4006-4309-a685-096c9eea0e70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "310d52b6-41f9-4f5f-8229-b6c83039cd14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "5f8ca3e0-5e65-4866-8959-080570f90052");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "05c1f3a9-8c39-4c22-beb1-7551edbecc48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "8166ccf8-6a65-451e-9f4d-09df4dfd675f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "92267172-d09f-4341-80d9-7694765fbbed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "3165b169-7968-4c9d-843a-deff3dd24ee8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "5cfc23f9-c013-4c1a-87d8-a05e016622e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "c7da92ca-cedb-4c99-81ae-d5dab9015c8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b561fe0c-5384-4fec-a4d1-bc9abef21690");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "82fae68b-a6ee-442f-ace9-f971e38941fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "6fbdd5aa-18e8-4d78-a7f7-83afec48fa02");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "4ad8566f-10bf-4cc9-be58-2826aa846b30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "5c1e912a-098b-44e0-bb77-22654de99222");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "5815c9d9-c915-4d02-9538-06370da10ab4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "0f1a1572-6159-4526-a9a4-996758fe7f23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "16ded76b-4121-4308-9d3d-c0dfeab5bef9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "b8e40c51-9b03-440e-9723-d83a6f5bbd22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "6bbd1de2-04eb-43e8-88fe-ffa654a5079b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "4b4bc2ef-ff35-4445-813f-66c2571f356c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "484eb946-4840-47bc-a3d4-64c7cd79d7cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "bb04ec18-bf1b-4ffa-a809-00da30cc196a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "b2cad6f2-adea-4a79-89f9-8243860060af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "e5b81dbc-f1dd-4328-bee9-dc07ea26c795");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "451fcd8f-0258-444b-b24b-4db329172f3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "14b673e4-d36a-4adf-bff1-4b7119aaa8e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "a9cfc0a9-5f96-43a2-b51c-d3e5cbc1d97b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "7ac5cc87-4640-44e0-96f0-0fcc4fce558b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "a0fa26ff-8c73-428c-a590-f563bcee229f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "6b14d5fe-85dd-4dd5-8630-438f10054ea1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "4f0af1ae-7a82-4880-937f-c498e3897776");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "016863c8-14f3-4ec3-8891-789540fb1e98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "ea04b6ec-28bd-40e8-aefb-77f815c3862b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "a4e0a049-10a3-41a0-9ba8-7edca4de29ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "1ccde159-cd42-4934-8837-24381fd16948");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "cade3a81-936b-49a3-9c29-4de349ae6c65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c6563b78-0c1c-4b10-92f9-1c8e830c8fc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "5c904615-4993-4645-8acc-2595fb56f0cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8a8959bf-0d17-4623-bb03-399aacfd79dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "996ad72c-11b8-4547-853f-b44d4bb80023");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "438c7588-6c57-4111-a829-89e524f9b903");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "7dbda956-1568-4de5-89d1-34759fd4d8ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "d3a22882-536e-4a89-b23b-39ee3d95ab95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "1168955d-5ec0-4958-aead-06e8254738a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "43bfcb11-39f0-4930-aedc-eafe728115b7");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 8, 22, 20, 49, 32, 840, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2747), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5625), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 8, 22, 20, 49, 32, 829, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4951), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4954), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4964), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4967), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4973), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4976), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4982), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4985), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5031), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5046), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5052), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5110), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 8, 22, 20, 49, 32, 841, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d176a63b-f0ef-4592-ae1b-675b21168e69", "AQAAAAEAACcQAAAAEHRW5vof9+5AmJm34LabIDs+P+fxNeaJPbr6NPciSFN6CbfvzScTFTUJhXpTpY53Ug==", "0a661f16-aef9-4358-8ced-6c11a5d12821" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe87972-da4f-4554-b81c-f2b88d86147b", "AQAAAAEAACcQAAAAEFhlPu3LNlgh/HZsM6zN63ga00K8Qd0Li+XizmI4Psb9f1Jg8OhmJZFy7X0ZIVvgrw==", "2d4a8aa3-8bce-4270-8cc0-d51b8235a4d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae0b9614-2181-48b7-b64a-2135664610cb", "AQAAAAEAACcQAAAAEPYpDiUOlLbxIZMGxRq6deMauvtcQ8qeWIVcVJTd2CM0odrOhIxgDm/KjL5bGQMoKg==", "8b37c24b-92af-48cd-b25f-bc52488b07bd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 4, "Geliştirici", 0, "079c5933-f6d0-402a-a90a-079804be1f6b", "x@gmail.com", true, "Bedirhan", "Gündöner", "-", false, null, "X@GMAIL.COM", "DEV", "AQAAAAEAACcQAAAAEGpjfNqnaImEH7X2p2xu/AoRytfWVwJFDIhrqzG6kBh1UqTA+0wMmbcbWNnXB8XGSw==", "+905050102249", true, "/userImages/defaultUser.png", "a2aac303-02b9-4292-b0e2-d069066d43fe", false, "dev" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8248), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1000), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1014), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1024), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1030), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1059), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3782), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8170), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3645), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7186), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4046), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 8, 25, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 8, 24, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 8, 23, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 8, 26, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 8, 26, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3895), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1067), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c718fe4-bb18-4e76-8ff1-2904a0f135d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "98882ca8-9fd1-4e63-be3d-3d43433a160f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6ba2bd77-b015-4449-b5ff-9fe203d530f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0fa1f816-7f26-4211-83ed-b9785941d29d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d8c5b624-1c4e-4500-8f0f-86bea69bd660");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "8eec020e-da99-4d3e-8ebf-bf21bd6f66e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "cbb8ada1-72e3-4f46-867f-294ffe731d1b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "28992952-f576-44a8-9758-bf81ab310540");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "0ff03e53-637a-42c6-8ee4-73c8dcddf7ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "ebf93765-960f-4ae8-897f-b73fb5d6c5e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "b1711577-41f1-45dd-a270-05e1d7efdaa6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4314c1b9-c914-4d44-8f39-6e3cad38f09f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "02e67c3c-b1cb-4b91-9070-2197ef804217");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "c2e0e2e1-8525-43fa-8ec3-c3116d7028cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "900c85db-8a25-452c-b14c-1462fc62a5c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "1d876844-8f77-4272-8ae3-01bf6c62f12a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "06d1ef19-304a-4a71-87b8-b930d73b4dd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "69e316d1-3b63-49bd-83d1-2c2670e3e089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "ed2872dd-1607-4148-8925-7d638fac97a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "be673407-55be-4a76-a407-ca5e47e36f0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "46cc4fdf-0878-4ee7-987f-dcd76f50df74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "228279be-c70a-45ab-bd52-e9330ea007b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "db09f36a-e4b6-4a0a-b213-e8f5f559c7d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "4c3b7c67-9d43-4bfd-8a6b-9e03f7766a54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "e58e8a6d-48f8-48af-948d-cf7f6380747a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "e5fa0a25-a000-45ac-afc7-dd25e805bb95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "42f0e445-8036-4826-a828-3a64166fc883");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "a1bf3aaf-a6ea-4957-8e1c-1e5a0d0ccfd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "ab122325-bc4f-4fed-aafa-6cd1aecc49a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "90e52646-cc70-4c08-8c3c-25cb04154602");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "b73a85fe-c703-4b62-a210-a5b744b22cf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d3bbf8d8-b11a-427f-9166-c368b9a55b12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "ded3d969-f84f-4d06-9323-9f2740dcf468");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "3773bd79-5d78-4ecf-a6d0-25c96ce0b631");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "216c080d-c735-41e2-ab54-804d24117113");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "315c56c1-4be5-49a8-b28b-4933abd54aa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "b5c226be-c47c-4d2f-86de-44cb1abcfaf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "6221682e-d725-423c-95b7-0e7e0129b33f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "22d53c81-1f47-4d13-aafa-79793f662521");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "29e7b2d8-e887-4511-b763-648b297222be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "9c74cc65-1258-4662-b8d7-ab91c4cdf181");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f2294cd2-944f-40cf-a364-dad76368a207");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "62dd750a-6e6d-4cf6-8397-927b10a2aa03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "bc637f32-9be7-408d-9b4d-2f1710f31d53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "df79f27d-8518-4de5-b0ab-2865c069867d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "67e86b46-f578-4a46-a686-1da2565b9e9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d92c9ef2-7341-46ce-ad0e-70a0b55e1ebb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "b590bf53-9b7f-446f-bc1e-6eedf3667f43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "918d5ecd-0e1f-4e1e-b7ca-9e03ff9d7d25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3f5a4f3d-bd47-4c80-94d2-10c325e2eaa9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "9fb3025c-d7c0-46ce-81e5-eff250d5340b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "e402281d-2ef9-4dfd-a9be-966c53955da1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "b2d0f468-e0f8-4e42-9422-2f74fc625ff5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "df2502be-332b-4b09-a3c4-4005d7fac244");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "85f9e2b2-79db-4b80-840e-45f7a11305f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "39f172a5-eeae-40a8-95b2-f6fc2befb0e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "098e5645-2d34-4371-9fc7-3baab1e70f54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "55f0a3e7-1df9-4d62-9394-8381aa656abc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "4be5e94c-d66e-41b7-b0e5-5d6bb20a574f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "0c22493c-52af-4719-9cb2-53d1b0da406e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "c01c6d68-2c5b-488d-9422-34abd1291a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "bdfd0f65-ac9f-47ac-9836-a50f194d36e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "3524ccd9-5b39-4886-85a6-9c29f8d4d11d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "33619f99-3cd9-4205-9e37-d62a6cfed2cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "b4154db2-b5cc-4701-b2e7-93c6d1ca386a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "50396768-f54f-44df-801b-425b105de3f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "3a41848c-b1d6-4c4b-ba5c-d6d482893d60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "cbeb5ac5-af4d-487a-8d61-5cdd221a20cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "263fc052-9e9a-4761-9f7b-007e7980cae0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "874d07b4-228e-4bf8-82ea-c9276578dd2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "fb70c832-0053-40db-b97e-2cf3ec4cca80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "bd518ebf-1907-4806-a5bb-8bd123d22a12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "607085ef-a7db-43bf-9a5f-33b752e830ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "e947c2ff-7eaa-41dc-8c5f-701042a446a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "d9950a17-a65d-4694-8221-6e069a7b995f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "27484142-fa7f-4fef-a888-390222b09345");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "c9b01514-17c2-4d2d-a9e7-355f9849c246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "2f6e3e23-0ea7-487a-b800-40b9c1ff3582");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "c70347ae-97be-4930-a6b3-b1220b1f0eed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "35629674-b9c2-40e8-bed1-30641c726570");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "fc2902da-2d93-4812-a8bb-afd79871cdf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "d71e5db3-b4af-43dc-a90d-f26648f555c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "6a779e28-90fe-47d9-9101-9da3d5b7da4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "5eac9607-84b6-438a-bbbb-5be329b6fad7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "3c796fb7-74da-4604-bb1c-95d856671b66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "c1b93ea1-30f4-472c-9bee-a97f46a3b802");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ba01ea0c-01ee-4566-a00b-e3bfc7dcc5e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "78910c50-f61e-4b8b-b9fb-4269b760487d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "848950fd-7a9f-4c9c-a4c6-c39617cf7f60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "e1e7f6ad-2dec-4327-a84f-499a8b9a9550");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "4d555653-1d04-45a1-b719-6ba9955a3013");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "48969f83-514b-402b-a680-225503cac968");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "511acbe0-05a1-483a-ad37-c2aed9959bf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "7da2c077-9768-4e96-b7f6-a030a1b07caa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "0252934a-0dd4-46f7-90b7-2ec1ca74c364");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "d5ef7572-c1e3-4c07-ab14-a8c76d8b4293");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "9dac3310-3dff-4e11-b230-80af54386b33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "af92dc11-bc9d-4201-b84d-57707c293866");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "d4b5c42c-a2cc-4b4e-9796-3abd3c796154");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "1551159a-c4f1-4743-ac8b-6b6222ffdab4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "747813d9-6080-4b08-a3f7-58e777f047cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "df63d102-b3e2-4867-85d2-4ed5cfc69473");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "cbe03424-6fc6-4ccc-8552-59d7273a53ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "0f253edc-d2b9-4dfb-b4e9-eb8b618a2f8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "6ad6a933-e8a3-4ac3-b12d-7ab5ac4ee47f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "942b0468-5d27-430c-9b2f-928423880f59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "decbc143-49b9-4e44-84de-2580223786b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "5f39a01d-a313-4f93-80a0-b8d6e257e0ed");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3293), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3297), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3344), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3359), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3367), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3370), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3390), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3487), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3491), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3495), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3382), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3545), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ae96698-9b29-47d1-a35a-508f57dca0cf", "AQAAAAEAACcQAAAAEALIw1s2Qx2ef4npsLgrxJu3zKPJwFw1lGLS53R6KLdZli/W5Cv5zfq9CzcpUXg4xA==", "1c420633-d3d1-42ec-a2bf-788781912194" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "823f5291-cd42-46fb-9c98-2a820a728eea", "AQAAAAEAACcQAAAAEI1qN1rSROXg4MOwh/kPuJtyWCyk48xgpuHOiLu7AWLcZPgupdieLMojqk0/DbF7Rw==", "d6c6338d-6fab-4b69-935b-a548a3357f00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd896ef7-e7a2-4110-bfad-899edce3ae73", "AQAAAAEAACcQAAAAEN6vgClKhU8QwwU/B3eXZknXvq2VPn+j8lMHlAaOyYo5D9xEdkeV0Xr3JH8Wz7SOqA==", "66c9fe28-b9f0-4f7e-9585-0f7266f38823" });
        }
    }
}
