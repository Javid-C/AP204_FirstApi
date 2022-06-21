using Microsoft.EntityFrameworkCore.Migrations;

namespace AP204_FirstAPI.Migrations
{
    public partial class addDisplayStatusColumnToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DisplayStatus",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayStatus",
                table: "Products");
        }
    }
}
