using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HannesMalterRoadTransport.Data.Migrations
{
    public partial class AddAssignTransportNotYetReadyAndAssignTransportToTransportController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assigned",
                table: "Transport");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Transport");

            migrationBuilder.AlterColumn<string>(
                name: "TrnspReady",
                table: "Transport",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TrnspReady",
                table: "Transport",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Assigned",
                table: "Transport",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Transport",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
