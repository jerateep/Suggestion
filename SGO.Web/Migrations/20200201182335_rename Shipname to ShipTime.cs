using Microsoft.EntityFrameworkCore.Migrations;

namespace SGO.Web.Migrations
{
    public partial class renameShipnametoShipTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shift_name",
                table: "SGO_SHIFT");

            migrationBuilder.AddColumn<string>(
                name: "Shift_Desc",
                table: "SGO_SHIFT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift_Time",
                table: "SGO_SHIFT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shift_Desc",
                table: "SGO_SHIFT");

            migrationBuilder.DropColumn(
                name: "Shift_Time",
                table: "SGO_SHIFT");

            migrationBuilder.AddColumn<string>(
                name: "Shift_name",
                table: "SGO_SHIFT",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
