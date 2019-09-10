using Microsoft.EntityFrameworkCore.Migrations;

namespace VegetableStore.Migrations
{
    public partial class quantityvote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quality",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quality",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Vote",
                table: "Products");
        }
    }
}
