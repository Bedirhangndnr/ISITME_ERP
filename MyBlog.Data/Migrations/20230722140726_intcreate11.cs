using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class intcreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(2585), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6700), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9745), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9771), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 7, 22, 17, 7, 24, 869, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2072), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2076), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(872), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(878), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(884), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7925), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6124), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6122), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6134), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 30, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 1, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(971), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(979), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(800), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(804), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(807), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2233), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2267), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9948), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 7, 25, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 7, 24, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 7, 23, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9392), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9397), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9400), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9403), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9406), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7724), new DateTime(2023, 7, 26, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 7, 26, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9529), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 7, 22, 17, 7, 24, 879, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 7, 22, 17, 7, 24, 870, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 7, 22, 17, 7, 24, 880, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(955), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(689), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(697), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(713), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(716), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1f20915e-968e-4778-89aa-656826a219b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "565227f4-760e-4316-999f-a8fc8b14086c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "08aa5e70-0e45-447f-b66d-52256aa75dbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "1576694f-8043-4a54-9163-0501abe11442");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "87c2b84f-b6b6-4ac2-a7a8-b3c43f38930c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "155536bd-6238-46bc-a024-4e18a873cac3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "0c41df22-2643-4eaf-971b-038d4431fb6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "1d731e88-ff45-43a1-a97b-f15d9ce691aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "6321a858-0259-4490-b2de-9646ad2040b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "46f56073-b7c9-4329-936b-4b84c27e4ef8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "924b0f5a-1e6c-4869-b83f-a81fd671314e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d1ab5055-b54b-4a6d-9dcd-815ec9e27b1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "4a26e643-db9b-4174-8996-7f4b24a5a131");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "640b8782-675c-425c-8665-3bb9f63ff696");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "fea94ff8-253e-4adb-af92-6e6edeeabf0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "e5a76647-7685-4036-93b0-e0931cb6b0d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "59ffcc19-2665-43b1-8f66-196b05d998e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "fcd40237-50cc-4a3a-a173-18985659bdb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "c8bb6c07-119e-4b0d-9f57-cc7606bccc1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "cc041ec1-f1aa-4123-9249-1e7841080261");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9746bd29-9303-41b9-b9aa-9d9ef71ebb95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7dc90d28-2a68-4e73-8188-9502c2bc1eb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "8de56e15-aa47-439a-a248-5df500cf72b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "4fe6fe53-9074-4d98-9ec6-9b6d805e31f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "c98e9d3d-9460-41ea-b1cf-4cd3e46911ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "d128ee45-df52-4a82-8d39-8c25f8606002");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "53d46116-ae78-497e-911b-6345f14769a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "7f7caade-9a05-49fa-9c30-11dab0fac739");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "f561ec63-06b6-4902-bd6c-895b02dac4f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "741a0e36-6818-414f-ba0c-1bbc4e5b1cd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "454bb700-b6b4-46ac-9fcb-4727c72f0618");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "7152106d-0c05-410d-a383-b1ed2ea8c148");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "8540f1bf-626f-4ece-af16-a3a5d3c55e63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "dbc70826-a721-4cef-8aee-f7176d39750f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "4512fbc7-4135-4a6d-a2dd-78d411e33211");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "eca8886e-76f0-4cf6-9423-2976960f7780");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "36529f63-11ba-4ca2-b14b-de7d4b01d724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "7413ae32-83ad-4e34-8f18-4ed4abca0c64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "639d7ec4-0582-488e-a115-5fabd799cd50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "a864732a-8b77-4ff0-91aa-a8ba0a9f6819");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "3481e323-8d36-46de-af49-dbe0184abdce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "d02445ee-9c6a-433c-b1e5-e1b86059cefa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "b3b48f2d-9baa-486d-bee6-49dc9f864a27");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "5b7d0b8e-5324-4968-ac01-4245984034ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "5c51ffa3-cd3e-4b04-8a51-43bbb4564614");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "ee59af84-626b-4afc-a4f0-44c062237448");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "b9125adf-418b-4157-8c14-27b2a55fc098");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "215ff822-4351-499f-a164-78bda86cfc2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "66ef5558-f246-438d-b639-68efd2db2945");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "fa02b7e0-5918-42d6-b7c3-01633b76bd9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "36385dd5-9cf7-4d17-96aa-b07228534e22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "25a108a5-41e7-421e-95b0-8bc6151ed7cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "c4cca521-c92d-4058-92a9-a47b350b48fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "fdd37efa-503f-4e88-a264-e22740cf572f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "128105dc-11bd-4a3d-a759-6d968552fca8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "d3836470-3696-48a5-b2bf-394723c99772");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "efeb0ccc-406a-48c9-a4e8-a2da95701a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "1101e229-ff9f-4607-9ee0-8783c875c5a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "88177a5e-6fb8-475d-a6b8-6be072f785ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "42fb20e9-3833-49df-8268-5fc5d9e6dcdc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "da4df418-60b9-4021-ad98-f40eea6d7fcd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "5f35177b-57e3-4f22-9f76-3f05d20b1093");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "e92bf1e1-2c8b-4226-92f1-64fcf2cf80bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "9051261b-6eb0-4be4-997f-8d6338fe6512");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "3d82e795-9099-402f-98b9-cec4fda0ca04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "d6fb6859-8c90-4d78-a5aa-3a921080fea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "3b1ce816-410c-4761-b033-935dae0ac172");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "8e2f14a6-02f5-48cc-bd4b-15806abc5bde");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "44e3333c-d024-411b-b10f-d407e3054619");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "9a544bf8-f196-4d88-8d58-7d642d5dc73b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "d0eb5b17-046e-4a4c-a811-458057fa9bb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "6fc97ccc-bb0e-48c1-8649-56d90f7a0622");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "655661e5-ccd4-4fa9-b951-19c204776cb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "5678524b-fa03-4c5c-a9e1-f444081bd339");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "a86093bd-9c33-4043-b41c-bf32b0c68de3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "a2da5494-aef2-45ff-801b-1abbda10c5c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "2d2140d3-b2ec-4569-a440-8288edc84d42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "8549c43c-331c-46fe-b087-4c1a4787aa2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "e61c5de3-5379-4284-a28b-7b415d878075");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "4ae1fe7a-af10-487b-81d3-424022872ba8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "26e46ab5-fad6-4372-ac8d-74d8bb834b3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "ffa05c3e-80cf-41cc-852d-3e512a13c9d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "b9229e12-cf47-4cb5-887d-6d6526901ea5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "edf3a8fb-f651-474c-ba94-f2603c12a24f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "0499c3ff-85e7-440b-b95d-2ffdb9298b80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "3039025a-3995-4115-9a79-6d7ad45a7172");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ff316b57-9dee-4aeb-a15e-f12f0f9d3ac6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "5c5a58da-6a3b-40bd-a1ea-98438bd0e9bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "f21b3a23-53b6-4adc-808a-7fc552ff37fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "af084a11-664b-46e8-86d6-b0001b24ed80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "4e76b533-f336-424e-8f4b-d28515069bd4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "bc297873-7d7e-4c7d-9db7-a4c66674a251");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "2dac70a3-c28f-4a06-ab2d-0722fd67814f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "a3c48e09-dccc-4507-9226-cfeda2dcb146");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "de76a253-8d5a-43c0-a721-81ee2e18acf9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "6eadc1f4-869a-4ff7-b298-df1beaadfba7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "e36becb5-8aac-45be-a9ef-d2fea31d39ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "bf0cd5f4-1c4e-4dcf-9e82-47efb677d49d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "0041aab2-37cf-4cd2-9c46-60c158226430");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "62e860fb-1f4f-437d-958d-2d7d70be3031");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "a115cf19-68fe-40b9-ac22-08e89fc57786");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "b01e69f8-6f8b-43cf-8522-c19c9796a706");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "9c84c1f2-740c-4f52-9195-09e75f643367");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "bde551ef-16e4-467d-903f-82e99922c3d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "aa721430-e9ae-44f5-9de9-b23b992635a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1437b7a3-e7d5-4071-ad16-47799ae417d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "5924f92e-19f5-48f5-86e5-4a3da01554c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "e2ff4508-065e-4fb9-82ca-9d83fa59c99a");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 7, 22, 17, 7, 24, 881, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 7, 22, 17, 7, 24, 871, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1629), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1631), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1640), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1643), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1649), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1654), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1657), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1666), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1671), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1733), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1742), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1753), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1762), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1767), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1770), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1773), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1787), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1790), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1793), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1798), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1801), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1807), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1818), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1821), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1784), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1846), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1860), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1865), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1874), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 7, 22, 17, 7, 24, 882, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7365543d-068a-4b6a-abde-f3b67a76db79", "AQAAAAEAACcQAAAAEGaxEUW71NZyJVT9yMlQ7lG2qiHCox054hvYiRAg6fQRp68lLBCqrL09qKfz+N+hOg==", "cad91995-2ae1-455c-bb7b-b7d3f65c015a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f9f131-9605-4db1-9646-d3c7e891d6f0", "AQAAAAEAACcQAAAAEPUi3OmLofNeMyK70bwvFiAXbfsD/p8n5QD7CxQutfPNXEig2c3KOpGAMsciLRq2ow==", "7e861032-2042-4603-b2a6-28eb2ce41967" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c8eb8d8-812f-4b0f-9075-1176bd640119", "d48d5a32-8e14-428d-b9c8-3bd7460563f0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
