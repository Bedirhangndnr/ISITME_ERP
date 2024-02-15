using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class SaleTablesProductIdPropertyConfigured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 2, 12, 13, 56, 33, 904, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(33), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3542), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4397), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 2, 17, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1540), new DateTime(2024, 2, 17, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 2, 15, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 2, 15, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 2, 14, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 2, 13, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 2, 16, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3097), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 2, 12, 13, 56, 33, 917, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 2, 12, 13, 56, 33, 905, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5458), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(316), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(321), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c0df2c0-b2a9-43af-8452-992aaf4db255");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "58180997-3780-4d03-96d1-7388999326ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "91f99943-107e-42c5-82c6-6719e631eb75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "fa209811-f6c0-48c5-b878-e5e5d348c614");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cded6cdb-aaab-445e-8afc-6f3ce55d1f84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3a8d6078-5824-467c-aa48-19027226e4a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "6c59e7b1-a03f-4a45-bdb8-de3e90626ba2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "78d7e625-8918-4a48-aa1f-3497797ea638");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "dfe19c74-8a7a-4b8d-9059-a8e6b10d5a16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "9d899434-716a-4281-ab3a-dba42182e097");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "28ec4958-1d3f-4b5a-b0f7-518c42f27457");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d30ca6df-d0de-47f5-846a-b6bf977c3736");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "0be78b75-3533-4d3b-ad45-69f8bfa5fedb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "c98c9b88-4de9-4531-bad1-c4cc69f8149b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b42e67e1-617d-456e-a4bd-6f0c2d0a0c4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "31144065-af89-4b63-8b6f-79a7f2cd5b6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "ee18b0ea-5cef-4856-aca8-00f153306249");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "3b710821-0507-465b-bfef-811d17871465");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "6818e788-c8c9-4776-bd1d-3cbeab907e17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "36c1c178-82d4-4421-b15b-14cb374ad5cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "a53bb794-6523-4434-8c9d-1ec19e5daabe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "e4e6af32-f15a-4d9f-b441-ec19dc56409e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "e70e3340-2226-4b2d-8242-6f25eec6fe6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "7df045e7-e2dd-42fa-961f-0e06da5573f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "053cdbcf-ffde-4a8d-8b7a-084619999823");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "bede3fd0-b6af-410f-9255-543e4450099c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "c92834af-bd9a-4c49-a444-3bd2b6e48d8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "bcfd4b51-3167-4e77-8a35-ca5fb0134234");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "372a8c1b-fc82-4b0c-8cb9-f10a02391dc3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "8385adc6-4fd8-41d7-9d83-84c57c56d0c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "5bb5a80c-32ce-480d-9d2a-7cab6e610633");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "ae5a5739-cada-424e-86d8-eb00de4d61a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "caef8030-e95c-4b8b-be37-302f4143614b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "f72758d9-68d4-4ea3-a3b7-0d7a0c37dace");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "0f743421-2ecf-41da-a1d7-13ce825cbd0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "404e26a1-d9c7-480d-a2ba-21148daa07d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "4b041278-4145-4028-a3c5-8ab763df3b09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "fbf5cc2c-ec33-46b0-ba8a-3b5c10a6a1d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "da0232ef-e6f8-46af-bf07-0a6e8f41a867");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "341981bd-ddae-4a5f-861d-2ebd09158b8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "33dc43d4-18bb-4e27-854e-f1af309af230");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "3354cf65-1f69-43e3-b99f-8a8ba18d4260");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "18c7f15e-8bbb-43b7-8f81-0a5aec5e0f96");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "dfe7d303-fb2d-4a66-b6ec-defad2f7fc80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "d3adbe1f-2b9f-43e0-8a7b-0c14ca1cfe34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "630b2d0e-bb83-4577-be32-3f8d4c026ac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d8db9476-1563-46b5-bd16-22aa479c6474");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "79a1c49d-0104-4979-ad11-7f7382fa1246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "a3215dd9-6d41-4155-9e35-6a31c19504d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3a49194b-531e-49e7-bdb8-932bf6bd8fa1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "0a45f3b2-7e2e-4a4e-b84f-5d36f9df71c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "876bd250-19f5-4d00-a072-ab651e603776");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "54c78998-df17-4c23-92a5-51d9ecd999e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f173c01d-34c1-45fe-8f1a-3f8e098393e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "fb2eef0e-f786-4fc5-b71a-b3d81fc45482");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3691d141-1445-459a-bc68-b013934ee426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "2db559eb-7bcb-40df-8b1d-319a070dd6ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "b6887be5-24db-4c0b-bab1-bfebccf7f9bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "a217a642-c65b-4847-9287-c200af96cee8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "6a745a1a-250e-432f-88f8-8466f81c7103");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "a2f1a87d-74ab-41ec-93f5-b6a389f8277a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "48664b6c-f378-45db-b791-6a0d26152b31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "0cc0618f-f916-4ae8-8db2-e79735929dd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "c851ded3-61ff-44f6-8cb0-7f7198867fd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "c5bb0910-0a1a-4080-a6d1-63b75acda374");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "1d0c9e81-bdd6-4d8e-bbba-76d6103b8912");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "f054813d-0165-43e2-ada8-f40bd448360e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "821fba4f-08bc-45a5-b0b4-10d6c603d2df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "cac529b0-105f-4bda-9907-5d4726a65c92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "6844bb72-e5c0-42c4-a202-23cf57a016a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "ec1e6154-3c4f-4104-83c4-f10e2f87b5c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "b4737abe-baf8-42cd-8af3-3857ffb80c23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "e10ca184-4ab0-4053-898c-070ec16d9ee3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "ac7b1ea1-b906-48aa-88e3-8c488a6dd998");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "1ccf386b-7939-4ade-9c9c-35296677b2f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "7d12bce3-b024-471a-9f71-a2516c93bdc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "308c3ea3-436b-4eed-8465-f6315da5ff00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "6ed45bdf-aa7b-4693-840b-12ec3bf9757a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "a591ec7b-9177-4034-bbe9-e4067518874b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "273579dd-7728-4f56-a7f1-77c5c3c934fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "3b553761-85b3-4cb9-ac3b-1431a6e3cf87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "f7b8b77d-b516-4bde-bea5-e4630384b1cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "574865f2-99c1-428c-9949-93570e1a2832");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "3b71a7ac-f2b2-4233-9b54-95babadaf9e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "86a16494-6626-4e4f-ada3-71c54b98ca80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "60f975c3-6ae0-4393-be46-2e1d6c92008f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ac87f298-3206-4fa4-8964-93c50070fb30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "b06bc26b-53b1-46ea-bb89-4256c12d65b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "f56e9906-569d-476f-8b12-30f47e6302f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "fb5861f7-ece9-408d-a5ff-5468a0c87e55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "91fd5bf4-2d9f-476f-9139-5530974072ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "409193cb-df0a-40eb-967e-41c876e2c337");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "b3713b5e-2f85-4767-b91f-25c7850a5355");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "7bf4bed8-a6c2-41e5-8b78-23a7d2442051");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "86cddf8b-0983-42db-9dac-e861be4c5fe8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "8812b80d-c094-4d37-aec9-ba338bec5336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "1f672d95-273b-493b-bbe6-41eb8f44b04b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "85e46d6a-aeb2-48da-8738-a90cd66a9a78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "dba7c6c0-ace3-4e9c-840b-b0b282a17bd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "216cdc4d-10db-4d28-a54b-4bf58270e9ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "ebf080a7-de26-4675-9e55-d8bfbf0d2e85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "482ea4c8-9741-46fc-b50c-5293f22fd5b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "81ddd27d-393f-4f7b-8694-14089ee04bb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "e305041f-583e-427d-963d-a757949b9efd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "1da4a92c-8dd9-4fbe-b4f2-cbcbf0cf68e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "d2639f82-bb09-4f10-9b99-45c591c304d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "0d49c309-bd92-4e3b-90a5-8bc0a116cb2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "701ec397-61b0-43e3-bca4-c743338d502a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "09c83a4b-0d9f-4139-a5bc-f437b2d91282");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "2836c242-08d6-419a-bad7-04a73249c2db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "f141ef28-586d-4d6b-995f-2164cde195db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "924d598e-7811-4de4-81e1-b8f879cd2b17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "5b98eda6-e28a-4713-a924-b34e55ebf6a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "d899a049-431e-48a4-856d-e5bb3e4e84e1");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 2, 12, 13, 56, 33, 918, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(756), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(758), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(765), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(769), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(771), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(773), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(776), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(783), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(801), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(856), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(876), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(884), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(919), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(925), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 2, 12, 13, 56, 33, 919, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1d1383f-d08c-4191-b535-297e1f3f1019", "AQAAAAEAACcQAAAAEF20QZgCEMoayoPxo2ikbNeRqhXlmaXOxAmAdYmB0jqvQeeOC7ScznaAgtj/gy94xQ==", "429c0415-eb30-4b05-9cd6-84c8151d364f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eabe0389-8e3c-49d7-8965-b120261a2c7c", "AQAAAAEAACcQAAAAENyMef8I6yW6OuqygaTsj3XBoTslFQKYAlhgam8psLyDc5OTtmF5nSKKfbJNt6jRwQ==", "62558c3b-1dbe-4478-8901-a2d9a9500928" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "231a85ac-1708-4226-ad6a-4f995a33a294", "AQAAAAEAACcQAAAAELvhyo+FO05/c7b9RsUOXInhKlhw0/oq206eJ0mzjm/KbryGWDQ1dnCW279C4ra1og==", "5eed21ed-90a9-4897-a77c-597a61f12b10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47293b6c-d257-4408-9ff8-55e3400d7bc8", "AQAAAAEAACcQAAAAELe6y/uTtBobltjMZenWDRKzYahp+UG1Tu1G8iy+5LNLweTixV/L1dGHe4ejZLWKiQ==", "e5e77bcd-f584-439e-8462-3992518746bd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367f4b16-692b-47a7-922c-83c3d3af055c", "AQAAAAEAACcQAAAAEAhKNd3Z+ojpj2sSTF00ZHbW3CZuUMfU/SOU9eKhIa+8FH6YzBf4atbCjHkBSbCpbg==", "f2239114-f2c0-4097-bdc7-e1149bd3f1fe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b604cf9d-9f07-4df6-8abc-c44082a5218a", "AQAAAAEAACcQAAAAEJ4exJXZkaCz7KkPIdM/THEKGbt4Z/zhV0uP/9rtZH1mFGmG9T8SyYlDOQQpKga7XA==", "688019fd-68ee-4538-b86b-e451db130c75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca9b215-ecea-4881-81be-c41367cbfb36", "AQAAAAEAACcQAAAAEMf/dzlFUEUVQD853ujG9wvCGNlEfz4zyPHitHVL8L7euDJ0Vd8I+8MyW2IpucqkTg==", "5b66a583-828e-44a3-b3af-c673ac0bfef5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e383a5-3cf7-492e-9ad1-338cf2362143", "AQAAAAEAACcQAAAAEJDA6Xg0+xmfy74u84dQ9FP0htmZNRZpQKysHrjESeqM8l5DEpVSlltpRry4IIHyRg==", "2c8a2cbe-ff03-4c15-b74a-7b08fb3b4e29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "047f2be7-1c1f-490c-874a-31b0c15474c2", "AQAAAAEAACcQAAAAEGR3Cc5UMTtdSTop0VD75PSQrJSQnhYYihEJdDT3MymlJwrDLFH/NK7kBDwc86O+fA==", "f7751473-8828-4e92-9f50-59b47541d0dd" });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(3389), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6692), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5635), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5648), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 2, 15, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 2, 15, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7228), new DateTime(2024, 2, 13, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7229), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6324), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 2, 13, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 2, 12, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6347), new DateTime(2024, 2, 11, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(6694), new DateTime(2024, 2, 14, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 2, 10, 14, 6, 20, 81, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(3836), new DateTime(2024, 2, 10, 14, 6, 20, 95, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 10, 14, 6, 20, 82, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5911), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5921), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5938), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "217145e6-64e1-4b4b-9d6e-bc24253eeae2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "133d700b-616a-460d-840b-dc4422231bb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "07717510-994f-4f0e-8fa5-1b1f283346d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "574d62aa-f38f-4884-a988-4f493106b5f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ea6ec734-dcf4-4819-af61-227a32b547e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "202fe52e-a026-4257-a61b-1d3fc355c6df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "36be63e8-f629-44c2-b1fa-1223549d482d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ad13ac80-f587-47dd-a344-2b0b87905d9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "f5672ddb-47c2-4853-a030-08528eef9142");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "0ea1fd11-3c25-4225-8a73-5f0636e2fbd9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "92986cf1-20ff-464e-8c2b-ffb3e0ef6eba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d48527bc-51db-46d8-9b38-746c41cb8479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "6589bbc7-3169-4f3a-8cc3-6917329513f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "13cfb5a5-ac7e-440d-9e24-77c6a5df7edd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "364b8143-d60c-4540-abef-cff7054cf707");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "742dc0fb-8029-43ca-92b3-d8e43d260f41");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "596d2949-3270-45ae-b13a-d56dab2292f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "33dc0a80-d0b0-4499-a1d9-5161a0be002d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "7aabb3db-7d50-43c2-8cfd-9300a802a0a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "7bc64158-53c4-4cbe-8efd-165ff3c09ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "69d296a9-3917-4009-8fbf-9fb296daf88c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "bf4fa51b-0c4e-42ab-bbe6-ae1e33b720da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "17968609-e989-4f89-a9e2-6af8a516a541");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "3d51218a-b51f-4158-a9ed-664472bbcdbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "1f7be72d-7313-41da-a70d-1c59953bb5d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "c0d55f15-2cc9-48a8-8aba-6b3ccfd3b82e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "98280ac3-7e4b-42ef-b35f-5b50d8b80a71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "f8444bb3-b059-4e7b-86ad-8940c0e39e3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "c9c85a72-91ac-40a7-aaaf-cbfd495999af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "a64476b8-8927-46d1-8bf4-79feeb7d3d6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "9862a960-185b-4ee7-950d-24fe06eea983");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "b9198d38-276a-45dc-aef3-72ebbd4369bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "abd627ba-4304-4473-a08a-3a0202984396");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "b93586d1-827e-418e-b856-51ee2559f200");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "1088d9ef-49e9-4ad2-9e82-804ed4c744fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "151126fa-b090-4659-ae77-1886ba4a7e08");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "84d3410e-9479-468c-8ecf-7bae7b3ab647");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "6ebaf30f-d4f9-41b6-88d8-62c6fefe76a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "d4ed2c38-78fe-45be-8c02-bd90d134d8f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "34b87877-d22c-441a-9c38-68497253dc5b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "962805d1-462b-482b-b8b5-b0071cc6e368");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "7616398a-91b8-477d-9623-de293986b2c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "c6021f12-bad4-4dca-ab33-e471f63cb616");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "e847fb16-7113-481c-b207-002239ba0d55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "ada01ef4-46b0-4039-b14f-0501fbd7f7d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "31917909-6df3-4f7e-be98-951da344fef5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "decf0392-0f8d-4fa4-8b84-e548f3a58d79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ca0b64d7-dbf4-4b4d-9d68-7d2d3a5f5537");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "1686808a-fb19-49c8-8f32-b4d6568da84e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "0ff9e5b5-6f99-455c-b1da-8c960bd84b13");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "15fc39df-1bc1-4c4b-8a5f-eb8846afe280");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "e4a5309e-411e-4015-95b4-dd2d9a32b3a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "bbc94df7-99a8-4153-b424-a3b35595243f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f64c17a0-b1fd-4918-b2f9-742c5852b23f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "d79536f3-4f3a-4bf2-930d-1c7de131a3ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "adc83f12-7f80-4a4c-8f2a-c7138d66f3c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "32ef0712-fd4b-4a2b-a93c-f05471a22a47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "b3b23fb3-827a-42b5-9bcf-3c4bbf8a6dcc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "fbe51c11-2404-42fb-bf5d-178064bf036f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "2e9309f3-272f-4e6a-9795-8823dbbdd95a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "3b25da8e-4394-468f-bff5-33d55220eb5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "ab14baff-4090-4052-963f-2138e7c378ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "5f056cf3-3af8-49ed-bff5-49034e157a18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "553dc579-918d-4450-a83e-0e4d772c2280");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "b06f3e5c-1a5c-45d5-942d-63e5b248c94f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "489f343b-bf83-4391-b229-223f1a22f738");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "09232585-faae-41e7-ab3c-3fdcf08a0051");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "f91e7b39-4ce1-4f02-9e31-f104a31558cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "d9fb295e-cc2d-4ebe-9ee3-6125afd9b4fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "d1628867-5250-4268-80af-e9e939b77f2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "7132d049-bdd8-4ffc-b26c-5ce159a7fa88");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "d551778e-ad92-47a8-8ff0-4409503dfcb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "8794d93e-e0da-4e82-a822-433241dc0fcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "cdbaa625-cfe2-4596-b4ad-d53e9a332db3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "b68c2df5-52c4-48e3-bf91-7f97e1c03ca5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "209c6632-f127-4f0e-9990-53fc00d452d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "1558f9b8-480c-4057-bdc2-b67a7d344e05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "89bcb64e-76e2-4409-a476-eda68d4faf4c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "6d147bc7-c08a-4d2c-aa5f-ab91885b368c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "1746101a-78bf-43fa-806d-51f2a4d8b712");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "61c38a48-8880-46a8-bfb8-1af1f225a126");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "0151b087-4a74-45d2-9077-25abc3f9d663");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "8192a934-4e87-40bc-8ad8-9a31c6474f76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "c092f222-ca33-46c9-98a3-b0ae2e1ac003");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "a44d2613-2202-4a3a-b560-bd9e9de7b881");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "c6a4a70c-e45b-4297-9ff5-ec5d69d5b025");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ea2a11ad-548c-425e-bcde-9b46f616bf2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "df1a35b0-371a-4c04-a3e4-027039f55e43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "566d5870-b076-4481-a57f-c23d088272b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "f2df181b-be93-4de9-a37b-dddcfef7d634");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "13936c8d-d1cb-4a4c-98f2-fe8f625adb5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "611a4eec-411f-483c-bac8-ffa526687e01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "5e21ad48-6f74-488c-8e41-27f23be35d99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "6a0a34e2-282d-4d49-863c-0d097170e0a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "f749ff12-ed37-447f-887d-bf2317bb4500");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "828fc7c5-5bc2-477c-a8d8-e05e82965cca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "d5147156-0743-4660-9d16-5645d5e4c571");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "88f03f96-ca03-4f0a-9f68-6a674870d024");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "bebcc65f-7544-40c5-acb9-330bf1871881");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "abcd8ab7-1cb1-46b5-a8df-772000bafca0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "8125c348-ab5f-4104-8cef-f3a80934adf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "b73978fb-27b4-4d81-958b-edeaae88dae6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "bbd9a099-6891-49b3-8097-3c53ae9f69ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "2ea0bff7-c0e6-4216-9a69-b554cf8260d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "87145165-89b5-420d-bae0-d7140fc4277f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "c26d90a7-201f-432f-9157-08b8eea78485");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "6caece13-0f0c-4f57-b5eb-864eabdb18dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "15afdeae-882a-4a36-a591-ebfa5c125d89");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "efd4b09e-f52c-4b0b-a967-65c92a09f532");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "f93db391-6fe6-44ea-aece-16cd08d38a1b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "77b88731-024a-4623-952f-d205c92e099f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "9b726163-a5fd-4321-9db6-b70bd69fcbf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "d43a74e6-768a-47ae-984b-05784ed3d798");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "3c8069c5-8514-4583-9a0a-8726d7d92b15");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 2, 10, 14, 6, 20, 96, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6376), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6384), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6387), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6393), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6395), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6397), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6400), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6402), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6408), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6436), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6483), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6490), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6492), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6514), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6506), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6569), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 2, 10, 14, 6, 20, 97, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6029d6f-4738-4b85-8193-05190113027b", "AQAAAAEAACcQAAAAEJHEUankP4fNln4TaooxE7V7+OxY/tWTW5+dTgsUrKU1BftWVG/f8HPG7y+uOftd9g==", "b71769c9-53cc-4e65-91ac-d7063cda260d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "849b0bf1-378a-4ee7-9b4c-be84c6629f5e", "AQAAAAEAACcQAAAAEC7yEH/sd2zVgK8/UYrGLoxNC5hs+01quZNT51To4hFw/Zvkz16/q6UeLiqFPvhOdg==", "92240225-480f-4dfd-b8b7-616ddac4644e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aaa995d-ffc1-488d-a5f4-d73ee6770fc6", "AQAAAAEAACcQAAAAEOy3V4KG4wh5laxNjoInVSdvU8GJjc/5Dskbmmew5R5GMRC88s2DigSu7VRjSet7LQ==", "e0e50094-fce0-40bb-b2f2-e55057ec0b18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4315775a-795f-4752-aa68-4fcccd191de4", "AQAAAAEAACcQAAAAEFsnHw9//hstVx3GF62aJtGPkb7/RwBZj9D6Q+ocGqn7ufwn3VqbLkqdKTzqL+UaAA==", "386aff34-6ecd-428a-9f54-65897f9824bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147b3e7e-8bec-4edc-8ca9-4b01924886e3", "AQAAAAEAACcQAAAAEL91UfMPAqYXwpHl7CD9JWCc2cyRMErQ2u4eQHDCGJTnDrO+5LfFOr4r1+Tzt8Nx0g==", "df0a17fc-b52a-4032-a7b2-f5d1426836ec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8420e3eb-c768-4280-b51b-eb9aa62af1f3", "AQAAAAEAACcQAAAAEMyUP7Y36+8K+h5NF+6ecl4QxMJ0M1OlqPophyNV9WBGIBdT5eRH6FiSQD9uDclO6A==", "368adb11-4d3d-46f7-b365-0d5d9c12e586" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5ab9a70-8633-4ecf-9683-10efd3340c34", "AQAAAAEAACcQAAAAEDkQjUKfrou3vUtoHPoFS48/E99AviIj0WKTOgfLxKImFFRkP/zjIEn/UyjD4lulJw==", "9ef29505-efc9-449a-9144-bd9edc7e74b5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9934f47-345b-4238-9458-b8c633bc5523", "AQAAAAEAACcQAAAAEHo7+i/5Xx39POLhjZAMuUUVtRM2V8SEA5dHm0s9meWcNo8mIBrWYUFeulm/cJW20Q==", "e8565794-1562-4777-8af2-b2d822ed5f87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d744841-45be-4a4c-ac3c-599af403005f", "AQAAAAEAACcQAAAAEMmpzz3CL/uBlqVf9C2RiIbG0U4NzOpzy++O7w9gZkoPT1axpiCEZKTvNvxrvf/Kxg==", "6f8ea38d-3bd8-4c17-8953-eb3c12582638" });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
