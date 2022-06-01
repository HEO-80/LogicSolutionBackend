using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicSolutionBackenProject.Migrations
{
    public partial class RemoveCantVehiculosFlotaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadVehiculos",
                table: "flotas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadVehiculos",
                table: "flotas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
