using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class someUpdatesAbt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(7547), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6954), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6962), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6961), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6969), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6969), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6975), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6975), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6983), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6987), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6544), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6578), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7625), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7628), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7637), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8431), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8436), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8438), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 12, 3, 18, 1, 40, 517, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(1402), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 7, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 12, 8, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7188), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7190), new DateTime(2023, 12, 8, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7192), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7194), new DateTime(2023, 12, 6, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9386), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 12, 6, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9397), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 12, 5, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 12, 4, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 12, 7, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(4497), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(3849), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 12, 3, 18, 1, 40, 518, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 12, 3, 18, 1, 40, 530, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5745), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5754), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5762), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e4e9c4c6-fe8b-4f03-8da5-246dae033a5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "14ea573e-5011-46eb-b590-a2aebb028391");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0b762de9-0493-4355-b781-ccdfeee6217d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "2e11823a-1bd7-4769-bc72-d5a33ef86857");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "da206347-00a3-419f-afc9-2e2ed12237be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "786f8b96-5510-494a-bce8-c7cdb967c618");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "e16a5190-c13a-40e7-bad1-c56d7e96a42b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "efb53dc3-08d2-4e0d-aefe-1deebf731ea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "6d3acbc9-2eb0-453e-9bb4-21d7b39677b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "fe288214-8191-4d26-beb2-9fb75013b955");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "c8f7aca0-126a-4235-8f05-133a3a28885c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "6e749e32-2cec-45a6-ab03-aa3d7bbbee94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "8f4d8b42-329f-439e-8700-a94ab6205338");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "71909634-9e3d-425e-8c1e-cb268258aab8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "e590132b-b3cb-4565-8381-9fcb3f48a64a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "3f5106bd-81fe-4e70-807c-e62b4adabef9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "04e7b273-a686-4b36-9c1f-60d138787bef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "43ee426a-e0c7-4d14-bafb-746320e2f62e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "74229952-8c80-4d55-a92d-1a8961fab07a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "8380bef8-335b-46cd-8e99-4f5239d554d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "99123345-3964-484f-92a3-ee97a9d1e161");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "edfe63ce-f3d9-4333-b453-f3c15cc55455");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "56fddc64-3dab-4670-b0d1-afd63a3ca7f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "7cc02202-485d-491a-a4e4-be62810ea265");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "192db8e5-f6b0-43de-8def-edc49bb49274");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "9568f9ec-f452-4b0f-ae91-4297f1c3442b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "f5f9a059-f03d-49da-b3cd-122daab9b0a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "ee45bc03-214a-4d0b-85cc-8ecbca547cc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "015d3029-4a64-4795-9c90-5b6fcc48e83d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "7232ead6-c2ad-4d70-ac2e-896900d2def0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "d8a58e26-2ee1-4a36-97c1-509d18648723");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "36b3487e-e804-489f-aaac-2ab694004f21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "8e834a4c-3784-4d67-885f-bc564ce746dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "a9b149eb-7eee-48ec-8d5d-e3108d72c008");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "cf4e7fe6-016c-42d3-b0e9-73e1a7239cf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "8db18ad4-a5a0-4ecb-971d-d77b381809ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "2ed14334-8bcb-42ab-8d1e-aa8c1eac958c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "3d6cf658-2d70-47ca-97a3-aacc41fbbd89");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "8c00ce10-bb61-40b8-ab17-695c79fd6c6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "bcb79149-4155-4b50-9c0e-a95705a60c94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "a78d7317-9657-4022-961c-2d78cbe0ddb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f6ff7c2c-82cc-49da-9b69-1b75e09f8a1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "86f3804f-0262-4ea0-ad3e-fbc57ba36c2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "97b02a83-5dcd-4f8c-b4f3-885019fdd1e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "f91275a1-b336-471d-8c84-3badf4a76853");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "3b91aecd-e67e-4a90-bce2-5bc86dec49ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "0cf91b62-13a6-47a9-8265-ee596dc1ecad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "52bc3778-3a8a-479f-bb37-f85d74b557af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "9f862192-18f1-4277-bbce-02b74973d5dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "f5b9fdf0-87fc-40e3-9b84-e77235057f1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "a42f89f7-9088-4635-936b-99a9bf04d05d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "c02324cc-0c9b-49f3-8e55-64ff77be2390");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "108098b0-d1eb-44f6-b738-3c1f6b33972e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "9b171267-45be-4e6d-bbfc-0cdc590d39eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "bc81e25a-e195-4781-889f-366ffaea72e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "fa60bab6-34df-45e1-94ea-d113be7fced2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "3aba0f5a-dd7c-43b5-ad7e-c20e7d4c1468");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "a351e881-d563-485a-9c2c-5225bc8ecf32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "f5b6e38c-f1b9-4be4-8287-0a6c45c1fe65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "f63fb87b-3275-4054-ba3a-502b8a8191c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "1e4e5b68-61ad-467b-8a19-438da986c39e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "6b133194-9a23-4749-ba5d-891eeafd0e52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "ff578069-17b8-4915-9b21-3a44b6bff445");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "81f9fccf-ae3d-4c80-8d56-5b4c7a800825");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "85e1a4fe-3a1a-4ee8-bda0-b9c573361167");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "68cfff9d-8721-4c7a-b0e6-0ea5806abce9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "e5dde32a-83a5-4cc6-89f8-84eed27ef659");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "aad86385-b6be-428f-8039-00a8b9199fac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "56e4e66d-e919-4f37-8619-eb84ae27f68e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "624bd60b-5719-424e-acea-7b4f77b9941f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "f2fc9a33-6277-46f7-a502-d63c043521e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "808998ba-57ef-47b5-9684-64e0e2e4c65c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "a56d1ec2-1350-4c22-8757-1b415a95cbf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "07a42377-f994-4c62-89a3-054374f9105a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "40b884b5-d327-4fe5-8f97-83af76bab9c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "dd9bc572-aeeb-46d9-a747-5236958eb7a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "47283ece-94d5-4d74-b0a0-773911975ec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "acf47007-86cf-4738-99a5-6ae9c575272a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "e5ecf277-7ea6-42ac-bdc9-a7be2d6c0002");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "1a15a82e-96e9-42fe-9642-183542691cc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "5699bb62-fa23-4212-8025-032cbd6d9db0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "4bcaa81f-2711-4b6f-8778-5952eec11d19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "118d0e30-101f-44e6-a0ec-f843ceb3c9de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "682381b8-9b7e-4c97-83bc-c2c327dbc9e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "73085318-6b1a-40fd-ac23-12f48d775e17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "24c0962c-9a5b-4cb3-9f3e-9394dec03d33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "66610159-2610-425f-a7bf-13b97763ee48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "cb097ac9-04e8-42d7-823f-c12505180b47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "4b4393dd-c2a0-4485-9e5c-05cbb6e2f03a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "aa337fe4-4a29-429d-b28a-395accae754b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "83bf9c9f-f2d7-4493-8212-4d083a1517fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "753d6c27-521b-46a1-8a4d-7135a3b6bd2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "df180eba-8225-43bc-87dc-3fa782f0e089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "2ab97a12-5e36-4e1f-93dd-d609cb829872");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "5121bf79-7bdf-42be-8bae-183a44bb8d18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "61f94829-ca09-430d-93e1-776f04d55bce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "270157c6-07b9-4fb8-9329-eaab730be1dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "cfe9127d-a3f6-4e4b-998b-17305b5562ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "b7a1235f-5c04-4abb-a689-243c54886301");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "3f83d249-4775-4223-a5e8-2f012169ec0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "c37e811f-efbc-4c45-9326-4adee080a952");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "9f124906-a565-4bd5-a35a-6fcf109b61ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "2b3ff2ec-9ccc-44d2-bee6-08784d5eacd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "19d19217-c082-47fa-aeb9-65c51977d320");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "989ff001-f0f1-4fe0-ab44-584ae8371918");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "dc96f9f5-2b77-4018-8e3c-332ab9350dcd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "a17a6da3-18bb-47e1-bfa0-f9eafb18b09f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "515271c5-f3c3-42ca-b3aa-a90a4717bbdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "17951514-0b36-4fc5-9655-716a9fb32958");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "2f50e1d9-a243-4447-baa0-a7739e2aa3a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "2b3cc56d-b082-450f-8421-ebbdce936cbb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "13bb8f9a-236d-4018-b985-839f1ae5c50a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "153e30ee-503c-4891-9438-15a106be815b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "0704e1ad-4170-402c-8ddb-86693060ffd4");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6275), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6279), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6284), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6292), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6382), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6391), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6393), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6395), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6403), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6405), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6409), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6411), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6413), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6415), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6417), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6424), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6428), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6437), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6441), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6449), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6456), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 12, 3, 18, 1, 40, 531, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4f1145d-f0c4-4a1f-b512-2ee49da43719", "AQAAAAEAACcQAAAAEEpFH6wi03yyqFsLZQ3j1bAb6/ZLp3/UM6DzTjHF9LydA3AV+a7v/45nTiPUntNkRw==", "f42d5547-7306-4e4c-a709-46960c7ccf9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb31e22e-f655-4db0-ae5e-2fe44d820c7b", "AQAAAAEAACcQAAAAEFQmFna23LL+UHeVCCd/6IJ7bO6U7oBQCTN6BdjRbuRAjDmrgEmqGn/pHumJf7PP2g==", "28a202d1-9553-4315-ba7d-4add5fdac2a9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b1b1c0-799e-4709-a304-c9297112a213", "AQAAAAEAACcQAAAAEL1dimPXNvsCQpVb4VAzFTcAOukuwqXT7xB8xX3oFc6qFSIZxOx//bLrZqPvBKG5GQ==", "5b530470-8410-4254-8b6a-27368e306669" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "885b85e3-1e25-4a9c-aee3-4e36016a0791", "AQAAAAEAACcQAAAAEG8wB8kFBojzft3llFtibICS3rmsLpZYu8z7+OvV+NgKxFLu49w1JDan7kZZUY1dWg==", "c693a61b-b02c-432b-a75e-0f76fd8d98a7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc606bf-75e7-44e7-b7f6-81c07b387cc1", "AQAAAAEAACcQAAAAELwZtySYfKtFGI+pgcf+8zqM3uu2OWCTpaKlxDo/0XqAHkygyRNVPeBXQ+aiWM/cCQ==", "d37a1fdb-4fc8-4898-b6ab-ed078e81e733" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2961c96b-abdd-4230-b3fd-d586ea836e20", "AQAAAAEAACcQAAAAEA7/S4jwsJRmPOEJzinROz4xnpd00w85TTl7xtnFTexMG+2HRqjjJzvWtYv0MdCXdQ==", "b19fa98f-a7db-4215-ab4c-9312b2121236" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f73c8d-8c59-4576-8417-5255cc59c921", "AQAAAAEAACcQAAAAEDxyHQe8cULqcm9AOISrrsJjzOCWtZhnKxuXmGe2H9R7FxjxL/FaAGmY992ZlnRnBg==", "8b928d9c-a823-4ad5-87b4-1dd2d0165709" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a81f5a0d-6ace-44fb-a5d8-43628aad3f80", "AQAAAAEAACcQAAAAECwGn8AGZVCm377+oX2NbvgeT26Wz2w5Tgw9E3oSFj3y6HtlCtX9evTiyYMBH2/bXQ==", "838ce71e-0bde-4afb-999f-5a276cbfdba5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d5f544-8449-4ab0-a68a-e47f21a091c8", "AQAAAAEAACcQAAAAEGFmrVi/1DkbX3zTLWokaWEefJAReTpyPemenp558sFQvt12TJezynetBSalK4gSfA==", "404a65af-a2f4-40ba-bddb-fb1167bbc53e" });
        }
    }
}
