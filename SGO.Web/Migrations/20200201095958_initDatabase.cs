using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGO.Web.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SGO_Approver",
                columns: table => new
                {
                    App_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    App_number = table.Column<string>(nullable: true),
                    App_pers_id = table.Column<string>(nullable: true),
                    txt_comment = table.Column<string>(nullable: true),
                    Status_id = table.Column<int>(nullable: false),
                    cod_creator = table.Column<string>(nullable: true),
                    cod_update = table.Column<string>(nullable: true),
                    dtm_create = table.Column<DateTime>(nullable: true),
                    dtm_update = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGO_Approver", x => x.App_id);
                });

            migrationBuilder.CreateTable(
                name: "SGO_HEAD",
                columns: table => new
                {
                    SGO_ID = table.Column<string>(nullable: false),
                    cod_Requester = table.Column<string>(nullable: true),
                    dtm_Request = table.Column<DateTime>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Class_ID = table.Column<int>(nullable: false),
                    SGOType_ID = table.Column<int>(nullable: false),
                    Detail_Now = table.Column<string>(nullable: true),
                    Detail_Future = table.Column<string>(nullable: true),
                    Detail_Result = table.Column<string>(nullable: true),
                    Status_id = table.Column<int>(nullable: false),
                    cod_creator = table.Column<string>(nullable: true),
                    cod_update = table.Column<string>(nullable: true),
                    dtm_create = table.Column<DateTime>(nullable: true),
                    dtm_update = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGO_HEAD", x => x.SGO_ID);
                });

            migrationBuilder.CreateTable(
                name: "SGO_Status",
                columns: table => new
                {
                    Status_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status_name = table.Column<string>(nullable: true),
                    Cod_group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGO_Status", x => x.Status_id);
                });

            migrationBuilder.CreateTable(
                name: "SGO_TEAM",
                columns: table => new
                {
                    Team_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SGO_ID = table.Column<string>(nullable: true),
                    Team_number = table.Column<string>(nullable: true),
                    pers_id = table.Column<string>(nullable: true),
                    txt_comment = table.Column<string>(nullable: true),
                    Status_id = table.Column<int>(nullable: false),
                    cod_creator = table.Column<string>(nullable: true),
                    cod_update = table.Column<string>(nullable: true),
                    dtm_create = table.Column<DateTime>(nullable: true),
                    dtm_update = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGO_TEAM", x => x.Team_id);
                });

            migrationBuilder.CreateTable(
                name: "SGO_Type",
                columns: table => new
                {
                    SGOType_ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SGOType_name = table.Column<string>(nullable: true),
                    Cod_group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGO_Type", x => x.SGOType_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SGO_Approver");

            migrationBuilder.DropTable(
                name: "SGO_HEAD");

            migrationBuilder.DropTable(
                name: "SGO_Status");

            migrationBuilder.DropTable(
                name: "SGO_TEAM");

            migrationBuilder.DropTable(
                name: "SGO_Type");
        }
    }
}
