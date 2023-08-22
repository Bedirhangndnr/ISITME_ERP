using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class addBerraElif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7083), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7084), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7089), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 8, 22, 23, 10, 5, 359, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3831), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3836), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4323), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4329), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7463), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7364), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7200), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7205), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7207), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7210), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7215), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7218), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7220), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7236), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7238), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7241), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7246), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 8, 25, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 8, 24, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 8, 23, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 8, 26, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 8, 26, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5272), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5292), new DateTime(2023, 8, 22, 23, 10, 5, 370, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2f3fea98-1dba-4a3d-9f13-1e8026256c59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7d38e081-da20-4fbe-9c52-ff5975896d49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0d212dbd-5664-4bce-b9d8-54d1f3a5b82e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c14313e2-a81b-4b72-89c6-f442b8879aea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c6af9a17-8428-4537-adfe-65de7430427f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "329ed17d-1332-493e-b452-defc4abb11d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d285aeea-98b9-4651-b230-9171a1f4c6dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "4f24cbb9-4618-4985-92cd-02ae8d5672f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "dff82ebe-efbd-45f0-9ee6-72229442a4d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "11051320-52cc-451e-9ad1-41bc23d62889");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "c0ceec4e-03e9-4a8c-8dc1-20137883baa7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "83eea199-a980-40d6-a53c-369a32150748");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "b96a7d5c-1681-4dde-ab05-3071dbd021ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "f3342b7d-df57-40f7-9e69-17a9c46d47bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "bdb73b12-e5bf-43a6-984a-7f6bc3b459f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "3d716c2d-9ce7-49d2-a928-177a4688f872");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "c14a3e34-3fc7-42cb-b06b-b87bae2cf950");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d18e8356-dfdd-42d0-a502-a43feb6acf1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "453447da-6cab-4346-8e84-6bf26601e002");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "aea9e855-794f-4bfd-a578-3ccaedf151c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4f3332bc-8850-45ea-aa2c-4d3edfe4b407");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8110e949-61eb-42b0-a775-987b7c9a2747");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "139c6e23-3e3f-4dcb-b944-ca7c6cf571d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "c0b35be1-b885-43d0-8e24-3581c5ad51d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "bb8c1672-e52b-49df-97b6-4d5ae23b3e51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "a1c998bb-7f84-4522-b7eb-d2e82346a415");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "f4a2c4db-930b-4d3b-86be-324b5f5644ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "bf4e63e1-0bd8-48cb-83e0-e019780d73df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "0a758c29-a05a-4c62-9bdd-dd0f8986f79d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "8626faf8-fe66-42ea-8aed-e27fc8b1571d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "031b69e7-a85b-4f15-bfbe-beb34d4700dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "e7ad5b14-b3c8-4245-a892-ceaf576e5880");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "60fa1285-71cf-4af5-a7e9-fd1df49a3bd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "bf7ab069-5632-4e66-9f21-0737c38cf74c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "5725bd8e-f771-498b-9434-844f45f78927");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "82b8b249-e6f0-4f9d-a202-2566097e8692");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "0e6cd074-11e6-486b-8c7a-519f756f3fd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "1285b0d5-d0b9-4d94-83ff-9ec81a582276");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "2621b2f3-b1c0-4f4c-a234-634ca184a1aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "79d8653f-e457-410b-aa89-c27d8183aeb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "4dca4ef6-5b4d-4bd0-ba27-f17e121517dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "642f28d8-85bc-4c67-8007-7e82f7fb36ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "7aea2c80-a729-4a45-8874-b6d9a87b7a6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "6a820f49-460b-4d62-a4f8-0127cdde81d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "8cdb716d-2f00-45ff-8e84-30b44d95667e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "7ca70a37-7f9d-46d8-8d30-1e467a3436a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "531bd7bc-0873-4b09-a09d-695389acf6d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ec80163a-958f-49d5-b317-1817a087ca50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "fbf32f39-942a-4356-b86d-d5a55236a766");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "44f60f15-761a-49d5-b455-498333d4085e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "ee006b08-c0a9-4c99-bc19-04b94362d033");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "f8c35359-ad55-4f41-97ac-7d8f50714a4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "0334fa26-7703-4950-8145-e8a259f2a874");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "02960e57-cbc6-4d7e-9780-c0c67aef11aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "31256a9b-a9cb-4244-a244-26057f67edf5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3af3f196-a784-41d1-a5b3-10ef18e198f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "b7fbedd7-7d3f-4f14-b461-037d22301719");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "fc5be028-c188-4339-9d5b-3c5c42c58383");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "af6405eb-1104-44f1-be31-0d1cac506645");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "0d5a7a5b-815b-4aa7-b504-6558da36d448");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "484db1d2-7a23-467b-a032-5772a100d71a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "506ac815-43c6-46d2-9ff4-df6462bec980");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "a9267b59-c58a-438c-b1ae-665fcbf6e857");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "ea497886-15c8-4ed0-b30e-c70df4e1fd9c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "d14f393f-f15a-4de4-a12e-0017125bba16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "e51ae1f2-8c58-4be3-b665-bf99c2adecff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "f81ac488-96b5-4a12-8da0-d0a995ee6d5f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "27c9df6e-f5db-4829-965b-d0220ec8d23e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "52ff0736-5eb9-4525-bed5-c68c1d9df88f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "a97bd812-3ffd-4e4a-9b67-9d29a9c503df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "aa679fcf-58a1-4d07-84ee-f547a27d0e52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "667c121e-8f68-4198-ae1d-8f8de64b7ce0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "1b2e7136-4575-4bfc-be36-50bab99c57e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "10cf215f-8e54-4f95-9b82-1e41b9f843e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "ce24e1fc-ae1b-4c78-a4ff-0705115e4114");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "39301f7d-a16b-4e53-871d-d08d5159bcca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "7a154cd6-158e-4985-9a19-b7bfbc781daf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "dc1c89de-9282-4357-84b7-d2fbb8181969");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "da7c761b-64ec-4c3a-894f-83afcc5f8199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "46711ace-cfb2-4d4c-9496-0bb2b60051f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "de21b9f0-da04-43f2-835f-5d9df1b45bba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "4f9cdbec-fcc6-42dc-ac9b-0a02fd19fa90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "043fddb7-5cd6-480c-937c-0bd34169907e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "3362c119-bdfa-4986-8467-8cc9dbd8f77f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "967f2ecb-7867-4fa6-be3e-600d3aae92f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "a67aba07-8f2d-4ebd-8c49-a05b6813baff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "f758ea3a-daeb-4c99-b7cd-e34500f08d4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "af8ac1ec-b4e4-4f1e-bd0f-5eddb856943b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "a3c9b888-4892-4b89-9147-5d8594449f9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "a2fdf4bb-2e4b-474c-9b7f-04c1f8faa386");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "719df217-835f-46c0-8b56-5f7c82fc1665");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "94215de9-0a9e-4607-8c96-5823eec951d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "aed9407c-a4d6-421f-b6f6-83fb123ec499");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "f4a04086-adc6-4dd0-aa02-a0634301626b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "23423238-2a8a-4b39-945e-4a984e3e1ce2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "bf16ebb6-65c1-47ae-85b5-3e0813584d37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "c554d09e-0f03-4c38-b928-e1efe720eefa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "03ce29fe-396f-4fc1-a5db-a8ff09db4a6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "0a9974c1-1c1b-47f0-b5c1-85f49c22b778");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c2248479-aa18-46cb-bf77-e3bbe93386f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "dcaf1881-3cee-42bf-a1bc-261ed2bd8402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "f038c6af-b5fb-45cf-8b8d-58a64a2e40d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "ddfd25b1-9ae2-4b40-8c45-57bf2571ba53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "fe55237d-c0ae-4182-9c65-6d71f951cc09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "29dfc40b-93ce-4e7a-8c2a-4a890f33ae81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "277eceae-f78d-452e-b1b0-71bece2fbbe1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "723d160b-e024-4b65-a74f-e226c6ed8dcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "35cd081f-d450-4222-bb34-1a6ba1746127");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "a5993a7d-8716-49d3-ae5e-b8f6a8507c1f");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7145), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7148), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7154), new DateTime(2023, 8, 22, 23, 10, 5, 360, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6783), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6876), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6881), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6897), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6899), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6912), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 8, 22, 23, 10, 5, 371, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f10f1fb7-9b3c-4bcc-8e7e-1bafe10ce371", "AQAAAAEAACcQAAAAEJ4fVSojDeLJJCZc3lcJoL1AG1nRGsi+33ZlMrq412RSJr1dEsTD0XM6enwJE+XN2g==", "fc2928bb-8cb7-49cb-ae82-7c54fa98f059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7441b832-093e-4e71-8b12-dc84ed300371", "AQAAAAEAACcQAAAAELvmjq3YZqo5DTF7YIbAZG5Fv2e106jee4axWt2X4sBtYZT8xCoSTghbscQzVVM7Xw==", "0f56580f-4220-4d40-b705-ac8599086b55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8298ec-9c47-4e43-b8bb-31284e83026e", "AQAAAAEAACcQAAAAEGH+Jg4vqrAAGWQTeICK6c5MP7RiVzhGUx8aGu1l5xXSQFpNDAdgn2aOUxFkBfw+SQ==", "9af4b27a-c40f-4282-91c4-dff8edad9626" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f37cc568-9e9d-472a-9f2f-fffda914fb5a", "AQAAAAEAACcQAAAAENGfDqHozwRR8prpgVtoKWRmkuYWhBBgMxc1r8W9pwPpmDJA5tCSkip0HAyzvKX3kA==", "67073047-8907-4681-85ce-e7e0cda67a91" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "Link", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 5, "-", 0, "07885704-4ede-42f8-b418-ab2d2f1c2968", "berra@gmail.com", true, "Berra", "-", "-", false, null, "BERRA@GMAIL.COM", "BERRA", "AQAAAAEAACcQAAAAEHEdsm2zC7Nwx8ho4Yl0q7f/CSIyYi5SRpAtpTmPbCzVOXQt9k1y7+Kydh4tvDf06g==", "+905050102249", true, "/userImages/defaultUser.png", "c9afc6a4-1159-4325-b613-c367646eec66", false, "berra" },
                    { 6, "-", 0, "8c56f2db-775f-418f-adcb-fa9dda4bfd27", "Elif@gmail.com", true, "Elif", "-", "-", false, null, "ELIF@GMAIL.COM", "ELIF", "AQAAAAEAACcQAAAAEChQqsE+HwhB1oFxDaen/dJttYLCeOtysc/6AZa8+kVat/EZmh7VPT+WgiVgyarVMA==", "+905050102249", true, "/userImages/defaultUser.png", "1659c4b6-0087-4d68-9ee4-b666ad7ce2f8", false, "Elif" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1875), new DateTime(2023, 8, 22, 22, 37, 47, 372, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9322), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9339), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 8, 22, 22, 37, 47, 370, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3292), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3295), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1360), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1364), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3685), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3584), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(746), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(763), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(767), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 8, 25, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 8, 24, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 8, 23, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 8, 26, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 8, 26, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2509), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 8, 22, 22, 37, 47, 382, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1679), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "727fc4a1-3e36-4f60-9d76-335a42887527");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "11dcc66a-2c74-4611-9e40-f5917ce274ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a5a3d17d-820e-4a86-b566-5699471d9b94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "25b61556-6642-431c-abbf-5fa085616de6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9cec4f5b-23c7-42a9-9a70-697bd7a2dda0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "0f213d17-dd52-4e4c-82bd-967a2a2abb2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "a3198b56-5f8b-41c8-8b50-e7adb08b0a65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "538ec7b6-41be-49b8-8c70-e4b711ffd542");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "c7b28d09-1230-44b0-b3d4-35345855361f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "843377bc-f902-4bf7-8dcf-fa970a7a1de7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "f88866a9-e843-4624-85ad-e5b266991987");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "f65ec857-fd9f-4316-8142-0bbc3d5887be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "0885b630-e6f5-4eb3-9994-5f4599087c18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "dbe4f9b4-4639-45b9-baf3-e7fd3bdee53d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "809bf588-177b-402a-9756-5372848d0d67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "7c27fe4e-94e1-417c-b3c8-8808e9aa8a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "44e994a8-a485-4137-ab5f-5fce9afdecb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "4b144d2d-618a-4f41-adf7-006962059a80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "ebd2f92d-81fe-4ec3-8927-61e4a6dd7879");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "5a981157-2ab1-4d68-b753-09b1eb5cf15f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "2febe768-e189-46c7-b679-591084764080");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "717651e6-3f55-4025-b814-7cc86fee7d54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "cb22bc0f-d5fd-4046-b3ee-51172b0b9964");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "76ac3203-59df-419e-9449-5c0e520b0c6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "38138157-1d8c-4054-834e-b2b027f4e130");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "c68b1afe-969a-4066-a21f-b39bdf69cdea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "05e33938-b525-4542-9211-cec6e586a7c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "30f153ef-42f8-45a5-ae1c-d9ba8da97ad8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "be2fd7da-11a5-407b-97ae-987cdceab83d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "42604cba-6e93-4d54-86bf-6fd80b1e5f5a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "35f03645-eb18-4d4d-a218-5d043304ec26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "c2fbc89b-9928-4408-b370-a2457145a683");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "95eef221-db26-4a57-b9c3-aaa2cf70952f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "57fadf9e-066c-436e-934e-f5c1e6831d4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "d808d460-2f49-4fe5-b1c2-f0ff5cde59d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "639d2930-e1a8-42fb-aa8f-b6b429565fd4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "92c41e2c-0fa5-477a-adb1-e10367ca39ac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "70f95468-92f5-49e5-bbf6-18fed4a2efe5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "5dc9a9bc-28d3-486b-b6d8-5a7ef16aabb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "84a15aed-e24e-4368-9de1-e48a2bda16d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "26f29fed-2643-4642-b8a6-45e41692ef5b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "b152a513-93fe-4b19-b416-cbcd184d50ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "3b6f644a-6441-4e24-9c2a-c82cf57454b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "1366a593-02a8-4cb8-9616-e479ae018972");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "24dbd8a4-553e-42df-b162-b3d0c67a5953");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "5736631e-2b42-4eac-aeb1-9e3d8fef67cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d5d72342-01b0-48a7-af55-176422639bf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "27cb91ee-cda0-43f3-a224-ba1245226547");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "8f38570e-0d6c-4531-a2a9-931e317497e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "4e8caa43-b868-42d9-886b-b5b2eae99b3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "514013a4-06ba-4cea-b166-825a329ed0aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "615ebac2-1890-4a22-9b8b-229778df5336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "74622c98-31b1-4bc6-8f25-6381713bd140");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "fd128580-f75e-4aca-9f3e-316a4e4735f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "3aed32db-7f6f-4c47-b1b4-78623967a77d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "3e3183cc-751f-4fe8-bdb1-c60df7c14ae4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "55d82497-d71b-47f8-a18a-208a1732a558");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "832c527c-bc1f-48b1-b225-567e4f7d179f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "95ccee52-6c0b-47a9-b26f-45d6db8e3253");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "590b179d-6495-4652-9217-4a0bf95d9f5a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "f7826d30-7e4c-406b-86ee-25e365f56f4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "c5d1823a-db54-40f7-986e-029c84f3d725");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "b130b14c-fa2a-4e1a-886c-d0aceb64fa58");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "05be1543-b5f4-41e9-8aa8-b53411cefa9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "35bd8ae8-fc9b-447f-9e01-e66e32daa9c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "52abc163-2717-4766-ad0e-449604fc5a52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "ad2eef24-71a2-4640-978a-d4c68b4471e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "1883fb8a-3371-43b6-a498-123f15b6af20");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "c4b0b36f-ad58-4471-8322-0e8a602eed2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "49715c82-7a1f-42ec-86ff-e6dde4d926c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "21111f40-da88-4c3a-8952-d8c4fb3ed259");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "71c36186-c678-4a7b-9bbe-9faecf5796e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "1d28dcbe-7081-418d-aad4-bc1487a24ed5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "c9deaaed-db4c-4f8f-abea-48702ed2f939");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "ac87d71f-5fe0-49a2-a664-56e0ae6cc4ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "be6de845-cc43-45cd-a55d-36d386b2645c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "6133aa16-c9d5-4ed0-934a-7b70270362d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "9e0bf8a3-60c9-4238-a1d1-9e2b663b1dae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "13fe87a4-e903-4275-8557-0bcb21b6556f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "f540d06c-a1d3-4135-90fd-773c58689a3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "557225b5-1ca4-4683-ae6d-cb7c872bd909");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "322481e5-9848-4e09-926b-d773375ef6ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "018b6732-4bb6-48c5-873b-67b7efb0b556");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "2b045918-dc26-4079-86b6-ce9b355a2c75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "5dea7625-53f6-41bc-9ec4-802e68ab9aa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "5ddd7306-7243-432f-93cb-3c6c75c020b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "5bd948cf-9f56-46a9-ac90-b7a2956f90a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "c1b93a5f-c08f-47e6-b437-8b87dfc24e45");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "3940d2ed-b294-43a3-8d6c-fff7b58bee99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "29b29fec-2f97-4572-bb9a-593ba48c55e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "ce2594aa-c832-49ce-a3ce-f777179271ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "bb35ae09-71b0-4c5a-b928-91983f83ab2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "90f6d5eb-8ea6-4e76-8964-149307f0661a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "8c41e154-98fa-4d08-98c7-daab3521e8cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "a290dc1d-5614-4c67-8390-1ef0983c80f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "e5b83b28-cdfc-4e6d-bd82-dc6eed2a3025");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "27a31cd3-3bf9-43e5-af86-507decb006bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "760dcc5f-099a-49ea-9a86-01701c54b878");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "bb37b8e5-058e-4a04-b93d-18c7a3d858df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c677ddfe-40fa-4bda-aeb4-99ab96ae0bdc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "19a0a60c-9be6-478e-97a4-27dbd3765b97");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "dc2aad9c-b47a-4415-8ea2-5b48292f06ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "c52990a5-24eb-4d16-89e1-114b0085841b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "61644c96-08be-430a-a7d9-3149a5072757");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "7d08339f-6ffc-4fdc-a02c-dbde7da53053");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "c631503b-0983-4a58-83e1-65af6bb5c201");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "e6f011e0-171b-4d8a-a852-949b8b005f77");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "33a2944b-ade8-48ba-9b8b-3329cbcbac35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "67206247-2192-4e72-9f1d-60c58c472965");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 8, 22, 22, 37, 47, 383, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 8, 22, 22, 37, 47, 371, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2629), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2749), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 8, 22, 22, 37, 47, 384, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d535a1-4291-41b5-8ff7-0369512f67dc", "AQAAAAEAACcQAAAAEBfJ2HxgGj7snQknYBK49u39Cd2raPORXQLTjUGaWw19joGobo4NRQLsmAu0YFy+Og==", "9d75bc09-f5c5-4ebf-af53-636e5de5490c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1c9fc99-38ae-41a2-9e72-0e8518edc8d5", "AQAAAAEAACcQAAAAEJ1e/OH0LAt6L1py9AviEua8CW6spwVUAvbikRCVCwAVclpT3thwqRPcle6dUBPp5A==", "e62de4d1-378d-41b0-9627-e50e54429812" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba07cb94-d01b-4572-9be1-4ff7f433b975", "AQAAAAEAACcQAAAAEFCKa5tjqToDm43CT6QSoutfxjLeia8Y+6ycinZO4SXXYyjenaDo2m98ed/0LZDlbg==", "a79df583-b10c-4652-b8c8-ee0be76d5b31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df268047-2157-4083-adbc-5a95bc4756db", "AQAAAAEAACcQAAAAEFEKe5dhqXckc1ayZyAOby5EaFhwDbZcJd/VdUlNdWCerbHFZE4DyZ72E5ypZCER4w==", "d4418a01-51eb-4da4-9c79-0472f80e5e3e" });
        }
    }
}
