using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class AddSaleEntitySgkIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SgkId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 486, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 2, 4, 16, 53, 9, 486, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6093), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6102), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6106), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6110), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6110), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6121), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7296), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 2, 4, 16, 53, 9, 484, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(9798), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 2, 9, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 2, 9, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 2, 7, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4893), new DateTime(2024, 2, 7, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 2, 6, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 2, 5, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 2, 8, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Parameter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(2841), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 2, 4, 16, 53, 9, 500, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 2, 4, 16, 53, 9, 485, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(5817), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5459), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5470), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5472), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5478), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5480), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5483), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5486), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5488), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a93ac3b5-2805-4b7a-8821-1e844ee2ff74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a3c7b421-937b-4280-ad29-1b4949c4cc9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2779376e-e4a7-447d-89a0-d1c8c27fa448");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "099f1151-6f70-4e27-9510-8b460d54f39b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "28c0927f-0628-4996-8beb-589da55f2c84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "66e66227-3442-4a42-abe8-9664d0c5f5a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "47e268d8-aa50-432c-b3b1-a05bea81db15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "7dab3828-f4be-4e1b-a131-0820368822cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "3c9a7fa1-60f8-4df9-9251-bd17a309b66a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "7957e0c0-8970-4ce3-9fae-b76e44ae8196");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "bb006eb6-05b7-47bc-bbeb-15cf96695300");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "04eb7fb8-9ee8-4693-9b61-80facdf9182e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "5d4e0478-0217-440a-ae61-2c01e6d5595b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "ea930fee-ec6f-473e-b4ed-77e9daa51d0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "4b17a9dd-9cbe-4818-a217-b1e68ea5ba38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "523bf9a9-3b83-4845-9828-ebf14c22faa2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "e6f0fb72-1bec-4bbb-960e-f51789de29e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "7bdb382d-759b-4759-acbd-2308656e5ff8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "d6dad511-127a-4829-adbc-b732e20eb913");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "5223cec1-4db4-4811-a3c0-afd029cf3bd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "243f3976-d549-437d-9d9a-ec8cc3d252d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7eb5fa4b-e9b2-4a03-a091-55f9728730f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "5d4cc0fd-fd6e-4228-8b8a-e3226f61534f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "50876e97-4127-46d6-b2b3-9c80ed5e4bbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "024bb59d-1d18-4acf-8d6d-dc08f4394c37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "12116d17-97d2-4f47-922c-6c183c9ed647");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "bc649466-5bac-4cc8-b807-0160cc1f27b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "9a38913a-0702-4a2e-b64f-b58b40804d3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "f9c8619a-1c5d-4e14-bfb6-26217a5fbfdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "41486c20-d916-4578-8a91-e4c1ac12840e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "644f3705-3ad0-4642-b036-a367cc8ce5c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "4f374585-2ab8-4ade-8bbe-71967e34c280");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "28733bcd-2a50-4c2a-acb3-7939a96c5b88");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "15b9e1c2-53c6-4949-9ce1-05610ed584c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "3a42144c-48fb-4daa-b46a-70539251be22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "3b6940d0-74a8-460e-8e99-fde5352f18f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "e4a3981d-9f4e-4192-9218-2e9b57c96217");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "0fc914ec-f1f3-4e41-bf00-fd98f272c8a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "cb14eb62-6a6e-4688-bc83-680b90414a75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "ca3f24b7-c7dc-40d7-9cff-9bad8a9302b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "8d27b414-1146-49e0-9b59-a24d33c4c4f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "58aee083-7647-4856-a046-76a34d8a730d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "cad06d2a-066b-4f99-9e9e-0fd6417bb65a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "8ebac9a3-6393-4d1b-a8d2-b4bf558ff695");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "f7e03234-00cc-4e83-b7e5-dd090448ffc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "4f5416dc-0dd2-4c5d-bc53-4d4f413c5b52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "3d7fa2e0-faea-4f4d-9cca-c2d45fa26e75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "3e43d5a5-68f7-4746-a35b-533b10ec9cd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "83118283-732d-45bb-9387-414eaa6d8227");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "defe22ab-28ca-429e-913b-239a7ace5cd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "8ee451e6-0888-48a5-8993-cd592e50a2a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "6b039aef-b929-40db-8726-0d4cd5dfe97a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "bcbd73c0-695c-440b-a343-d213d9353a2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "f444caa5-0449-44b5-9380-1efbc53cfb3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "2c54b4aa-5760-488a-9828-36c0762648dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "e3df0ac8-ea5b-4c55-9ffb-ffd1da5ccc26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "a3835896-7b5a-49be-8dde-275f6fc7e3cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "a98fece0-5a63-498f-b74d-8cbe7959cd84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "720ee1b1-910f-4f78-b561-a405437a04ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "a7a0cf9c-4ed7-473c-842c-144f8aba68e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "516e5b0c-204a-4c54-be72-f3d08ebc0614");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "4fbcfef9-0cf4-407e-8a69-8b43b77c700b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "9856e4ae-e53d-4bd2-8f35-460226e0fd92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "cf96562e-40dd-4776-8709-322a9631971a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "c3e5519c-deee-4486-821c-4aa2c1eac7bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "17b6560d-1bb5-41fd-a248-3130ceac96ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "77461bcb-7ca4-414c-b1c5-ad2174b92e02");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "f9345c86-84a9-4d88-96c5-b9b251705ce3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "474dd833-7b70-4a5c-9039-0b25b515adc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "39f7c961-c699-488d-b585-38807a069fe1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "371c74a3-aea3-4595-bc60-56d3ab0b8cad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "fa3f600d-8e6a-4f37-821d-85ef9b4bda68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "adda0493-8ed9-4a81-b206-604ef3ae3a9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "0c94e75b-4bbc-4450-bb51-125db2c95e74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "9d9e3aa1-1472-4950-a7b4-5d3eb75dc1a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "61ceab3e-94e1-4f68-8c8d-b2facd5d9db0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "e6d2f2d7-464d-47f5-a819-3dc25260f997");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "68b8800f-ea6b-4fe2-8b78-a095994df0c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "8fb63298-b497-4205-9212-ec5fad5aad74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "d1d47233-3a4b-434e-8e37-b30579a3c610");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "833ed15b-2e4d-41e9-8f5a-2a3cf6e77c64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "d68be94f-d4ee-45f9-9a86-6e27f1e46dd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "27a07b5b-fce9-4dbc-a37a-c739ce858d5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "5b49b34f-dd88-42d0-afa9-c5f94e73e3d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "cd0372c2-1d70-4734-a769-6abf70f8b185");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "95c1d37e-b832-44ce-aaa4-f5d9c4fdd0ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "e8f05220-e453-4917-80d8-df475180de0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "331abdc7-54e7-4867-89a9-968ffb567ccc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "15029a12-6834-48ef-a097-2761e8e83731");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "6c49986e-53ab-4c8e-b3ed-f942ebd3addd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "6c160c85-3729-4185-94cb-31361b334a48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "0f1ffba0-f093-484c-8716-c8238ce0d6b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "eb38776d-103d-4113-bda3-4264bc5efbf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "c107d8b5-650c-46fb-9560-a081892c9f03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "b9cce637-e66d-4470-ab68-5383ed166753");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "55664a19-91c1-4430-b86f-a437150942ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "9e1c3c1b-6786-46dd-9a3a-9e22d20edaa3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "174346b2-72a6-49fc-a124-3858fa7c5926");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "a6b4f606-df1b-4bbe-9c03-37218eb42024");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "9254863a-18b4-4445-beec-7a299a78221c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "aa277737-3798-45d7-bda2-9a9c288f3686");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "9d7476c6-1941-4245-a7ec-42ed2605d15d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "b7da2718-0c0e-47b8-9a6d-8f03fed01d44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "580cc20a-d71b-4f73-802d-6b14941e6a39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "a8494258-323d-4c70-aaf9-0e1242221e42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1687db5b-0f5d-4793-84ad-efbe2df24ee2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "a80d8689-84b5-41eb-922c-9a9e9ff8b013");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "64b77761-e4ba-4500-ac9d-600fa5a2694d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "8cc98ff6-5643-4e66-a60b-531df7940846");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "84b5d2ce-b962-41fc-937f-2eb6585167d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "a54df619-c1b6-46ee-bbea-d15844694831");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "a7ee31a6-3cbf-4040-8c94-81210656d5c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "937aca5b-2cb4-4c3d-b150-a63a5a164212");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "74e5649a-e8fc-4062-b4b9-6a2766b66bec");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 2, 4, 16, 53, 9, 501, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6253), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6258), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6303), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6309), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6312), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6326), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6339), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6351), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6356), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6368), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6376), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6386), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6397), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6400), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6402), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6405), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6408), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6418), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 2, 4, 16, 53, 9, 502, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5bb0dbf-3825-4302-a70b-eb767b993ad6", "AQAAAAEAACcQAAAAEATDLQdN83U4deINMxSi3EVViTRsiajWLPJ+u9OH5N1woZZzYGWtJm0gXVnns1cBhg==", "78fe7645-3212-4b92-9ae8-c0011926dd53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e17ab58e-df03-4892-a86d-67d9d86cb036", "AQAAAAEAACcQAAAAEBMe8XRDrPwvuUF89j4MvuiFLo/x9CBTxWFAeowKBE0ysooU0v3FImk7LGW1gq6ncQ==", "738571d0-afca-40fe-b42b-94f4574178d7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec3a5e6-be65-46a9-ad43-8da49bc1b36a", "AQAAAAEAACcQAAAAEGrhnZ3nov5srcmouH8VF6ClAHVVe0I0CapsYdYQcBzVhSOskionxP5vw07LWicfXg==", "fe24dfed-80b6-4074-a50c-7c94acdff13e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2044ab80-9c56-4dfe-a311-7666b2e8f902", "AQAAAAEAACcQAAAAED38A8f2SIpyADpIzkumbu8RfYEO8+vDhH/az2zLaVRlQF4JvOGbh+n3qTDz5ViODg==", "a5ffcedd-ec93-4ef0-aa72-5279c2aa8bfe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b163112-418a-46e9-ba8a-7e6e628af113", "AQAAAAEAACcQAAAAECfki7l9MKuH8tRV1V9rVaTezAb8kaB20jWlBDzw+tTUFRTm6y/hfnWzcloToW6fEw==", "d0fe9603-6398-44ca-b906-3063493651bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ee33dcf-a7a0-4dc0-bcb6-13e57ddc4822", "AQAAAAEAACcQAAAAEKmZvD/4vv60gsQ/Bs9Ct+r2W2mjd7w+KiK6iW8Huo2F4dGBtDSSsEchEhGJSPfb1w==", "4d2282f1-e4b1-4306-b799-8d4f24ddd9c3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fdf9499-c7f5-481b-bd8b-1bc919f585f5", "AQAAAAEAACcQAAAAEDZZA+tr95vcSgzPZ+HtUsqMcLh0MJSKw7M99NK2fOHHB45NBSe5bB4HoJ17LjbTXQ==", "a30512c9-9100-41f5-a13c-57b0c36be0de" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9907061-43f1-425e-a120-b32742dc612b", "AQAAAAEAACcQAAAAEBDR5juG7+w3MMyFnjDNl1BBjEA1uG9ANGLtT0Xf7x6DKhAGTLzYvM5wYO0k6vgMnA==", "ca29c71a-1325-4de5-bc96-3a827d0b300d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26ee8451-6da1-4605-8d24-430ceeb17eae", "AQAAAAEAACcQAAAAEBPXzpblD+9nFK9umMtdJpTUc/0PwcpDhBJKyUrxEz06h9In9FQu9XfvEZ6PMfralA==", "73ef0270-72a5-4e42-924c-e3e9285fd9f2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SgkId",
                table: "Sales");

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
    }
}
