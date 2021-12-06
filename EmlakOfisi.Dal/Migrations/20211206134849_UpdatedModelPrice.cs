using Microsoft.EntityFrameworkCore.Migrations;

namespace EmlakOfisi.Dal.Migrations
{
    public partial class UpdatedModelPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ads",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ads");
        }
    }
}
