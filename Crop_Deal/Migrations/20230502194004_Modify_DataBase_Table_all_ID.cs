using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crop_Deal.Migrations
{
    /// <inheritdoc />
    public partial class Modify_DataBase_Table_all_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Invoice_id",
                table: "Invoices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Crop_id",
                table: "Crops",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CropDetail_id",
                table: "Crop_details",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Invoices",
                newName: "Invoice_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Crops",
                newName: "Crop_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Crop_details",
                newName: "CropDetail_id");
        }
    }
}
