using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicSolutionBackenProject.Migrations
{
    public partial class DateNulableToVehiculosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "vehiculos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_flotas_FlotaId",
                table: "vehiculos",
                column: "FlotaId",
                principalTable: "flotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_flotas_FlotaId",
                table: "vehiculos");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "vehiculos");

            migrationBuilder.RenameColumn(
                name: "FlotaId",
                table: "vehiculos",
                newName: "flotaId");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_FlotaId",
                table: "vehiculos",
                newName: "IX_vehiculos_flotaId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "vehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_flotas_flotaId",
                table: "vehiculos",
                column: "flotaId",
                principalTable: "flotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
