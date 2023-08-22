using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class updateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8248), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1000), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1014), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1024), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1030), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1059), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3782), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8170), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3645), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 26, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 27, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 30, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 1, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 8, 22, 20, 43, 21, 604, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7186), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4046), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 8, 25, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 8, 24, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 8, 23, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 8, 26, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 8, 26, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3895), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 8, 22, 20, 43, 21, 616, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1067), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c718fe4-bb18-4e76-8ff1-2904a0f135d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "98882ca8-9fd1-4e63-be3d-3d43433a160f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6ba2bd77-b015-4449-b5ff-9fe203d530f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0fa1f816-7f26-4211-83ed-b9785941d29d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d8c5b624-1c4e-4500-8f0f-86bea69bd660");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "8eec020e-da99-4d3e-8ebf-bf21bd6f66e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "cbb8ada1-72e3-4f46-867f-294ffe731d1b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "28992952-f576-44a8-9758-bf81ab310540");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "0ff03e53-637a-42c6-8ee4-73c8dcddf7ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "ebf93765-960f-4ae8-897f-b73fb5d6c5e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "b1711577-41f1-45dd-a270-05e1d7efdaa6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4314c1b9-c914-4d44-8f39-6e3cad38f09f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "02e67c3c-b1cb-4b91-9070-2197ef804217");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "c2e0e2e1-8525-43fa-8ec3-c3116d7028cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "900c85db-8a25-452c-b14c-1462fc62a5c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "1d876844-8f77-4272-8ae3-01bf6c62f12a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "06d1ef19-304a-4a71-87b8-b930d73b4dd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "69e316d1-3b63-49bd-83d1-2c2670e3e089");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "ed2872dd-1607-4148-8925-7d638fac97a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "be673407-55be-4a76-a407-ca5e47e36f0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "46cc4fdf-0878-4ee7-987f-dcd76f50df74");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "228279be-c70a-45ab-bd52-e9330ea007b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "db09f36a-e4b6-4a0a-b213-e8f5f559c7d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "4c3b7c67-9d43-4bfd-8a6b-9e03f7766a54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "e58e8a6d-48f8-48af-948d-cf7f6380747a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "e5fa0a25-a000-45ac-afc7-dd25e805bb95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "42f0e445-8036-4826-a828-3a64166fc883");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "a1bf3aaf-a6ea-4957-8e1c-1e5a0d0ccfd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "ab122325-bc4f-4fed-aafa-6cd1aecc49a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "90e52646-cc70-4c08-8c3c-25cb04154602");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "b73a85fe-c703-4b62-a210-a5b744b22cf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d3bbf8d8-b11a-427f-9166-c368b9a55b12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "ded3d969-f84f-4d06-9323-9f2740dcf468");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "3773bd79-5d78-4ecf-a6d0-25c96ce0b631");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "216c080d-c735-41e2-ab54-804d24117113");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "315c56c1-4be5-49a8-b28b-4933abd54aa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "b5c226be-c47c-4d2f-86de-44cb1abcfaf2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "6221682e-d725-423c-95b7-0e7e0129b33f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "22d53c81-1f47-4d13-aafa-79793f662521");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "29e7b2d8-e887-4511-b763-648b297222be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "9c74cc65-1258-4662-b8d7-ab91c4cdf181");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "f2294cd2-944f-40cf-a364-dad76368a207");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "62dd750a-6e6d-4cf6-8397-927b10a2aa03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "bc637f32-9be7-408d-9b4d-2f1710f31d53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "df79f27d-8518-4de5-b0ab-2865c069867d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "67e86b46-f578-4a46-a686-1da2565b9e9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "d92c9ef2-7341-46ce-ad0e-70a0b55e1ebb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "b590bf53-9b7f-446f-bc1e-6eedf3667f43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "918d5ecd-0e1f-4e1e-b7ca-9e03ff9d7d25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3f5a4f3d-bd47-4c80-94d2-10c325e2eaa9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "9fb3025c-d7c0-46ce-81e5-eff250d5340b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "e402281d-2ef9-4dfd-a9be-966c53955da1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "b2d0f468-e0f8-4e42-9422-2f74fc625ff5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "df2502be-332b-4b09-a3c4-4005d7fac244");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "85f9e2b2-79db-4b80-840e-45f7a11305f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "39f172a5-eeae-40a8-95b2-f6fc2befb0e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "098e5645-2d34-4371-9fc7-3baab1e70f54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "55f0a3e7-1df9-4d62-9394-8381aa656abc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "4be5e94c-d66e-41b7-b0e5-5d6bb20a574f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "0c22493c-52af-4719-9cb2-53d1b0da406e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "c01c6d68-2c5b-488d-9422-34abd1291a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "bdfd0f65-ac9f-47ac-9836-a50f194d36e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "3524ccd9-5b39-4886-85a6-9c29f8d4d11d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "33619f99-3cd9-4205-9e37-d62a6cfed2cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "b4154db2-b5cc-4701-b2e7-93c6d1ca386a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "50396768-f54f-44df-801b-425b105de3f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "3a41848c-b1d6-4c4b-ba5c-d6d482893d60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "cbeb5ac5-af4d-487a-8d61-5cdd221a20cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "263fc052-9e9a-4761-9f7b-007e7980cae0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "874d07b4-228e-4bf8-82ea-c9276578dd2f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "fb70c832-0053-40db-b97e-2cf3ec4cca80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "bd518ebf-1907-4806-a5bb-8bd123d22a12");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "607085ef-a7db-43bf-9a5f-33b752e830ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "e947c2ff-7eaa-41dc-8c5f-701042a446a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "d9950a17-a65d-4694-8221-6e069a7b995f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "27484142-fa7f-4fef-a888-390222b09345");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "c9b01514-17c2-4d2d-a9e7-355f9849c246");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "2f6e3e23-0ea7-487a-b800-40b9c1ff3582");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "c70347ae-97be-4930-a6b3-b1220b1f0eed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "35629674-b9c2-40e8-bed1-30641c726570");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "fc2902da-2d93-4812-a8bb-afd79871cdf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "d71e5db3-b4af-43dc-a90d-f26648f555c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "6a779e28-90fe-47d9-9101-9da3d5b7da4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "5eac9607-84b6-438a-bbbb-5be329b6fad7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "3c796fb7-74da-4604-bb1c-95d856671b66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "c1b93ea1-30f4-472c-9bee-a97f46a3b802");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "ba01ea0c-01ee-4566-a00b-e3bfc7dcc5e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "78910c50-f61e-4b8b-b9fb-4269b760487d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "848950fd-7a9f-4c9c-a4c6-c39617cf7f60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "e1e7f6ad-2dec-4327-a84f-499a8b9a9550");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "4d555653-1d04-45a1-b719-6ba9955a3013");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "48969f83-514b-402b-a680-225503cac968");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "511acbe0-05a1-483a-ad37-c2aed9959bf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "7da2c077-9768-4e96-b7f6-a030a1b07caa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "0252934a-0dd4-46f7-90b7-2ec1ca74c364");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "d5ef7572-c1e3-4c07-ab14-a8c76d8b4293");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "9dac3310-3dff-4e11-b230-80af54386b33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "af92dc11-bc9d-4201-b84d-57707c293866");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "d4b5c42c-a2cc-4b4e-9796-3abd3c796154");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "1551159a-c4f1-4743-ac8b-6b6222ffdab4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "747813d9-6080-4b08-a3f7-58e777f047cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "df63d102-b3e2-4867-85d2-4ed5cfc69473");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "cbe03424-6fc6-4ccc-8552-59d7273a53ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "0f253edc-d2b9-4dfb-b4e9-eb8b618a2f8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "6ad6a933-e8a3-4ac3-b12d-7ab5ac4ee47f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "942b0468-5d27-430c-9b2f-928423880f59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "decbc143-49b9-4e44-84de-2580223786b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "5f39a01d-a313-4f93-80a0-b8d6e257e0ed");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 8, 22, 20, 43, 21, 617, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 8, 22, 20, 43, 21, 605, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3293), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3297), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3344), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3359), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3367), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3370), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3390), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3487), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3491), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3495), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3382), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3545), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 8, 22, 20, 43, 21, 618, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "Link", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "Admin | Bilal", "7ae96698-9b29-47d1-a35a-508f57dca0cf", "bilalAdmin@gmail.com", "Bilal", "Meto", "-", "BILALADMIN@GMAIL.COM", "BILALADMIN", "AQAAAAEAACcQAAAAEALIw1s2Qx2ef4npsLgrxJu3zKPJwFw1lGLS53R6KLdZli/W5Cv5zfq9CzcpUXg4xA==", "+905537314131", "1c420633-d3d1-42ec-a2bf-788781912194", "bilalAdmin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "Link", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "Admin | Nazlı", "823f5291-cd42-46fb-9c98-2a820a728eea", "nazliAdmin@gmail.com", "Nazlı", "-", "-", "NAZLIADMIN@GMAIL.COM", "NAZLIADMIN", "AQAAAAEAACcQAAAAEI1qN1rSROXg4MOwh/kPuJtyWCyk48xgpuHOiLu7AWLcZPgupdieLMojqk0/DbF7Rw==", "+905398815246", "d6c6338d-6fab-4b69-935b-a548a3357f00", "nazliAdmin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "-", "fd896ef7-e7a2-4110-bfad-899edce3ae73", "sema@gmail.com", "Sema", "-", "SEMA@GMAIL.COM", "SEMA", "AQAAAAEAACcQAAAAEN6vgClKhU8QwwU/B3eXZknXvq2VPn+j8lMHlAaOyYo5D9xEdkeV0Xr3JH8Wz7SOqA==", "+905071273567", "66c9fe28-b9f0-4f7e-9585-0f7266f38823", "sema" });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductId",
                table: "Sales");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7127), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8124), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8157), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8194), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8193), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8198), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(147), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9253), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9259), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9271), new DateTime(2023, 7, 29, 18, 10, 55, 391, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1064), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1067), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1070), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(7314), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(7319), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 2, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4544), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 3, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 4, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 5, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 7, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4607), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(423), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(439), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 30, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 7, 29, 18, 10, 55, 405, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7886), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5431), new DateTime(2023, 8, 1, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 7, 31, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 7, 30, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 8, 2, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6108), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 8, 2, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4216), new DateTime(2023, 7, 29, 18, 10, 55, 402, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2118), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(9213), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 7, 29, 18, 10, 55, 392, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0c872770-ece4-468f-a27a-536f143faaf9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e4fd088e-a811-4b0f-8de3-532b82c5fd38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b6d53954-b940-49d8-a496-0b018bfe8586");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "19de55bb-dffc-4039-b664-127941381809");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "948a616b-e364-4088-b978-9f42b45015f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "684978a4-48b1-4f93-8c88-d2277cf836b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "538892a1-2da8-424e-b689-67e99da396b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "d7f06b37-e97b-4608-8d88-1ef353b6e6a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "d4577c52-ac31-4534-8c61-2af8c8f82fab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "6122a82f-0d03-4f51-ad6c-78ed85a22fee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "b3afcac6-df61-42a9-9654-0aee4bc1fa59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "aa2ce2b8-1425-4504-8e3a-e5f35f1c3573");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "73a31b5c-1cb6-4fcf-ae38-03211206fb90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "2f2b8976-ec80-4c42-9d48-1ca97efcc3c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "cf6322c4-a93a-4cc9-8afe-ec28702e9a60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "4777c6e2-4732-4c79-b95f-1b857626c09b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "9c2675bb-49a1-4f9b-aae7-efb177deb1c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "b14647bd-372d-4baf-a972-dac13e7e2683");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "405fb974-1b52-4584-b74e-fd093591fb4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "b9c2d210-e5f4-4b47-819d-9626a70bb75a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "2875677d-b5b5-41d8-8e66-57520f8cc8d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "ba6e2fe1-cdaa-4aa4-865f-c65256e70600");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "d9532262-6487-43f8-90d9-8289eeb608e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "a58fb023-b8af-4f60-be41-ca087a2ef7fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "80d72fdb-b00d-45e6-acf2-e670721b9f87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "62f5917d-844f-4e89-9eab-fab2c345cd01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "973155ab-0276-4530-87fe-ee018ab93780");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "b818ce01-e83a-4c52-afae-0232e2311813");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "c677a6d3-9e90-45d7-99d4-1a04d76bb7a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "4027e701-f5bc-4906-b69d-be92a9f750b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "f354ae6e-5b6f-499c-9723-c562afbe82a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "84a0881c-d81c-4508-908d-5a9415a2da14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "ec1dc628-73d5-4e9f-92a6-bbe7381045c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "8453c824-27fa-4ea9-bd64-f99857435648");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "b22cb913-4d93-4928-8575-943bcb757fd1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "ec49a8fd-84c9-4380-ba0d-951faff90893");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "e3c7f97e-509b-4347-a836-f857d67bea8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "5b3f7f6e-b830-48a4-8f61-dafd049867f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "3b152904-adab-4f01-a1cf-3e5b06c3babc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "224890d6-dfd9-4131-a1da-67a730f81a68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "ffa3a397-daa2-4cef-ad40-788852dfe631");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "a0af0f82-f4df-4263-b3e3-cc5370171850");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "62abdcc1-1656-4a58-b760-23058640dcbd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "633fe2f4-ec22-4892-9226-0368280ea9a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "4a8b2f87-596f-4c27-a81b-994e7626de14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "047a9a0e-0a44-406a-badc-14aeb1fe2bd9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "4823c44f-5f30-4140-bdd6-9406fb967768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "ce4d9bd5-1697-4871-9a74-22bd1b229734");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "0a91919d-9538-4e47-9365-0eda0d0e1063");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "0a67227d-cd49-4a77-86c0-931cb902e13b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "a70ba4ff-ae67-44c0-a952-ba5669c22b1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "dfa155b3-8b44-4e03-9e5d-ef60e79e341b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "7d6f95b8-fc1d-4f62-b377-7b86200acd92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "084291a1-906a-45fc-bd33-679ac3e2af16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "4464b29b-f509-47f0-98f9-568e172542b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "c43d073a-6544-439d-83a9-894a2b8a8eaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "44e20def-5f2b-4d2d-8b6a-c911bf6cd4de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "ac652400-70c9-47f5-99ab-e21641c36f46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "2f6dac76-22ce-43e3-8c52-70659e42761a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "ae5b0453-1a15-4730-bf31-0bf7b603895d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "1fa432bf-e31d-48c5-8876-5b368d3ba852");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "d909482c-3fcf-480f-9ed1-ed546bef157a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "31578269-ffe0-4949-ac02-289d012474da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "f66433e4-9f3d-4ab9-8c2f-77c372172aed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "8cfbed27-ac52-44ce-898a-528293527c35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "407fd6e9-799f-4279-9a6c-cf22491ecf18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "29984d9a-690f-495a-b368-7780011fa121");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "b3f30028-a363-410c-bdad-d649c842d171");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "4fd10d3a-41b9-4690-91a2-b1c7db81466c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "4d7baa71-840f-491c-8fa9-01228a4436fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "d5076b76-9628-4a15-b80c-e692679d37fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "b9f6877d-2679-41a1-8e8b-321425ca7497");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "82d5f1ba-764f-4198-b45f-1f8d8580b5b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "5145ee46-798c-4aae-86d5-03af874f0049");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "ac68005f-1328-4e48-8c5c-af31bb703841");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "ebda2fb2-477b-4698-9bad-6311d49b8a6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "5160066c-cec2-457f-9463-66f0d989e853");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "7bf58e7c-06f6-41b7-8bf7-6f984ad863fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "cc797f00-ae55-4c72-9a67-67ded7a05155");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "e86c790f-d03f-4f2d-bd2d-0603e1277a4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "bd91d045-432f-4e53-a6f9-3d55a8a51cdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "2e873fc9-4d42-4be9-b477-47015b9d32e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "bc55cec3-9a9f-4706-b046-7e9e0470ac5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "2a7d7501-a120-407e-9590-95c35237414e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "eca52895-8457-43f4-80cf-3750787d42f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "b5b424f3-d26f-463d-894c-d951928ade23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "23677c1b-8c06-4b95-be5e-bd95a8857afe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "96285962-382d-4cf9-9a78-66bef424a6b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "8e18736c-b9cd-4276-b84a-f44e1e9d706c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "95b315d1-3119-4c95-ae2f-cd9dd49e11d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "c1bc6fad-e1de-4b1b-ac2e-f60a855cf87b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "afa8f15a-b3eb-42ed-b3f3-3aa79504f1ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "0d72c9b7-e467-4bc0-b4ab-fb35d433f7b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "4baff8c8-a569-4d6c-8ee0-cd49efec080c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "15676f8f-12ca-4ccc-a2c4-781e4344e4be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "c7ebf407-9e32-4b84-82d0-73f8142b4f30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "9cdcd280-aa0e-4f08-b794-5e93da3aa21f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "796c8ae5-ec8b-4448-af38-13aae72f1ac8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "c4deaf46-637c-43a1-a828-ba60ab416fd4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "969cf512-240b-46ba-9a6a-4480a1725ebe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "d628d349-ccd1-42b6-be4c-c42cb403470a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "8497c2d2-096e-4c82-9304-8d43d3e5d342");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "74fc3b82-5544-4a38-8ec0-0953f8ad5551");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "f3ee0b15-cc2a-4e38-8ce7-f1fc4daaf251");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "82c611aa-a9ef-4ccb-9377-1f83a27c7ceb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "37594b82-88cb-4d6c-800b-17ee03258d2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "3957ba02-7bde-48be-bad9-99d5efba700b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "c5e51429-86bf-4896-bcab-ff79ce03fde6");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 7, 29, 18, 10, 55, 403, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 7, 29, 18, 10, 55, 393, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9829), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9835), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9838), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9844), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9849), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9861), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9864), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9887), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9896), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9938), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 7, 29, 18, 10, 55, 404, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "Link", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "Admin User of MyBlog", "a5033888-c872-4bbb-a0a3-5990e3b91e61", "adminuser@gmail.com", "Admin", "User", "https://twitter.com/adminuser", "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEOQ4uYrlzE8s9J46ydtTMvlDRl7D1OM7pvbaaS8FIL9XthQ0UvLu1z++jX4NKZ0fSw==", "+905555555555", "7bfcb206-828c-43e1-af46-107810700dee", "adminuser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "Link", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "Editor User of MyBlog", "a67c5ec4-82ab-4f43-9cd2-1fcf9c3cd3d0", "editoruser@gmail.com", "Admin", "User", "https://twitter.com/adminuser", "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEOyNNs5RJVoqvwbfYcrtjGznqs8ofIt0WUcwvo0oXfDalMevD3XWvvLxwju0hSyyDA==", "+905555555555", "69f85cd1-8ca4-4f61-af0a-8b9abca53083", "editoruser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "Editor User 2 of MyBlog", "7f65f76c-6d3b-4db2-abe2-73bdb93936ba", "editoruser2@gmail.com", "Admin", "User", "EDITORUSER2@GMAIL.COM", "EDITORUSER2", null, "+905555555555", "e4e327f9-485c-4c3c-b63c-61fc6d48c71a", "editoruser2" });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");
        }
    }
}
