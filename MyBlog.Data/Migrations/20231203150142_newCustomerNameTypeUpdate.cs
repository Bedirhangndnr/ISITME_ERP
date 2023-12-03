using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class newCustomerNameTypeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NewCustomerName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NewCustomerName",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5539a8da-de2d-4d3e-b21f-cea541b31b3a", "AQAAAAEAACcQAAAAEKGZaQAPqNpesk/Zh5EN2m7YIEKzygfKoM2nVuztRegxX6AD9exOM7P+qOPVSpDRwA==", "6a2f4101-ff8e-4ed7-a80b-d2eb33b92a97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f482e63b-6b16-4510-9cd1-c321e66bf12a", "AQAAAAEAACcQAAAAEBBZJqTct84XXRZ8RTkHOZ+4uzZ2XHvUMcFo99g94t3jGwfqMOCglRV0XmKa2vqtVQ==", "a38bd842-b3c7-473f-87b0-bace198ab66d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c26542e9-7301-4a18-8439-ed8ea4c3d2c8", "AQAAAAEAACcQAAAAEHjSqDB2QmFSLJ2CEbKoMl3Za/our84550+o/NXF7s+PyXy5sNYnhoo8sfKEbEQFAA==", "b7859c0c-e232-454b-9dad-3b383362d6b2" });
        }
    }
}
