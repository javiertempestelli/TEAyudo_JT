using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcompananteObraSocial");

            migrationBuilder.DropTable(
                name: "DisponibilidadHorarias");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "EstadoPostulaciones");

            migrationBuilder.DropTable(
                name: "EstadoUsuario");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "TiposDeUsuario");

            migrationBuilder.DropTable(
                name: "ObrasSociales");

            migrationBuilder.DropTable(
                name: "Postulaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
