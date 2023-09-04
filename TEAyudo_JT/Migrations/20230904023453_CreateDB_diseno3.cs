using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB_diseno3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstadoPostulaciones_Postulaciones_PostulacionId",
                table: "EstadoPostulaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_EstadoUsuario_Usuarios_UsuarioId",
                table: "EstadoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposDeUsuario_Usuarios_UsuarioId",
                table: "TiposDeUsuario");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_TiposDeUsuario_UsuarioId",
                table: "TiposDeUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EstadoUsuario_UsuarioId",
                table: "EstadoUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EstadoPostulaciones_PostulacionId",
                table: "EstadoPostulaciones");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TiposDeUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "EstadoUsuario");

            migrationBuilder.DropColumn(
                name: "PostulacionId",
                table: "EstadoPostulaciones");

            migrationBuilder.AddColumn<int>(
                name: "ChatConversacionId",
                table: "Tutores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatConversacionId",
                table: "Acompanantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChatConversaciones",
                columns: table => new
                {
                    ChatConversacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatConversaciones", x => x.ChatConversacionId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPostulacionPostulacion",
                columns: table => new
                {
                    EstadosDePostulacionEstadoPostulacionId = table.Column<int>(type: "int", nullable: false),
                    PostulacionesPostulacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPostulacionPostulacion", x => new { x.EstadosDePostulacionEstadoPostulacionId, x.PostulacionesPostulacionId });
                    table.ForeignKey(
                        name: "FK_EstadoPostulacionPostulacion_EstadoPostulaciones_EstadosDePostulacionEstadoPostulacionId",
                        column: x => x.EstadosDePostulacionEstadoPostulacionId,
                        principalTable: "EstadoPostulaciones",
                        principalColumn: "EstadoPostulacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadoPostulacionPostulacion_Postulaciones_PostulacionesPostulacionId",
                        column: x => x.PostulacionesPostulacionId,
                        principalTable: "Postulaciones",
                        principalColumn: "PostulacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatMensaje",
                columns: table => new
                {
                    ChatMensajeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatConversacionId = table.Column<int>(type: "int", nullable: false),
                    RemitenteId = table.Column<int>(type: "int", nullable: false),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMensaje", x => x.ChatMensajeId);
                    table.ForeignKey(
                        name: "FK_ChatMensaje_ChatConversaciones_ChatConversacionId",
                        column: x => x.ChatConversacionId,
                        principalTable: "ChatConversaciones",
                        principalColumn: "ChatConversacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_ChatConversacionId",
                table: "Tutores",
                column: "ChatConversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanantes_ChatConversacionId",
                table: "Acompanantes",
                column: "ChatConversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMensaje_ChatConversacionId",
                table: "ChatMensaje",
                column: "ChatConversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPostulacionPostulacion_PostulacionesPostulacionId",
                table: "EstadoPostulacionPostulacion",
                column: "PostulacionesPostulacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acompanantes_ChatConversaciones_ChatConversacionId",
                table: "Acompanantes",
                column: "ChatConversacionId",
                principalTable: "ChatConversaciones",
                principalColumn: "ChatConversacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_ChatConversaciones_ChatConversacionId",
                table: "Tutores",
                column: "ChatConversacionId",
                principalTable: "ChatConversaciones",
                principalColumn: "ChatConversacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acompanantes_ChatConversaciones_ChatConversacionId",
                table: "Acompanantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_ChatConversaciones_ChatConversacionId",
                table: "Tutores");

            migrationBuilder.DropTable(
                name: "ChatMensaje");

            migrationBuilder.DropTable(
                name: "EstadoPostulacionPostulacion");

            migrationBuilder.DropTable(
                name: "ChatConversaciones");

            migrationBuilder.DropIndex(
                name: "IX_Tutores_ChatConversacionId",
                table: "Tutores");

            migrationBuilder.DropIndex(
                name: "IX_Acompanantes_ChatConversacionId",
                table: "Acompanantes");

            migrationBuilder.DropColumn(
                name: "ChatConversacionId",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "ChatConversacionId",
                table: "Acompanantes");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TiposDeUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "EstadoUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostulacionId",
                table: "EstadoPostulaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    EstadoUsuario = table.Column<int>(type: "int", nullable: false),
                    FotoPerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeUsuario_UsuarioId",
                table: "TiposDeUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuario_UsuarioId",
                table: "EstadoUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPostulaciones_PostulacionId",
                table: "EstadoPostulaciones",
                column: "PostulacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoPostulaciones_Postulaciones_PostulacionId",
                table: "EstadoPostulaciones",
                column: "PostulacionId",
                principalTable: "Postulaciones",
                principalColumn: "PostulacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoUsuario_Usuarios_UsuarioId",
                table: "EstadoUsuario",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposDeUsuario_Usuarios_UsuarioId",
                table: "TiposDeUsuario",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }
    }
}
