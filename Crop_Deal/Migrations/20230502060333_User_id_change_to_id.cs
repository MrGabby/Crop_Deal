using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crop_Deal.Migrations
{
    /// <inheritdoc />
    public partial class User_id_change_to_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Users",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "User_id");
        }
    }
}
