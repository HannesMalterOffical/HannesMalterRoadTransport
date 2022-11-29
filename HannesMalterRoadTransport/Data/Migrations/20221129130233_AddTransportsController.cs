using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HannesMalterRoadTransport.Data.Migrations
{
    public partial class AddTransportsController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarNR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnspReady = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transport");
        }
    }
}
