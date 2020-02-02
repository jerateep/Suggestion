using Microsoft.EntityFrameworkCore.Migrations;

namespace SGO.Web.Migrations
{
    public partial class add_gso_id_approver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SGO_ID",
                table: "SGO_Approver",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SGO_ID",
                table: "SGO_Approver");
        }
    }
}
