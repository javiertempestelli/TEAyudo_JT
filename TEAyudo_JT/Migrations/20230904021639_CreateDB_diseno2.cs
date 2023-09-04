using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB_diseno2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Acompanantes",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoPerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    EstadoUsuario = table.Column<int>(type: "int", nullable: false),
                    ObraSocialId = table.Column<int>(type: "int", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documentacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostulacionId = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<int>(type: "int", nullable: false),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanantes", x => x.AcompananteId);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    TutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    CertUniDisc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoPerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    EstadoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.TutorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeUsuario_AcompananteId",
                table: "TiposDeUsuario",
                column: "AcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeUsuario_TutorId",
                table: "TiposDeUsuario",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuario_AcompananteId",
                table: "EstadoUsuario",
                column: "AcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuario_TutorId",
                table: "EstadoUsuario",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcompananteObraSocial_Acompanantes_AcompanantesAcompananteId",
                table: "AcompananteObraSocial",
                column: "AcompanantesAcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Acompanantes_AcompananteId",
                table: "Especialidades",
                column: "AcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoUsuario_Acompanantes_AcompananteId",
                table: "EstadoUsuario",
                column: "AcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoUsuario_Tutores_TutorId",
                table: "EstadoUsuario",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Tutores_TutorId",
                table: "Pacientes",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulaciones_Acompanantes_AcompananteId",
                table: "Postulaciones",
                column: "AcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposDeUsuario_Acompanantes_AcompananteId",
                table: "TiposDeUsuario",
                column: "AcompananteId",
                principalTable: "Acompanantes",
                principalColumn: "AcompananteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposDeUsuario_Tutores_TutorId",
                table: "TiposDeUsuario",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "TutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcompananteObraSocial_Acompanantes_AcompanantesAcompananteId",
                table: "AcompananteObraSocial");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Acompanantes_AcompananteId",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_EstadoUsuario_Acompanantes_AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_EstadoUsuario_Tutores_TutorId",
                table: "EstadoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Tutores_TutorId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulaciones_Acompanantes_AcompananteId",
                table: "Postulaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposDeUsuario_Acompanantes_AcompananteId",
                table: "TiposDeUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposDeUsuario_Tutores_TutorId",
                table: "TiposDeUsuario");

            migrationBuilder.DropTable(
                name: "Acompanantes");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropIndex(
                name: "IX_TiposDeUsuario_AcompananteId",
                table: "TiposDeUsuario");

            migrationBuilder.DropIndex(
                name: "IX_TiposDeUsuario_TutorId",
                table: "TiposDeUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EstadoUsuario_AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.DropIndex(
                name: "IX_EstadoUsuario_TutorId",
                table: "EstadoUsuario");

            migrationBuilder.DropColumn(
                name: "AcompananteId",
                table: "TiposDeUsuario");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "TiposDeUsuario");

            migrationBuilder.DropColumn(
                name: "AcompananteId",
                table: "EstadoUsuario");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "EstadoUsuario");

            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Pacientes",
                newName: "TutorUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                newName: "IX_Pacientes_TutorUsuarioId");

            migrationBuilder.RenameColumn(
                name: "AcompananteId",
                table: "Especialidades",
                newName: "AcompananteUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_AcompananteId",
                table: "Especialidades",
                newName: "IX_Especialidades_AcompananteUsuarioId");

            migrationBuilder.RenameColumn(
                name: "AcompanantesAcompananteId",
                table: "AcompananteObraSocial",
                newName: "AcompanantesUsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "AcompananteId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertUniDisc",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacto",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Documentacion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Especialidad",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experiencia",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObraSocialId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostulacionId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompananteObraSocial_Usuarios_AcompanantesUsuarioId",
                table: "AcompananteObraSocial",
                column: "AcompanantesUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Usuarios_AcompananteUsuarioId",
                table: "Especialidades",
                column: "AcompananteUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Usuarios_TutorUsuarioId",
                table: "Pacientes",
                column: "TutorUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulaciones_Usuarios_AcompananteId",
                table: "Postulaciones",
                column: "AcompananteId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
