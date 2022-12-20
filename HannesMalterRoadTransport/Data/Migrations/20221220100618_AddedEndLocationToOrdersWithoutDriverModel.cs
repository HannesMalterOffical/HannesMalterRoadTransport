using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HannesMalterRoadTransport.Data.Migrations
{
    public partial class AddedEndLocationToOrdersWithoutDriverModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndLocation",
                table: "OrdersWithoutDriver",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndLocation",
                table: "OrdersWithoutDriver");
        }
    }
}
