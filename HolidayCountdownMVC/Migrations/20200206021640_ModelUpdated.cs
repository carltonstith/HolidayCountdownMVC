using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayCountdownMVC.Migrations
{
    public partial class ModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Gifts");

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Gifts",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Gifts");

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Gifts",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }
    }
}
