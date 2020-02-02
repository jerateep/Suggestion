using Microsoft.EntityFrameworkCore.Migrations;

namespace SGO.Web.Migrations
{
    public partial class add_tbl_dep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class_ID",
                table: "SGO_HEAD");

            migrationBuilder.AddColumn<int>(
                name: "Dep_ID",
                table: "SGO_HEAD",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dep_ID",
                table: "SGO_HEAD");

            migrationBuilder.AddColumn<int>(
                name: "Class_ID",
                table: "SGO_HEAD",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
