using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KieuThiHienBTH2.Migrations
{
    public partial class Create_Table_Preson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presons",
                columns: table => new
                {
                    PresonID = table.Column<string>(type: "TEXT", nullable: false),
                    PresonName = table.Column<string>(type: "TEXT", nullable: false),
                    PresonAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presons", x => x.PresonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presons");
        }
    }
}
