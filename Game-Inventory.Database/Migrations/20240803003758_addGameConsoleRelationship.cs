using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Inventory.Database.Migrations
{
    /// <inheritdoc />
    public partial class addGameConsoleRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamesConsoles",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    ConsoleId = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_GameConsole", x => new { x.GameId, x.ConsoleId });
                    table.ForeignKey(
                        name: "Fk_GameConsole_Console",
                        column: x => x.ConsoleId,
                        principalTable: "Consoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_GameConsole_Game",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamesConsoles_ConsoleId",
                table: "GamesConsoles",
                column: "ConsoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesConsoles");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
