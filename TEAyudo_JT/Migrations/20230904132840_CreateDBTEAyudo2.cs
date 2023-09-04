using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBTEAyudo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ObrasSociales",
                columns: table => new
                {
                    ObraSocialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrasSociales", x => x.ObraSocialId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: true),
                    ObraSocialId = table.Column<int>(type: "int", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostulacionId = table.Column<int>(type: "int", nullable: true),
                    Especialidad = table.Column<int>(type: "int", nullable: true),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    CertUniDisc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "AcompananteObraSocial",
                columns: table => new
                {
                    AcompanantesUsuarioId = table.Column<int>(type: "int", nullable: false),
                    ObrasSocialesObraSocialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompananteObraSocial", x => new { x.AcompanantesUsuarioId, x.ObrasSocialesObraSocialId });
                    table.ForeignKey(
                        name: "FK_AcompananteObraSocial_ObrasSociales_ObrasSocialesObraSocialId",
                        column: x => x.ObrasSocialesObraSocialId,
                        principalTable: "ObrasSociales",
                        principalColumn: "ObraSocialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompananteObraSocial_Usuarios_AcompanantesUsuarioId",
                        column: x => x.AcompanantesUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcompananteUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadId);
                    table.ForeignKey(
                        name: "FK_Especialidades_Usuarios_AcompananteUsuarioId",
                        column: x => x.AcompananteUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "EstadoUsuario",
                columns: table => new
                {
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoUsuario", x => x.EstadoUsuarioId);
                    table.ForeignKey(
                        name: "FK_EstadoUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoTEA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Pacientes_Usuarios_TutorUsuarioId",
                        column: x => x.TutorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Postulaciones",
                columns: table => new
                {
                    PostulacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EspecliadadId = table.Column<int>(type: "int", nullable: false),
                    ObraSocialId = table.Column<int>(type: "int", nullable: false),
                    DisponibilidadHorariaId = table.Column<int>(type: "int", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    EstadoPostulacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulaciones", x => x.PostulacionId);
                    table.ForeignKey(
                        name: "FK_Postulaciones_Usuarios_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeUsuario",
                columns: table => new
                {
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeUsuario", x => x.TipoUsuarioId);
                    table.ForeignKey(
                        name: "FK_TiposDeUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "DisponibilidadHorarias",
                columns: table => new
                {
                    DisponibilidadHorariaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostulacionId = table.Column<int>(type: "int", nullable: false),
                    HorarioInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisponibilidadHorarias", x => x.DisponibilidadHorariaId);
                    table.ForeignKey(
                        name: "FK_DisponibilidadHorarias_Postulaciones_PostulacionId",
                        column: x => x.PostulacionId,
                        principalTable: "Postulaciones",
                        principalColumn: "PostulacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPostulaciones",
                columns: table => new
                {
                    EstadoPostulacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostulacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPostulaciones", x => x.EstadoPostulacionId);
                    table.ForeignKey(
                        name: "FK_EstadoPostulaciones_Postulaciones_PostulacionId",
                        column: x => x.PostulacionId,
                        principalTable: "Postulaciones",
                        principalColumn: "PostulacionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcompananteObraSocial_ObrasSocialesObraSocialId",
                table: "AcompananteObraSocial",
                column: "ObrasSocialesObraSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_DisponibilidadHorarias_PostulacionId",
                table: "DisponibilidadHorarias",
                column: "PostulacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_AcompananteUsuarioId",
                table: "Especialidades",
                column: "AcompananteUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPostulaciones_PostulacionId",
                table: "EstadoPostulaciones",
                column: "PostulacionId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuario_UsuarioId",
                table: "EstadoUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorUsuarioId",
                table: "Pacientes",
                column: "TutorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulaciones_AcompananteId",
                table: "Postulaciones",
                column: "AcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeUsuario_UsuarioId",
                table: "TiposDeUsuario",
                column: "UsuarioId");

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Nombre", "Apellido", "Edad", "CorreoElectronic", "Contrasena", "FotoPerfil", "Domicilio", "EstadoUsuario" },
                values: new object[] { "Juan", "Garcia", 30, "juangarcia01@mail.com", "password", "/datos/juangarcia01@mail.com.jpg", "CalleFalsa 123", "1" });


            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Nombre", "Apellido", "Edad", "CorreoElectronic", "Contrasena", "FotoPerfil", "Domicilio", "EstadoUsuario" },
                values: new object[] { "Carlos", "Fernandez", 43, "carlosfernandez01@mail.com", "password", "/datos/albertofernandez01@mail.com.jpg", "AvenidaEquivocada 321", "1" });


            //migrationBuilder.InsertData(
            //    table: "Pacientes",
            //    columns: new[] { "Nombre", "Apellido", "Edad", "DiagnosticoTEA","Sexo","TutorId" },
            //    values: new object[] { "Juancito", "Garcia", 10, "/datos/juancito.pdf","M",1 });
        }

        /// <inheritdoc />
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
