using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Inventory.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixedConsoleFkCompanyIDtoCompanyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Consoles",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Consoles_CompanyID",
                table: "Consoles",
                newName: "IX_Consoles_CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Consoles",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_Consoles_CompanyId",
                table: "Consoles",
                newName: "IX_Consoles_CompanyID");
        }
    }
}
