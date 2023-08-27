using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addedDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1875), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9322), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9339), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3292), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3295), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1360), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1364), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3685), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3584), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(746), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(763), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(767), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 8, 25, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 8, 24, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 8, 23, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 8, 26, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 8, 26, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2509), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1679), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "727fc4a1-3e36-4f60-9d76-335a42887527");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "11dcc66a-2c74-4611-9e40-f5917ce274ed", "Standart Kullanıcı Yetkisi", "DefaultUser", "DEFAULTUSER" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a5a3d17d-820e-4a86-b566-5699471d9b94", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "25b61556-6642-431c-abbf-5fa085616de6", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9cec4f5b-23c7-42a9-9a70-697bd7a2dda0", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0f213d17-dd52-4e4c-82bd-967a2a2abb2f", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a3198b56-5f8b-41c8-8b50-e7adb08b0a65", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "538ec7b6-41be-49b8-8c70-e4b711ffd542", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c7b28d09-1230-44b0-b3d4-35345855361f", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "843377bc-f902-4bf7-8dcf-fa970a7a1de7", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f88866a9-e843-4624-85ad-e5b266991987", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f65ec857-fd9f-4316-8142-0bbc3d5887be", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0885b630-e6f5-4eb3-9994-5f4599087c18", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dbe4f9b4-4639-45b9-baf3-e7fd3bdee53d", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "809bf588-177b-402a-9756-5372848d0d67", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7c27fe4e-94e1-417c-b3c8-8808e9aa8a8b", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "44e994a8-a485-4137-ab5f-5fce9afdecb1", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4b144d2d-618a-4f41-adf7-006962059a80", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ebd2f92d-81fe-4ec3-8927-61e4a6dd7879", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5a981157-2ab1-4d68-b753-09b1eb5cf15f", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2febe768-e189-46c7-b679-591084764080", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "717651e6-3f55-4025-b814-7cc86fee7d54", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "cb22bc0f-d5fd-4046-b3ee-51172b0b9964", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "76ac3203-59df-419e-9449-5c0e520b0c6f", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "38138157-1d8c-4054-834e-b2b027f4e130", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c68b1afe-969a-4066-a21f-b39bdf69cdea", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "05e33938-b525-4542-9211-cec6e586a7c7", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "30f153ef-42f8-45a5-ae1c-d9ba8da97ad8", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "be2fd7da-11a5-407b-97ae-987cdceab83d", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "42604cba-6e93-4d54-86bf-6fd80b1e5f5a", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "35f03645-eb18-4d4d-a218-5d043304ec26", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c2fbc89b-9928-4408-b370-a2457145a683", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "95eef221-db26-4a57-b9c3-aaa2cf70952f", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "57fadf9e-066c-436e-934e-f5c1e6831d4a", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d808d460-2f49-4fe5-b1c2-f0ff5cde59d6", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "639d2930-e1a8-42fb-aa8f-b6b429565fd4", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "92c41e2c-0fa5-477a-adb1-e10367ca39ac", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "70f95468-92f5-49e5-bbf6-18fed4a2efe5", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5dc9a9bc-28d3-486b-b6d8-5a7ef16aabb3", "Geliştiriciye Mesaj Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "84a15aed-e24e-4368-9de1-e48a2bda16d7", "Geliştiriciye Mesaj Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "26f29fed-2643-4642-b8a6-45e41692ef5b", "Geliştiriciye Mesaj Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b152a513-93fe-4b19-b416-cbcd184d50ad", "Geliştiriciye Mesaj Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3b6f644a-6441-4e24-9c2a-c82cf57454b7", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1366a593-02a8-4cb8-9616-e479ae018972", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "24dbd8a4-553e-42df-b162-b3d0c67a5953", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5736631e-2b42-4eac-aeb1-9e3d8fef67cf", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d5d72342-01b0-48a7-af55-176422639bf2", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "27cb91ee-cda0-43f3-a224-ba1245226547", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8f38570e-0d6c-4531-a2a9-931e317497e7", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4e8caa43-b868-42d9-886b-b5b2eae99b3a", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "514013a4-06ba-4cea-b166-825a329ed0aa", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "615ebac2-1890-4a22-9b8b-229778df5336", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "74622c98-31b1-4bc6-8f25-6381713bd140", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fd128580-f75e-4aca-9f3e-316a4e4735f7", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3aed32db-7f6f-4c47-b1b4-78623967a77d", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3e3183cc-751f-4fe8-bdb1-c60df7c14ae4", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "55d82497-d71b-47f8-a18a-208a1732a558", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "832c527c-bc1f-48b1-b225-567e4f7d179f", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "95ccee52-6c0b-47a9-b26f-45d6db8e3253", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "590b179d-6495-4652-9217-4a0bf95d9f5a", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f7826d30-7e4c-406b-86ee-25e365f56f4e", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c5d1823a-db54-40f7-986e-029c84f3d725", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b130b14c-fa2a-4e1a-886c-d0aceb64fa58", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "05be1543-b5f4-41e9-8aa8-b53411cefa9b", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "35bd8ae8-fc9b-447f-9e01-e66e32daa9c3", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "52abc163-2717-4766-ad0e-449604fc5a52", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ad2eef24-71a2-4640-978a-d4c68b4471e7", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1883fb8a-3371-43b6-a498-123f15b6af20", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c4b0b36f-ad58-4471-8322-0e8a602eed2e", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "49715c82-7a1f-42ec-86ff-e6dde4d926c2", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "21111f40-da88-4c3a-8952-d8c4fb3ed259", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "71c36186-c678-4a7b-9bbe-9faecf5796e6", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1d28dcbe-7081-418d-aad4-bc1487a24ed5", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c9deaaed-db4c-4f8f-abea-48702ed2f939", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ac87d71f-5fe0-49a2-a664-56e0ae6cc4ad", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "be6de845-cc43-45cd-a55d-36d386b2645c", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6133aa16-c9d5-4ed0-934a-7b70270362d9", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9e0bf8a3-60c9-4238-a1d1-9e2b663b1dae", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "13fe87a4-e903-4275-8557-0bcb21b6556f", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f540d06c-a1d3-4135-90fd-773c58689a3a", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "557225b5-1ca4-4683-ae6d-cb7c872bd909", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "322481e5-9848-4e09-926b-d773375ef6ba", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "018b6732-4bb6-48c5-873b-67b7efb0b556", "Geliştiriciye Mesajlar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2b045918-dc26-4079-86b6-ce9b355a2c75", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5dea7625-53f6-41bc-9ec4-802e68ab9aa5", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5ddd7306-7243-432f-93cb-3c6c75c020b9", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5bd948cf-9f56-46a9-ac90-b7a2956f90a8", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c1b93a5f-c08f-47e6-b437-8b87dfc24e45", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3940d2ed-b294-43a3-8d6c-fff7b58bee99", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "29b29fec-2f97-4572-bb9a-593ba48c55e9", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ce2594aa-c832-49ce-a3ce-f777179271ba", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bb35ae09-71b0-4c5a-b928-91983f83ab2a", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "90f6d5eb-8ea6-4e76-8964-149307f0661a", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8c41e154-98fa-4d08-98c7-daab3521e8cd", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a290dc1d-5614-4c67-8390-1ef0983c80f9", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e5b83b28-cdfc-4e6d-bd82-dc6eed2a3025", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "27a31cd3-3bf9-43e5-af86-507decb006bb", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "760dcc5f-099a-49ea-9a86-01701c54b878", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bb37b8e5-058e-4a04-b93d-18c7a3d858df", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c677ddfe-40fa-4bda-aeb4-99ab96ae0bdc", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "19a0a60c-9be6-478e-97a4-27dbd3765b97", "Geliştiriciye Mesajlar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "dc2aad9c-b47a-4415-8ea2-5b48292f06ca", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c52990a5-24eb-4d16-89e1-114b0085841b", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "61644c96-08be-430a-a7d9-3149a5072757", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7d08339f-6ffc-4fdc-a02c-dbde7da53053", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c631503b-0983-4a58-83e1-65af6bb5c201", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e6f011e0-171b-4d8a-a852-949b8b005f77", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "33a2944b-ade8-48ba-9b8b-3329cbcbac35", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 109, 1, "67206247-2192-4e72-9f1d-60c58c472965", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2629), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2749), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d535a1-4291-41b5-8ff7-0369512f67dc", "AQAAAAEAACcQAAAAEBfJ2HxgGj7snQknYBK49u39Cd2raPORXQLTjUGaWw19joGobo4NRQLsmAu0YFy+Og==", "9d75bc09-f5c5-4ebf-af53-636e5de5490c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1c9fc99-38ae-41a2-9e72-0e8518edc8d5", "AQAAAAEAACcQAAAAEJ1e/OH0LAt6L1py9AviEua8CW6spwVUAvbikRCVCwAVclpT3thwqRPcle6dUBPp5A==", "e62de4d1-378d-41b0-9627-e50e54429812" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba07cb94-d01b-4572-9be1-4ff7f433b975", "AQAAAAEAACcQAAAAEFCKa5tjqToDm43CT6QSoutfxjLeia8Y+6ycinZO4SXXYyjenaDo2m98ed/0LZDlbg==", "a79df583-b10c-4652-b8c8-ee0be76d5b31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df268047-2157-4083-adbc-5a95bc4756db", "AQAAAAEAACcQAAAAEFEKe5dhqXckc1ayZyAOby5EaFhwDbZcJd/VdUlNdWCerbHFZE4DyZ72E5ypZCER4w==", "d4418a01-51eb-4da4-9c79-0472f80e5e3e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(8083), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6106), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9848), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9864), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 8, 22, 21, 12, 7, 891, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(24), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(7301), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(982), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(993), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(7811), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5192), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5195), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6526), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(197), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(214), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(227), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 8, 22, 21, 12, 7, 908, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5303), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 8, 25, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5324), new DateTime(2023, 8, 24, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 8, 23, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5004), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5016), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 8, 26, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4128), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 8, 26, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3128), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3148), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 8, 22, 21, 12, 7, 905, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 8, 22, 21, 12, 7, 892, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "76445054-1c3f-457e-b542-66d3040e7359");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 3, "edc8af7b-12dc-4c23-a16a-3a6a4188d6dc", "Kullanıcı Ekleme Yetkisi", "User.Create", "USER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c5d7fc9c-bfa9-4e79-a06e-680490de3883", "Kullanıcı Görüntüleme Yetkisi", "User.Read", "USER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6d637c5a-3eda-49f0-a016-221e30ff3226", "Kullanıcı Güncelleme Yetkisi", "User.Update", "USER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8bf453a6-a2a5-4cfc-985f-af136a520880", "Kullanıcı Silme Yetkisi", "User.Delete", "USER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e8ed877b-f96f-4071-85e4-1f0a0b1312b0", "Rol Görüntüleme Yetkisi", "Role.Read", "ROLE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4329b78d-01dc-46ff-9f7d-985a09717a1b", "Rol Güncelleme Yetkisi", "Role.Update", "ROLE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "65f36d59-77bf-4351-926f-067f29f31393", "Rol Silme Yetkisi", "Role.Delete", "ROLE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c935e323-8c34-4491-a583-cc7e16687461", "Rol Ekleme Yetkisi", "Role.Create", "ROLE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "78344b56-3869-4f47-8000-bfac9e1a40ca", "Ödeme Ekleme Yetkisi", "Payment.Create", "PAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "018f1645-3cd2-4c34-a151-9a82ab3bad4e", "Ödeme Görüntüleme Yetkisi", "Payment.Read", "PAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "85f755e4-1676-4973-a36e-468ae4e911d3", "Ödeme Güncelleme Yetkisi", "Payment.Update", "PAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9ee64833-089a-4a49-8294-b1a5afcca207", "Ödeme Silme Yetkisi", "Payment.Delete", "PAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3f23b222-f750-458d-aae1-7708f8fc8370", "Ödeme Türü Ekleme Yetkisi", "PaymentType.Create", "PAYMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2691cd0a-82b9-4ebd-9cb9-e4bde5ec193c", "Ödeme Türü Görüntüleme Yetkisi", "PaymentType.Read", "PAYMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "61bee589-d290-41be-924a-f503eef55833", "Ödeme Türü Güncelleme Yetkisi", "PaymentType.Update", "PAYMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "61015093-73c9-4869-b83e-9cc33c25333f", "Ödeme Türü Silme Yetkisi", "PaymentType.Delete", "PAYMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "34d89093-c6e3-445f-96b7-65f8097b0791", "Personel Ekleme Yetkisi", "Employee.Create", "EMPLOYEE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "43c0d8a2-46bf-4e5c-8de9-eba2988ee6c1", "Personel Görüntüleme Yetkisi", "Employee.Read", "EMPLOYEE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "66f6fe7b-4f44-43c5-8e87-adb33c542556", "Personel Güncelleme Yetkisi", "Employee.Update", "EMPLOYEE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2d4f02f1-0562-4e1e-bdfc-1afb50db6dcf", "Personel Silme Yetkisi", "Employee.Delete", "EMPLOYEE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2a3e5a06-f4be-4986-ba68-08afbf60c595", "Personel Türü Ekleme Yetkisi", "EmployeeType.Create", "EMPLOYEETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c76c3478-48d0-4e93-90d4-959127239b47", "Personel Türü Görüntüleme Yetkisi", "EmployeeType.Read", "EMPLOYEETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "af4f8709-4f6b-4c70-aaa7-6b341111da80", "Personel Türü Güncelleme Yetkisi", "EmployeeType.Update", "EMPLOYEETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4de76327-7572-4bfd-9bc8-0b60e57a11db", "Personel Türü Silme Yetkisi", "EmployeeType.Delete", "EMPLOYEETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d8fc1d42-99e2-4d5e-ac1d-9a4a003c87b8", "Müşteri Ekleme Yetkisi", "Customer.Create", "CUSTOMER.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1facfda6-809c-47ac-844a-d524bd64a292", "Müşteri Görüntüleme Yetkisi", "Customer.Read", "CUSTOMER.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5d7149aa-1374-4c37-aef6-637e42901726", "Müşteri Güncelleme Yetkisi", "Customer.Update", "CUSTOMER.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "84c0c874-bc32-418f-b736-fb4c5e52bb59", "Müşteri Silme Yetkisi", "Customer.Delete", "CUSTOMER.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a9f518a5-b020-48fc-80e0-19a2095a4547", "Müşteri Tipi Ekleme Yetkisi", "CustomerType.Create", "CUSTOMERTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7083dd45-0757-4e0a-9785-bf8ab9f30e12", "Müşteri Tipi Görüntüleme Yetkisi", "CustomerType.Read", "CUSTOMERTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1407aa27-9beb-4077-ac58-e5e93d14c562", "Müşteri Tipi Güncelleme Yetkisi", "CustomerType.Update", "CUSTOMERTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1fd56891-046d-483b-9530-17519bc1eaa5", "Müşteri Tipi Silme Yetkisi", "CustomerType.Delete", "CUSTOMERTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9a8e6787-c4c5-44a1-a923-5309603bee86", "Bildirim Ekleme Yetkisi", "Notification.Create", "NOTIFICATION.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a8b7129f-5182-46f2-bf91-a709a6164f76", "Bildirim Görüntüleme Yetkisi", "Notification.Read", "NOTIFICATION.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "40df1694-17f4-410f-8b6f-668700508928", "Bildirim Güncelleme Yetkisi", "Notification.Update", "NOTIFICATION.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5e9601ad-d2e4-460b-9b4b-af792c290346", "Bildirim Silme Yetkisi", "Notification.Delete", "NOTIFICATION.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c2e0165b-419d-49d6-8ba0-bb5395ef00a8", "Geliştiriciye Mesaj Ekleme Yetkisi", "Brand.Create", "BRAND.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5545a5fd-30fa-4f29-8c38-3625ff0e0c78", "Geliştiriciye Mesaj Görüntüleme Yetkisi", "Brand.Read", "BRAND.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "efdda925-29ca-4582-9a64-498260b00fe0", "Geliştiriciye Mesaj Güncelleme Yetkisi", "Brand.Update", "BRAND.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3ecebe19-3460-4cf8-a4e1-9ea100f7ec78", "Geliştiriciye Mesaj Silme Yetkisi", "Brand.Delete", "BRAND.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2ba0bf82-910c-45e9-9ccc-65f402ee1eed", "Satış Durumu Ekleme Yetkisi", "SaleStatus.Create", "SALESTATUS.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "2c46c158-5dc2-4bd8-8420-2f0184bc5c5d", "Satış Durumu Görüntüleme Yetkisi", "SaleStatus.Read", "SALESTATUS.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b6d3cdd8-6b73-4a0b-8019-6473af765d3d", "Satış Durumu Güncelleme Yetkisi", "SaleStatus.Update", "SALESTATUS.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "46d299e4-da77-4e5b-8542-0fcd7bcc9a6c", "Satış Durumu Silme Yetkisi", "SaleStatus.Delete", "SALESTATUS.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "0ae92075-7140-4031-9d51-e3dba9429f44", "Satış Türü Ekleme Yetkisi", "SaleType.Create", "SALETYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "1367ec09-d459-43c2-83b1-a5e2ff139ea0", "Satış Türü Görüntüleme Yetkisi", "SaleType.Read", "SALETYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c79541c5-1343-446d-9e38-e98a4a21c064", "Satış Türü Güncelleme Yetkisi", "SaleType.Update", "SALETYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d3d87362-ffa3-473a-9df5-13fdb639f341", "Satış Türü Silme Yetkisi", "SaleType.Delete", "SALETYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a6a81c79-e311-4784-8f2b-e5b0f40d321b", "Ürün Grubu Ekleme Yetkisi", "ProductGroup.Create", "PRODUCTGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e4ed8eb0-b655-47c1-8d17-8855606205f1", "Ürün Grubu Görüntüleme Yetkisi", "ProductGroup.Read", "PRODUCTGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a773350f-ed33-40d4-97d2-2c2f05d50bbf", "Ürün Grubu Güncelleme Yetkisi", "ProductGroup.Update", "PRODUCTGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "879451d8-e74f-4783-8212-5136f1877de3", "Ürün Grubu Silme Yetkisi", "ProductGroup.Delete", "PRODUCTGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fec16fe1-2f7d-46dd-89fd-498eb69d1242", "Ürün Alt Grubu Ekleme Yetkisi", "ProductSubGroup.Create", "PRODUCTSUBGROUP.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3abe4ebf-9bee-4b61-9c6e-50774df0b9e6", "Ürün Alt Grubu Görüntüleme Yetkisi", "ProductSubGroup.Read", "PRODUCTSUBGROUP.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "b9724c05-3247-493b-96e6-4a2e4bcf5ae0", "Ürün Alt Grubu Güncelleme Yetkisi", "ProductSubGroup.Update", "PRODUCTSUBGROUP.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6d9dba35-8004-44a6-aab0-3698d5d9b7d7", "Ürün Silme Yetkisi", "ProductSubGroup.Delete", "PRODUCTSUBGROUP.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "51ebb652-eb6f-4ae1-855e-bd7fbfec17f0", "Randevu Türü Ekleme Yetkisi", "AppointmentType.Create", "APPOINTMENTTYPE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bcfe4bbf-cea8-41df-8996-25daba6db227", "Randevu Türü Görüntüleme Yetkisi", "AppointmentType.Read", "APPOINTMENTTYPE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8aac43dd-7bfe-4165-9561-4088d6f0bdf8", "Randevu Türü Güncelleme Yetkisi", "AppointmentType.Update", "APPOINTMENTTYPE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "d2155d0a-d564-4237-b975-9d8b063e0cee", "Randevu Türü Silme Yetkisi", "AppointmentType.Delete", "APPOINTMENTTYPE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a13a15e2-af0f-41a6-bd50-f02da2542466", "Satış Oluşturma Yetkisi", "Sale.Create", "SALE.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "86d583d2-94f7-4f98-a952-e669d94675a9", "Satış Görüntüleme Yetkisi", "Sale.Read", "SALE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bd54aa4d-fd32-4f63-ba1b-eb340c3249b1", "Satış Güncelleme Yetkisi", "Sale.Update", "SALE.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bd334467-ec5b-4ac0-b8c5-9e48299941aa", "Satış Silme Yetkisi", "Sale.Delete", "SALE.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9275a04a-a04d-4d78-8e75-cdad408c8be6", "Ürün Ekleme Yetkisi", "Product.Create", "PRODUCT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "10e5d1d4-13f8-47e1-ae88-ae5b6bd1a007", "Ürün Görüntüleme Yetkisi", "Product.Read", "PRODUCT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5e1695a0-ce9e-4614-ac93-e9dcddc37d32", "Ürün Güncelleme Yetkisi", "Product.Update", "PRODUCT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "951838ff-f3cc-4185-b05d-b6545caa6220", "Ürün Silme Yetkisi", "Product.Delete", "PRODUCT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "46043f08-faf9-4df6-af0f-3b46f2fa79ca", "Randevu Oluşturma Yetkisi", "Appointment.Create", "APPOINTMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7ddf3f0d-8df4-4eb0-8973-fab2072f1510", "Randevu Görüntüleme Yetkisi", "Appointment.Read", "APPOINTMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "60911132-2346-4b06-848f-0b5cba9cc6a6", "Randevu Güncelleme Yetkisi", "Appointment.Update", "APPOINTMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "566c1903-9997-4bab-a2dc-7f4408d2c7b6", "Randevu Silme Yetkisi", "Appointment.Delete", "APPOINTMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "84b02f72-993c-4ba8-be15-f3aa855d57a8", "Randevu Oluşturma Yetkisi", "OutPayment.Create", "OUTPAYMENT.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "caf7f31f-bdb4-4b7d-b8aa-2f7d02a39ca0", "Randevu Görüntüleme Yetkisi", "OutPayment.Read", "OUTPAYMENT.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "8ab99161-d863-4a3b-8d2e-c32dfc2106bd", "Randevu Güncelleme Yetkisi", "OutPayment.Update", "OUTPAYMENT.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "46396db9-8acc-4ae7-b1f9-f45e668013e3", "Randevu Silme Yetkisi", "OutPayment.Delete", "OUTPAYMENT.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "bb138ec2-9932-40d4-b9ca-54b01561243d", "Dış Ödeme Detayı Oluşturma Yetkisi", "OutPaymentDetail.Create", "OUTPAYMENTDETAIL.CREATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "7215b132-544a-4612-96e8-f3bc757e9b52", "Dış Ödeme Detayı Görüntüleme Yetkisi", "OutPaymentDetail.Read", "OUTPAYMENTDETAIL.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "e9e55ed9-ad06-4e86-992e-7de2898d5a8b", "Dış Ödeme Detayı Güncelleme Yetkisi", "OutPaymentDetail.Update", "OUTPAYMENTDETAIL.UPDATE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "00e302ee-fb5e-420b-86b7-f0524091d33c", "Dış Ödeme Detayı Silme Yetkisi", "OutPaymentDetail.Delete", "OUTPAYMENTDETAIL.DELETE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 2, "e51a1ce8-7b72-406c-b097-daf8d8868573", "Geliştiriciye Mesajlar Programı Görüntüleme", "EmployeeProgram.Read", "EMPLOYEEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6de44a8b-5c19-4a0f-b495-4c4621076a82", "Randevular Programı Görüntüleme", "InstitutionalProgram.Read", "INSTITUTIONALPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3a643eab-991d-4409-9356-ce343c69add1", "Hastalar Programı Görüntüleme", "CustomerProgram.Read", "CUSTOMERPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "fbbe7592-f9c4-4ab0-8241-8d35f5ae0f6e", "Referanslar Programı Görüntüleme", "PaymentProgram.Read", "PAYMENTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a703cd58-e476-4dbf-a0ae-4e6e406e4377", "Ürünler Programı Görüntüleme", "ProductProgram.Read", "PRODUCTPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "de0b5b4d-af59-463e-9d8c-1c2e3822fbb6", "Roller Programı Görüntüleme", "MarketingProgram.Read", "MARKETINGPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5d1fcb72-b90c-4225-b69a-a4fd6b2d741c", "Satışlar Programı Görüntüleme", "AgendaProgram.Read", "AGENDAPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "cce9cc73-4d36-4825-b23d-6271fde586d4", "Stok Programı Görüntüleme", "FinanceProgram.Read", "FINANCEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AccessLevel", "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { 1, "048403e8-5703-4c21-9800-da46de93a09d", "Anasayfa Görüntüleme Yetkisi", "HomeProgram.Read", "HOMEPROGRAM.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "66ddf3a5-5141-4f94-8cfc-9b47e4f4dd49", "Stok Modülü Görüntüleme", "StockModule.Read", "StockModule.Read" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "39d81014-30fb-4c52-b35e-5e11693c4326", "Personel Tipleri Modülü Görüntüleme", "EmployeeTypeModule.Read", "EMPLOYEETYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "a27acbe4-d0da-4a75-b1a8-b27ee4e16e4e", "Personeller Modülü Görüntüleme", "EmployeeModule.Read", "EMPLOYEEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "c815c202-0995-4a2e-807e-c05a141c50f0", "Kullanıcılar Modülü Görüntüleme", "UserModule.Read", "USERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "266a1e16-9b3b-4d0c-84f8-b4d099a67e4e", "Hastalar Modülü Görüntüleme", "CustomerModule.Read", "CUSTOMERMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "21cd38b6-0f55-43a9-abd6-768d36827010", "HAsta Tipleri Modülü Görüntüleme", "CustomerTypeModule.Read", "CUSTOMERTYPEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9e415996-7603-4070-94bb-46bf1c85eca8", "Ürünler Modülü Yetkisi", "ProductModule.Read", "PRODUCTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "9ec4570d-4512-499f-bd34-da18d90edc8e", "Ürün Grupları Modülü Yetkisi", "ProductGroupModule.Read", "PRODUCTGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5f8d3303-eac0-4a63-88b3-5db9522bd06b", "Ürün Alt Grupları Modülü Yetkisi", "ProductSubGroupModule.Read", "PRODUCTSUBGROUPMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "f5bb19b2-5d85-4b07-b433-4142317997dc", "Geliştiriciye Mesajlar Modülü Yetkisi", "BrandModule.Read", "BRANDMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "6d194fbb-54d5-452e-a17b-98af6c4d124f", "Hasta Referanları Modülü Yetkisi", "CustomerReferanceModule.Read", "CUSTOMERREFERANCEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "4877885f-b438-4929-91c5-061c86dddfc5", "Randevular Modülü Yetkisi", "AppointmentModule.Read", "APPOINTMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "43540aac-67d4-4596-91cb-76be5b2030a4", "Bildirimler Modülü Yetkisi", "NotificationModule.Read", "NOTIFICATIONMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "136e1a5c-e82f-4681-84b1-b0c024a4b62f", "Dış Ödemeler Modülü Yetkisi", "OutPaymentModule.Read", "OUTPAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "ca8cbb80-2158-4ba4-9e09-cfc14bbb22df", "Satışlar Modülü Yetkisi", "SaleModule.Read", "SALEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "5f5b4a6d-ab5d-4ba1-92da-f789e7eae8a1", "Gelen Ödemeler Modülü Yetkisi", "PaymentModule.Read", "PAYMENTMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "3ce98508-3c3e-48b6-8f1b-990e58c6be07", "Gelir Giderler Modülü Yetkisi", "ExpenseModule.Read", "EXPENSEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ConcurrencyStamp", "Definition", "Name", "NormalizedName" },
                values: new object[] { "987101c2-bf87-43d6-a3a8-3cc761e65e62", "Roller Modülü Yetkisi", "RoleModule.Read", "ROLEMODULE.READ" });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 8, 22, 21, 12, 7, 906, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6968), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5985), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 8, 22, 21, 12, 7, 893, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9472), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9480), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9488), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9503), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9511), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9515), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9519), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9523), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9538), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9558), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9569), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9585), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9589), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9593), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9597), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9601), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9605), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9613), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9616), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9628), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9632), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9636), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9651), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9609), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 8, 22, 21, 12, 7, 907, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "510e8b10-fc68-4a0a-aeec-e18dc8a651bd", "AQAAAAEAACcQAAAAEA1ZGOL8HuvC1TBD4dvWrzF71z7MGL9jLzikYi9qfqLAy68hCNv4fwGGWx9wOlBy0A==", "65dad135-7b90-42da-b35c-7d683ef4e1ca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c0e94fb-185a-4b3a-97f1-a4ddd8ac3548", "AQAAAAEAACcQAAAAEAvL2Jyo8aLBbpUOOfX/j2RUPnPW6x/IJMlPAzrT+MZe8SoLm9yRh9ueFxo9r37bZA==", "52db7f0c-b2d1-4187-914a-ac68f7a18e3d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e05b56e-bc0b-4492-bd7b-cb8fec8b93e3", "AQAAAAEAACcQAAAAEA6MCqHHXzoSq8vHPfzaRNT1aUiQ643WBccrloqnHYHJ+JeXOdb0qkIKm5cj3uhVMA==", "428d9376-7bd0-4b22-858a-10d6f1f746db" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb4613f-e644-47e4-a5cb-2b1051501472", "AQAAAAEAACcQAAAAEB3lns6IiKDHjZI5DgOw9Q1Y4wMY4j09oVInfrhYOlYIeWaAtHh/XSW9kO3eHd1YOw==", "fa2e0bce-76e9-4a66-a448-5b660aea4102" });
        }
    }
}
