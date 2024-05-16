using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JmmTest.Migrations
{
    /// <inheritdoc />
    public partial class AddEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "priority",
                table: "JmmTest",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "JmmTest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "JmmTest");

            migrationBuilder.AlterColumn<string>(
                name: "priority",
                table: "JmmTest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
