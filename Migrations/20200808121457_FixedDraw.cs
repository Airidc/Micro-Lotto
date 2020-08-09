using Microsoft.EntityFrameworkCore.Migrations;

namespace micro_lotto.Migrations
{
    public partial class FixedDraw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "iso_time",
                table: "Draw",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iso_time",
                table: "Draw");
        }
    }
}
