using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriajeApp.Migrations
{
    public partial class TriajeAppMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Encuesta",
                schema: "dbo",
                columns: table => new
                {
                    encuestaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    encuestaFecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    encuestaTipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoBarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoDNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoEdad = table.Column<int>(type: "int", nullable: false),
                    empresaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaEdificio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaNivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kitBienvenida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoTemperatura = table.Column<int>(type: "int", nullable: false),
                    haViajado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cercaniaCovid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoSintomas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alertaIncapacidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reintegroIncapacidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoIncapacitado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleadoVacunado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.encuestaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encuesta",
                schema: "dbo");
        }
    }
}
