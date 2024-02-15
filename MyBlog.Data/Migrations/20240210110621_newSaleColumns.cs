using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class newSaleColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelivered",
                table: "Sales",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SaleDate",
                table: "Sales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedSaleDate",
                table: "Sales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelivered",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SaleDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "UpdatedSaleDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Product");

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
    }
}
