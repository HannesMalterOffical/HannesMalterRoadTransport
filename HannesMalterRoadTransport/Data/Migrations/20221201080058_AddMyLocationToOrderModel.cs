using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HannesMalterRoadTransport.Data.Migrations
{
    public partial class AddMyLocationToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyLocation",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyLocation",
                table: "Order");
        }
    }
}
