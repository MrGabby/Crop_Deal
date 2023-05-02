using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crop_Deal.Migrations
{
    /// <inheritdoc />
    public partial class Modify_DataBase_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank_account_no",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Bank_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DBO",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IFSC",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "User_roles",
                table: "Users",
                newName: "Roles");

            migrationBuilder.RenameColumn(
                name: "User_name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "User_contact",
                table: "Users",
                newName: "Contact");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "Users",
                newName: "User_roles");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "User_name");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Users",
                newName: "User_contact");

            migrationBuilder.AddColumn<string>(
                name: "Bank_account_no",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bank_name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DBO",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IFSC",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
