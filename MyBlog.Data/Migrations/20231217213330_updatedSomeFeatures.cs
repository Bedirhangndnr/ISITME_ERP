using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class updatedSomeFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HospitalOfReport",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 306, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 12, 18, 0, 33, 27, 306, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 257, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 12, 18, 0, 33, 27, 257, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3142), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 12, 18, 0, 33, 27, 251, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7681), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1848), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1860), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9205), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9223), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9233), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 12, 18, 0, 33, 27, 252, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 254, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 12, 18, 0, 33, 27, 254, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 33, 27, 254, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 12, 18, 0, 33, 27, 254, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 12, 18, 0, 33, 27, 254, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 12, 23, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 12, 23, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 12, 21, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 12, 18, 0, 33, 27, 316, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7244), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7249), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7255), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 12, 21, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(149), new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 12, 20, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 12, 19, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 303, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 22, 0, 33, 27, 303, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 12, 18, 0, 33, 27, 303, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1218), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 12, 18, 0, 33, 27, 304, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 303, DateTimeKind.Local).AddTicks(1272), new DateTime(2023, 12, 18, 0, 33, 27, 303, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 12, 18, 0, 33, 27, 255, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 12, 18, 0, 33, 27, 308, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 309, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 12, 18, 0, 33, 27, 309, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1530), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1556), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ff03acbf-e8c9-42f2-9628-dc8d79c94237");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6d70b059-417f-40d5-8a7d-9165805e2253");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e50c3bcc-7aa2-4bb2-b43c-efeb8c62de29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "41c49808-36b6-4862-a60d-6f5ae70db109");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "576b5187-9285-4137-804a-dd61e149e2b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "d608d4fb-6673-44e9-aec9-1d8cc407488a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "10a9f385-82dd-4fb5-b709-a57f59b8bb7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "4c035b61-441e-4d4a-8289-3571b13d80ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "20ce03e5-4246-4892-829c-9b19e5e54e93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "796e98c3-b241-4faa-892c-50ef4b8be1ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "231d76f4-bd9e-440d-abdc-12d2d23643e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "191dd6cb-c3d8-4706-af52-385948bbcc4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "5ce86a6a-d269-41ff-a10a-0c5db18a3de4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "081bb96d-9288-4fda-a314-ef059cd2759e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "ab3a3e3f-e053-4643-bfef-372c0cecf7f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "0444adeb-3afb-4ca6-b613-b019fe90a1bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "a6d7358b-6007-4c2f-ac32-4f523f566085");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "e3f8de29-66cf-4384-b77d-8da87c114066");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "88e51b51-f424-4ffc-9f2e-4088966aac89");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "208fa846-3d7d-4c66-a93d-8a27f8b57291");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "574f9e5c-e47a-442b-8aba-4bdbbf3cc5f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "3559dc6a-4588-43ca-a018-04c6cb0aee39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7d03fc86-c489-4ad2-9717-85f1d0ac1a94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "6887c385-b1e5-4086-bc0a-5609a6dfa477");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "0606c119-ef89-438b-844b-a83bd9e9f5c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "73d06286-3124-494a-82ff-2e03cc6604e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "12cc6dfb-96ba-46b9-9f56-65a1d156b686");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "3425f59e-8516-4741-8571-c16608704a6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "9224d02b-89e8-445d-8275-a37d3a09685f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "7346fc92-25f2-4b11-9c65-a50229777a64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "0e2e316f-c5bf-4e37-b058-6250ce51db6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "7396fb51-0f09-46be-b6ea-920f161836ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "835889ef-77e3-4350-9571-ec52c6c1b3b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "ebba505b-7cac-46cd-9657-f832c1bb12ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "63025a91-2ed0-41fe-a397-34780d37ec70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "1d39c1a5-01e3-412f-a27b-9f7adfb7d99c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "76c4b773-c0f1-49bf-bc3e-6175f690a225");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "90195866-2d62-4c78-9711-1206db409c4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "e780d3ec-60cb-46ca-95cd-5af5b187c44d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "8ea41c88-9a59-4443-9600-2f81274bb55e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "be53ca55-24f6-4086-9c48-6e328dc2a684");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "bd452003-acf6-4f21-87de-1d42b90ab64c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "1cfae61d-268e-491d-9b4c-3826bdc63edb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "7096fd22-054a-456d-9517-3e47644c098e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "f76a1026-60e7-4d67-9f7e-9d9d6f5b18bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "a8cfc0c0-aae0-4267-8cca-9297cd2389c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "9b64a0ba-274c-43e1-8481-8d3d9ad35e64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "bc2629a8-cf4a-4e3b-a0c3-aa0343085ddd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "11f05204-1219-4407-a8cf-f866756220fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "ab0aacde-0a5a-4874-b34d-8e3ef6fc1c2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "aae5ec2b-b0b8-40f1-99db-93521487d9ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "bd106e37-1b9e-4a52-9dd5-42336e7f1bd1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "0604f625-57bc-49f5-8de6-5eacec068547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "3bd05f0b-51f8-486f-9711-d5e24607fa64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "07a65fad-4917-4204-b908-3694df72e624");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "2e368514-21d2-44bf-a6bb-51fc7f19a485");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "9ee54f34-6502-4f7c-9589-8a56a87b2281");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "67a74bb1-a0fd-4ec2-a2d0-bff7c1d58c29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "87729d41-d6b2-4909-b974-fc27f3fb38b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "81f61a1b-20b3-4eed-a163-05baa5646432");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "13dca821-f035-44f7-8385-390c3ff1f894");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "5e120351-a58f-44a3-b430-ecf75bc76576");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "5bc5a25b-c46c-4901-bac8-30ace21dfd1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "55d4ae7c-9ea2-42b6-8291-a60c29b146b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "336c8f63-e736-4b66-882d-be99119f5657");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "7ea05545-76e0-41e0-9bec-e89c1cdc0e5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "998fb20c-d5f0-4ab8-8741-1b2c2c8370ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "f4f6fbd3-9fe1-40aa-bfca-677c4a9f34bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "24861ecb-dabc-44c1-aac0-c4016ba046a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "33d54c17-4a20-4c13-96e8-8f3410f84cc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "a51f09ca-53f2-4771-833a-ea07690c7fed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "6f6ff56c-0913-469f-a0ae-ab83c9e78813");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "7ab4a454-dc9c-4630-b014-7db2960a8ebc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "89b1a736-b91a-4e5b-bc19-b779af700cae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "1b132ed7-6f13-4a61-9874-0719fba98507");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "a00a91db-7813-44b9-841c-0105c1388db1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "375136f8-e278-4672-8ac4-d7048cc8f81f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "931162b0-93cd-493d-a571-41823043777b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "163ac262-18ab-4b90-a461-7557c6f6ce7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "5ee81d26-fe25-42c0-acf6-b995960a983d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "5b933b4f-f867-4dae-86e0-a72f7c4b483a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "a90fc853-6171-47a5-95e2-b2d18f00ed15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "c53f2903-060c-45c4-8dcb-8ca8ee811887");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "5af06cca-cb49-4f64-929b-5cbe64694bbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "2171ed36-3f88-4c05-87b7-c3cb8de316e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "1c43ea80-1904-40e1-8984-83d4c94c8d74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "b5e7635c-2b1e-484e-b7e7-3eee4644a24b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "007fd8f0-d337-4e8f-9253-b52489858439");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "ed64d519-95ae-4bc0-bd90-9955ace62574");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "6b2956e9-ca42-497c-9a34-7853c2f6ba0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "c02d761c-52b0-4be8-82ba-c4122fbf7b8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "4b17d0c1-1ffa-44b4-861c-0603afda3e91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "4a62d1de-e742-4234-af0c-ca46495dd084");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "6a587ccd-f31e-4c8b-a71b-eb0f18b0903c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "80f5b24f-f958-4e9c-8bb7-d3cd6f5083c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "658ec20d-ee18-481d-92c2-4b25e48ff760");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "c63c8206-57c2-4161-ae05-69b9a8cfa52a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "7d80abfb-0102-4ed2-92d0-0e9eb5af90a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "1f9125d5-d0c9-4fa0-875a-1c8cc3b7723a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "ce9d4da1-2aea-46f2-983d-3186c5e70a5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "a40195ff-7b10-4ef2-8f7a-bf9c1e3d75f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8255cf12-4196-4781-80e1-9c27a3f6dcd6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "cf823795-0ffb-4e4d-9d2f-2a1769f1da64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "30a8478e-c2f2-43ff-84da-8c1db07a65db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "f7d722b2-ee99-472f-aa4a-b2b63be31764");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "25785636-d938-425b-90ee-7fde9a865d71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "30c9fd00-92eb-42f3-8586-322f034b625e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "969fba57-185d-4f80-b0fe-91f3adcfa9fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "d5c92ac0-cf07-489b-b16d-fdcf5795b1be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "1848f580-33e9-4a15-af8b-a3d3cd991ab2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "1875dafc-b066-4b1d-ac03-f9f7d9603a36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "61ba1a2a-cb3b-4e8e-b215-ca4f537a2f4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "9e092b5c-90ac-4cbb-9c41-c8667802e69d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "799cfea2-46b1-4d2b-a735-6a0ba3bba22f");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 309, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 12, 18, 0, 33, 27, 309, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 12, 18, 0, 33, 27, 313, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5485), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5501), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5675), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5743), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5779), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5842), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5937), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5952), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5978), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5992), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 12, 18, 0, 33, 27, 315, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb95f861-0997-4e42-95e4-f7a3377afad4", "AQAAAAEAACcQAAAAEDGdn4joUZGNle3szkwd1MP4JtFbZmWxQ4vSL4jWBUUM3YdS4q7KE7mUAyNVFHVRJA==", "28f5e122-bb63-4013-b62d-4b20c7a76a6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdb20ea7-8cd8-45eb-a35d-56f9128a940e", "AQAAAAEAACcQAAAAEK4Zc1pwHRwKlvb7yZE5kh5f4VA+IyfOgq9qEVNa4WSeNLZMWKnSmvRZ0Px9x3m0FA==", "f03c0bd9-0401-4f63-9633-7f56188b295e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e513ff-e4ef-4054-bb6b-fe79f60e1561", "AQAAAAEAACcQAAAAEMgUJpBzurbCM5wdvvi0CHtGXcfwvSDGxhY0xvhqGRONUgp9SjFjy3rEXQup3T0CLA==", "3d50258a-9c58-4f13-90fa-dad52d40dde9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7c65184-5d58-4d8d-ac51-d015f36bed98", "AQAAAAEAACcQAAAAEHmzOwTmUZQRXb5GEKExybWlesOC2m/ekb2u17zHpCROHXoQgJ2k8dXfXQ2z7Vuirg==", "83af6263-c72a-44cd-afc8-6e143bdea382" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a1ebe7-e415-4c33-bb80-f9c78146568f", "AQAAAAEAACcQAAAAENhMHNO9QK82Qsy5p3uW27H3+GV/A9hBKhvbcSLPiY7IyDjeVDgsNjIGdEOTkDeVfw==", "56c2fb08-ab0f-400e-9d07-45f5bc461960" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05bdf018-c1db-4f5c-9866-78835fdf6ecd", "AQAAAAEAACcQAAAAEIeWIANz9Aq8FL0BSNAw5w3Ary7//gdk852WMVhdllgfi4lIfzmnEAIKkT5yxhJykA==", "3614567e-0a90-4048-a3ae-db981bd970b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc17c4be-e6a3-48c4-a375-851a6529a486", "AQAAAAEAACcQAAAAEIPoGfYk9VmaEf0BGPdhc/ZIItBD5DyCnNm2/HCrkLyrsFKP2IfAjo5YYvVXyqG2cA==", "fbd6b2b8-dfca-4743-93fb-19986c2c129c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7b1fcc-5dc1-423a-bf0f-74bf4e0a8b40", "AQAAAAEAACcQAAAAEI8IokKT+RJvJXtRnQR4tXEisaB6UXzyNz6NSCTuqPcP29PtgiW2YdFUHO9Y8s+Eqw==", "d645381a-2b82-45e1-855c-d533c8dda53b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d825485-3799-4405-a1fa-8a0e724d01e3", "AQAAAAEAACcQAAAAEC2gHaq+u1uHDA31AV7+9bbYM57qOmopfnbM5raBL88b6WLbTv9/eHO6aOdChvBTxA==", "8349837e-29ea-42be-bc13-2672bdd1c9b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HospitalOfReport",
                table: "Customers",
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
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 717, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 12, 17, 23, 17, 50, 717, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(948), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(959), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(957), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(965), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(970), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(975), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(980), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(985), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(992), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(996), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(1002), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2046), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2055), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3407), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(7084), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(8487), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(9208), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 21, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 12, 17, 23, 17, 50, 715, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(7844), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2632), new DateTime(2023, 12, 22, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2635), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 12, 22, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 12, 20, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 12, 20, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 12, 19, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 12, 18, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(965), new DateTime(2023, 12, 21, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(979), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3105), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 12, 17, 23, 17, 50, 740, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 739, DateTimeKind.Local).AddTicks(9586), new DateTime(2023, 12, 17, 23, 17, 50, 739, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 716, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 12, 17, 23, 17, 50, 716, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(661), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(670), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(678), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(686), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(697), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "60c19a6d-8275-44b2-895b-c1ff72653ee1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8431b092-9a0e-465e-8d01-809b12391d27");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2cc5b961-b8bc-402e-801d-ae132cd1d6cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c2c385d4-8cff-45b9-9176-cfe523b961c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "70141d58-d68d-4b77-a2a7-2d88c7a50336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "10f15581-138e-402b-b16a-487b8c4e2ba7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "bd1f7514-05e8-46c2-af6d-97fcd99210f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "8789f134-5440-4a21-97ae-c53643dfbdd6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "3ed0a87c-d7a8-4d0b-ae31-f2d1931072d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f2542784-8696-4c3a-a440-0ca39e0896d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "badd8fb4-e9f8-4b7c-aacd-55c75963f555");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "a92df020-0f40-4a34-9b9f-196820786c70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "862a5bbb-9e21-473c-9603-61b616e56110");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "90d05cc4-ab25-40dd-ab89-9ce6365d7d4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "5d239f0d-4b12-4db5-8c91-321e42033b92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "a2315837-cac1-4570-b52d-0612b822409f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "d8ca1bc4-bec0-43bd-9095-b2659d88f0ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "1d295f24-7149-4566-89aa-e37da511d8be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "7645b789-ce66-4173-b751-fb385c73cd0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "b8987fb0-bf96-437f-9f64-2bc290e9d4ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "335f22d2-0a6a-4f12-812d-51759b67b5fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "d7a6e011-96ec-4aae-8322-9aec6159c065");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "2889f4ae-13df-42e7-9106-cb74b544d42b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "cd0fe7b6-1c64-4c4e-a893-28228bba5940");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "dc0bd465-fbe1-4231-b842-e87c351d6165");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "e9a327b5-668f-4354-bf5e-2aa7ea1a3dc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "34c77453-35ef-459c-aeb9-477595d34c3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "2d9646b5-c3c2-4e3e-82f1-48c415a33895");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "c0e05a14-e7fe-4f47-b377-137ce1638772");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "97d915f6-3fa5-4266-82b5-9a9099b6a112");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "a6f090c6-e619-4789-8c0e-cf1ea709c299");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "48ad447d-6b1f-4421-b494-c7246ad2af06");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "2f1db735-ac57-442d-b9de-570615320ab1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "846fee40-34a1-4d78-b9f1-0ad80c761bb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "122a3e46-a546-4283-bd09-bb955535a13a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "89c5160e-46fd-4499-9e03-45415657d921");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "6e811b96-b791-45d6-8e23-aabe98fba8f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "45a5b240-d637-4b76-ad53-b2e7b8cc37da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "c9234abb-fa20-455f-b1bb-a4b07db9033f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "59b7b1c0-6764-46de-8dea-6f1c0b019813");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "d768bdb9-f558-425c-9ca0-9f8a608b5332");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f05718dc-bac5-45ce-b17a-2d480f72f56b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "fecac650-5e86-456e-8dfa-d51909853ac6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "8e4ae45a-adab-4b9f-84a6-6789a87702ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "d4381501-25fd-4e41-ac36-54258cd4e2cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "ea65c728-39ce-42dc-8621-c16846a564aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "9c7c5b68-b441-45f5-b7aa-c35256d6134e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "56e33098-e744-492e-a6ba-556cbd84c1d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "829dc8aa-bcbc-459d-a006-ec2d6378d37b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "ac1623f1-8088-4c7d-8ac7-00deb36af80f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "8bae0c55-aa75-4add-b185-dc88e79f8db3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "d3624da4-e13a-4711-947c-d17764f8e2f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "c99373d3-a6e7-4a75-9d2a-500ec72ea19c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f59554d0-942d-445b-9dbd-20c6e951fb9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "4a44b982-068b-4f91-9afd-ac2a918f65a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "2f1ea3ef-9eee-462a-8aab-b17cfd8527bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "9177a751-0276-440b-8232-ed5729248e62");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "6698e219-c13e-42c4-828f-d8bc4370f727");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "5e665c51-fdfc-4113-9aef-fdaaae0eb9d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "19241f72-9aef-4f30-92cc-3e5141694b0e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "b1ad8c33-b79a-4327-bb1d-489dc1313f9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "4ee772f0-19fe-4e38-9f66-a180715f4879");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "6ff1adf4-f714-40bb-85c5-1d3d27eb7b8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "87cf1def-c1f5-4f35-8a57-8953bbd41edf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "c19857c4-c496-42ed-a0c1-c3dfd9151a24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "f3009653-3414-4007-851f-a7e5c1ee4493");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "45724b06-1268-4671-8d3f-456a9d37cbda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "ce9d2737-9dbe-42b5-b0c2-0a9e70dd5d26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "a59a86b1-9af7-4a9b-a9ac-bbbce13445a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "9f4148e3-ac20-43e7-a5ac-357c1bf4ae40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "d6315e5a-edd6-4629-a9cd-85f3939ce144");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "4ea0b8a7-892b-480c-a557-da7ea8b9816e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "faa39330-ae77-467e-b65e-ae48025ed096");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "f92b1228-365a-4901-a5f1-1c450983ac3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "357febfa-3873-448f-a224-e5f17d817d75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "b561218b-e7ee-4575-891e-2b0b4b9fdc6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "e8ab3d30-f42b-46de-809e-90d2e1c83fcd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "355cba31-8d8c-419f-bd28-a0aa91c296d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "941726a6-cfc4-4022-bbf9-8906494aa168");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "ecaf3dc9-d7db-4aab-9415-b1ab3762f9a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "195dcfe7-f459-4868-b830-3948cb0ecb3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "5cd489b4-59ae-40d4-a05a-08c101f10c7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "0dfce7d0-4208-458e-aa8c-3bd980e8bd1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "5d54de11-99c9-4c71-8bf0-38c2a6fd40eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "ab847141-02b6-4691-bef8-1efb009d3824");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "88d73b5c-6efc-47ad-a18b-3368d4c09946");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "db4a61fa-7e32-4b65-8d49-a16982928d44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "4e8d75c9-cc82-470a-8743-361208ea8813");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "caccc944-1f58-447c-9739-664fa8b4b05f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "fa42fb94-9692-4926-a9fe-1b1a5549d896");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "370276f4-80b3-47ee-b092-bebcf07cea11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "90698d68-3266-4778-9f45-a90cdc5731f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "00bdd4e6-a11c-4446-89e2-17bfa2dfecc6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "31c98228-c44b-4257-8591-7dc555a3bf8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "8bee6404-c0ba-4900-a641-d29549bd9553");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "5beb93ea-befc-448e-afcd-fa44216a08a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "54a99b12-54b6-45f4-a5b2-74a58779b7e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "ff56d383-6ddd-4a3e-8dcd-c70d43d9de8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "b99f1c9b-a398-4d11-976f-ca91b2adb7dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "13f15ebc-c585-40fe-b0c7-18f93321ba57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "9aeeb1f7-265f-49d3-8f4e-b1829afc6a79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "1eeb2e3b-3c64-4909-b448-feec96ee0244");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "879bcc2e-3a35-4527-8037-8b167038b066");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "8302830c-d51b-457c-907e-6620e1386945");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "009189f3-9bf4-44a0-933f-587d5ddffc45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "fd9c23e7-723f-4ba3-93a1-cc4d6e3de29a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "b2822c6c-9b39-41c3-bd12-ddf6a63b6766");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "96a07783-1faa-4c1e-9bf5-b105535ecb25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "22b137b0-8a27-4d1b-aba9-3502331524e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "fc6797b5-69da-41d9-bcc4-9f17564955ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "beed9675-3288-4f8a-9eca-7313786ad451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "3ac961b3-f0c4-42a8-b9b7-6e487d9246f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "b222f547-8702-42f6-9c4f-a5ab68743b65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "cb36004b-2a21-40e8-b42f-5ebdf48f2ebb");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 12, 17, 23, 17, 50, 741, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 12, 17, 23, 17, 50, 742, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1316), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1329), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1397), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1404), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1416), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1427), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1438), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1457), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1468), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1476), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1479), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1490), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1502), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1520), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1557), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1627), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1631), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 12, 17, 23, 17, 50, 743, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03c68d94-2b88-4d09-af6c-2e5f4800ba68", "AQAAAAEAACcQAAAAEPhP9FhN8X8UT7KqmwuStbolaPbr0a+ItrLW41YZMwjnhapbjG3s/AM8wB84dfeajw==", "e750b4db-3893-436d-acaa-d7a91981c429" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36525d0-0ece-4b30-82ff-a3aa1a38786a", "AQAAAAEAACcQAAAAEJTCZ0kVKtG2seAlS2YefVPOLwBtDftVavcFsFF0mf29/So3jvSwshnIwoxCyV6ovg==", "066170f8-ba7d-4999-823b-b74f5faa0906" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "271ceaa7-b91d-44fb-baf7-e34da858677c", "AQAAAAEAACcQAAAAEPdNYdrYJg2LvXACfZ12b4fb2oor8habVJc4EbUXDLnTWyjaeVG/CJXRXbXgvXVYoQ==", "4546935c-d7e8-49a6-9b55-cc2cfc8ed47a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c81c3d96-6fb3-4fb5-8a04-ec0652b41d5f", "AQAAAAEAACcQAAAAEDbrXloIAYJl/P24q7VI97H2F8NXYxyEX2iBJVEQYoWh5xijKOyKoYe+MZCI08Tdrg==", "f3a671aa-7fbf-41d6-a1cb-2502954d1a6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b661b10-fa1e-4b8c-be47-e2b5aae7b511", "AQAAAAEAACcQAAAAEDHt06cYSslAk1NF6QsyZD7dAAJIMC0QfcQllmuLROWe6fzNANide9uAQVoZ69HfnQ==", "52c20991-5cbf-4004-96fb-f6cbd6bb39e3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65644bb9-02b0-45f5-a282-220b64d3cb1c", "AQAAAAEAACcQAAAAEJzO48qkAlg6avBHnEknVDvJa8IdOoKqRbWOLNQE7Zx9oQeL/FiDgqtJhn9cne9Hrg==", "bbed560d-09e9-4075-8bb6-63dc08fb9e20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf6a156b-c598-4d26-8fd3-04e8e0f97e02", "AQAAAAEAACcQAAAAEBq+zDnsD138hvpsHxAJJdA8LccLVskYyNpfyKGCamkUnyALaYdSWL2U3rN9HXipfg==", "0660af70-e2d5-439f-8400-b0ee8d4e553a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fe033c9-f07f-4466-b46b-cc81cf63091b", "AQAAAAEAACcQAAAAEEbXN5gya1TG906r2cDtPIGtPzcUyyhin6Pn75IZayvondMrCW9FErDNS7RxQse/Uw==", "b87f1c1b-ede8-4382-ba0b-908e56a51d5e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53dbfe3-0571-4b1a-9b2d-827c8c735502", "AQAAAAEAACcQAAAAEAMorsRJ5v233Orsjnd7H4gYrjhn9dCAGXmoU5xaUCh2PICqgaNSE4N2fXzQMLXQBg==", "2100d369-6df6-4117-87de-a20df3d077e4" });
        }
    }
}
