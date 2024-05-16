using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JmmTest.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "JmmTest",
                newName: "title");

            migrationBuilder.AddColumn<DateTime>(
                name: "Gduedate",
                table: "JmmTest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "JmmTest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "priority",
                table: "JmmTest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gduedate",
                table: "JmmTest");

            migrationBuilder.DropColumn(
                name: "description",
                table: "JmmTest");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "JmmTest");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "JmmTest",
                newName: "Gender");
        }
    }
}
