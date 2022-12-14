using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HannesMalterRoadTransport.Data.Migrations
{
    public partial class RenamedMyLocationToStartingLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyLocation",
                table: "Order",
                newName: "StartingLocation");

            migrationBuilder.CreateTable(
                name: "OrdersWithoutDriver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ETA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarNR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersWithoutDriver", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersWithoutDriver");

            migrationBuilder.RenameColumn(
                name: "StartingLocation",
                table: "Order",
                newName: "MyLocation");
        }
    }
}
