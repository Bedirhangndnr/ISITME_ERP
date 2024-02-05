using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class miggForSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Sales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DownPayment",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(6678), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 170, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 1, 22, 0, 21, 16, 170, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1719), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1718), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1722), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1734), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1733), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2530), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2540), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2542), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7355), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 1, 27, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 1, 27, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 1, 25, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 1, 25, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 1, 24, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 1, 23, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 1, 26, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9867), new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2819), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 1, 22, 0, 21, 16, 183, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 1, 22, 0, 21, 16, 169, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 1, 22, 0, 21, 16, 184, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6243), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d966162b-1e88-404e-aeea-86db4a1bada7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "efb64fea-3916-4729-858f-e480ecb17e84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9e107391-eb6b-4507-ba2d-8e03ca79fd5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "70ef263b-6d42-47e9-95f4-3e02b27c7e46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "02130c62-5807-41fb-bcb7-442bf5de56d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "f430e11d-9653-4b2b-9bd6-bb1051eb1917");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "de53bfd7-b030-4a48-bd41-d37a32e77edb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "030c9613-fbda-4f20-98fc-612c527f646b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2943d438-6395-4fa8-86de-eca41e3b89fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "e11e19bd-a043-4c46-ad66-3b81c88ba199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "35967672-ee73-4402-9a4e-457e896a27af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c6c71291-9415-4ddd-8600-16b007ade705");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "9767019e-6a51-4009-9944-6dfe29ede42a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "01e59323-485e-4936-8905-1f9f4b4829bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "f61d3422-a95d-4dad-b3e6-025d5b84ed1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "8f98bd9d-3331-4144-bc8e-9097e953ced1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "af36fb13-4421-4e00-b3ae-454c1a39821f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "8ab8361d-5899-417c-99cc-5016eda97486");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "10902450-3c08-4643-a7d6-d9549684cf63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "8abe83c8-9a4a-40e6-a65a-89658128d1e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "37ae46ce-a1b7-46f6-8400-d7900ad76066");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "224c6bbe-7094-449a-8d3e-08aef7167ce0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "7f53e15f-bbef-42f0-9b2b-dfe25e6b62ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "e507f73d-4c99-40a1-967e-cb7c43689fba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "dfc13ce1-b613-4a40-b67c-e6ae695e39cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "ec9cd8c4-d6bf-4aa3-96ca-fcd5f0b29fbb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1a4cc926-3df5-4164-94a4-0a907eb22b6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "852e8806-49d6-4521-9801-7f896fa96b70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "4b37548f-c593-408c-a20d-caede51d0a5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "9c572b2c-89bd-4e36-a7f5-39184cbb7352");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "8ac5517a-bef3-4178-add0-541d169c4548");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "c2c611f4-c480-4827-b129-0f03b23907c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "6b406e0e-dbd7-4880-9137-7e1d18856198");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "7f38b5d7-489c-4c5d-a211-90d1dfae1e9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "d911767d-5bea-4a7e-aa16-2d51c0ca051c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "9302579a-d7a5-4835-9694-51fdb1b462eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "2d07a1ba-c75f-45b4-9f2e-4ebc876762eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "bf877acb-5d83-4312-8868-2f12ad4fb037");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "5e08ffd7-39fd-456d-b920-1ce848c9db70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "332d6e1e-a2fc-480c-97f8-ca9519eca3b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "f908a3aa-f675-4db2-add8-8fa0e1442c24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "afff12e0-1f96-4721-9a9e-7aab3879fcd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "932130a1-a686-4cfb-95cc-c5154e4e4f21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "c5e1a067-e73c-4f7c-8955-77cb184a7d1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "af2abfac-990e-4070-872f-3d8d27410bd3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "781f259a-5f5d-4cf4-8f47-47c7bccd596a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "ed6d7928-b5ae-4845-b0eb-916b92c0c178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "4c56576f-8ea5-49fc-9ad3-e90003a5fb37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "fad5d729-a23b-4715-86aa-8256e0bf5388");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "fda0bf23-68c9-4489-99fa-401e92e89b80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "0e7f9e54-8c82-48dc-b8fd-48e50f0e1b9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "2173d0f1-232a-438c-b752-b6bd70e3384f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "7ab0e6ec-6089-4eb4-b367-947fc840eae2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "ae7c45c2-d96a-496f-8d49-649d19735000");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "9473bc09-b480-4715-ae57-b116c4273426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "d4dae555-ed72-4d95-9478-f30574b36673");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "00e90780-9820-465f-b5c8-61f849cfc6fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "edef845d-6ce5-44e5-9a93-62924733d50f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "6d328db9-dcbb-466a-9d96-518e28249948");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "bbac0534-030d-4e90-a50c-196b13f1d439");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "75c03c9f-66fc-4352-8be2-e7ec0158a237");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "37de9560-ccaa-4a60-b215-05f96f20089c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "1bdd5903-973c-4091-b3fb-15a51438a022");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "cf3586b4-2b4d-4dfb-8a26-c98057328ba6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "cc273186-498b-45ba-987d-1cd302316660");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "cb521e46-a593-4780-b4e2-18a56f109d86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0408ea44-3671-4c74-b9ef-a35f242edc7d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "11995391-c8b7-41a2-a4de-364c5836fc2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "e99b1445-ecd7-46d1-94e6-21af3a07e1ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "f60c2db8-fda6-4ed6-8abc-591b0ecf0da6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "a738435b-0a90-4cb4-a93b-9a032b51fdf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "016afa8f-a3b9-4f45-b2e2-7a3f5c1ff40f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "d3b87712-e391-4d63-8fdb-930ad72cfaaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "da7e7e66-29d0-4de7-9ebb-a9f232563bc4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "46f9df14-e376-4625-ab4b-4a2604fe196a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "39f6d8a1-0f8b-49f9-b06d-a838aa1d7ddf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "bc186b29-64dd-442f-974d-47a60889c131");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "c41e83aa-c4c7-44b7-ab94-87c3ee40be81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "969d806d-7647-4d1d-9df1-a5b1441c4b4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "97118617-357a-4d6d-bbaf-35174e83ef10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "abd8fc31-8afc-474a-800e-f8a2464eae13");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "a3a4bbbf-078c-4bc5-a2ab-25ee3cc66e94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "e051fbd4-086f-45cc-b4a6-bbce2cef18ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "b79c06c9-5476-4adb-a8db-633bec3a66c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "99c47e67-c3a4-4daf-bc60-997c3b950ff5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "c58564a6-a49c-4daf-aff1-c21d6f662664");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "6b98e28e-b71a-4b0d-95d2-a62a27ea773a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "90e616b3-eefd-499b-a265-3b8bd3710a2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "d8d9367e-3ba2-4bdf-a3d5-442551608d01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "cf17119a-addf-45c0-ba87-95528ee2bf3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "75dd193c-e2eb-47e7-805c-e787bd0d09b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "79bb7d70-1dbf-457e-8143-b692904d8370");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "36558ae9-7431-4613-9ac5-30ad6555a12f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "bd7087c0-a354-465b-8e19-2667db219e07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "ce22e7ba-319b-487e-b73f-a91017e145c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "58d8ee19-c115-42ca-8be8-aaad61136b04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "4cb66249-fac0-4eb5-adda-67eb49d07346");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "1a90a775-a44b-4a97-b990-8daa98e56bc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "dbab7a68-372f-40f8-be2a-e30ac9feb6bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "a637040c-b6af-4f94-9233-5aea8aa8285a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "f56323d1-aa93-4f08-a183-888db28e17bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8cae6260-90da-4b8b-8cb6-9631541caaea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "c4eac499-44c6-4bcf-8825-400836cae49b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "7e10c480-adc8-44c6-ad8c-8381c2b109aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "98684171-deda-42d4-a187-6f39909eeb1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "32d8aca6-a71b-407a-a694-8b1de820f7db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "e36b90ef-634b-42c6-97e5-aa0679c37f8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "a5a9064b-6bcb-4a54-bd60-0f8fd82e565f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "deaf15ba-af86-4a37-b2fb-c78bb5fecdc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "e122a9ba-a755-4814-8609-d47dab2e265b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "a24075b4-9b65-4105-8538-507788661b73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "4dea543f-11c3-492d-be8a-cab28de50bb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "869d8356-6b3a-43da-a0e3-bb5f8b30f083");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "2af8fb0c-55de-40c8-8b60-bed5d2f0ba74");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(1132), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6724), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6726), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6736), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6765), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6815), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6826), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6847), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 1, 22, 0, 21, 16, 185, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eac6f58-5335-478a-8b6a-31d87ed76d64", "AQAAAAEAACcQAAAAENEfB1qTAvxFMpfWRGsFYj7oYKCgdYWOBLFGdW6ia9Lx05c7ECvdLGk2CGFpIQDmaw==", "3d809c2b-bef2-459b-bdae-9b2edf99f57d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc6cdee4-ea7b-4ae4-b0ff-f6cf41dc0d76", "AQAAAAEAACcQAAAAEGBDy99mcq6nB0Ybt83G6btks7FY7B2g8mYWbHU3VuCOyY+pKBE84L5zQDrIZ5GHLA==", "612e72c5-46dc-4f3b-a86b-8a8153afb2b5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36064451-d133-4d60-9681-3f55a7fcca9c", "AQAAAAEAACcQAAAAEK34J6OPM5YgLgMHLnPKL1rBLzNAek1s9sugl3E8vdhXibJvh5payUICtB7Id2jiPg==", "655f2dc3-ebc1-4382-a6d0-f887fa45df05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "575237eb-9d81-45b3-a484-936c1c960290", "AQAAAAEAACcQAAAAEFX/19wSX0rpTqH1fbHBhC2Qq9kaYMcQ8BBNsQE8f80MO81+5FjUiQo4VNcA/WQLNQ==", "5a476258-061a-47ef-a9c3-42bee15c8175" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3461a10e-f128-4d9a-8688-9f24ec23b120", "AQAAAAEAACcQAAAAEMnTOnF2K2f56QsMbs2UsOBA/7QM5707ODaB6uh9/bDXPdxDaMxuHOPoWpJOLD8fIg==", "ddbda3cc-b142-473e-b3cd-10d2477d0b47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449f205a-237a-4886-aac6-784f194d9ab7", "AQAAAAEAACcQAAAAEEUFXfXKBOtqLDVTGWoCZYBMXCkcIUCUOs/7l/hFRMzW2SFtbt4VDUu1Od8/79lj4A==", "2f85b9cf-1257-4c61-8336-e125d68c2eb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e679be99-9f9f-4466-9139-0f1842bdb24c", "AQAAAAEAACcQAAAAEHOaYteq/JasLEf3ifvbfRNddj6AxthZcbhimF7/rQnj3KPFOshh7jj7xK9414x7Kw==", "b2f93aa0-c5b8-4d14-960e-f387b4e3eba6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a3a48a-dc1d-40be-8948-da3ffc9cb53e", "AQAAAAEAACcQAAAAEMoR9DHhoKtCBQC4e3jROGEq6eKI3scbmuaBjSLRKlnD+CAe3p+dULxe12LOTsfNog==", "1e7b58e5-8975-4a4a-b28c-4a9dad6645e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda31830-07c7-4f78-8ae8-c45a6d346a0f", "AQAAAAEAACcQAAAAENVxn7wL/ITIITkkIceSxHhiN3ozkX/x6jFHESUB7oFrASXpaHvWtm/Q4qIcJ6hERA==", "437128bf-8d7c-4c8a-851e-08d564350c4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "DownPayment",
                table: "Sales");

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
    }
}
