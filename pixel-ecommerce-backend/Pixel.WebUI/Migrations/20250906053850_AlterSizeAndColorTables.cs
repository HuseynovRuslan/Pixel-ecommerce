using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pixel.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class AlterSizeAndColorTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "shortName",
                table: "Sizes",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HexCode",
                table: "Colors",
                type: "varchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shortName",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "HexCode",
                table: "Colors");
        }
    }
}
