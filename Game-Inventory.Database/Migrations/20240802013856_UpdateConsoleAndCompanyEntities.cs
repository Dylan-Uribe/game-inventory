using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Inventory.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConsoleAndCompanyEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Consoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Companies",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consoles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companies",
                newName: "ID");
        }
    }
}
