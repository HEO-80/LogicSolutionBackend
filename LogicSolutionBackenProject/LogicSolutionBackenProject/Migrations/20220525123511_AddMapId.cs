using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicSolutionBackenProject.Migrations
{
    public partial class AddMapId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "maps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<int>(type: "int", nullable: false),
                    Long = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maps_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactos");

            migrationBuilder.DropTable(
                name: "maps");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "flotas");
        }
    }
}
