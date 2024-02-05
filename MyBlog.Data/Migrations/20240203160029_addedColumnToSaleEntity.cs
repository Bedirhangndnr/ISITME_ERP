using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addedColumnToSaleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AmountOfSgk",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "SgkTypeTitle",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8673), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8677), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 2, 3, 19, 0, 26, 792, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(276), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 2, 8, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 2, 8, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7950), new DateTime(2024, 2, 6, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5762), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5764), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 6, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 2, 5, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 2, 4, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 7, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 2, 3, 19, 0, 26, 807, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 806, DateTimeKind.Local).AddTicks(8882), new DateTime(2024, 2, 3, 19, 0, 26, 806, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 2, 3, 19, 0, 26, 793, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6623), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6637), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "03aa8fd3-7112-468f-9df6-6af460e87dcc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7df70282-ca0a-4087-8362-dd4d37da92c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "90343425-03c2-47ea-9cbc-3503fe5d991f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "1c636e51-88f3-41a5-8a42-6a93ad7e3d21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "811fb01b-73ec-4743-ba04-ab93938381f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "46a7bf5f-22f2-499e-8895-41489b306388");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "31714d0f-f58d-47a9-b870-e59ea050d03d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ca0d5326-a538-439c-bb1d-9ee0bddfe92e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "db5c2e04-ae1e-4027-9c02-5d1f717074e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "e05d3e94-3768-438b-a3e2-d372546f5242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "6c395fd9-f067-4b2c-a945-e087fc6ff020");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "ed7450a2-3fad-4cc9-a836-2cce240ced5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "269f179f-272d-4886-bb63-7d35e15a234e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "31f98e92-37d7-429f-b777-9207ff40114b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "db225c91-c0f2-4052-9cd3-99bdf33f5703");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "9a6ccb41-ce69-4fa0-8bfd-5ee597255da6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "63b461d6-0cd5-4bf2-a0a1-52740a1bcb29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "a728c473-a502-43ab-8ed3-a0ea1fe078ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "2e65e91c-46f6-4e0f-8ef0-e4edc5c3f352");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "9f6872b1-ba29-4674-a7c9-30b75c171a43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "bcd857ad-e70f-48a6-89f4-4172ca0bbbee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "ee68f6a9-c94c-4981-ac8e-4f1a6ef4290b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "ca2b951a-1219-4da0-b815-9bca7d2bf295");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "d0d61f15-6d2c-4b20-9014-25364ddbd1ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "71ce2140-21e4-4104-9006-d13c810b18f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "70c90ada-c464-4382-a603-c65a234c5687");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "40b7eaeb-08ec-4140-8dc3-1d3a68b17955");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "d7d92418-89b8-4282-b413-a5d8b88df77e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "7dc7fd54-5642-42d3-8061-9b016cd0df63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "d0b6185f-7c86-49e5-ade2-1498565ef7a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "f61a6bd8-8182-4ead-af01-7ebd66f79072");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "bd5c435a-f77f-4e66-a160-acea79227229");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "9cc9f66e-f542-407b-8b48-e4bf1a6e862d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "70cde12b-9f85-4e83-9872-477af0a6e80f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "e658fb4d-c985-4fa8-a690-1d0c0e416c7b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "42e2552e-a085-42c9-ba5e-f519d4b2ec66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "4e154815-98ca-4fc6-8f46-0444a6856257");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "61207325-bfc1-415d-ba67-df74f647b40d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "2189dd06-d7e3-4256-8fb3-47848632db71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "398283e2-4729-4e64-b5ad-2bb9618e3279");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "ba302570-25ad-47bd-ac5f-7f3d8b052e5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f4e523c3-0395-4a6d-885f-085e2f3dca27");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "412a081f-33a0-41b1-9c14-f6bc2e085d6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "65357681-1a07-40c3-8ae2-ed6c45614f7b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "9c78f8bf-fc2c-4a02-bedd-95fe4d79e1fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "e4aeb074-ff68-463e-a1ac-6e4d2d080307");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "eb9e8a18-dfbe-40b6-9acf-09555d4fabd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "c7bdb9a1-8b3b-4b6a-8a2d-c26bda3fe4b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "a2f7817e-9f80-469d-abbd-5fb070d769ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "c414f56c-6c1c-4744-a7c8-1814c044d5ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "2e90fef0-bf18-4d9f-bca9-b25829727921");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "a8c10a91-3bad-48fe-b519-67d55f05c645");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "90acbadb-a1fb-4067-8ddc-a5730c2f5495");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "2dcaa086-353e-4284-bc23-8e3ec38f2801");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "15eee3c7-3a7e-4710-b568-fc6608677524");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "d20f28ec-4f0b-4139-99cc-63c31ac26e07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "8fa4e8b6-88b6-4974-ac9c-c3f64244e576");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "d385e995-8ea1-43ba-966a-398532fae106");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "10dca3b6-1449-469a-89f2-7a7b7600cac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "6d1e0f07-f94e-4f8e-8005-5917d1b1b549");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "8d0d621f-cf58-4015-80aa-e9dc46194571");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "cfb58fc3-7b21-40e1-bd74-e75a14f7c24c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "4ae79330-07f6-454b-a230-61e79af48397");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "3ad51396-cd26-4f16-ac04-56cef6300a73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "d38268f4-4c1f-4778-9e93-dea78afc147f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "403b2f40-3791-49c0-93e1-499b33d2052c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0e776d47-b38d-4f02-8b2a-abeaef93bb12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "a08d79a3-3bd1-46cd-8d24-2a6bfc25dd81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "23df8db3-37f2-4a5a-ab68-425973beb31b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "a7a26346-215b-4ad4-bc82-4f07d0ce7240");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "0eb03ae5-4e2e-4030-9bbe-6df30452c471");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "70ceb8be-a174-48da-8672-6e395b5080b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "0801a269-032c-4c64-9c18-bb93d96fb86c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "f77320ee-bf90-45b0-9d14-d91ca75f7d4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "ac5b828e-06fa-4e90-8882-2a3d52f5bb15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "30994464-ed92-4912-98ac-5f09ce5203a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "6dd5f9b7-2e12-4a87-bd49-015d599f02a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "13696fb0-9511-4ac5-aca3-75c108bc1982");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "f1dbda31-cba5-4afc-a528-aa216aaef6ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "d91f66be-8989-4746-9b82-ee59931a9231");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "764c27ea-3501-49a2-b186-4de06b7bdc45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "3457fca3-36aa-4d03-b5b0-7e541100bb86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "1bf6e543-a1ed-40d6-bf6f-ff64a971225b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "acaba816-b78d-40ea-8fcd-c7bd091441a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "273c9792-88ea-402a-a0d7-827c8bfcb617");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "22fb5804-7321-4750-b93a-96139bb652c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "1e74c079-b5fc-485d-95f2-b3d89ce60405");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "00c47541-4f5f-4f5d-b2d1-dc114b404495");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "e9366b3a-5224-4242-9a4c-683ffb3144e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "5b29b61e-90af-44f7-a2cc-c7a41fdea8da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "8f00c496-f820-420b-b6a3-7b722b6d2d99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "94de80be-b5aa-478f-be70-116e912eb39c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "04171c12-af41-4d0b-ada4-fef502516efe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "9dd53d97-c9e1-4f14-b6ff-5d0a6d94504c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "bb449f87-8629-4f10-85e5-cbc161394016");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "6873fa87-4e1b-47ac-ad9d-b11e33ef6a20");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "655f0bb6-c119-4035-8bbf-cbf46558d8ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "7d54614f-37d8-41ee-9b99-45c1a2c00918");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "99710fdc-81f1-4e1e-94fd-63e1f053f0ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "8f5ae55a-b308-4b08-8301-97940b81775e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "adbfd9af-29ad-458c-9e92-bc3be8f8f134");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "645fe2e8-8299-40e6-af8a-93c0ee0bebc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "5ebbc3f3-dda0-44a0-abe0-a35c5b180af5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "68585c86-2df6-42ac-86b2-2edfce85b27b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "2c67cca5-cad0-4560-ad92-d4077f52b576");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "03185051-280a-498a-bce1-4da0171f7fc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "2333a10c-0b39-45d5-ba91-48bd7de90e3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "7395033b-13cf-41bc-a6ff-624f9cc87b3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "53a59a14-c4d0-4d81-a8b0-8bbb6e290470");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "72893e8a-bde2-405a-90ae-24e955143983");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "da8f3791-964a-4e0a-9df8-ae4e31c07083");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "6ae6ff47-1230-43ae-bbf4-332ab3e62931");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "ef46c4d2-834d-480e-ae28-e6d9600d2104");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "dd832af3-d824-4a9a-ada8-db017f6f3960");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7129), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7136), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7228), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7242), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7250), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7256), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7295), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7299), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7302), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7314), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7321), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 2, 3, 19, 0, 26, 808, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2896661b-42f6-46fe-b938-1822b6ced574", "AQAAAAEAACcQAAAAEA1WxXGeUm56MxPVuzCjqzI/zEa+vRmDSnaXzziEytiYa+OdIoOSPy8AmsPjEEJdlw==", "baadb506-a691-424e-8a12-cc56f568777d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f8d8b41-4717-44c2-9db8-58a09efc0743", "AQAAAAEAACcQAAAAEBuE06uSEiFCmElLF/qDCSQg8zzBkQzQQoCtJPSHMnql4p2qo2ulEkzrslYPAHvsTA==", "8fdb5cea-9fd6-47d5-b73a-f44c210a25ae" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1957e423-e8ff-4474-90c0-e8d98ed50021", "AQAAAAEAACcQAAAAEH6Mah0df/3m7EojvpWGvz+E1ThOyz6EJ0bxrahhw3Fa+MShTEVY6SY9xywtXAIi3g==", "f2b81acd-b1cb-401d-a079-eec15bb398e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce64454b-ebd6-43a8-a0ea-abbd548ddcae", "AQAAAAEAACcQAAAAEAPSuIAhWHQZlEpYBeF8LYwlVdgxHKVGely47e8daO1dIvwtZWRG/lm+g0m4XSoZfQ==", "bfdbf071-f337-4d79-80bc-7a6a0e5d242b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cce79fd-bb67-4851-bf18-3f074f100c61", "AQAAAAEAACcQAAAAEFaPWKcEtdywTewjITnppsxEhaDEFktOrcRhNgLjGNs6J//oYclrawhF3H+TYGKiJg==", "a206f57f-40fc-4cc2-aa95-8dc1ed8e0e8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac409637-9bbc-434e-a8b5-d075d0a408a9", "AQAAAAEAACcQAAAAEFA4u+dDERAIyVfWcD666Ese9rOmrBkB+PmsrEwk+QxbsS4uA+1U4uWLH3FiacKhQQ==", "3ae888bf-f1cc-4e4e-93b3-ba791bb30112" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84065fb2-23f6-4515-9229-698c347824c9", "AQAAAAEAACcQAAAAEEz5F1k3WLfkIAvbGtdz+bwn+PuolzfWBs2Ee5NssvkbXJL2YF5OCEleTnpuBGVEfA==", "5b440a92-beb9-405c-9a3d-029f6049aa7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "457c5fad-5025-48be-8184-10962c044fe4", "AQAAAAEAACcQAAAAEN44OCd4LoKBLuIi7BORMflYxlJyqW7xlbr+9oMrc7P+822+8WNjsVupoYd/JzolAA==", "fdd310b1-cc68-4325-bfa3-ac412748d669" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae3b88e4-03cf-44c9-9859-51d074eb3a97", "AQAAAAEAACcQAAAAEMYRdhi4EEGGFrwb1HZqaNO4jE/qKjqGgLR/pMklVYUuxB3QHYzkt+dnDqqI/MEt2Q==", "d9d36c44-d22f-4ef5-be42-ed73285261b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SgkTypeTitle",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "AmountOfSgk",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Sales",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 56, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 1, 22, 1, 27, 2, 56, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local), new DateTime(2024, 1, 22, 1, 27, 2, 54, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(29), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4943), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(733), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(736), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1619), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1633), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 1, 27, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 1, 27, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 1, 25, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3625), new DateTime(2024, 1, 25, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 1, 24, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 1, 23, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 1, 26, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(7975), new DateTime(2024, 1, 22, 1, 27, 2, 69, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 1, 22, 1, 27, 2, 55, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "20dcd987-9185-4e2a-94fc-c198d4e9a566");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7549b87d-0f7e-4c74-a123-ce753b1858f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e0143873-452f-4a8d-bd74-2165a377fa37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "edb6a821-71ad-4d8b-8c0a-1159d6ec68ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a5605ea6-3399-478d-8c28-bdc5c8ddafdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "9134d43a-4cb2-494f-ae86-385b5beadf6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "e0bc050f-75be-4c07-a917-95faa1089bd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ce303e85-3cb9-4826-a564-cc7e41712ea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "403f837c-df0d-43bb-aad0-038beff01591");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "4b3c904e-840d-4ab1-8673-f3eac2a864d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "9a2a2fde-dfba-4caa-b58e-4e9a5e365be1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4a869f14-f77e-4d3b-b113-7b95bcd90bda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "50f77cff-d8a4-400b-ac7e-84c117139852");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "1eb1b60f-6c71-4495-ac5e-a242ceaf6ed8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b6d7dd7a-4583-4c5f-ac11-3e6a2e87de6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "9f07857f-630e-443c-8b39-4d1f766ca48c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8563b671-a2e9-49e6-9e79-03476228a630");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d3145b3c-857f-4d94-ac57-2ceb50a9fd98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "4567a30d-7c69-42d3-a186-079805d73a3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "42cf68fb-f115-49c2-88f6-23f0b7eac19a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "22a1308d-d870-4122-bdee-36e90157aacc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "ba468d5b-6d23-4536-9cbe-499a78f91016");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7f977a71-3640-46df-8652-12d7fe328392");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "a4bf0492-45fc-4e5c-ae7c-67313166e509");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "4ee3375b-82f0-4035-bef5-1135d2ae4ac1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "0c8b9ff7-be92-4db2-a233-cf6e42163f55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "0a0ed6e6-4a7c-4c65-8bd9-c3492b4437b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "b00573b1-c1ec-4e03-860a-b34b579a3cf3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "ec1ced1d-cc6c-471c-9c85-b30ac54edb84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "cdb28a4d-2240-4996-b276-5fe098f3d554");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "0850558a-0ad4-4a7c-80d4-ff0e89486acd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "a994afb7-6ecd-47f2-abd8-ed3a5e11b99b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "48cf0082-8b90-49e3-92a5-e21f0e3290ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "b2ada370-f310-4ee4-844b-707c3dc01b0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "cab30588-2f8d-4cb4-8cfe-0b3aa0f10bc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "b18e97f4-591b-4ce4-836c-1596174350dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "5ba6bc7e-d4d9-48e3-984a-e92b07ba5761");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "43d01da7-251c-4ace-8dfa-ae0e160cdc76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "564955ca-e606-43e9-9c02-3f0ecab45e5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "fcdd499d-d959-4920-9a40-32fefa10c4ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "eba4d359-9fa4-4947-8a0e-f968ebe143f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "b8cafe63-2815-4096-8342-df2fcb5389b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "6dd131b7-b862-4f6b-93dc-9ea0433a38e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "9b7de024-b1e1-4816-a29a-94630ce954ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "5aaafc88-1a61-4267-b05d-d45c1efb4ea7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "15555e56-aa45-4a54-8d29-6ca71b66df42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "3102bb8d-b563-4419-88dc-9883783661f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "5231f234-650c-4541-a2b7-3a77579a9518");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "1ca45ecd-64f3-4156-88e4-92456d7ef284");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "1fed942d-2aeb-4531-80b9-23990f3a5e4c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "1f870f58-4931-4983-b3bd-bdadf7edabe7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "e0e8dedb-ebbc-4645-baca-b7073a56dcc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "3f93153a-9990-46d2-8e78-deef7fafccd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "b61bcc25-3ae8-44eb-9258-835af94dd844");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "368dbb3d-c37f-4705-b78e-de84f7029832");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "11dae935-5fc5-474d-86f8-a4334f2f18a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "e0ef4fa7-9230-43aa-90b9-abbe1df3d36e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "68b18ad8-1d79-4f54-8439-44470842d168");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "dddef4b7-fe7e-455f-8c63-0365cf8dc8cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "fc3a8eb6-ac14-44e5-875a-e339a48bf547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "ab313ffa-3be2-46fd-b38e-ee9915b4ba0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "4e6188ac-f2d7-4289-883a-dc5d057ee62f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "32a9c41c-991d-4f7b-8941-b9a942226c8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "08fd4e62-12d5-4555-a43e-ad1fa59205b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "fbacfb8b-eac3-4fe4-8184-095365272cc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "661b2319-225f-4402-a6be-6c3e9613b2e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "8dbfb6bc-ab7a-4326-b5ac-2460d06b0fec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "eb3bafaa-f7eb-4f10-b5f7-ee676192bca7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "78e8323a-4c42-4b45-b7a7-f9a7a04ace25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "cbf868c7-5c42-43a2-b0d2-1b9661a7738e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "30487af8-e3fb-4f38-9761-9de732f61017");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "07c492e8-88ce-486e-af17-39c1a280ddb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "90f5ee00-3576-4671-a5ae-764f8fb8f7a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "1f480f31-bba2-4fc9-9cff-6aed8b559005");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "e18dc7f5-7764-4cb0-9603-cf54b23ddaf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "d78b95ff-ec89-46bd-a922-56a3268adb3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "9fe19c6d-70df-4a88-8d3f-1f5b2b54f7f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "645f4d17-d920-40a9-b045-ce1c49820218");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "63e722bd-9789-4149-8607-7fc201b634af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "197cf3a9-0683-4c42-b8fc-565f31e550b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "845f4313-bbe9-44a5-bc66-cb1e81f35724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "6c72974e-6b3c-4fec-a883-fe760865fa50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "8f089dc1-9d1b-4890-bc80-247c03a16699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "bde44a9c-a799-4925-b0c2-34602fa2deb9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "876a4980-96b8-47ea-ad3f-32e009ff1334");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "8e150daf-b420-4363-bb6f-ec9620052ad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "e656b547-1a4b-4d2c-b67d-e20b8954b0cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "0cb5f009-8ed5-4fcc-b11d-2f1e01f46f3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "a50a095d-752e-415b-883e-18a50591cbd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "56a61d8a-609d-46c7-8731-91f508700369");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "0dbfcee9-adf2-4680-9929-75d16902dd6e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "6d159bb1-4e6b-418c-9886-b2656dc5f402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "3b29b039-e3aa-4ed9-b586-d28c3d8b5afa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "3a4bd1d8-3810-4ed2-b0d2-7b6b20e7ca4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "ce8371e6-ee0c-4964-be30-41aede0b7d3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "e220be24-276d-4b81-9d58-29d2ee90bdb6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "1d34b36e-d2ee-43e5-b074-fa0afe101ec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "b5e26950-4d22-4471-905f-9c96df9336f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "e1f6610c-9db9-4743-a0d1-f007a0a26c34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "a05c8edc-43b7-4405-bfa6-56cd5ece4862");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "5528cdf7-e0f6-46a9-971e-29fd011eb6f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "3c4751da-b974-4ed9-acc5-09cc8cce9be7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "c75393b2-4025-407b-9457-a40afebee51a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "7d19f638-9790-498c-bb23-84cc10cc8821");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "e2d96b54-52e6-49e6-9644-fc80fdf13f1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "07820b0f-936b-4a01-aab4-c3d5fc05f055");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "152e4171-8492-4acb-b2d9-f680981e94e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "9ae367bc-2f46-4f54-a5ca-e38f5e05f10e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "f6b1bd6b-2915-46a9-a891-743ee22d0c91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "5b46efc6-48b7-40d0-be0a-063c0789fa58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "22f36f71-4bc0-455a-9bd8-cf6657db3b00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "b9978755-e577-48ac-b015-34aa4f508a26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "f9b801ae-83d6-44e0-86c0-58ce8ef65157");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "126b1596-2101-42da-89e3-f786cf33184c");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 1, 22, 1, 27, 2, 70, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4636), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4709), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4733), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 1, 22, 1, 27, 2, 71, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606a19d9-7d7d-48c9-b0df-fa1eb2484c68", "AQAAAAEAACcQAAAAEPiluVJfWC8vYQEj+sLUZGsfJbjF4wlUheVMPsaP7W8mOiwJgXU+0sE1e66PRpeXug==", "55ab3b9b-548a-4ff1-8643-00bce58e51ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2d625d-669c-46cb-9e37-9dec82a1ce0d", "AQAAAAEAACcQAAAAECEYh5l9PIx+sUg2IbEuVYr63E5Nb6WY3dqEn24iElMjj43LSifiENs0Y42ZLLHAMg==", "dabe62de-4a8c-4d54-bcb5-18bd85a47f32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d79b5d9-ff18-4779-82c8-047a593b16e2", "AQAAAAEAACcQAAAAEMLV2d3WyGzuFmObZ0/BCCLcFj2/vzrBmWivvx/LNudlVpOov6zmgMytnZ1FYmmyrw==", "646b8a19-068a-4ee0-896e-afa8a2da259c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cceb2878-3832-4520-8e70-271c22d14f75", "AQAAAAEAACcQAAAAEK5EqaDd6CNWihY4Jsr9I5QdDEBLzagdI5Fa91wpvDdAks3akHFflA+mxpoisl6Fcw==", "aae8b87b-03c6-4418-99ff-eed8c55d5766" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da6c910-56a6-41c7-85ed-5f92b88d7c37", "AQAAAAEAACcQAAAAEEfokPkpd92N/m5cP9Jg+yuK6MLwDxvVQueOolakvXZ2cfNezj0BsRvU9279oRh8yQ==", "a910d632-c76a-4d28-8e8b-6302b623449b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cd60555-ddf1-4d2a-8932-b41aa9afbd28", "AQAAAAEAACcQAAAAEHAWBFx+qzuAxfJN0OKsUtzLC+efYdoA+73r7RqKuHwujdWVWyC4XIDO6VCDbv1s8A==", "a6592dbf-3c32-43d4-9548-2f627c40c836" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09966a6-264c-4790-b0b5-2f89dadbbc00", "AQAAAAEAACcQAAAAEKbyUS8OKZ2Pbmeca2Xy/PvkFVndCGCr1oaIrfXyuyuxFauus9xrWoGFrqhKFH+mMQ==", "e433ea75-47ea-4964-9322-a8666c73ca23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbbd4d98-fdfe-4787-b0d5-4120b2a7affa", "AQAAAAEAACcQAAAAEHOr6G3ZVwVfBfQmo2iy48f4OcDo8imCArDEIxUCymaO6BxQhLKO+5lubR4HTqPw9g==", "72724547-d147-4b1d-bc13-a08107af7a74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bd6cbaa-acbd-4daa-a297-ce107f1585e5", "AQAAAAEAACcQAAAAEHMfidHvFYFsuL6S7jGPtrU6qr+ZjI4XrabqIA3Vr2ecO+qrqe6z7njNlxl2KsuTRA==", "21a55213-bb0e-40df-8290-624517b851c9" });
        }
    }
}
