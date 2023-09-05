using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class newTestDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(738), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(742), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4701), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4415), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4421), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9749), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(8455), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(8459), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9437), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9442), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9948), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 6, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 9, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 10, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 11, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 12, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 9, 2, 14, 0, 45, 819, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9567), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9861), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9866), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9872), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9887), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 9, 7, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 9, 7, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 9, 5, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 9, 2, 14, 0, 45, 832, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 9, 5, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 9, 4, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 9, 3, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 9, 6, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 9, 6, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7232), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7236), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7242), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 9, 2, 14, 0, 45, 830, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2009), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2014), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2021), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(3912), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e009dbda-0e5e-43a6-9a3b-d0e363dd8d8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4b08d0a2-8f84-4d63-9d5f-0e2d0b7e6045");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4dc4c629-43ec-404e-a3fc-8150a0031418");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6f363700-0afc-45d7-8538-718aa32f293b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d6feff45-a86e-4d8c-8f5b-fa010692c22f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "ee520d8a-42d1-4d84-8bc2-66a8fb9b3525");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "6d46de3e-714c-44d9-b49b-b20123430bd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "02e4293a-dbb1-432d-b8f6-588d271c21ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "58cb55d0-b1b1-4fad-b104-62a5612f3d6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f2c68c4e-f504-486a-86c8-e9f119bfe12f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8634d523-1f08-427f-b43d-586f10a984ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "71b3ca26-c87a-4f10-be0b-6837088198cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "cdd18ea5-6464-4ccc-9701-17551f7e13be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "785f0079-80f7-4600-ae16-b1bc8744877d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "3fa09ed7-c552-4d6a-88d3-a63e493bdcf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "bfa75188-ac7c-4a23-bae2-edaed795a4b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "771f7b36-cf86-40ab-a218-d26e181ea3b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "2b4603ba-fd8f-481e-98a6-b888286b091a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "be1ac5f3-bdd4-417b-bf93-42346f92dd46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "b790bc9c-40c2-4fb8-aeb6-3d3abf9dcf04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "c0d0d313-1da2-4f29-bd35-42ed8ad8c2c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "984a1c8b-8e90-4701-aaf9-9caecdb8ac06");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "39f521fd-235c-4439-822d-c84e116d84a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "32e40dde-d1a4-4665-924a-c51b16a16038");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "472553ea-acc2-4d96-bc7b-c896bb733223");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "e97dd0e7-f166-45ac-b6e7-60c1d0b32aad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "64ee85eb-6d7e-4d04-8f4f-b95c6cabe562");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "1fe969fa-3ecf-4fd7-af69-4e804df3bd64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "58272fd7-6a5d-4f14-b8d4-ef99b84f7599");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "c65c7e25-4461-4599-9567-83fbd2bb026a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "6e526a65-b3c1-4779-92cd-e5a0bd84a5e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "04452704-8742-4a75-86b4-0b4d9bf25041");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "5b79c500-30fb-4298-98c2-5b6cf8877b90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "43152915-1954-483a-82e8-44d917e64e76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "df82ebd0-07b3-4141-bfe2-6503c1af3c07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "beb0cb3c-428c-48ba-9eb1-4c701ba4603b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "70acdde7-f725-4a61-aa94-4285c6e0a395");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "95a95fa7-4111-45b7-a7d3-be3315bcaca1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "aab90629-ff7d-4ab6-bd8f-419ffc0cd869");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "f3bb4f0f-e57f-4886-8fbc-b68c834e5450", "Brand Ekleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "04f3e280-acd9-4439-90c0-4506ba635657", "Brand Görüntüleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "245550b5-eae8-42b6-9257-879cb2f3be38", "Brand Güncelleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "e6c58276-2f7c-42ae-8217-1eb039a711fb", "Brand Silme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "5a2ed582-ac68-4448-bb49-0cd5250df2b4", "Brand Ekleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "f600844c-4cfb-46e8-8f74-403ac7ea0477", "Brand  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "f3362af5-0abf-40c6-8154-5ec8e54be6fa", "Brand  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "54e50fe2-85aa-44df-9d23-0b8dae64f5e7", "Brand  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "79c6f2e0-4109-4714-87eb-115d5ca2c1c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "c247fceb-6cf5-478f-97dd-d093047f2699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "675d2fce-15c0-4b15-b922-c9782d595210");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "4d4f162f-672b-493b-9989-0390c4a73dd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "584a2d60-2701-4fe8-b6e0-74cb3ee5be17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "85023a32-faf9-4dfb-b0c5-02d8fc1fb77b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "b1407e66-a168-41a8-b871-8203c88036fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "8f583e13-f4f2-41e2-84a2-0532e985ee9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "c4bba38d-8708-477b-b5a6-0bd20e0652c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "5b79d3ed-467d-4722-8ed3-1467d9db54d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "b0bcead1-787f-4aeb-ad45-995c5a9bbe10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "7a9290ba-0e02-4974-a6ca-0f3f16a56c3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "250489b9-b142-4bbf-88aa-689ba9a66ae6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "710de729-c027-4da1-9459-f96f0f3508f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "516e1a16-7544-4ec0-b0f7-a79b70c07ca1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "27d40466-3b77-4d99-a898-bf2201ec573e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "100e1c61-9b1f-43ee-a4a8-5d5647afefaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "a5eb2273-2bd9-4c8e-8b10-81bcb094f50d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "bcb93f55-df9a-4e76-b26f-c01dd790b1d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "4051cebd-abbc-4bf0-b610-3754ae50b55f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "5e4c946e-6e18-4336-9bc2-1b2978c142ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "cd8a6d49-c7c2-4911-a9eb-966808439636");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "9d6d10da-8f63-43bd-95c6-d45629d0accd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "7b4b2bce-f679-4324-90c8-7d951675fab0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "92044476-16c0-47c4-8ffd-849ec9d05c0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b43708ad-8495-495f-9e94-551ecb4505ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "c8e205c3-faef-4660-b11c-82356dc198cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "87780d92-7a0b-4413-a2a5-038d8d102693");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "81f3c37b-3c67-4472-906f-a8e2db420ea4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "0366db54-5cfc-44d1-8f7c-827580c864a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "108dc465-b04d-41d8-ada7-9ff2361e11e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "4951e938-48db-4526-965b-19c38df36e00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "08236dc4-c6aa-482f-acf8-5f29395182fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "bdc10596-acd1-43d9-b641-6a33b6d410f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "1ddde4f5-56a3-4e96-ac82-1a73efc5607b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "4cbaa576-a77b-4800-ad3c-ea587978f8cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "12664ea6-b692-48be-af9e-6973235fb4ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "76a4310c-3429-4bd8-b506-d1c78af76c30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "ed649e59-584e-4da2-8638-c4cd81b3c8aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "b53ec823-6b27-4450-8bfc-d1f07f118023");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "bf0f71ad-978b-4491-a40b-deddc46c4ccf", "Markalar Programı Görüntüleme" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "3463d4ea-e725-4efd-bcef-ee63e34f4cf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "8d23aee6-3378-4435-b3d5-776dd7a2e073");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "f6407315-52cc-422e-a938-6664e7f2cb57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "d21014eb-c60a-4ffc-85d4-d71b21d55509");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "1912bb13-55f4-4b9b-8b02-a8aa1c39169a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "147eed8e-cae9-4bd0-8e2d-e37d5358c5db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "61abe827-0995-4e75-b1e2-b7bd5de2baaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "48c3ce15-15fd-4dfb-b5f3-40821d3004b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "724c783a-4af6-4173-92df-1ce68494a114");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "e1733b8c-5fe6-4aad-8fcd-42e48fb63c42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "5cd6536d-f402-4873-ade8-aa0c4ec24132");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "35a34744-55c9-4578-8cf5-aced5f8ba356");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "8c0d2aa2-4fae-403d-950d-42685434e999");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "c698bed0-8515-475b-a1cf-951871cc1a79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "9f31d08a-5a4a-4e35-a4e4-c994de801ab3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "ecd2b7e6-ca78-4c9f-8b03-40d2e7da6f9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "a0cfc142-1d60-420d-8422-3cfffd6d60e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "0dbfca27-23ec-4e47-81c0-872e5713f90f", "Markalar Modülü Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "3ab855fc-28c1-4658-88b4-53f262c3a745");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "e44dea58-c356-4278-b4b0-540349dca57f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "0714aad3-da3b-4bc4-b36b-69b1d8becbee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "b38f6206-631f-4199-a3cd-9d94a631eb9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "078cfb1d-03ac-443d-9a1f-d193524af3c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "59f8ced6-47b9-4eec-961f-d1282ad59e0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "dc247d25-33ac-4470-bfca-323db0ef4e15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "b03a56d6-1600-4b3a-ac75-b0d8cf21e839");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7716), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7726), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7192), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7201), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7205), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2893), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 9, 2, 14, 0, 45, 820, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9308), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9311), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9322), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9332), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9341), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9350), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9359), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9397), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9404), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9406), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9426), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9436), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9439), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9444), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9451), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9466), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9469), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9471), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9474), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9481), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9492), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9449), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9497), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9502), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9509), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9512), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9519), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 9, 2, 14, 0, 45, 831, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93508f17-bcc3-433e-9537-9ee373e6c9eb", "AQAAAAEAACcQAAAAEEc8wbRPKPjJiW4BK76L8cD8t/m3OZ4isvBaqwTlohU70fX8KrmAR6+NSOCLccAmYg==", "fef8d063-2a9c-48ad-afef-cecee4584f10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "571330bc-40b7-4de8-ac2d-29ca1edf37a4", "AQAAAAEAACcQAAAAECad4TfPbUNajqdVbXezw4O+SrXkC4+LuXajnZfhfw5fhSsK8xDS0osE9ysBPX95Uw==", "1d3711e4-9ee7-4405-8b14-7d681f8fa608" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b28078-d72f-4111-81c8-627078332ba3", "AQAAAAEAACcQAAAAEBHKOFT5JSpLpVgsZyIHIDhChXm3dm02c0Q/8iQhTXfkK25qqjgwom15/FHvuCQKwA==", "bfb48c6f-aa40-42b7-b2d8-a0f38b9ed61e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52594629-1b4f-4c46-9c01-2072bd307345", "AQAAAAEAACcQAAAAED24k/OAOf/lXyftuqtxDE4wPZuIUC/7KNx0t7TeWThw3b0oy/Ceim/UXd2GrkQBgA==", "0c73ddda-5295-416d-8883-eb11bbf632e0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74dfce25-84e4-4c8b-a76e-933d20bfcc3b", "AQAAAAEAACcQAAAAEMwv0hYfVq5BE80E/6IJxtcGtpsjCSipvFKkt2KN/GXSyU+ZNTdz9+1p+Z7TbV22WA==", "6b1a5c25-9699-4c13-85fe-286cee57b0b6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05320aa3-cb4b-4c90-803f-0de14776de0d", "AQAAAAEAACcQAAAAEDaLBLm/c0bgcWeiJekpuDPsFspyFBQy8gRXpln+y+row6Xyuub7fb5S2GjF/WJPaQ==", "c7de8910-818d-45e8-bad3-e5338803e4f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(4994), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3633), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1336), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(992), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5433), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 3, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 5, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 8, 26, 14, 43, 41, 303, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(441), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1485), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2002), new DateTime(2023, 8, 31, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 8, 31, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2008), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 8, 29, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(30), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 8, 29, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 8, 28, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 8, 27, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9227), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9233), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 8, 30, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 8, 30, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8585), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9328), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7667), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7673), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7676), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 8, 26, 14, 43, 41, 314, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(249), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "eafead8b-30be-4990-9054-f4fb89cac04f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0aa38a94-5073-4682-ab06-59a66cc2d76c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "555bb88e-7ba0-4090-9557-e9a769d42045");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ed6db875-2283-4877-aa14-2a80719650ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "95db4f02-c194-4847-b2dd-f9b643c02b9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "32139de2-294f-4807-8bdd-d2b377c546a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "4a9492b1-39ed-4a0e-b63d-743225d6003c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "af702c7f-4d50-4f4f-9db7-aeeda5d119de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "c7c93ba6-218e-4e1b-99d7-4535e0348547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "14f9f2c4-e0d1-4f31-99b5-8e7679886675");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "08359312-0bad-460d-a79e-286c1aa019b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "cdd63ae0-b326-4f32-ab24-1bfdf5c4b707");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "fcc6f0d0-9d7d-465b-8ca6-4486176adc7a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "0e42d3ef-cd82-4971-b869-aa6a03370d0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "8431d1fa-525f-42ed-abc7-2fcd5d253d7a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "bc0180ba-fb17-4932-8888-00ec0dede4e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "d422146e-7103-4e58-8247-8b041086d355");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "dfefb769-9d78-4644-8bb2-2cfdd437ce41");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "a716c705-b5d1-4258-ad24-11709aac756b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "7eb7d31d-670d-4f71-bb73-ae11975c7c98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4c9e91d9-b0fa-4989-ba4e-56c206d955a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "c53dbb3e-18b4-4dbb-8cab-64e7fb31d089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "eb48bbf1-bdfa-443b-9a66-85592b5e4da0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "05bff3b6-3f56-40e5-acf3-cda24c0be071");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "05a25d20-ba9e-4e8c-96b9-7df5c459c69d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "a7317469-c9f1-40ba-ba99-16b17e7ec19c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "0fe22e59-7d35-4dca-bf10-5752b4ce1fbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "52ad0a19-879e-4e14-8b37-6e4e8dc5da95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "54c56cf7-4cb6-4d52-ad6a-9dfb93ed4c4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "53181876-4515-4ce8-8fbc-d6a619d21278");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "5c9c100a-8cf2-47d1-b947-e25a7ade1a09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "6f316dc1-1c85-4ae8-9f06-e82b771588cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "e4963f3e-574f-4d1f-9163-df8e7dfa45ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "1f645473-3757-4920-b673-be91e07233c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "b5f2bf17-8bfe-404e-980f-0cb7ecd69008");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "13bc0583-c573-44c7-b7e4-1d64087e4d5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "7e1cc732-3c3f-466b-8435-2678a4140a72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "a29e92f0-4417-4771-86dc-a768b83b94dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "ac814f27-c8c8-4eba-bb08-3d10017992a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "d2d11396-422e-4622-9f1e-867847215bf0", "Geliştiriciye Mesaj Ekleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "a4efd455-0af5-45c1-a212-0b60fcf00104", "Geliştiriciye Mesaj Görüntüleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "dabfef5a-0c0e-4085-b638-bf35d384597a", "Geliştiriciye Mesaj Güncelleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "b9f95225-e1e0-4dcd-88c7-2c4d6dfb5c36", "Geliştiriciye Mesaj Silme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "258540be-2475-4cda-9186-ab687ef1d129", "Geliştiriciye Mesaj Ekleme Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "53976aea-675f-48ad-9801-f853d7bdd485", "Geliştiriciye Mesaj  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "a61e2e5e-3821-4ed0-96f7-819da5b89734", "Geliştiriciye Mesaj  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "221b2df3-849f-4c5a-827f-0f402197d9e3", "Geliştiriciye Mesaj  Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "53fd9f08-960d-4a6c-ae65-3e2a83c41df9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "4f17b21c-1972-4a07-9046-5a95807d239c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "f86ed54f-dd2c-4962-93b7-2adde426aa5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "4462b7c1-290b-446f-b96d-5c1a1326731a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "f6de0802-c816-493e-84bc-163245cf2b86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "67c13017-04c3-4dfe-a50c-9e48cb947c37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "900252db-bb6b-41f1-bb93-90fdd83dc804");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "c8b23fe7-688b-46aa-837f-ffbbec4be82f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "5c20568d-0522-49d5-ba43-d19dd8ede480");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "df5d1fd1-b69e-4943-8d3c-d8b9a7204e0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "c912b6a2-d364-4027-a596-3ec94572ffea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "8c378f01-79f0-4ddb-9c42-8536b1f64095");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "2f98ba81-1f23-4936-953e-54da156fc693");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "fcbca198-653e-49a6-bc00-f0752fff9cd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "2fbee04f-165b-48df-9f1d-9049db8b2b0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "9a7ad41a-18f1-4f72-a3ff-ea00f8b58c8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "5a79972e-f8e4-47f4-b00b-ef0315d36de5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "40860860-65df-4eb8-9bf6-28b2d539cc07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "40119977-cbd3-4e46-9dbd-e2bcff350588");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "646514a6-efc2-439b-a466-233bb82cb384");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "9e3356f2-6512-4288-b37f-b412936214c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "ef4334f5-00d3-481d-912b-3722ceb072a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "4ae1aeda-2fae-41d1-96db-93c56f8d5c74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "e5b42ac1-ca54-4402-b59b-801d4976e89d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "bc7a5687-1cfb-4faf-b075-b4d807bf31ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "d870742c-bd76-477d-8938-8b90a973a7b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "df674d68-b50f-4c4e-bc5c-cf99351d1bab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "027c5fa6-fc00-4705-be5e-89e1ee3d4f32");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "c99b1238-d99f-4377-acb9-d5101f85e5a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "9ef3ffae-ca70-48c4-b51a-b16533bbe36e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "a065c7ae-140b-43f0-bff1-a1651b67a5a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "f66a4250-1e6a-4b66-8862-ec213f4f5cf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "5c1ad8d6-bbcc-46e8-9f9c-850fad804ea6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "b83031bd-55cc-4a48-b9df-a17e847e20b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "4cf223ad-32dc-49ab-8e32-7a0c3779f17a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "fa6e32f6-28d9-4f58-ac30-6eb9a7f826a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "7506f123-b857-48f3-a701-6418deb8468b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "6af0964a-6c6e-48cb-b989-7fcc8b768b6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "aafe2dd9-475a-460d-8e2c-8035228cd4b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "7aab353d-062b-4e68-99ac-b8f67c6904ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "4a906ad5-364b-4a90-aa94-3b68065126db", "Geliştiriciye Mesajlar Programı Görüntüleme" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "0ad314ec-4826-4520-b6ca-6661b6055cca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "3eb1e8c2-98d8-4424-b1ce-887f4c01e185");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "cd93da74-bb4d-4561-b727-81b5ccb63936");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "32916f45-b85b-4629-ad99-c5f84c33d504");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "3208ec65-291d-4ae6-9374-5479f8dc78ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "de17efed-f109-400a-a2b2-9f01e601b986");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d1317325-9e23-4c3f-915a-f7efb1a7360c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "bc340b6f-41d8-4569-9a8f-976a528c9b6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "11480c1a-643c-4c5a-b24b-8c62083454d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "33f5c8e4-2f27-488b-b04e-22e5283972aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "8525c837-c8f4-4d3d-9084-f763914e116a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "ce534d0d-b5d0-4f74-a08e-3a09664d41eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "547f28b6-edf8-4d0d-ad2c-c9d23380a269");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "928bf41d-ae44-44de-870b-ca4b7ee5debc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "249dd211-6b11-4266-9a27-56db326cbbf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "e9ea083e-efff-491b-9b92-49f594711000");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "c79b9081-0497-41d3-b2b8-36c61fbd6a48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ConcurrencyStamp", "Definition" },
                values: new object[] { "b15722bf-1c57-469e-966a-73f7b8318dc9", "Geliştiriciye Mesajlar Modülü Yetkisi" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "dc49477d-1862-4c32-971f-945d103d1132");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "fa519836-8c78-4180-a58b-f576726dc017");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "5c6dfa27-1723-4215-ad67-232205abbd8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "ba363e11-fb6f-411a-b7d2-796200dd4843");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "3fe7f6ab-958b-4caf-8f60-88e4526a498a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "f3613f79-259b-42cc-a565-279ea0d073c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "12c2a77c-9bbb-4b93-83fb-88f1a2e76612");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "e8972fdd-d0e6-432b-9e06-e55a7323a96a");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9341), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9347), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 8, 26, 14, 43, 41, 315, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3157), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 8, 26, 14, 43, 41, 304, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(952), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(959), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(961), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(966), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(971), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(978), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(993), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1043), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1063), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1065), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1068), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1070), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1073), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1075), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1080), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1085), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1088), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1097), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1114), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1083), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 8, 26, 14, 43, 41, 316, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165ed241-f00b-435d-a891-979874bb034d", "AQAAAAEAACcQAAAAEEThf7VtQhVG5iAsLLe0P0IrjBBS+osrclDE0OijFISCQ/QFewnvQp4E0TJsBAsUJg==", "965b6e80-b9fe-473e-8b01-782eccede55b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25addb03-c41b-4d79-8ca8-480ce76cd2b5", "AQAAAAEAACcQAAAAENmphyuMoE9hQctJWNRroArAeQjxaCp2ZuEj7k6jnPTD0l+gvLtGMq4h3zyucFAD9A==", "a17f4f7a-4cbd-464e-b9c6-0a97b25d2636" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7b3c622-6f7e-47e1-ba63-b9f006af3c0c", "AQAAAAEAACcQAAAAELoGOSzO5PVX6n+H1XAD3alHJ0EAwoV5BLH03Q4/pkOYuR49dnVawnpZiuEvxds4Eg==", "41b1233a-4699-456a-ac0c-3278905bb78b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00d861fc-ef18-4cc6-ad52-5e9d3079ac77", "AQAAAAEAACcQAAAAEIciA1fg9HEVjnKzj6Ctv9t2uaIl2Me1v2mnLhQMBhofRu5+ZcZ6Zfl/q5v0yU3Ixg==", "59aeaf32-3482-4977-b8af-d3cec82243f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a74f895-cd74-4ece-b630-629cf49f02dc", "AQAAAAEAACcQAAAAEEHY7aS3q1ZtfxzK8zowLRbrzUw3seJljUlawAlTBwy+eNN9zsczsRIsHE1uLHAAew==", "0610a738-6924-49f5-96b4-1001fb0edadc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1ed9c0-0b3a-4c16-a7da-06b401f1a9a0", "AQAAAAEAACcQAAAAEKes0P/rfDisb05O6qqyb0hTMiz0tdSRFUvYh19UwgzN7yJjhud3TteOBX7/NxO+oQ==", "99a70ab0-b720-4df1-954f-f196cb947e12" });
        }
    }
}
