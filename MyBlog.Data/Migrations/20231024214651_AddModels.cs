using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(592), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4394), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9243), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6087), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 25, 0, 46, 49, 273, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 10, 30, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 10, 30, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 10, 28, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title" },
                values: new object[] { 1, 1, "Test Verisi", new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(79), "TEST", true, false, "Test Verisi", new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(79), null, "Model Title Test" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 10, 28, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 27, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 26, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 10, 29, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8159), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8161), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 10, 25, 0, 46, 49, 287, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8430), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8432), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8435), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8441), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2805df14-876e-4ee6-8687-d44f28a781fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "14dbdb83-11bf-4ad8-b0b8-dcea3c19ae59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6ba33253-bbfe-422a-8e45-759ecbc54772");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "93f1333a-9477-4552-a817-24a3fa4f7b72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "837d2bd1-0dcd-40ca-b562-d95f3da88768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "b21e6d8d-4db4-4184-8c34-2c64623d6eb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "c07a3bdd-f1b0-4a6b-b84f-69e0918e75d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "7128a020-e3d8-4e6c-8d3d-98cc99a85474");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "5e6a77bf-2126-448a-aa58-c9405aabbbd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "fb40ed95-18a8-4ef9-a17e-c18e58649724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "78875cc0-b044-4ed7-8cc4-77672c3512f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "ed7adbe6-0d89-428b-a50d-75ff82ffdb15");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "979f6386-ffd6-4dd6-989d-755a691e7aa1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "018036c7-e3f3-4a2f-bafc-a141b9980eac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "6f097544-0952-45e8-93b6-9dfb5739e510");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "542ec37a-ed28-4016-8822-4ba238d47ef6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "4c341c75-7368-4b86-b86e-d84944870021");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "cf385fe8-8dd9-42e3-883b-c4cc43ae102d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "c724bfe4-7d72-4a3c-9e9b-da6b929cb77c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2614e183-3373-4980-8071-7f5329619b49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "782c8374-c38d-4838-85e8-cd0a6e954be8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "79f66ff2-f565-4618-b340-c0b1a34716ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "06b86cc0-15d2-4083-bf54-ad04159517ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "f517518c-0f47-4d01-b27c-9911af52e2f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "af392e23-b772-4f3a-92b1-de2c1c022630");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "1aa3b4c6-3d05-454c-b36b-fb7ce8a9c0e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "293e9fac-74dc-4c06-95d8-8d4e465a4eec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "7db969b9-7010-4872-8649-6f14bdd12673");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "c42ac4d7-1dd5-4ab3-be1c-beb6e7eb69a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "13b01739-50dd-405d-947e-8764b5590453");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "9ebac352-192c-4aeb-a5a3-26d46da05e6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "d316a0fe-aa74-426b-bb08-80bf58eff7e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "642f1071-43f7-47e1-a5f4-a10a8b020de0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "9baaad0c-580b-445a-bde3-26700b34ae83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "3660bf02-88e7-4264-aba8-f81a8a9839d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "3d7ab9a6-6fa7-4262-b400-702b04ca4256");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "a292895d-7b5c-4932-a75f-8569df682baf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "127bdc80-eeb7-4bc6-af02-6973712ec82d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "cfeac3f5-ca32-4835-91a2-243fbf88863a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "89bee32a-7b84-4ab0-bd9b-edbef754b90f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "69d6f200-468f-48c2-ad4e-7e72517f0e71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "099139b5-cdd0-4150-aacb-b7b8dc02db46");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "5bd3ecd1-0688-4e8c-85bd-a1c877a4f676");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "89b72e64-8ea5-4ad9-a0e8-8b9a0f8c0c50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "89873c5a-b86b-4677-ba6c-cb86b0ccf7f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "1f5169a8-265e-4617-be40-db736dc51bca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "476108c9-70c2-4dbe-8660-472937fe5dc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "0488c735-abeb-42c3-a9e5-543e34808b1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "c65274cd-52d5-41b4-845b-acd0404851d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "3d887671-c5f0-4d69-b92b-757ab8de905b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "b5194439-9f4b-469f-b67b-63b668e43ec5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "abaa6987-27cc-45c9-9ec2-f9ee66aab2cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "43d933c8-6d61-4a6d-8778-8584a5fc9e1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "7e580cea-34cb-4de7-a7bc-f45800ed3f68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "eb0ca368-fb80-4e32-86d7-8e9017656b18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "aa342387-ec1c-4e26-a949-e8585fdd01d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "4274955b-414d-4c56-a8a7-e7480c3e73c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "826919da-4008-4c45-892d-17d27df8d2ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "2472e5da-7ef7-4d97-a31e-3a7ba76e2416");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "16e59795-cf2a-4fa7-9a74-77ccc6426c52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "40dacb02-ba45-43fc-bc56-6ee35586590c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "19a582cc-4686-44f1-8c3e-7c08e9c19ce4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "81dda72f-09c6-423a-844a-b149ec2b2e47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "25cd94a8-369e-4dae-8e75-a354a05a10f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "05dcdfac-8bf4-4006-b715-4224873686de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "139f79a6-775a-4c61-b235-f430775e79f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "d7fe50c8-8d51-4e02-a8f2-7829602e52dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "d23eb6cb-c5e6-4e34-9f4f-5f77068343b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "bff4f045-ac11-43a1-b06e-707646c25842");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "1f62e70d-15f3-4e95-bcc4-97ec9a57e821");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "f91e523c-ce65-405d-bb11-123c7bf4b085");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "5033dfc6-955d-44ce-affa-9644763c0749");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "b6f50f29-fa37-4779-bfd9-8f86cdd15764");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "01ba9ad1-372c-4f76-a71b-40f13c6b74bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "4c207f74-9227-4ae8-a550-6716dc28c197");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "c8db1698-cbaf-4547-9393-96205ee66bf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "56708a6f-c4c8-4d0a-a5ee-d639927aecb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "0ff1e88e-a3fd-47d7-ba4a-90d192914756");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "7252eab3-f604-4aa3-99d1-7c916a98256f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "15eb94ff-c25d-4e6e-8480-25799191cf47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "18da61b4-a95f-40d7-bdb0-3572a472ce81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "3599c55a-362b-4b91-bc6b-d1b7e04c4e18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "885cf140-15a3-4703-a43b-4476facabfc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "0c3ddfea-0d8b-4773-8908-69cb24a3a1af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "9f2089cd-d0b2-42ed-a6ed-294ee4452477");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "6c702a2c-1ad7-49e7-88f9-789185d34f5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "393d55a0-8b93-4457-b0d9-63947e89fcc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "2116f1ec-45ca-479d-81b9-9a38b324f936");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "79dc7a69-5a64-4458-828c-f0efa1391ed9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "6acbe2b5-c0dd-4a37-b24d-f78d194eea54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "045a8dab-c1e1-42c6-b608-bf87f736b839");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "c92817bf-32f1-4e5c-bb58-6c3a10cbfd4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "22ac87f8-3deb-4dd0-a724-7fbe8c551422");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "ddff1e36-c387-4c49-a315-0b6414bfb1f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "d640fa1c-e7ae-4467-b2b8-f212d0068bc6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "ea986713-c01e-4499-86e0-261fa06a2c8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "040691cc-1ea4-4ce7-ac03-5adfeb88fc39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "6ed55397-495d-4cb9-978b-1c2a0ea83984");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "ebb1f15a-fa99-4b94-b402-3f22d68c62b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "2dacec5b-5d1f-4e55-a797-d309a67279f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "bc49eaeb-0713-41f8-98e4-7219ec2811e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "020bff71-8d84-4321-b227-1d6a81615486");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "0a3adc3b-3f67-41be-9e84-ac8fa15b0348");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "73a7975a-728b-4d26-b25b-199652d092a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "f6b3efbc-0982-4b7d-8a1a-b17636cd3dc9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "da1d70a0-9ff9-45dd-81d0-080e507f2285");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "c7ae06a5-e035-4eef-b362-efd248fcd60f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "ba011f4c-1df4-4a71-a6bc-68a70675657d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "be531be0-e519-4945-a662-6f2d1de21823");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "e7837788-f3e8-46ca-9035-8531e56f1286");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8046d9be-03fe-431e-b9b3-8765a8af8cbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "506ffb2c-4f73-42f8-9229-4a5dcfa4bd81");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "91c165bf-c1e6-4da5-b094-dfbc725c1eac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "c3c5f510-14e8-4efb-8da6-2e43efaf2d18");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 10, 25, 0, 46, 49, 274, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9014), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9055), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9057), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9059), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9061), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9069), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9077), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 10, 25, 0, 46, 49, 288, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bad823-f804-42eb-8b65-ac5088a22fd7", "AQAAAAEAACcQAAAAEISYctpY+CPW2E5DWHFq8lhg0izfRxKqMvY6hgzcFhIv0nQmvXfAbiUkRp1RDJ1R1g==", "8bc61808-5ffa-4f22-b210-3ddfb50ced03" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f8be56a-6f9b-494f-8c61-994b4e9fc97a", "AQAAAAEAACcQAAAAEAC8wDA81vogDYjkrWL7XGMVdG17hWpBxNoja3f/pTwomgrRZMV410XDVSnrm+AIXA==", "3678a157-eaef-45bf-ba88-096a82fd55a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d3cc645-7959-447c-b806-6858f5f30a3d", "AQAAAAEAACcQAAAAEI9k/cPjFOd0BlHNHY257GE8y54qTn2GOJ8GajZ9muoOZbTWT8dJvTTboeJutG9kdA==", "d99c1a78-ab05-4290-a01c-ba36fb0d929a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac7474a-0f79-4a54-87a4-39502c1726f7", "AQAAAAEAACcQAAAAEK/S1cSlgxc5IGiuHXh1ltU3G2JaipaugiZLVoCsPgxiMctriExM9ld78c6yqLY+CQ==", "8fdce411-b297-4990-aea2-ab7ebfe18b86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8eca00-1cfc-4f9e-9ba8-86684580c13c", "AQAAAAEAACcQAAAAEMa6uR/nu5LdNMKkyknb8GdAbs23556/pUOSdZMIaD3ej/GIrMFBwpFt3o3QVMIB5w==", "25fa0068-b558-415d-bf45-874553c82ee7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60dda227-7a29-4857-9721-d2c0ca17d3b9", "AQAAAAEAACcQAAAAEKG0HpPzXkdmsjFH3a0HMrwtUwOoMyitvsO/JY20i/RmacTNKjBDtOJ2ov6Q1AtbIg==", "d8d6d504-8f2e-4204-a28b-0d63b3cf219a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd97fa3-1946-40dc-9778-0f7c3ada12ee", "AQAAAAEAACcQAAAAEHcNRwXdFJjbN6slKyVsHdkjyBJFZbNq4PsDQjQuSARmmxIIwz0IdzK4tRmCwQJ51g==", "ec88e3ac-b723-42dd-8906-28e52f598912" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d1d084-42a5-45a9-ad5d-507546af857f", "AQAAAAEAACcQAAAAEO7dX8fGpLyhedtkzsHzmPYTuLdjxJE9xZQwvxGy0Xt3tZitQTdpT1EObcKblvLxDg==", "9a0a67df-1026-43a7-9d8e-ede15f85002f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e33d28bc-5c1b-4a4f-bf35-b723d02e96c1", "AQAAAAEAACcQAAAAEOt5kaJQpuJUDUAmW7W1Z7KD4jWiM+ECdCJxFlrM3x+EwFIP5mcVshfNbTHLPXlO/Q==", "b736256e-57ba-4bfb-809d-91c4896606c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "912e549a-0c1a-49da-859c-0802ed4d79ff", "Yeliz", "Kılıç", "AQAAAAEAACcQAAAAEG8vyB1RynSQX03ynQyLErBIZHt6nAewB7Bb+1N/ZEUEDj0GQI/gxWS3714ep5GZPw==", "8ee643e2-1a6d-411b-9641-34532b7209d5" });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.UpdateData(
                table: "AppointmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(5631), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2429), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2433), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2447), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "AssociatedInstitutions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3179), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3182), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4516), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "CustomerReferanceTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(7238), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "CustomerReferances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(8606), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 28, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1086), new DateTime(2023, 9, 29, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1089), new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 9, 29, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1094), new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "MessageToDevelopers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EstimatedCompletionDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 9, 27, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1097), new DateTime(2023, 9, 24, 20, 33, 48, 902, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7489), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7496), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7818), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7819), new DateTime(2023, 9, 27, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 9, 26, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "TargetDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 9, 25, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "OutPaymentDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "OutPayments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 9, 28, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(2412), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 9, 24, 20, 33, 48, 884, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 9, 24, 20, 33, 48, 900, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "ProductSubGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(172), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8556), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8558), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8561), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8567), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8599), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0072ba13-50f9-4807-ba38-6c512d278aa4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8ca3cc86-8ee6-49c6-8b89-e4f36535e42c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "bd67067d-4c97-48f6-ae0f-44bc3a18fe40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "47cc3b38-6f14-4c80-bf3f-6b3ab6cf3d78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "011d6f90-62d3-4c70-bfe1-81266b4ae3ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5faf6eac-610b-4515-96d9-6d090bae7de5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "b20b32bb-8b3d-4b1c-9074-3c6418fad1ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "f2165f23-f5bd-4e92-a2bd-b3aa51799eef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2213af0a-ab49-4b9d-8d91-cad955774eff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f4d2b513-9908-4906-b5c2-f5a3a6ae4fd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "96ab101c-5c3b-4b72-bd94-a0354718f955");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "8a9045d7-fe5e-469b-82bd-9995d068ed33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "b64d08bb-a7e5-4a00-b888-8f1f92d2d2d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "1ac3d87a-5713-44d5-9a16-939a58a4198b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "4ff94e27-1503-493b-9cb1-376270556831");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "b560fc81-d851-444c-a944-80c560493271");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "378be281-4d3d-4e0f-867c-a28de55192cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "db236423-58f0-433e-af87-269b27f70a7b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "3ae6fb0a-716b-44ed-86ca-777f14e29abf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2bea8665-f7bb-46a5-a296-b5792fc7d3cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "57070b47-1dc3-4380-a950-2496a679a340");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "ef5dc1a2-9f5e-4868-a248-594a79151b14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: "93fb4345-546f-4e15-95fa-66bf9e990536");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: "1c1f49b6-c80c-4e6c-aaa9-2036ef036098");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: "b26142f6-21bc-4442-bb1a-71e11ef797af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: "c71c912d-70f3-448b-8b07-ced6935f1d52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: "94102b86-92b8-48a1-9534-3f47f4011bdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: "73f549b6-dce4-4993-945d-40cc314df625");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: "cff4e327-2ef4-4f6c-81f1-6015cfd375b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: "3c3fb41e-bf25-43c6-938a-4074aea48638");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: "2b3f7eb7-2412-40e6-bf07-8a5b62fcbf75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: "14749da9-fe1a-4411-8f37-a4861105bf00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: "9c8598c7-19be-4f6d-960d-dea5a637da0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: "6301df8d-051a-4152-8105-05f198994cda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: "c03d4682-284b-4abe-a8e6-50cf56f3840c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: "cdc0c93a-6b09-45d6-82be-beb11dce337b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: "1c1e823e-6d46-4b53-9300-58d0b675138f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: "5c5dc4ac-dd8e-4f53-a8aa-fa8fccec0aab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: "d918aacb-577c-4e48-887f-e4bcdecd6e14");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: "768e20b2-bff4-48e6-93d9-3184bfd7eff9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: "acd9973f-196b-4b81-8f79-9e43a8764842");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: "ab16056d-1bd1-478c-b62c-984c3ae0e6e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: "b4b65d2c-850f-4164-b4f3-9dfe7417934b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: "39c2edc1-52ce-435a-a661-ec0565b0668b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: "5d9bc625-befc-4c11-8fa7-9f72193ee991");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: "fb335805-6f14-4729-983e-fb8e4f19e815");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: "9463e74e-6b85-4a9b-a2da-330b9a1816ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: "271ae6b4-8550-4e88-849b-c9af09aa1886");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: "01ac32ab-40ea-4f95-9951-0afdd72464d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: "2fce4f6e-5348-449e-a347-38c1616e52cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: "1f1f1522-e335-417b-bda6-a26e26bc172f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: "468f1486-e23b-4492-b881-5c942a21aaac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: "fe6c79f2-7fc5-4f92-8fc7-d43781c2618b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: "976b6be9-c515-4e03-9d05-60b6fe091168");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: "e6358c2c-f8e0-4fa7-86e7-310d448157dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: "b4da9fa0-13ac-4561-bb47-66e0419f8078");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: "9e344b34-1100-4bbf-be66-6e417de1ff63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: "6e0b8141-77ca-4bde-aafd-dcc7fcb5cbb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: "a7c2b9ff-fdca-4d86-954b-0d396d6112c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: "1174d2cf-49dc-45b1-87d9-baed4aa9b1b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: "68c6f997-91fe-4895-a1ed-1c845aaaff48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: "971cee25-488f-4385-85e2-5a9bb889e079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: "cc7f2ba0-83c1-4cf9-a4b5-39ae4d0eb656");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: "8cb253b4-de55-4ab8-886d-8d8d8b744f51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: "9c0270df-d513-4770-adbd-5d545aca23c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: "4fe1ef3b-1acb-4619-b92e-14c28abeaedf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: "0f00e5ef-e9e5-4658-930c-7e6af0538322");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: "ee74d746-3e6e-4763-bb1a-d316f8b16697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: "7c10513b-be46-4fd2-82e0-0e86e2a17c4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: "739fb734-e5b4-4d74-966c-0b644f5c3b7c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: "a04c1bda-5656-41f7-a37e-fc7cb7908a9b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: "6d354320-a036-4181-aa41-175ac854174b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: "26f3f4bd-ea42-42c4-8674-eb3afe0e55cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: "5dad7f91-89fc-459e-abc0-fdc527e97620");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: "cefff91f-1102-4843-82fc-07a141e63072");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: "ac8f17c3-41e9-41d0-8d8a-0a4574daab55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: "c6a98954-db5f-49b5-8f47-26195364b4de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: "0a7ce585-0d9b-4ef8-86f7-06668b5db317");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: "22c8bea2-f000-4077-bf1d-3e0e6cec72bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: "7353bc34-cd1c-4fe9-8534-8fc7ed0a7e4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: "82352fc3-2c66-464c-b209-fe31921ba187");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: "59483271-ce7a-474b-be6e-7082ada2523e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: "bc93c130-7737-4cd9-ae16-a84483c693d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: "74c01a9f-d4fc-47cd-984e-90459654ff47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: "08bb5205-b18f-4b57-b3df-36f3c8bd069c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: "30792031-682f-4f48-bdf0-e5297b2494aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: "28fee376-a3eb-414e-bcbb-86b1697c86da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: "6b8910ac-baa8-4ba4-a76c-6cdaafb8d11d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: "9719ef35-71d9-452a-95c5-a83082d84cdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: "7d7fe9a4-02be-43b0-9599-58d584f1e49d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: "9cad92f6-4ba9-40f9-9523-8ff9920f2bbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: "eb6606cb-9c64-4275-8afc-58c4ab3f0fce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: "fa2faede-3868-4077-b656-3c13e59167ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: "ee228ce5-b56e-49c8-a1d4-70299d7b9707");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: "bd5f7651-56ea-451a-a8d1-cc9453544f9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: "c145cbd3-996e-4a6d-a7db-957905d38293");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: "ed82e63e-498b-4bb1-b0cd-496677418f73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: "0aba80d2-6f3e-4863-ac35-ace3ca35487a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: "2f28e95a-d413-43e3-83df-4de08ed7f68c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "f6cbc74d-9efc-44c0-b41f-c262511a657f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "4d91cc52-be3d-41da-8aba-8747660f17e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "a995327a-f06c-4d88-b686-4a0022191955");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: "2efa8f9f-8105-470f-bb25-00629dd72e61");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: "e970692e-75a5-436b-93b5-db09a335ae28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: "0eb93f28-99eb-44a9-bcfb-4baf3dea2f4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: "5b636d05-9f97-42ff-806e-95d2e45a3cd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: "52b80670-f827-4da8-ab37-07ea8fa273fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: "92c214cd-d36d-4f34-8607-07ff404f3e1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: "7fa338d5-2e16-46f9-be08-3555352a6f7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: "92c0c140-252e-4181-ae31-1d03c3632871");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: "8d9adf28-b15e-442c-a771-061c0f8f408c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: "d68f1d3d-6a0f-4ea5-b1c2-60f9a016c3f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: "b9d6f97b-9131-4f18-9c66-ceb6c84ebb03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: "4eeab563-7bfb-4e6a-a1cf-394c837b7242");

            migrationBuilder.UpdateData(
                table: "SaleStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(668), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "SaleTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(5033), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(1292), new DateTime(2023, 9, 24, 20, 33, 48, 885, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9539), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9544), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9557), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9573), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9584), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9586), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9630), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9635), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9646), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9652), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9654), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9657), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9687), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9747), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "SubPrograms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 9, 24, 20, 33, 48, 901, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c84f0e3-f3e2-45a9-bbde-18470c86c0d5", "AQAAAAEAACcQAAAAEJshtMLUf9iiWK4e6mjL+dYHUMmJjY0akbOHOm8MBFrXUkuLPSpsWTKMD96P2d+VAQ==", "9e868ce9-310d-4d17-841b-6dda417342b2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad67d20-af59-4573-9d60-68c499d38d6c", "AQAAAAEAACcQAAAAEF2ccvATy2xEdnZV/kEGBcBbO4/ZMrqLN147xQTwW1YIC208dB6PeH71Toec6ANWdw==", "610af386-c50b-4d12-afe1-ccabe64fa476" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7624a6b1-f96a-4991-97d6-f6355894cb5d", "AQAAAAEAACcQAAAAEL41/uN8gBbemLi/c6biM+FgJJlvXWawnq9UP0X1gg3OfJvNEwtGjRyIG0DoBUsk5w==", "bcf295cc-2af0-4476-b855-0a89849858d0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2722fb1-8bde-4af2-9a44-cff55909433b", "AQAAAAEAACcQAAAAEGoNJeXq9KHgPfnMs5WMwbXLgd29PGU0Mj4YtCXt92n9w8eetKRWCJbDg3TVZ7kazg==", "e83af705-b3af-403a-a993-538c72403c67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "205d476e-2889-4fa2-9b51-7ac2b31c7b37", "AQAAAAEAACcQAAAAEDc1eo1SSB9/iUjt/ptyHjejsfROA4yyb+cBzmd+YZTvPUNjbxr1fh3vDYVZi9gkMQ==", "608936eb-43d0-4f41-99f7-cc53cf0c5a9e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c1ec58-0cae-48a8-aa57-7526ac237e66", "AQAAAAEAACcQAAAAEDspVNi8BKquUY2qsLG0vdzPiZGc/oAG9IAwaMKaeoyPM0Ust29YOuAhFU6gCA+fQw==", "636e1e5a-e981-4a63-8628-eca79e06de45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a0942b-df8f-4503-aad9-d4dfc8dbc1d0", "AQAAAAEAACcQAAAAEKTOaoBKHDmh8iHE2tu4NvPJBUBWSHVoyXqotN3PTs2ZnIaW3rLCiQRFtC0zF5ju8g==", "952523e7-e1ff-4556-8291-8749ecda8c7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a29d66b3-997a-4488-97fb-ad73c0604480", "AQAAAAEAACcQAAAAEJ4EUhse3XltTbEqGgkAy+XP3f85oYJVEYPncnLB69rbiFtghffUAEvV9KehWqo+pA==", "4408475d-2489-481f-b7b3-c11f7ebe9c88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "712694aa-fda2-4458-bbfa-1b16ad7b8b4f", "AQAAAAEAACcQAAAAEMKuFaUi3bo/ZMSEEW5kXvh00D6o8D5tmSR5/w/mSGY64/N02dc44X3dPb1rIQKiHg==", "fed4e158-a9f2-4423-b3bf-34d218a1ff2d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b26c1e2-7b41-4ec6-801e-b461afe9b890", "Sema", "-", "AQAAAAEAACcQAAAAEE19I7MaE0V704Mhnq/N2m/cJLmjK611W4tmRoTAT9bBD3D2FOJYDTyLwk+0lWnCYg==", "6fe5111f-5f8f-4319-bb56-44c96b7e2754" });
        }
    }
}
