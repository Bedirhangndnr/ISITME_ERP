using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addSomeFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsProduct",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProduct",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 720, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 12, 10, 15, 32, 10, 720, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9426), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9425), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9436), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9435), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9445), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9451), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 12, 10, 15, 32, 10, 718, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4050), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 15, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 12, 15, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 12, 13, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 12, 13, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5682), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 12, 12, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 12, 11, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 12, 14, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 10, 15, 32, 10, 737, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 12, 10, 15, 32, 10, 719, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4448), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "445a6175-d12e-43b8-bead-1168d4b9b005");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2f7f773d-768a-4a74-b186-57a466395996");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "22893090-802d-4182-99f1-2cf22b3bfa24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "57102c77-1176-40c8-afb3-26f38d4ef5b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8aea36eb-1f6a-46e2-b4bb-e6b0cb736490");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "dcc92bf8-7c11-46cd-ae80-c6bcb363dc42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "aa21f7bd-c2c5-4f30-bba9-556b705cb913");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "d41a98d8-c289-4694-9b9d-21dc95b59417");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "5d6d1bfc-7d6b-4515-8cf9-17c15e102eb2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "3ce566b7-12b4-4ca2-b534-187dc6bdaf83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "b7c24c23-c63c-4e81-b6e9-24ee181ab60f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "bb178df7-b95e-4def-a78b-5e6502c2835f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "51a9e902-8771-425a-a49b-019acaff44dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "27a64ee0-6182-4471-b64f-dc634b4a7bdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "d14fed8c-29cd-455a-adc1-59afe5a05d7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "a454de26-c9a5-42c0-8d7f-a8c0a8ac01f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "666b2ed3-1be8-4d74-ba84-e0fce8e51959");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "be85e5d1-aa42-4a94-a1e8-8f6163a1662e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "ef95eb0d-a126-4905-9982-4c8e7df91f8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "f5b54b15-0642-4dac-92f4-7c713cf642f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "bcb38582-cc9a-44ed-a867-7e3dd2d40cbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "aeacf3b2-9a1d-420e-a258-9cdbc0121702");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "314c1b8a-a2b2-4451-ad09-46caaf92ee50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "c89f902f-6a51-4f31-b491-d64f965347d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "3adb2da1-8618-4fa7-a127-43f4934b686e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "8bdd0cef-2a71-4627-8a1c-d373e7ec406e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "a56421d7-1e12-4323-98fa-2e88ddf5f147");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "2e3a8676-60ea-482b-81a7-b0c329396dd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "390febd0-f91a-435f-bd85-299fcd8a08bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "0fb343c4-0571-4b0c-bed8-c0ff9d215479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "25438a6a-d99a-4436-a57b-1be69bc02086");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "17b0f32c-88e9-449d-81c6-5a7efe0e3fd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "709443dd-e89f-43b4-afd2-ca7196777242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "5644cb02-a558-483c-8700-9abe91b51fcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "65c9a2ac-af0b-4152-89e2-a9c439f973e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "46fe2a4c-a6af-4213-848a-1aa94d59e260");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "d9d02504-337b-4451-a1db-685e7eef44f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "bbad91ce-4522-4a9b-97ba-defac64273d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "147ab446-5e3d-467c-9a85-f573e7bd7f3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "ddba91cd-50b6-467f-a38e-62237469cef8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "5c0179f2-1ca9-41c5-8d0f-30f8db8afb49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "918f7783-9179-440c-959c-74579894c736");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "1f6e49a4-fcad-4027-9233-97be33a83479");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "a8f8ce7f-cacd-4896-9232-b29b28276033");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "66d97c85-92fe-4381-ac34-923c7c0e520b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "080bb325-20a2-4589-9f81-a55f51c42699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "b678e667-7f3c-4929-b92c-c1e23ddc042f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "5b4bb8e7-f5be-4a3b-ab25-4d11abad6a09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "a4aaba8a-109e-4c82-b8e7-2a25c6424ced");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "f288ee58-d903-4a4a-91d2-feaaacb5ab00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "b0530ef3-3b5c-4291-9ec7-0d2a1fc22a10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "fed7cbc8-1fbf-49e7-9f38-c83488f830be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "56cca750-4122-4d89-8dc8-8e8ebf6dc8ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "72d54a7e-b78e-4b27-a384-4c1b7b480761");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "c0a47f79-de8e-49fa-9e3a-14e148f2c469");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3e896001-38e4-48cd-975e-c944b7a161be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "d515f1dd-7c2f-4bca-93e0-7c1ddc416488");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "79726980-c8e5-49ce-b12a-2b0657b77d70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "430a5aac-710c-43f6-9a42-151b2c24fec7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "58d7947f-496c-4ba4-8ede-de2fd6717469");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "ca865aee-a633-401d-a6c0-ef4f3e0d6d98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "f1f35f10-17e6-41f0-90b3-d80231d3c8cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "db127f46-c8bd-4d05-afcf-e3e58634e41b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "f0d2cdc1-5843-4037-9a79-727e4e22ea1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "ec41a4aa-7f8c-4ac9-b219-3a242abe26ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "b92a0a49-5e30-4f5b-b167-f27166981520");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0c9dfc3b-291e-4c8e-b5ec-7eb3e2c27371");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "a1296367-be4d-4a9d-9ab9-36762f18f4d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "bda314fc-2afd-4dec-94b7-497a93282810");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "e2ad6d6c-ba28-48e6-8f27-282f62363e46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "3407380f-3254-4c48-ac67-d509df8e605a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "1519b7cb-f9c2-4f42-b8b8-d0aa74dba57a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "f4b17b8a-cce1-4be6-9654-8ca15c5d1ff9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "15179ce5-b1bb-40a6-96b7-f80c7434ee3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "4a14ba0b-e757-4ef0-baf3-bc0430d5a2cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "bc3b4ee7-7c5f-4b2c-8fd1-dbd97d901627");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "1ac42840-9b39-48a3-93a5-664ebf85d697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "d3ca090e-2dea-47a9-9642-183d66b45e19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "749945d7-91a4-4ba8-8e8c-dadb9422da45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "41dc38ae-6836-45e8-92ea-6224a623bcb7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "2a4c5e91-b8f0-47d3-86a8-cdd54b3927b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "838004c0-07bd-48be-bd6a-df4f7999b4d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "63f6be25-a4c4-446e-9ed5-183fd5f008c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "65b0e678-681b-4a2c-8037-d347b04b614e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "7112ffd3-e458-4154-bc9f-a055bacc1ba1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "10b7a496-6c7a-4bee-80fc-170acbaebb23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "81f669eb-ad70-43ed-956b-232698be2ba0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "4a096e96-75ae-4ef8-a44d-147a8701e403");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "5da998fa-921c-4fee-a97c-fd6a97d7264b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "26694fcb-dd34-4937-b2d2-e9ff38c75749");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "4fc20963-ca13-4f85-bd1c-a38372cd9426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "9b4d6dc8-1536-4810-a34c-baef2a89b2d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "299ac67b-b82d-4ba0-8fff-b9a34f77122a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "09ce77f0-cd9c-48cf-8b71-eb7dc635c8c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "99c7df65-80e9-44b8-857b-45c6aed83af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "f60ad444-90f9-40d7-8765-fa19c37658e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "81ba79da-23e8-4a86-bc21-f8d42539a8c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "82dc8ff2-7b68-411d-8282-8324e2530ad5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "ff04a365-b52d-45bd-993f-552187ecf5f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "9a511930-9b6b-40df-b323-2658d42758e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "6e1fd94a-6fef-4c7b-bb70-4561fcefccba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8ade9008-6a65-4d24-af81-95ae723805e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "71ed9468-1ad9-4e73-aa1e-4d27f1f58639");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "4199bdc8-5e9f-4aec-bd5a-a433bbc26526");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "350bc8ef-915d-4e8c-86d9-57a41cf47612");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1285fefa-5eec-43d8-a5f8-8f9bb5b4e8ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "a126bda3-fc84-43c9-988e-dfff1857242c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "711cb6cc-8662-4e5f-a304-7a301505dc3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "f66645be-dad4-4344-a0d7-7ac2c4ea6df9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "93716c9e-85ea-49a6-b27b-51f53a486d4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8219f627-24d5-4fee-989c-ff8bb71fcd8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "d0bb01f0-3d18-49fd-bb90-41e5e23118ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "28fc0243-a542-4ee0-a3c3-02a603f3e8f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "1634351e-f980-4165-bbe5-f120216c593c");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(8261), new DateTime(2023, 12, 10, 15, 32, 10, 738, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(2435), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5139), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5293), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5296), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5299), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5307), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 12, 10, 15, 32, 10, 739, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9e4618b-ee41-4646-8a0a-52a3ea934311", "AQAAAAEAACcQAAAAEKjnn5ak5A1XE41MuSJ1iy1oxx9aT7N5dAAUdEJhNA7aocwJKqJcvj6mwZ31W+DrpA==", "5d459001-e8ca-4bc7-a602-5f604d3323a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5d40fa0-ca00-449e-8c24-f8cb72ea2cb3", "AQAAAAEAACcQAAAAEHFKh2kkCOmvn9QK+4zSnLFFi0UEe4KdnF24VDKEMsVziXMR2EYEfaGQvj/CswZcCg==", "c14f40ca-513b-4ce4-8380-6b56bc0ac9f2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e490629-ef47-433d-9255-e777e7e7121e", "AQAAAAEAACcQAAAAEHsjo8scRS/N5jH9WJVjf5pGRziCv4PgqyZiVcC5gYDs3btUyd+Rh9Ez25GWZbIaMw==", "754584a3-7115-47d8-b6af-9def026348a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "341c54a7-5b3c-45b6-a8aa-66a9d82ce1e0", "AQAAAAEAACcQAAAAEFgNlWdDjw4UOGGb17tdDskjKUDslX7u/cjOcyf/87I6S7Q+oa3HKaPYOwW8fwp5og==", "f38f2b63-e7d7-47ab-ae49-831e6cf8e96c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0dfccdd-3b9b-446f-9dc9-cfe135de805c", "AQAAAAEAACcQAAAAEEi5lKNSPeHgGEvSTtlYOTgGu2GCcQq5WBuybvCyl/8ZehGZBL3oWwB9jeZNkLz5tg==", "0b0ea5a3-f366-4427-a2b6-3a17ec50354b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d661e570-169e-4bd6-8348-6e99bd7a03f5", "AQAAAAEAACcQAAAAEIzwcip7veXtHMooSbE7ruGsOlrQpZGwoMtUuOiq2rdvA/mbwhB2dSZtOWTfyeeZKg==", "3d710762-bc23-4c91-a7b6-ff10fb559c58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b76c8ad-4582-46b4-a88a-3389f8c33ff2", "AQAAAAEAACcQAAAAEEJI/G3NkXy2Q/voaeD7/Cc2KRZmvrGZBjjtvZE7InTLOVAwu9ygcfUT+aw5rCfZOA==", "e992c38a-7121-44af-8b7a-82b1f0520e4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d4c039-8077-429e-bee8-47605f611aff", "AQAAAAEAACcQAAAAEH+xVl2Q4M8evnS9uGnq8UD3KgBtpwCDirraYNmvifiD8oFpNTFRv5vX9b3BXEGvvg==", "26d3e590-14ca-4d71-97d4-8896cf76bc96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69fe86d6-c959-4344-ba34-e3365ee721bd", "AQAAAAEAACcQAAAAEIqsoXYc6PaWut8wNje4OsjJ7SAl4h42T7rLpq2wqM/sgFJZ6cz2+5zohDu9bIwnMA==", "5810262d-2d22-4457-9012-2d093b480c66" });
        }
    }
}
