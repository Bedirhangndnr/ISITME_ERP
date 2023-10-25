using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brands_BrandId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 850, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 10, 25, 23, 8, 7, 850, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1027), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1026), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1039), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1045), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1057), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9320), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1761), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1773), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1775), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1782), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 29, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(4501), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 10, 30, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 10, 30, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 10, 28, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7959), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1967), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1968), new DateTime(2023, 10, 28, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1979), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1979), new DateTime(2023, 10, 27, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 10, 26, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7141), new DateTime(2023, 10, 29, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7145), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 10, 25, 23, 8, 7, 863, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CreatedDate", "ModelId", "ModifiedDate" },
                values: new object[] { null, new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(8701), 1, new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(7065), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(3385), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8480), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8487), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8491), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8495), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "045d72ff-d198-4da6-b2e5-5d643d62cedc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "88c27001-69ad-42e3-af66-fac3f79e60e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "154a7a73-7133-4cf2-89f8-6a6939cf8022");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "4ffd2ad8-c3b9-444d-8123-6070b716e749");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d99e60bf-bc83-40ff-8051-ecd5c30223ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "ccfc6e52-2957-419b-81f2-75be8544595d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d0c18569-a830-4d97-9f36-a20254c353fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ff8192ae-2196-43cb-a72c-55842908aa52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "4b3e4ec1-a3d3-4ee0-a46d-b6009d064db7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "5d5cf708-0bbf-41cf-b0b0-57843a456fe4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8c196108-c72f-4048-8a90-7ba0a9c99fbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "e8b9114e-9939-4276-8570-d62c2c868b75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "4c10ea34-0fbe-4441-b0fb-a324577b89e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "9296f1a7-648c-4784-9972-a6f1b2bae5f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "5b5903be-88d3-4359-ac50-dad4e82c614c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "a794e17e-48ad-4b68-96cd-a37ffd88dc68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "1528e76a-119d-4ae4-96f0-2a62b66c5d4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "fd71920c-4120-4cb8-a9f4-91d9ec0b0874");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "dae7691b-b88f-45e7-9bd2-2e46a43efeaf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "ca5cb889-3f23-41d8-8bd1-f596ad939df7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "395f3cc5-27a1-452a-8a1c-a7e4808dc25f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "794de873-b19e-4042-8d35-44f99741a6d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7423fc05-c4b4-4adc-b1a8-109489c9aa44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "2eae1b17-9a40-40ed-9513-49ad8d4e08bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "01697c4c-aa58-4b96-b8a9-202e2f56cc3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "d57596e8-cd71-4a36-b912-8f59fe975cf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1219e9c8-c510-4368-9e21-5939228f65be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "423a5580-dcff-4fbd-babf-ec54846e143a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "605d1ab4-4d37-4f25-b14a-2f9c2fe7560f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "d63d6991-4a6c-4a63-98c4-349e7e5a6ed2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "a3a95613-ef30-46ce-9202-0e236d794744");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "2b975e42-026d-4779-b70c-b0938b152bba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "4c373701-3f40-4bf4-b9f9-5490a9d74c5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "5365cb63-f4c7-4421-a436-04a97c5b4b47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "3915f5c0-1812-4cc8-991b-9c26f73de02a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "e0969c60-9196-4111-b501-3a5e240875da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "5f9cf01f-a0bc-4851-b5d0-72ab21b58dc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "c69a215c-ce9b-46ac-8a87-e43ff31eabb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "313664bd-3778-4392-a751-a3bb1aae8e86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "c01ee2d5-ed6a-45cb-9158-3d055eb3e652");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "06fde827-f225-46f4-b8c9-240682e2f808");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "ce2c94aa-482d-4cac-b799-5c28235d5dc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "30c7bf94-4ed9-4e80-a943-9edc52687125");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "ee2c33d7-b91b-4cab-a89e-d3829d068351");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "987902bc-4b32-46d5-8acb-12a180563b63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "df5e5bf1-aa5e-4992-bd64-03c68793c300");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "b7ec1fd3-fd96-445c-9776-fad9ad059f0e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "7e38ade6-00d9-46d5-8c1d-e90bb67b44f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "1aa66ffd-bda6-430b-bc88-7f6fb111fa33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3b868767-b5fe-49ef-b358-3256f3dfb332");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "87146720-8d02-429a-9731-5253ccfb46d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "d04009bf-ab16-4d7f-a541-049f8f72e36d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "3f33881c-d74f-4cc6-ad72-da98d6bb78b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "85ba45e6-be3a-45a4-8ad4-70dc47d03224");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "caaa6543-164c-4455-97a1-7ff831f281fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "fc5f56dc-302c-4673-99ee-2f6b7ec011c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "095f0ce0-7a26-4941-aae8-f9b675b9d0e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "5e5159d3-19ed-416f-b256-5fb0ee9c2a2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "30841fa2-200d-4eca-9f59-62ecd0cdd1e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "1fbebf91-3530-42df-9011-439144c165c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "a165903c-7294-4737-a6c2-f0702acd267d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "50e0a6bf-eb50-4d45-9a66-86dd2c995269");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "87d8a6f0-594f-4a2b-82bb-463a5685bd71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "1b2014d1-032d-4509-9a3a-a4141fc9cb30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "e97a12af-7861-4b00-b2ff-ca192160ea9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "c5c07f95-b12d-4b62-8022-6f762955240d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "c9420540-aa70-40c1-aceb-61876615b6e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "36d1f324-57db-45fe-9b58-30eb93c1faff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "72c238a3-15ff-4922-a5da-69b43d3ac4c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "a6133707-cc17-45c7-b716-6c1ef1686f59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "8d7e79a0-389a-4276-bbb7-6b51e745d5a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "f48969e3-9dd8-40d1-815a-cea229fe7cee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "d86e9f16-a1fb-43f2-bb9d-07105419c84c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "fcf7cc93-6fcb-4705-a920-4c6e46a34b27");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "c2ec9f21-2859-4e53-9602-394333841d50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "822321d7-dbc3-44fd-8ee4-59d59d8345be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "4ae498b3-0360-4e4c-bb20-70599bad31b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "8b80007a-b9ab-421f-ae1a-b230be61672c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "8fd5b825-fc59-4396-ab17-fd1ae0f19ec0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "0351b6d2-1d31-4061-ba58-55726a0125d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "76691911-adbc-46d1-8a7a-5139fa5a62df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "d61bfa6b-14fe-4d5f-9967-3e20deb074af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "20f47cbc-e89d-4752-9570-347986e16c9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "8f0a0689-2ad9-4db9-afa3-03784977742c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "c305b64a-90dd-4068-9596-327757a00774");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "a3b46230-fbc0-44ce-bfd8-2d00554f1642");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "4aeff4fe-438f-4698-a44b-c1bab1a150be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "86319368-5f29-421c-9049-9e69cd1810dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "42d0e12d-6a83-4430-9244-5219f593310e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "beb408ba-dcd0-41e4-abe9-4bbfaaa0d2ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "5c30f8f1-ed29-44d2-b8fa-2de6ebd49cb7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "b859baf4-cb74-402f-9d4f-1cd4d198e943");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "6d3ac7cd-ada5-4c56-b1b4-6c1bf111fcbd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "aecded74-9951-4034-be99-19545a265322");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "f47417fb-e7b3-4f5e-8426-eceb7f59be54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "7fff2dd0-6564-4cf2-9ede-4cf2447dd4ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "dafa7923-541a-438a-84d6-9a1b411fb6ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "cba5ad46-4a1e-49fd-8c1a-e3f6198b91d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "e3edb57b-aebd-461a-8292-f6051be1efd6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "3a258a95-3c20-4563-9103-6c9f8d9eb1db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "ce6578ba-9c92-4ae2-8f3e-3775c49bf8d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "e5fda07b-3b50-4002-b2e5-0aa3959cf217");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "10f88b0e-9dca-4339-b27c-d635c8c1b359");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "77de9f85-ffa3-460b-8ada-38b71ca0ed44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "13049aa4-9d3f-4d36-a1b7-a53b3cf8f502");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "0021db4f-af15-4e21-8c30-4fa490ed1bd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "b78da3d7-e47e-4ac4-b284-7ae30302045b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "5bb6f00a-2b45-47fd-91bd-c5d2febda17b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "358fffb9-90b0-40e8-b4b4-65188050cdbb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "cda8b8ea-d579-440f-b1ff-65f4c3ab50f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8a5a5a38-e891-49f7-88f0-3e74c0f30865");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "9a77d93d-0789-4bdd-9f1d-854f7bda663e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "68507851-e781-48fc-a215-0a04a6ce273d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "6696a680-8bf4-4173-b0e8-84dc05f937fd");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 10, 25, 23, 8, 7, 849, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9051), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9062), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9072), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9077), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9083), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9111), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9119), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9148), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9150), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9152), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9156), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9197), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9201), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9205), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9207), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9216), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9218), new DateTime(2023, 10, 25, 23, 8, 7, 864, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11140505-1db6-4f3d-968f-19e57cc04741", "AQAAAAEAACcQAAAAENRzPEkHWzNpRR9e/3C6DTeNEhmOp0smFSj2OvS3FwrbtkVf0U/r1Iusl9UgGW4X0w==", "c6cc961a-6fba-4526-9b5a-1ed10615413b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16bf262e-3ccd-4fa0-9d82-d35d256a1882", "AQAAAAEAACcQAAAAEAlEeIbaDwye6ngUIMXsbtprNOQvBPHDSbzkf/02Nsdb52nTSqiJk75hEW6FaAcY2w==", "f68b2512-6a5b-46f7-a248-9dc6f3f3ba25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fa82cd9-0a1d-4f37-8cc2-a7ff9fb5ed50", "AQAAAAEAACcQAAAAEEFhiYPSzH2IKbxcZ6/CW8oEcsQ3RIncutpaqFCElKrV+NBXpXrDjaLfQ3IMZpaxNw==", "acd92a96-8b12-40c8-b126-caff7b2b2e45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b98174c-b0e6-45e6-81e2-37d2bf22d7c7", "AQAAAAEAACcQAAAAEJ6UKC2olN3xdPou3N/I3DdITCY2HV9iFasdy3tv8/O6Q5hYS+Yf/e+srbZRlxonZA==", "03fcb843-ee5e-4d72-9b9d-d82eda2d9400" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5744c128-7e46-4875-b1f5-ae6c07b44403", "AQAAAAEAACcQAAAAEO/vvL4jHqoCJWU6YDNYuHpolVPnf68pGpTtZpjIZ8kie1ieVgIuIhTXrtoUSzS7Bw==", "8b091cd9-bae2-4599-9f0b-1572e895a30d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14e23b3c-1b45-4acd-95f1-ccb3f427d278", "AQAAAAEAACcQAAAAEEznn/HvYn6M03by+S2uG0RVwrJnCrrVxaxML+l1GCh9zEAq9OhHEGMbRv/cFaS1NA==", "db39fc19-d172-4aa4-a3f0-7d65680774c3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07f0568-3635-4271-8b54-8c4ecd9e18ec", "AQAAAAEAACcQAAAAEBFYUPZ9dsHCjZn03kXL04d7hLnkMxhd8qZX1IyfqjJBVhg5jZPpr71T9KrkhFIliQ==", "6394a9cd-028c-4da2-aab6-ccf940398768" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee4fabf7-2022-4e15-80bd-b7281c2b63c9", "AQAAAAEAACcQAAAAEH+CMZxSvUmluZQ+bm7w2hJGpbjQjcOiguaYYM6V73FqWATIzbc2+YmPVHqyCOcL9Q==", "a55bd138-146c-4cf5-9443-6dd40b527637" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6fd1ceb-9a5c-4977-8d0d-cef790fee7fd", "AQAAAAEAACcQAAAAEBx7SjiaaiMSszb450YUXE1A2gZwJSZ6l8cjQuhtsrjyNMgxLlNBb4O1lb8/WF5F9A==", "13e63eb9-e0e5-4c1f-bb5c-3f94c53e026c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cd25387-67c9-4d5c-81ba-dd7ed5eea05f", "AQAAAAEAACcQAAAAEIXBlj3gYbwAJkIGVe/HYAA7soYM1OIhaLhoiaWmZq3Olho3wZvJGwKqFZ94DAiB9w==", "fb5c2947-93e1-454e-9d34-d063469b9f46" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ModelId",
                table: "Product",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brands_BrandId",
                table: "Product",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Models_ModelId",
                table: "Product",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brands_BrandId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Models_ModelId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ModelId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(592), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4394), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6087), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 10, 30, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 10, 30, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 10, 28, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 10, 28, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 27, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 26, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 10, 29, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8159), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8161), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CreatedDate", "ModifiedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8430), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8432), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8435), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8441), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2805df14-876e-4ee6-8687-d44f28a781fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "14dbdb83-11bf-4ad8-b0b8-dcea3c19ae59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6ba33253-bbfe-422a-8e45-759ecbc54772");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "93f1333a-9477-4552-a817-24a3fa4f7b72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "837d2bd1-0dcd-40ca-b562-d95f3da88768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "b21e6d8d-4db4-4184-8c34-2c64623d6eb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "c07a3bdd-f1b0-4a6b-b84f-69e0918e75d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "7128a020-e3d8-4e6c-8d3d-98cc99a85474");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "5e6a77bf-2126-448a-aa58-c9405aabbbd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "fb40ed95-18a8-4ef9-a17e-c18e58649724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "78875cc0-b044-4ed7-8cc4-77672c3512f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "ed7adbe6-0d89-428b-a50d-75ff82ffdb15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "979f6386-ffd6-4dd6-989d-755a691e7aa1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "018036c7-e3f3-4a2f-bafc-a141b9980eac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "6f097544-0952-45e8-93b6-9dfb5739e510");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "542ec37a-ed28-4016-8822-4ba238d47ef6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "4c341c75-7368-4b86-b86e-d84944870021");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "cf385fe8-8dd9-42e3-883b-c4cc43ae102d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "c724bfe4-7d72-4a3c-9e9b-da6b929cb77c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2614e183-3373-4980-8071-7f5329619b49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "782c8374-c38d-4838-85e8-cd0a6e954be8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "79f66ff2-f565-4618-b340-c0b1a34716ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "06b86cc0-15d2-4083-bf54-ad04159517ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "f517518c-0f47-4d01-b27c-9911af52e2f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "af392e23-b772-4f3a-92b1-de2c1c022630");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "1aa3b4c6-3d05-454c-b36b-fb7ce8a9c0e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "293e9fac-74dc-4c06-95d8-8d4e465a4eec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "7db969b9-7010-4872-8649-6f14bdd12673");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "c42ac4d7-1dd5-4ab3-be1c-beb6e7eb69a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "13b01739-50dd-405d-947e-8764b5590453");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "9ebac352-192c-4aeb-a5a3-26d46da05e6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d316a0fe-aa74-426b-bb08-80bf58eff7e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "642f1071-43f7-47e1-a5f4-a10a8b020de0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "9baaad0c-580b-445a-bde3-26700b34ae83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "3660bf02-88e7-4264-aba8-f81a8a9839d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "3d7ab9a6-6fa7-4262-b400-702b04ca4256");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "a292895d-7b5c-4932-a75f-8569df682baf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "127bdc80-eeb7-4bc6-af02-6973712ec82d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "cfeac3f5-ca32-4835-91a2-243fbf88863a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "89bee32a-7b84-4ab0-bd9b-edbef754b90f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "69d6f200-468f-48c2-ad4e-7e72517f0e71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "099139b5-cdd0-4150-aacb-b7b8dc02db46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "5bd3ecd1-0688-4e8c-85bd-a1c877a4f676");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "89b72e64-8ea5-4ad9-a0e8-8b9a0f8c0c50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "89873c5a-b86b-4677-ba6c-cb86b0ccf7f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "1f5169a8-265e-4617-be40-db736dc51bca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "476108c9-70c2-4dbe-8660-472937fe5dc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "0488c735-abeb-42c3-a9e5-543e34808b1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "c65274cd-52d5-41b4-845b-acd0404851d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3d887671-c5f0-4d69-b92b-757ab8de905b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "b5194439-9f4b-469f-b67b-63b668e43ec5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "abaa6987-27cc-45c9-9ec2-f9ee66aab2cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "43d933c8-6d61-4a6d-8778-8584a5fc9e1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "7e580cea-34cb-4de7-a7bc-f45800ed3f68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "eb0ca368-fb80-4e32-86d7-8e9017656b18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "aa342387-ec1c-4e26-a949-e8585fdd01d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "4274955b-414d-4c56-a8a7-e7480c3e73c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "826919da-4008-4c45-892d-17d27df8d2ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "2472e5da-7ef7-4d97-a31e-3a7ba76e2416");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "16e59795-cf2a-4fa7-9a74-77ccc6426c52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "40dacb02-ba45-43fc-bc56-6ee35586590c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "19a582cc-4686-44f1-8c3e-7c08e9c19ce4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "81dda72f-09c6-423a-844a-b149ec2b2e47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "25cd94a8-369e-4dae-8e75-a354a05a10f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "05dcdfac-8bf4-4006-b715-4224873686de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "139f79a6-775a-4c61-b235-f430775e79f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "d7fe50c8-8d51-4e02-a8f2-7829602e52dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "d23eb6cb-c5e6-4e34-9f4f-5f77068343b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "bff4f045-ac11-43a1-b06e-707646c25842");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "1f62e70d-15f3-4e95-bcc4-97ec9a57e821");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "f91e523c-ce65-405d-bb11-123c7bf4b085");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "5033dfc6-955d-44ce-affa-9644763c0749");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b6f50f29-fa37-4779-bfd9-8f86cdd15764");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "01ba9ad1-372c-4f76-a71b-40f13c6b74bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "4c207f74-9227-4ae8-a550-6716dc28c197");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "c8db1698-cbaf-4547-9393-96205ee66bf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "56708a6f-c4c8-4d0a-a5ee-d639927aecb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "0ff1e88e-a3fd-47d7-ba4a-90d192914756");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "7252eab3-f604-4aa3-99d1-7c916a98256f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "15eb94ff-c25d-4e6e-8480-25799191cf47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "18da61b4-a95f-40d7-bdb0-3572a472ce81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "3599c55a-362b-4b91-bc6b-d1b7e04c4e18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "885cf140-15a3-4703-a43b-4476facabfc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "0c3ddfea-0d8b-4773-8908-69cb24a3a1af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "9f2089cd-d0b2-42ed-a6ed-294ee4452477");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "6c702a2c-1ad7-49e7-88f9-789185d34f5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "393d55a0-8b93-4457-b0d9-63947e89fcc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "2116f1ec-45ca-479d-81b9-9a38b324f936");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "79dc7a69-5a64-4458-828c-f0efa1391ed9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "6acbe2b5-c0dd-4a37-b24d-f78d194eea54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "045a8dab-c1e1-42c6-b608-bf87f736b839");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "c92817bf-32f1-4e5c-bb58-6c3a10cbfd4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "22ac87f8-3deb-4dd0-a724-7fbe8c551422");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "ddff1e36-c387-4c49-a315-0b6414bfb1f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d640fa1c-e7ae-4467-b2b8-f212d0068bc6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "ea986713-c01e-4499-86e0-261fa06a2c8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "040691cc-1ea4-4ce7-ac03-5adfeb88fc39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "6ed55397-495d-4cb9-978b-1c2a0ea83984");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "ebb1f15a-fa99-4b94-b402-3f22d68c62b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "2dacec5b-5d1f-4e55-a797-d309a67279f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "bc49eaeb-0713-41f8-98e4-7219ec2811e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "020bff71-8d84-4321-b227-1d6a81615486");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "0a3adc3b-3f67-41be-9e84-ac8fa15b0348");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "73a7975a-728b-4d26-b25b-199652d092a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "f6b3efbc-0982-4b7d-8a1a-b17636cd3dc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "da1d70a0-9ff9-45dd-81d0-080e507f2285");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "c7ae06a5-e035-4eef-b362-efd248fcd60f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "ba011f4c-1df4-4a71-a6bc-68a70675657d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "be531be0-e519-4945-a662-6f2d1de21823");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "e7837788-f3e8-46ca-9035-8531e56f1286");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8046d9be-03fe-431e-b9b3-8765a8af8cbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "506ffb2c-4f73-42f8-9229-4a5dcfa4bd81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "91c165bf-c1e6-4da5-b094-dfbc725c1eac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "c3c5f510-14e8-4efb-8da6-2e43efaf2d18");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9014), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9055), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9057), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9059), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9061), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9069), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9077), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bad823-f804-42eb-8b65-ac5088a22fd7", "AQAAAAEAACcQAAAAEISYctpY+CPW2E5DWHFq8lhg0izfRxKqMvY6hgzcFhIv0nQmvXfAbiUkRp1RDJ1R1g==", "8bc61808-5ffa-4f22-b210-3ddfb50ced03" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f8be56a-6f9b-494f-8c61-994b4e9fc97a", "AQAAAAEAACcQAAAAEAC8wDA81vogDYjkrWL7XGMVdG17hWpBxNoja3f/pTwomgrRZMV410XDVSnrm+AIXA==", "3678a157-eaef-45bf-ba88-096a82fd55a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d3cc645-7959-447c-b806-6858f5f30a3d", "AQAAAAEAACcQAAAAEI9k/cPjFOd0BlHNHY257GE8y54qTn2GOJ8GajZ9muoOZbTWT8dJvTTboeJutG9kdA==", "d99c1a78-ab05-4290-a01c-ba36fb0d929a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac7474a-0f79-4a54-87a4-39502c1726f7", "AQAAAAEAACcQAAAAEK/S1cSlgxc5IGiuHXh1ltU3G2JaipaugiZLVoCsPgxiMctriExM9ld78c6yqLY+CQ==", "8fdce411-b297-4990-aea2-ab7ebfe18b86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8eca00-1cfc-4f9e-9ba8-86684580c13c", "AQAAAAEAACcQAAAAEMa6uR/nu5LdNMKkyknb8GdAbs23556/pUOSdZMIaD3ej/GIrMFBwpFt3o3QVMIB5w==", "25fa0068-b558-415d-bf45-874553c82ee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60dda227-7a29-4857-9721-d2c0ca17d3b9", "AQAAAAEAACcQAAAAEKG0HpPzXkdmsjFH3a0HMrwtUwOoMyitvsO/JY20i/RmacTNKjBDtOJ2ov6Q1AtbIg==", "d8d6d504-8f2e-4204-a28b-0d63b3cf219a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd97fa3-1946-40dc-9778-0f7c3ada12ee", "AQAAAAEAACcQAAAAEHcNRwXdFJjbN6slKyVsHdkjyBJFZbNq4PsDQjQuSARmmxIIwz0IdzK4tRmCwQJ51g==", "ec88e3ac-b723-42dd-8906-28e52f598912" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d1d084-42a5-45a9-ad5d-507546af857f", "AQAAAAEAACcQAAAAEO7dX8fGpLyhedtkzsHzmPYTuLdjxJE9xZQwvxGy0Xt3tZitQTdpT1EObcKblvLxDg==", "9a0a67df-1026-43a7-9d8e-ede15f85002f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e33d28bc-5c1b-4a4f-bf35-b723d02e96c1", "AQAAAAEAACcQAAAAEOt5kaJQpuJUDUAmW7W1Z7KD4jWiM+ECdCJxFlrM3x+EwFIP5mcVshfNbTHLPXlO/Q==", "b736256e-57ba-4bfb-809d-91c4896606c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "912e549a-0c1a-49da-859c-0802ed4d79ff", "AQAAAAEAACcQAAAAEG8vyB1RynSQX03ynQyLErBIZHt6nAewB7Bb+1N/ZEUEDj0GQI/gxWS3714ep5GZPw==", "8ee643e2-1a6d-411b-9641-34532b7209d5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brands_BrandId",
                table: "Product",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
