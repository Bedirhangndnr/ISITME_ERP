using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Data.Migrations
{
    public partial class AddCustomerReferanceTitleIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerReferanceTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false) // Değerleri uygun şekilde ayarlayabilirsiniz.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReferanceTitles", x => x.Id);
                });

            // CustomerReferanceTitle tablosuna verileri ekleyin.
            migrationBuilder.InsertData(
                table: "CustomerReferanceTitles",
                columns: new[] { "Id", "IsActive", "IsDeleted", "CreatedByName", "ModifiedByName", "CreatedDate", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, true, false, "InitialCreate", "InitialCreate", DateTime.Now, DateTime.Now, "CustomerReferanceTitle unvan1" },
                    { 2, true, false, "InitialCreate", "InitialCreate", DateTime.Now, DateTime.Now, "CustomerReferanceTitle unvan2" }
                    // Diğer verileri buraya ekleyebilirsiniz.
                });
            migrationBuilder.AddColumn<int>(
                name: "CustomerReferanceTitleId",
                table: "CustomerReferances",
                type: "int",
                nullable: true,
                defaultValue: 1); // Varsayılan değeri 1 olarak belirledik.

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReferances_CustomerReferanceTitleId",
                table: "CustomerReferances",
                column: "CustomerReferanceTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReferances_CustomerReferanceTitles_CustomerReferanceTitleId",
                table: "CustomerReferances",
                column: "CustomerReferanceTitleId",
                principalTable: "CustomerReferanceTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerReferanceTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReferances_CustomerReferanceTitles_CustomerReferanceTitleId",
                table: "CustomerReferances");

            migrationBuilder.DropIndex(
                name: "IX_CustomerReferances_CustomerReferanceTitleId",
                table: "CustomerReferances");

            migrationBuilder.DropColumn(
                name: "CustomerReferanceTitleId",
                table: "CustomerReferances");
        }
    }

}
