using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Inventory.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGameConsoleNameinDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "GamesConsoles",
                newName: "GameConsoles");

            migrationBuilder.RenameIndex(
                name: "IX_GamesConsoles_ConsoleId",
                table: "GameConsoles",
                newName: "IX_GameConsoles_ConsoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "GameConsoles",
                newName: "GamesConsoles");

            migrationBuilder.RenameIndex(
                name: "IX_GameConsoles_ConsoleId",
                table: "GamesConsoles",
                newName: "IX_GamesConsoles_ConsoleId");
        }
    }
}
