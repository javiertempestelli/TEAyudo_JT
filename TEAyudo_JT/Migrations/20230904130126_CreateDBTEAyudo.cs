using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBTEAyudo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstadoUsuario_Acompanantes_AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EstadoUsuario_AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.DropColumn(
                name: "AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.RenameColumn(
                name: "EstadoUsuario",
                table: "Acompanantes",
                newName: "EstadoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanantes_EstadoUsuarioId",
                table: "Acompanantes",
                column: "EstadoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acompanantes_EstadoUsuario_EstadoUsuarioId",
                table: "Acompanantes",
                column: "EstadoUsuarioId",
                principalTable: "EstadoUsuario",
                principalColumn: "EstadoUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acompanantes_EstadoUsuario_EstadoUsuarioId",
                table: "Acompanantes");

            migrationBuilder.DropIndex(
                name: "IX_Acompanantes_EstadoUsuarioId",
                table: "Acompanantes");

            migrationBuilder.RenameColumn(
                name: "EstadoUsuarioId",
                table: "Acompanantes",
                newName: "EstadoUsuario");

            migrationBuilder.AddColumn<int>(
                name: "AcompananteId",
                table: "EstadoUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuario_AcompananteId",
                table: "EstadoUsuario",
                column: "AcompananteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoUsuario_Acompanantes_AcompananteId",
                table: "EstadoUsuario",
                column: "AcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId");
        }
    }
}
