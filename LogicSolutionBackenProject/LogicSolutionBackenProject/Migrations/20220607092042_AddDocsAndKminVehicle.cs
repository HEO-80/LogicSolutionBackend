using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicSolutionBackenProject.Migrations
{
    public partial class AddDocsAndKminVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "KmRecorridos",
                table: "vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "KmRecorridos",
                table: "vehiculos",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
