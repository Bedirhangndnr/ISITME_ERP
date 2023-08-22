using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class updateRequiredvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaleStatuses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppointmentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                column: "ConcurrencyStamp",
                value: "edc8af7b-12dc-4c23-a16a-3a6a4188d6dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c5d7fc9c-bfa9-4e79-a06e-680490de3883");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6d637c5a-3eda-49f0-a016-221e30ff3226");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8bf453a6-a2a5-4cfc-985f-af136a520880");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "e8ed877b-f96f-4071-85e4-1f0a0b1312b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "4329b78d-01dc-46ff-9f7d-985a09717a1b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "65f36d59-77bf-4351-926f-067f29f31393");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "c935e323-8c34-4491-a583-cc7e16687461");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "78344b56-3869-4f47-8000-bfac9e1a40ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "018f1645-3cd2-4c34-a151-9a82ab3bad4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "85f755e4-1676-4973-a36e-468ae4e911d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "9ee64833-089a-4a49-8294-b1a5afcca207");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "3f23b222-f750-458d-aae1-7708f8fc8370");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "2691cd0a-82b9-4ebd-9cb9-e4bde5ec193c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "61bee589-d290-41be-924a-f503eef55833");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "61015093-73c9-4869-b83e-9cc33c25333f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "34d89093-c6e3-445f-96b7-65f8097b0791");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "43c0d8a2-46bf-4e5c-8de9-eba2988ee6c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "66f6fe7b-4f44-43c5-8e87-adb33c542556");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "2d4f02f1-0562-4e1e-bdfc-1afb50db6dcf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "2a3e5a06-f4be-4986-ba68-08afbf60c595");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "c76c3478-48d0-4e93-90d4-959127239b47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "af4f8709-4f6b-4c70-aaa7-6b341111da80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "4de76327-7572-4bfd-9bc8-0b60e57a11db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "d8fc1d42-99e2-4d5e-ac1d-9a4a003c87b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1facfda6-809c-47ac-844a-d524bd64a292");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "5d7149aa-1374-4c37-aef6-637e42901726");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "84c0c874-bc32-418f-b736-fb4c5e52bb59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "a9f518a5-b020-48fc-80e0-19a2095a4547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "7083dd45-0757-4e0a-9785-bf8ab9f30e12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "1407aa27-9beb-4077-ac58-e5e93d14c562");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "1fd56891-046d-483b-9530-17519bc1eaa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "9a8e6787-c4c5-44a1-a923-5309603bee86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "a8b7129f-5182-46f2-bf91-a709a6164f76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "40df1694-17f4-410f-8b6f-668700508928");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "5e9601ad-d2e4-460b-9b4b-af792c290346");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "c2e0165b-419d-49d6-8ba0-bb5395ef00a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "5545a5fd-30fa-4f29-8c38-3625ff0e0c78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "efdda925-29ca-4582-9a64-498260b00fe0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "3ecebe19-3460-4cf8-a4e1-9ea100f7ec78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "2ba0bf82-910c-45e9-9ccc-65f402ee1eed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "2c46c158-5dc2-4bd8-8420-2f0184bc5c5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "b6d3cdd8-6b73-4a0b-8019-6473af765d3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "46d299e4-da77-4e5b-8542-0fcd7bcc9a6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "0ae92075-7140-4031-9d51-e3dba9429f44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "1367ec09-d459-43c2-83b1-a5e2ff139ea0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "c79541c5-1343-446d-9e38-e98a4a21c064");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "d3d87362-ffa3-473a-9df5-13fdb639f341");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "a6a81c79-e311-4784-8f2b-e5b0f40d321b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "e4ed8eb0-b655-47c1-8d17-8855606205f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "a773350f-ed33-40d4-97d2-2c2f05d50bbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "879451d8-e74f-4783-8212-5136f1877de3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "fec16fe1-2f7d-46dd-89fd-498eb69d1242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "3abe4ebf-9bee-4b61-9c6e-50774df0b9e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "b9724c05-3247-493b-96e6-4a2e4bcf5ae0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "6d9dba35-8004-44a6-aab0-3698d5d9b7d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "51ebb652-eb6f-4ae1-855e-bd7fbfec17f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "bcfe4bbf-cea8-41df-8996-25daba6db227");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "8aac43dd-7bfe-4165-9561-4088d6f0bdf8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "d2155d0a-d564-4237-b975-9d8b063e0cee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "a13a15e2-af0f-41a6-bd50-f02da2542466");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "86d583d2-94f7-4f98-a952-e669d94675a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "bd54aa4d-fd32-4f63-ba1b-eb340c3249b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "bd334467-ec5b-4ac0-b8c5-9e48299941aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "9275a04a-a04d-4d78-8e75-cdad408c8be6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "10e5d1d4-13f8-47e1-ae88-ae5b6bd1a007");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "5e1695a0-ce9e-4614-ac93-e9dcddc37d32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "951838ff-f3cc-4185-b05d-b6545caa6220");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "46043f08-faf9-4df6-af0f-3b46f2fa79ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "7ddf3f0d-8df4-4eb0-8973-fab2072f1510");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "60911132-2346-4b06-848f-0b5cba9cc6a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "566c1903-9997-4bab-a2dc-7f4408d2c7b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "84b02f72-993c-4ba8-be15-f3aa855d57a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "caf7f31f-bdb4-4b7d-b8aa-2f7d02a39ca0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "8ab99161-d863-4a3b-8d2e-c32dfc2106bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "46396db9-8acc-4ae7-b1f9-f45e668013e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "bb138ec2-9932-40d4-b9ca-54b01561243d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "7215b132-544a-4612-96e8-f3bc757e9b52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "e9e55ed9-ad06-4e86-992e-7de2898d5a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "00e302ee-fb5e-420b-86b7-f0524091d33c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "e51a1ce8-7b72-406c-b097-daf8d8868573");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "6de44a8b-5c19-4a0f-b495-4c4621076a82");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "3a643eab-991d-4409-9356-ce343c69add1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "fbbe7592-f9c4-4ab0-8241-8d35f5ae0f6e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "a703cd58-e476-4dbf-a0ae-4e6e406e4377");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "de0b5b4d-af59-463e-9d8c-1c2e3822fbb6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "5d1fcb72-b90c-4225-b69a-a4fd6b2d741c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "cce9cc73-4d36-4825-b23d-6271fde586d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "048403e8-5703-4c21-9800-da46de93a09d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "66ddf3a5-5141-4f94-8cfc-9b47e4f4dd49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "39d81014-30fb-4c52-b35e-5e11693c4326");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "a27acbe4-d0da-4a75-b1a8-b27ee4e16e4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "c815c202-0995-4a2e-807e-c05a141c50f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "266a1e16-9b3b-4d0c-84f8-b4d099a67e4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "21cd38b6-0f55-43a9-abd6-768d36827010");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "9e415996-7603-4070-94bb-46bf1c85eca8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "9ec4570d-4512-499f-bd34-da18d90edc8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "5f8d3303-eac0-4a63-88b3-5db9522bd06b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "f5bb19b2-5d85-4b07-b433-4142317997dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "6d194fbb-54d5-452e-a17b-98af6c4d124f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "4877885f-b438-4929-91c5-061c86dddfc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "43540aac-67d4-4596-91cb-76be5b2030a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "136e1a5c-e82f-4681-84b1-b0c024a4b62f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "ca8cbb80-2158-4ba4-9e09-cfc14bbb22df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "5f5b4a6d-ab5d-4ba1-92da-f789e7eae8a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "3ce98508-3c3e-48b6-8f1b-990e58c6be07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "987101c2-bf87-43d6-a3a8-3cc761e65e62");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaleStatuses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppointmentTypes",
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079c5933-f6d0-402a-a90a-079804be1f6b", "AQAAAAEAACcQAAAAEGpjfNqnaImEH7X2p2xu/AoRytfWVwJFDIhrqzG6kBh1UqTA+0wMmbcbWNnXB8XGSw==", "a2aac303-02b9-4292-b0e2-d069066d43fe" });
        }
    }
}
