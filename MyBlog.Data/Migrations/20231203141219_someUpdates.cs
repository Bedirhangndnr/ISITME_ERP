using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class someUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "NewCustomerName",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 482, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 12, 3, 17, 12, 17, 482, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(16), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(21), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(42), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(49), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(48), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(849), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(852), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(855), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(857), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(859), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(864), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1723), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1734), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(5217), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 7, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(8656), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9432), new DateTime(2023, 12, 8, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9437), new DateTime(2023, 12, 8, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9439), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 12, 6, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7304), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7308), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1536), new DateTime(2023, 12, 6, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 12, 5, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 12, 4, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7064), new DateTime(2023, 12, 7, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7070), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 12, 3, 17, 12, 17, 493, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 17, 12, 17, 481, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8158), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8161), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "212b03a0-b016-4007-80f4-0fdb1252bd56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "23941c60-b756-460f-a6dc-320e610a8f77");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ea03ecbf-4b40-49ae-8eaf-9c8f548a3bc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "45291e18-84e9-4370-8def-b73eac37c5d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "5ac59e73-9fb2-428b-8d0e-c8eb6ef17639");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "46378998-8e99-4a43-8e3f-28de5e957db9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d5092be9-3772-48cf-8f22-1f4a8dfa445a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "f0fb27b5-a0c1-4b95-87f5-3dfe22a5cc3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "f7e7859b-7211-4e51-a54f-6e47f59c2c03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f7715bf3-c98b-4d0c-bc1d-b40f2a80904d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "0add5476-567c-4585-94e4-4044ea0b6ace");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "05ca6f1c-fc8b-4f2f-826b-47ab27e405d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "1efcf5f8-b160-4cd0-bca6-dfab306d9983");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "60729740-0459-441c-8d73-f9b18f59c18f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "043f3911-b0a4-4504-81d7-043838b6ac22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "aaf64af5-19b7-45ad-8793-2395a477a57c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "0686236f-feb1-43d0-a4ba-ee1766fa1c31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "53822720-873b-406e-ad84-7a73e31cfa3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "161260a6-11ef-49f9-ab66-3bf7177a0305");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "f8474915-5dbe-47b0-9d88-59600c3b5052");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "474021dc-a91f-4646-8c0b-ad8f00fe6c67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "dd30e77e-3354-40c9-a51f-929be9fc2791");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "cb45da34-d7d3-4b5f-9d27-d12ab714ad33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "89227324-687c-4e68-81f3-56bf1ba095aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "fb9b77a5-7892-4b76-b342-8c54affcd030");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "288c0ee6-b334-4d40-985c-d795b6b2a97d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "558eec70-5cdb-450e-b7c4-beb59700d858");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "3a61968e-1ff1-474f-b9d1-e45eb5e4313f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "9efaac47-5747-45fa-995e-dcda8a59f0e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "6ba78c19-eeaf-41db-ab3a-e45f403a8b9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "6f0d6269-2a5e-4518-a874-1a9eca521d33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d7e8e7c8-e4a4-4502-ba12-8a0797185e11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "34d2db67-cc81-4244-9cef-4f304f986bba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "490368b5-68e9-4e55-b6c7-c250feaef2c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "b372aad7-bd9c-4067-977a-0d23b0583ac4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "0c46748d-618e-4f63-b202-6a5248eb45a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "11a5fec1-766b-48b9-bb3c-28ac1494de7f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "404b634e-350d-4c22-8aa0-efa8e3c3106a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "cf24f277-6e70-4dec-8fe8-6c24fd09f0a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "ae78b234-af19-4184-9c98-9f0af1793b79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "7e5ec043-4b63-4c0b-a4e5-88ea39bfd634");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "1f80a4dd-8a75-4539-9f5d-7daae389c601");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "3e00f604-2a16-4c61-b867-6bf2ae1b1372");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "9d6bd348-f694-4e0b-b9ef-4e9dedcaa12e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "ede8eb1c-35e9-472d-aba3-e1d1ba33f9bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "c405f6b1-e865-45d6-bd4d-d32739abc17e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "eae45cfb-04d2-480c-aa6e-72dd59e69a78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "2cf14ecb-908a-4bad-af82-2b79d916996b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "08b620f8-de2b-49d0-8ba3-ec8bcec703f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "f1fa8f2f-b58a-491a-b23b-66993d13076e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "f2f1cfa6-0582-4bee-bdfe-4e2cddfc3538");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "ac05f836-f05a-4914-9935-847e3a0c6755");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "d569660c-57f5-4df7-bc8e-8924f91085cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "696099a0-8c2a-41a4-91c8-d132f8c63a30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "5647452e-b6fe-4521-b30c-7addb7c96ed3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "b7ade6f5-9856-4b42-a9e6-fe5a575150b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "d6cf3000-e409-47fe-8128-5ed785b5edc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "9526c570-8512-4b92-bfd7-bda20bddd3a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "8b61c244-7dd7-424c-9c54-05d2ef77d38a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "90f3a4a0-05e2-449f-8624-3869e7db5942");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "3ccd8573-dbed-4ca9-8c93-69ce67ef1693");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "56b73283-1127-41bb-b116-aec16c850081");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "fd66aedc-6a3d-4aac-b6b9-5c1a01a3f1d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "e68ef3b6-731f-4cef-8ea8-7f15dc256297");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "437bf39b-957b-43ba-9668-9a635387e4f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "21c08bab-1adf-480e-b0e4-0b45552d0759");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "31d24bd4-c605-4c35-9b1d-46edf8af131c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "710cd4d2-f2a4-4be2-b4d7-b311119ba9d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "fddf62d3-a209-465d-acee-75b1fc7275d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "90f4a4c7-9f50-4ffe-9020-0938981caf2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "e22614d9-7997-4aa8-91b5-736eb0fb99e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "4a052724-0941-49a8-9968-063858dc05cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "01ffc452-6a49-43e9-bc85-410189b863b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "a933c675-17a6-4869-aac4-bbc1ea6f86cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "4fcf9ec9-4852-42c3-b064-8651ff70bbf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "0fab45b8-080f-4f60-bc87-57f0560bb674");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "5ba7d131-0de7-4ad2-be11-20ecfcbcc062");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "1b7fac4f-132e-4d41-a0e1-99edb04a2b79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "a474b8d7-b61e-4158-9476-dafae0088fbd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "521d0aa9-daad-4fe3-b2cc-a1297dcd62fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "be3a8c4f-b8b1-4330-80cb-c125402530eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "fbe1877c-d455-43e6-b144-4046827550cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "f1cafd51-e268-418e-a78a-08c914ba6f54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "4d2c1274-74de-4e96-bd5c-4038efba0b60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "cb199169-1b34-48cc-83c2-6934243f9b6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "318ac7be-b911-4078-849e-e3f144d53cd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "aeebc1bd-e189-4960-a300-1dd68fd38622");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "9cb1bcaf-c842-4c60-b08f-5d5d060527c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "f39156e6-513d-40ac-b5cd-fbb22c750348");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "c947042d-5846-44c0-89ff-c181330184af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "5dd75087-420e-4e6d-9225-33c9fd0fe57a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "16a596d2-de46-4a87-934c-7b3a4cd26a86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "10ecf8cf-aa4a-4dc1-9f3e-1fb84d078157");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "53403d78-c016-4726-970c-10f96d2a19e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d7b6fb4a-b4e8-419f-990e-4d9924da13e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "302d0252-b66c-43a9-8e89-cbc05aae0376");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "08b39cf6-be1e-44d3-8238-17029b5c0156");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "7bd471d6-f419-48c8-95e5-7dbe01957ef8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "3c8b9fee-1d5d-4eaa-892e-fa70e818f892");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "6af60439-7fe5-4359-9087-42681b91b1a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "241c20e1-709f-4209-a147-e7b7471b7052");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "1d70a3ac-e3f9-44d4-a377-409b41fc85e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "3d7ce182-91f0-4b26-83a8-196dfc8ba715");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "621b8b42-8812-4649-a636-2559a6921ad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "7e71e621-22c2-4c45-88e6-ad01540a918c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "6142cc29-3244-4a51-a0d9-279b481d653f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "c33a763b-a788-4537-8ddb-9ce91833cad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "3b830901-a9a5-47f8-8d72-574edb387220");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "7ef50ec9-ac07-4935-99a6-73635e5db602");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "19c7f406-0f43-4001-8d8d-1bff3f840f65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "638420bb-ea65-4ce1-a421-176e1a87ba70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "48b45300-62e3-493c-a257-793e8efc2990");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "07110842-cf26-4468-b784-209c5b68c0f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "9fb61056-7e87-4379-a2a3-ce48fe2665ea");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(3509), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8649), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8652), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8654), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8656), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8658), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8664), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8669), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8671), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8675), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8717), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 12, 3, 17, 12, 17, 494, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b03e1db5-3f60-4eb8-aabb-396c7d39438d", "AQAAAAEAACcQAAAAEJgWfttjCoBXlKN9uOVFmA7gC2NV7UqS6TCVW9965sYjMTLJs6bjMWiNa0nHFOdALg==", "737bb9fb-07b3-4b2e-bef5-14943fdb7106" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ca8cd87-be6b-4711-b7bb-8834174fdfcf", "AQAAAAEAACcQAAAAEOSwklE4WxkpVOHszDzvBtIPeLahlDvb71FQ+PRBw/tYboUeMdZFwUREWhuspcWshg==", "bbcad9fd-498a-458d-9a24-bc1624598fa0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a0b1f6a-1c15-4483-baf7-16343dfa0ada", "AQAAAAEAACcQAAAAEELwCquGa9zTJrxaJjaJZCK0Zw2xLF+4q637ZnYSo8pWMr6ggzMGetMkWzVf0Kq0YA==", "3a71d036-49b5-489d-b672-156ac4694f68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47256a83-1d24-4023-8aa5-3f6987a085e7", "AQAAAAEAACcQAAAAEBm4hROXNGRUC5av7/fx+G8UqQSFxo0eH87VQeoxlotaowa99+RCDSbegaxVS+//lQ==", "337e4a3e-d35b-46db-bc3a-e011d97f9e59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13957690-1893-4024-bbdc-334261d23c51", "AQAAAAEAACcQAAAAEEt1BFgjMVFMQbhp/TylyM4Ymq7g/jpU5XLZSE1+LlNrsBxy/FfW/Qi56+tnGqT93w==", "383556a6-f01f-437b-9f8c-8cc01ff02079" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91213b4e-d0d6-42ee-85cd-cbcc16c12d8f", "AQAAAAEAACcQAAAAEMjGPvEvDQFv7kYt2yWYpV2yIs7JmxU9UGTEm9mGzf9yQIFicgfIpPKTMX3NQLqkQQ==", "2ae360fb-9fdf-451b-a4c6-1b3b40c5a3db" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5539a8da-de2d-4d3e-b21f-cea541b31b3a", "Esma", "AQAAAAEAACcQAAAAEKGZaQAPqNpesk/Zh5EN2m7YIEKzygfKoM2nVuztRegxX6AD9exOM7P+qOPVSpDRwA==", "6a2f4101-ff8e-4ed7-a80b-d2eb33b92a97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f482e63b-6b16-4510-9cd1-c321e66bf12a", "Asiye", "AQAAAAEAACcQAAAAEBBZJqTct84XXRZ8RTkHOZ+4uzZ2XHvUMcFo99g94t3jGwfqMOCglRV0XmKa2vqtVQ==", "a38bd842-b3c7-473f-87b0-bace198ab66d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c26542e9-7301-4a18-8439-ed8ea4c3d2c8", "AQAAAAEAACcQAAAAEHjSqDB2QmFSLJ2CEbKoMl3Za/our84550+o/NXF7s+PyXy5sNYnhoo8sfKEbEQFAA==", "b7859c0c-e232-454b-9dad-3b383362d6b2" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SerialNumber",
                table: "Product",
                column: "SerialNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_SerialNumber",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NewCustomerName",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8193), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8201), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8209), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8217), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8216), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8219), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8229), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8233), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(671), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(672), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(706), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(709), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9017), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 11, 18, 13, 48, 23, 741, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(20), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(24), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(3572), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(4048), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 22, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1293), new DateTime(2023, 11, 23, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 11, 23, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 11, 21, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1302), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 11, 21, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 20, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 11, 19, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 11, 22, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 11, 18, 13, 48, 23, 756, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(4648), new DateTime(2023, 11, 18, 13, 48, 23, 742, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9849), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9856), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e9049bf0-a110-429c-b842-ae95c270b0f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ac8fe4fe-fa79-4159-a8c0-0cd590194845");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f3578c6e-d965-459b-ab6c-f4adede6f229");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e49b2f8a-0816-4e59-ac4f-02619ac0d746");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "0bf77d75-7e57-4320-bddb-2702dff42538");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "19dedac7-9ba8-4ec7-ad2e-bdd0bf4f177d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9096a005-e70a-44ad-a20f-b3af50f10dba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "e3c7de0e-2dea-4192-a079-329fd7457ce2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "1c809238-62b8-49bc-8faf-b4e374d03154");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d548b34b-2029-4af7-a20e-353ac1826458");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "32c4a42a-7b1a-4a2d-8041-a0b9853599e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "92363d5a-b20f-474b-999e-649e8490b625");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "3e831d75-1317-4ee8-a5b7-2b5c5f830453");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "70cabdfc-2b5b-4eef-87f3-e2ee356137ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "26511a70-f28b-411b-8327-6d08394ca171");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "552b65b8-cf04-43b7-ae5c-6a06524bd125");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "79b72652-a184-4108-972b-ef7b1627bf98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "4a04240d-603d-4419-b719-0b195e1b50c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "0babd947-6896-4e9a-a84c-7375a1c921ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "86bdd5d9-e78f-4257-903d-81ecf68edbd1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "3e644fcd-f674-4b13-bc42-dc5e17b42815");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "532bd45e-6981-4b1a-bf13-a5cae6f10ddc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "6b416fc6-c981-4ec7-9e43-4c7ebe3697bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "4799b8b6-5eae-423d-a9ed-ff66b6696099");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "a7b76796-db75-46b8-a738-39f970176eb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "69ad9454-4381-4d85-9a80-2b0ab5c91141");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "6ebbf95e-3cdf-43b5-9ed2-662155261f2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "64feec4d-e5a3-4094-b11a-c06c16d5936a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "118cddef-4bee-422b-ac90-b02942d0c2e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "93ebeefc-4bed-40f7-bcd1-a3484a52e587");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "2cd9f110-bece-4065-b396-36921cdd4dd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "59605834-f124-4c63-a40a-08f628a6dd79");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "fd5fd604-c40f-4b30-88eb-f2344ba73547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "45219a9d-53eb-4756-90d7-89879bc1eaac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "8d354688-6ba2-4211-bece-0aa0979466fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "01c11107-61c1-463c-95ff-57e3da866203");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "354ca633-8cfd-41d4-ae75-467b8f2340e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "c9c8be3b-cdb3-48ff-a4b6-a729f6eb9d15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "cc709abe-332f-4c96-8b21-c21f260ac324");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "95a0b36b-bdc7-4134-b896-72079d62ac93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "0b8202fd-e736-4c80-b9b5-ae6b91dcf760");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "893f9ace-30fd-42bc-acaa-2014950e24aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "fe78720a-64ff-41f9-87f6-37e185f0da45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "ff6b46b9-d3a0-40f2-b9d9-0a9924fcdb3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "ea5f94dd-9540-4cf0-94e9-75f997a1134d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "5f54520c-2af8-4d7e-b86c-7f79c1b74c07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "70d4c641-0aed-4451-a8cf-9355abed4ad0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "5126877a-bff0-49db-926d-0fcaaf81ea29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "ef85d9fc-9f4b-4c2f-94ce-7cd7203eb92a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "35217b60-2ce5-412e-b894-59a3e6ccf9cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "7801df52-7d20-41e2-8948-8b6364be42f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "c18820fe-da66-4610-bd4b-b34ef41ecdf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "d1505535-7a33-429b-83f6-d6a12b98510b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "48a2d417-9a03-4451-b4b4-e4393d028e17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "2a02b2b6-180f-4723-8227-d771a2e22800");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "f70576c1-432b-4a73-b559-f46db419b53d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "0ec49668-a9cd-4a3a-974f-02882d0b87b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "6dc34869-e5e5-479f-a3c3-d6a0ac02025b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "6e263449-7180-470d-8e4e-187e0f426bf4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "52eec554-ba42-423b-8846-81065271365e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "83309603-c7aa-4deb-a47d-4c8d6437ecfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "5c0a689d-05e3-4a5e-9e65-8ffcdf1109e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "cee22126-fcd7-4de7-8099-17cf31d15f53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "fb353a6b-5320-4c60-9af0-3901ce49e2eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "85447e89-fc61-4861-94f3-01a2ccde57ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "f298660f-fa2b-49db-bcac-c4765bef7ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "79048629-a9f2-4c26-a0ce-b814f8c5215e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "b32a6d9c-d309-4fcf-9b5b-fccd537e7659");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "1bb756f3-297b-474e-aa11-7664cd806356");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "30150a7f-55c4-41bd-9ce2-c6f6bf5ccbc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "4b295e75-7f81-4044-b02c-50d07836e8ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "93fa9e0e-2cff-4058-a06b-b75357f89f90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "ea7e82ba-b733-4c3e-8b48-78d2a2c59a83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "3fbbc1b0-8ba3-422b-9c3d-a8603e35f3e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "81dd4a2e-c95a-44a1-bfc9-22ccd7a2d059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "75b60b94-716e-4e6d-890f-daf29a68b604");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "bdd2b575-4ef4-4edc-98c5-84a33ca40c2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "043772f7-a878-454b-97c7-959946f7cc8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "dc036c95-a4df-4fe8-955d-e3cec467a0d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "1dfa4fa7-6237-465f-a35b-11a99a78eca2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "e9834045-3526-4260-a089-8b344489ae37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "7c1a6cc2-4b96-4f58-8e0c-1b94094bf057");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "2e7cea29-c375-4304-be26-edc569079592");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "44a54e33-75ff-455c-b6e1-72b6fff64310");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "8dcc9aee-9323-4812-87e6-f355babacb48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "7e8425d8-3c30-45cd-a804-591cfd25a0af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "fd815354-d9ed-4e00-b871-5a7ba2d3cf70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "ffe9dfe5-6841-4b6a-a939-438451d4f18b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "2a7b85e6-88c4-44e7-b713-3c44db2de81c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "e54c3d7c-b858-42b0-a6ac-b0cc2745024b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "9b668efc-bc54-44fc-acf7-6a384b9a890d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "833162a7-1fda-4272-94fd-92e6c5c41246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "8fa291c0-10f3-4239-8d1b-f9051d95a61d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "a0b13314-162a-4402-9cb3-fcc623e6386a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "7791ffc0-7307-4ba6-95a8-2c0c604e07e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "ccea785b-262c-4c8a-8368-84cf385dd4ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "77fcf23c-2bb0-493e-a69a-57d3e5e48e84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "f6a31185-2683-4720-9abe-674fda5fdffd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "f2659b71-5a00-4cce-9870-1af7c9747aa6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "5b8d284a-c953-4f5f-adb4-c20a11816029");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "5ebc6a47-45df-45e9-86f5-bd3ec3939ab2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "483d853f-b5fd-4b6a-bd24-5c2cf4c06c14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "9112e3db-e3ef-452f-968f-d53a08b1b41a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "35cf0692-da2c-4ef5-aca1-d1a78361a8f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "e9340c3d-65df-4b35-8e80-e4662d423ca1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "9d2fbd97-e2c6-401c-81af-c4b5095550a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "4ef6f31c-2b8e-404c-9b47-9ff15c47982a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "feac54a9-d329-4c7b-bef8-a425d3258a21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "57c0892b-8ee0-4d46-a65a-79a4cc98483b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "d4f25f81-284e-4584-a3bb-08f37e96199e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "a52606ce-3094-4c9c-8b4a-788e4d1714c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "5c5a55cf-7d1f-4e20-8539-06f66458a6f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "011a4a6a-d34b-4b5b-88eb-c5a890f016f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "e0fd1e9b-68fa-4d79-a828-cdbcb0960ac8");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(4936), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 11, 18, 13, 48, 23, 757, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(379), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(423), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(449), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(513), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(526), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(529), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(535), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(542), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(544), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(567), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 11, 18, 13, 48, 23, 758, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede36f3d-bd8b-4e97-a71e-715e93e3e720", "AQAAAAEAACcQAAAAELUIFSLYI5Z6+hRM1f/DWX0hlYR8RynEayYEWuckRcbDecebsvYml4Yd22Z7UqhHAA==", "de4bbda2-6734-4b23-8888-0b7236b0be50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a341c9d2-8b6c-483b-b866-d1345c742f3e", "AQAAAAEAACcQAAAAEJ+6rNjt5NiMIMyy8CsifqoSgtJy8r9gE6vvZU8Jb6TX2kYEKAQDJ0Y+O22f6hXU6g==", "f29a9581-3587-4987-bb9e-8624a6ed5fb0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb9ea7f-e079-4007-84a8-eff04cf2c2c2", "AQAAAAEAACcQAAAAENmqMvWGmlOWshm2tYc2KLYKDob6zqEy0Qf1dJEzI8WR10JCA0JeneN9Zr6lyx1fBQ==", "f36df34b-650f-419b-8d72-997c3155e4f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33c35d60-b95f-4372-94b9-56c5c9dbcf1b", "AQAAAAEAACcQAAAAEFQUtke+mSXUxiXaalMazf/xNkTp7cLNKw4wACobYdXsFymlHh2ysyQUtN5E+NC16g==", "05dd873c-524d-40da-976c-c5c1174c43dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d2b4fc-473f-409e-b042-96a5704920b5", "AQAAAAEAACcQAAAAEEtm9U6hCEATxJ7oeI12PWu1ApSm6kaNOqDXbrSjCK2UakJBp7cJkN7DdtB8UtwNdQ==", "ecb02802-8fa6-4fea-9c1f-e4f380675a32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89d5f511-77d8-49bb-8c58-7cac87460a8a", "AQAAAAEAACcQAAAAECr2dia4H1VeWYLFw34/IltjM1RG8ABFv9BTmhiVDoyxvAMs6/vtFS7a5ZE6NbBwpg==", "99aee405-02dd-4949-985f-3af834339ec8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fc95e8b-3e2c-46ea-9d0a-eeb7b2e65d6f", "Bilal", "AQAAAAEAACcQAAAAEP5ydAXjAXP4YX4Bolx9PSEgsw/4lcjN/bcaSjElcjI4ZsINSw7L3EHUqJXNTZQUJg==", "f3ea3aaf-1d7b-402e-9d8b-e2fcebe067cd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea238630-7e49-4c6a-a280-4203764a8553", "Nazlı", "AQAAAAEAACcQAAAAELMqpGlKmpm/h5j23DQC/K4DndycB/SfyDOUplqJ0cROuvdFx+uDbgvQ1zMed7iuAw==", "89e1bcee-0e94-4d03-b5d5-ff650be955ff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "801d46df-0153-4128-9586-2526a6f8ffc4", "AQAAAAEAACcQAAAAEF33x5P6ih7x/1n64rMYBkIIK5O/STrB917tN+KYxg7Tcp+JLg0Iom+CZ4QAOFseXQ==", "ea872659-32f1-4b70-963e-5beeb0a2df92" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Institution", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 9, "-", 0, "c398e3db-f29f-48dc-9985-319fdd717c79", "gulistan@gmail.com", true, "Sema", "Ases", "-", "https://twitter.com/adminuser", false, null, "GULISTAN@GMAIL.COM", "GULISTAN", "AQAAAAEAACcQAAAAEJMgSTcnjEz5OLNZtIevx3u6Tsobb5RAvDvChOS4MWmXzSyR8di2gsgWbyXBlccwWw==", "+905071273567", true, "/userImages/defaultUser.png", "901bbb4a-9431-48bf-80b1-888189e080f7", false, "gulistan" });
        }
    }
}
