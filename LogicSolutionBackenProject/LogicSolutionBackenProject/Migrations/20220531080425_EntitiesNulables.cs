using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicSolutionBackenProject.Migrations
{
    public partial class EntitiesNulables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_flotas_FlotaId",
                table: "vehiculos");

            migrationBuilder.RenameColumn(
                name: "FlotaId",
                table: "vehiculos",
                newName: "flotaId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_FlotaId",
                table: "vehiculos",
                newName: "IX_vehiculos_flotaId");

            migrationBuilder.AlterColumn<int>(
                name: "flotaId",
                table: "vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_flotas_flotaId",
                table: "vehiculos",
                column: "flotaId",
                principalTable: "flotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_flotas_flotaId",
                table: "vehiculos");

            migrationBuilder.RenameColumn(
                name: "flotaId",
                table: "vehiculos",
                newName: "FlotaId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_flotaId",
                table: "vehiculos",
                newName: "IX_vehiculos_FlotaId");

            migrationBuilder.AlterColumn<int>(
                name: "FlotaId",
                table: "vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_flotas_FlotaId",
                table: "vehiculos",
                column: "FlotaId",
                principalTable: "flotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
