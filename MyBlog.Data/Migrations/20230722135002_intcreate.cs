using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class intcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9423), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4016), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3814), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3818), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3820), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3822), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3826), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3828), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8084), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 7, 22, 16, 49, 59, 647, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5231), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6701), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3539), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 27, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 28, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3565), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3562), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 30, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3573), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3569), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 31, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 1, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7186), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7191), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 23, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(820), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(824), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(846), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 7, 25, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4631), new DateTime(2023, 7, 24, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4635), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 7, 23, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 7, 26, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 7, 26, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5265), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 7, 22, 16, 49, 59, 661, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 7, 22, 16, 49, 59, 648, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2031), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2035), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fa134d4a-38f6-4f59-b454-8aeeb1a12efa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "58fbc4a1-6f78-4e30-894c-87cf50c9a6c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "671f9488-e47d-4a81-8442-733dd9ddff72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a42edeaf-5b52-44ad-9cbe-22e9eba43ebd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e1e05776-d6f0-4487-867c-6e7b2e09a079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5935254b-508a-4a52-a44b-47650aa4fdce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "a1b55f93-a65c-4bad-9501-0acba87c789a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "3e71d7ae-b6d3-4bbb-bce3-1029840a5f84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "53412033-eb23-483e-86f8-13112b9607cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "59297656-7e5a-4797-a2c7-b5fd07aa335c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "54a1b230-35ee-48c2-9310-02131a703a18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "d8d13225-14ed-408f-b104-60348c8cbc03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "f63aca7c-86d4-49d4-a3ef-0c8b9cb4d4c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "007d2e42-404b-4366-af64-f8687ac5a87d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "df310a97-2c0f-4263-9b06-a8f49c0b1034");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "9baa8a56-0e17-4437-8ab2-19d41dbd34ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "9733250f-49cc-4c93-b77b-d666e590a44b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "b41e6fff-2120-4e15-ba3d-f47836ec7dce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "0d14cd9f-63bb-4ac0-b8eb-a31fcfea0089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "a15e381f-a4b2-46e9-a297-62e38a4af9e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9308b5be-214f-4e1b-9c95-33c0f0620f85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "a3ded53b-1ff9-4e49-8ddb-4d9d1ab24171");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "dcf9b888-7cd5-4af3-846e-3c6b1a6519ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "f4bff8fc-2535-4c3b-88b5-0f66830ca4fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "7362dff2-8555-406e-9aa1-5d41c0968acd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "2b6b01f8-3acf-4d83-9519-2ea4d802f670");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "1a25faff-8d05-42d9-bfac-8298723234b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "d5df4554-4606-4c7f-a224-d32ee31ed314");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "220aebf7-1762-4b12-a5ed-c8aebc30079e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "789a035b-3db5-45d8-a32c-b5bb1fa391b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "7963bf52-28a8-4655-a4d2-295f541edf9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "5f2ae3a6-574b-4ab3-9eeb-dbcbd7ac6170");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "71ccc2c5-5dee-4288-8dd1-5aa7e8343401");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "a07f0e4a-ce7a-4f19-8b31-ebedf484a89a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "bb0d6e13-3acf-49e1-ac49-05e2f6685e67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "afe78977-f36b-43f0-9e2a-753366d89786");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "b788f3ae-a28f-4f95-b8f2-f7763d92de1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "57beb246-262a-47cf-aa86-9beda0b8a66d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "f8cf74b6-398f-41f5-8dd0-a55680b33f56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "648d5b0a-7396-42ac-b3bf-36dd53cc411b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "39ae43f0-4cad-423d-8f08-1ffd22746588");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "a6f73eef-1c17-4352-aefa-8c8bf5d97c99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "8dabeddd-28db-47d2-be2a-1e8cd3a3245d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "d18b9352-2c07-4198-a78f-d97fcd5eda52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "8e181155-596f-4ae7-b391-d73e05456884");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "94cafbad-ee9e-45f8-b58f-23d44aa3919d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "3ef5c2dc-bd10-4c59-a7c2-3364a28e3a47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "fa74bccf-199d-4e6e-ad51-94383f48d2c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "2e017694-a382-4def-afb8-b30d4db41c8d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "9d6666e3-2f1f-4bee-8b58-4f445bc02976");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "93057ec0-3b1f-444e-901a-1e53f7ac5762");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "79b8f886-ca45-477d-9ed9-8fa17147f2ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "9f3e3102-4f1e-4c14-ab2c-8fb0a67a7044");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "178367c8-4efd-4f01-a7a7-0e2973fec8c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "2c169d3d-d67b-42e7-9065-b0313d58de17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "e855a893-3567-41d8-9955-efc24110b79a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "f73a2d5c-69e3-4160-add0-5b99b35fde96");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "5dc1b83c-fb46-42af-80fe-a7be1b74a162");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "46ce58ec-bdf1-437c-b7ad-07f8ef4bea61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "13226f38-031e-4013-a5ff-046eb36f6730");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "8b405de8-a62a-46cd-adf2-3981ca9da0a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "becdcb3a-790d-4b50-99db-7aebb1d53393");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "b7635b17-6069-42a9-b4cb-4fa1935597d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "1bb84b5d-7784-493a-accf-cc5fb605b97f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "4d75a036-dc5d-4abb-b602-224204f71799");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "f40eb99c-647e-496d-a4ee-2f2a8efbc710");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "42af540f-a1e4-488e-950a-51978aab8461");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "9d42869c-f4d3-42cb-bce9-18f244dc8d86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "8faedf1c-4fec-468d-bee8-664efc60a1ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "816e233b-45c8-4d99-8ab7-554bffd635d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "e62f6790-35bf-42dd-a0a0-7f02e46f856f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "769927c2-fe0c-4234-bbb3-992028bf49aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "13b23f5d-65e4-4898-bd2c-150fb72079d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "09d50e79-fbaf-4214-bede-ed06d4651178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "eab7853f-f9de-463b-b88c-9b992fb324c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "9ab05533-8f80-4cfb-a1e9-31111e9d35f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "7a968784-7ba0-4d8e-9632-2a28bec553ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "9b32a881-9125-4fab-b4df-0eed8d91aad2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "cb58b845-7f88-4c53-9582-2c78e7f8be28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "f33ac1e4-c55f-4977-8626-9b529fc3abb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "c9064eb0-c452-4c5b-a3c5-0191677b0e2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "0e4b8d79-04a7-4589-aea8-056dbecdb2f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "73be497d-c833-4e13-93f5-54f22f4e7ea9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "41b67188-e88a-4e11-98b3-599584450569");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "f6343ab6-c701-437f-93c0-3b6ab6644c35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "9d96c725-7f0a-4fb8-9370-c89d0c97730d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "a701aa64-005d-459b-bf69-9c09a6fb0ed7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "1048596a-1dad-414c-b0fc-a1a866f6cdbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "2ea876cc-c5a5-4fdf-9cc6-1d872227ed87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "84e2edf6-5a89-4a33-a55a-8f5c03f0c4c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "9164789e-975d-42d3-95b8-caf95b29d242");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "9313b255-75b9-4211-bdcd-45aabadf6d3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "63885373-b2be-4818-b267-a0b37f1d4031");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "b93094c0-6131-4205-967c-9c28e3199c0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "2e3b775e-0673-4383-8ef3-fae62198e4a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "e7527fd8-4589-40ab-9643-52be44767874");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "4f5e2d3e-4072-49e2-9170-57071e47e950");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "628b4baa-3e49-4bd6-bbc7-768dfe394067");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "80f847eb-66a7-49ac-a550-aec988c1ca98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "40c3ac1a-9c17-42a7-8ab9-7534c883fda8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "88061f8b-ea92-432a-8767-d4c42e8f4577");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "ac372003-2fe9-404c-b0d8-d8dfb6060e04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "5ae7c228-42bc-4f93-bfa5-46543acdf488");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "cbff6735-1320-44d6-9ef7-029c649bb563");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "3f05baf1-f60a-4047-854d-7be66724c940");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "1301639c-248f-4384-b9af-20dac2b37dc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "698f9459-7fc4-47a5-8e3b-17138175ecbd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "0e57f095-8136-4618-8c5b-4f1d650801a4");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 7, 22, 16, 49, 59, 662, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9363), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 7, 22, 16, 49, 59, 663, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 7, 22, 16, 49, 59, 649, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3361), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3365), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3369), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3377), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3381), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3390), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3495), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3507), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3542), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3546), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 7, 22, 16, 49, 59, 664, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4c29b2b-5d1d-4c8c-b054-add400d75653", "AQAAAAEAACcQAAAAEF2oUZLFP37k8GS4rZw1lNbht9X1nDN11ETlAo5n3Jjt/DR+RpTpTU1I7BjDm8yEWQ==", "e162771f-cb11-41b1-898a-cc17283e2b31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b796a40-0567-4352-9462-5cc46e113e8c", "AQAAAAEAACcQAAAAEOG+Lic4pWL3uO5Ip0aMY6QHDDflVzrwk7Ejit1f7rdImNUmW/R8XeJ4b3t4vOUpdg==", "3c995fc1-fbd3-4940-b396-f25bb9eefc67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b082305-5c50-4d26-b730-0d46e4636229", "a53a964a-825b-49a8-b88e-8463894b5085" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4147), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8278), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8286), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8292), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8291), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8303), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1448), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9734), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 7, 9, 19, 35, 43, 67, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3354), new DateTime(2023, 7, 9, 19, 35, 43, 68, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4072), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4077), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2413), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 14, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 15, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2433), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 17, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2446), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4786), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9518), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9230), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9231), new DateTime(2023, 7, 12, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9241), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 7, 11, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 7, 10, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 7, 13, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1506), new DateTime(2023, 7, 13, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3375), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3379), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 7, 9, 19, 35, 43, 83, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 7, 9, 19, 35, 43, 69, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f69a630a-d09f-401f-b301-825412467ae5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e95b0b11-2811-4eb9-8fc3-0ac6ecf9b9be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c4626207-65d8-4c88-83b4-18b6ce964860");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e95db7a7-d5af-426a-aa23-dae2c0aa3d76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ceaf07cd-17cb-4f29-a4ab-481a55fb25d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "8475a65c-f7da-4071-92fc-45f359411350");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "3d4000bd-3d21-4a7e-9cbc-84d3874e970e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "62d42071-d39c-48a5-bc28-aaee6f208c4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "203e8c5f-e3d0-4679-8b84-3606893c33ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "314fa597-a125-44b8-83e1-de4a1f02051d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "d3a68733-edd4-4d50-8312-7c949ee67db9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "e8a2c68a-a5c8-44b2-87f0-105a30991de1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "11677a66-695a-4f51-b7a9-67d1d2f1cd11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "18488d26-7aea-4503-927f-2f0a94f8328f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "87da20d0-0e11-49e4-a8d8-452d7ca1a1fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "d65ef4c8-567e-481c-83bf-14cf0efd1ef4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "d5b469ea-e073-496d-8bbc-5e4510b6a97f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "3ad1c363-db10-4281-8bae-c87ca6573076");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "e7541d52-e885-4195-ab1d-da02037a4ce6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "ce78b735-ec48-4bef-bf1b-135c6d6ef438");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "d45cee2f-a721-4a3c-a49e-237570ce3da5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "5bad4a3a-23a9-4622-80ef-6931f3a92ebd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "9507b36a-8959-44d1-8485-bb172e0da4a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "3c8967a0-e83b-4961-8b07-061e2cd4b633");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "514b1bd2-1193-4a80-aaef-e64c416523dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "56e56b4f-fd10-4bb6-a6fc-7ec26516d48b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "2fbbdb1f-792b-480a-a1d2-2c18dd52529b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "b58e395c-7a9a-4265-bb10-f5860693e5b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "46d87dc1-5279-4693-a6bc-b3952b11a621");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "9f2f4b15-ae91-4bd8-bb72-3d349504a99d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "77f057b7-be61-46cc-9084-8106ea17ceda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "15ca6a6e-44a0-4dbe-8f93-0c7c75f07d58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "1d954a1f-a7d4-4af2-b141-f367f7cf4c06");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "0bb2a5d8-757b-4a86-b7d5-8ce0cb60ec51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "d725f202-e66e-4eb7-a18f-b3f85b12aeb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "ea8b9ff8-1b41-45dc-9d43-0cf3d34cca6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "04adba40-115f-45d8-ad18-4224a32640f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "86847b11-1541-4d33-a6d7-7b37a5a4ab3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "4c6d6c31-c5a9-492b-92ef-638ca1e753c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "bc676762-f301-4d34-9be7-21bd78971858");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "477cd233-e7f1-418f-a37f-0ef0e267fe92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "5534cfb2-6fc7-4437-93a2-d801b1aa3623");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "399b70f4-9194-42ea-a7fa-552f6d507121");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "d8b425ec-27c7-41eb-98a8-2dfc6c885b61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "45644134-6d95-430d-af35-1af2216acdb6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "f754f39f-fab4-4ba8-82f2-454c5886d430");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "f91194f9-307d-40f0-96f4-d06508b65582");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "0fbce8d0-1464-4180-8e63-a1e323721d7b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "01a10d3c-bb16-4185-9337-5239ddec40cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "0e42cdc8-a097-4102-91ed-5557cf717404");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "d4d6ed3a-f7e2-4e20-bdc1-d5241c110082");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "fa5a2c4f-791e-4971-aec3-855829efc7ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "74465ef8-cac1-4393-a0ea-519eaa6e5b9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "047d4320-3697-4199-a6b6-1dbfd177478f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "38614dd8-e4b8-44c8-8773-3dfa6eaa9b22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "bbf22a71-2c73-4bfe-803a-5d39ab093ff4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "b2ed7eb6-23f0-44c9-af19-e0f044506801");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "87e8e518-0429-41d9-af15-87e26ab03c6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "966a84e7-0737-4b2d-93db-5a7196e11d78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "08084969-07a7-4314-967f-1d57a463774e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "a9aa96d6-385a-4e50-9d9e-fd80785dc9ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "b80dcac5-14bf-4be8-8f1b-5d599a3743d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "88d5d815-0b5d-4ca3-a759-74f44dedec28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "d83f11b6-0215-42d0-b017-767b00a468af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "d62e9650-dfae-47f6-9bc9-5ac670310524");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "b7725ec2-1589-48c7-a021-bfcda235ecf4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "e6f36f21-009b-4fb5-9968-806c593ad3ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "56041f33-130b-446b-ae5a-2daba7d0f195");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "84fe2c2f-ab81-4155-acce-cbe52a274b98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "d6428df9-82b3-4d0a-bc44-24f0161458b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "77e91438-580a-4731-9828-ccd22c3b8f73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "b242cb56-1759-4c6b-a9c7-ce0039de571d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b43f54d1-cb0e-4e47-9c17-204f044f39f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "103ea423-79e3-4a96-9b35-98d0e2cdd928");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "d2c2948f-cd1d-4e0d-a5bd-82d8064e2635");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "33d619fd-2c10-4429-a812-52a6cf75ddd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "76016ce2-0e3d-42e5-8aea-19d30c81b0c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "5f7219da-6423-472e-9619-bfa4c856a778");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "7da39206-a6f7-4ecf-865a-d2094624f501");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "08915c9b-4bcb-4eae-bda5-fc9de13589e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "0049d657-7183-41a2-8d1c-6843bdc6cd02");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "87163784-182c-411f-bfb2-445fb7324b0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "ae123afd-5f2f-478a-b413-f8cd2d6f452f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "15facd4f-a57b-48ac-ae83-66212c4c2864");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "ec442ad0-5d24-4cef-9a04-1d349e4afa63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "f7b1b976-1abf-4262-86e1-cf589b423923");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "71cc3c50-b8e9-4ddd-b4d1-7be23f466d97");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "2bee6fb0-f11b-4004-a069-dde8e4e804eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "e67f1761-26cb-4fdb-8a8c-148c6ff11c4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "53635341-4e1f-4fff-b367-981b3826cee4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "f0e4d1a3-2434-4556-942b-86e2bbc3aac4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "1887a9dd-3ba4-4476-b4ef-e02e313a2b6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "6ef7fad6-13e0-4bd5-9f1c-cb77ea4ce56c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "eaa5a5f6-820b-4808-a6bb-6d88dc091e74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d45e3204-83a6-4b09-b079-2153fe09cec8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "68d712c5-fbd7-48cd-bbdd-c7b0f33ab230");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "5d06a40b-502f-47e2-86f3-528a39d193cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "7625bb2d-c947-4574-a79b-e2d9350ba4fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "e3f0a0c0-0d35-42bf-a4c2-77e347ac6efc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "b59d48dc-c830-449c-aa67-3133866d9384");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "b07d86c6-4621-480a-8dc0-499f58f8a473");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "bb8c1efa-9577-46f4-ab72-55906c045612");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "2720bfb9-199b-45ba-bfcb-9a43e0816036");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "6a2bf722-844d-47a9-b036-452ec6d64d9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "ff7346ba-e968-4110-894e-f3e2996d1697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "be7299c9-29cd-406c-bc45-75ddaa97365f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "24fabf54-2730-4ed6-895d-43b029b0fc0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "fd7a0146-278d-4680-84ca-1f0ed949a9b1");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8346), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 7, 9, 19, 35, 43, 84, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 7, 9, 19, 35, 43, 70, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1019), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1025), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1028), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1039), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1073), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1076), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1087), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1098), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1110), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1127), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1130), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1150), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1164), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1167), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1170), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1176), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1178), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1184), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1187), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1190), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1193), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1196), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1201), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1204), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1207), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1210), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1216), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1218), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1221), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1224), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1241), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1255), new DateTime(2023, 7, 9, 19, 35, 43, 85, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcad174c-2a99-470a-9fa4-ab0c77a56e3b", "AQAAAAEAACcQAAAAEB82V12TXz04VLdBoqUjxg1M/1P6KCOiXZVo3S5REoe0bhSA845CNiAHFirwozkeqA==", "d0650bf3-d4f2-41fd-bcb7-e698dc7a8011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0991fef8-ffdc-4e2d-929c-2bdded8f2f04", "AQAAAAEAACcQAAAAEEvuM7jkb5uGaf7YSSx7xb4PHrEqR69xslVHv/havX1dbKA3p+vyFsI3NHlhduDpAA==", "2d26cdb0-a3d5-461c-9433-56ecb6ee2314" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9030e4e5-1dc2-44a9-8dd8-3d2b91277d55", "fcdac9eb-3389-4d65-a49a-317f286fa1db" });
        }
    }
}
