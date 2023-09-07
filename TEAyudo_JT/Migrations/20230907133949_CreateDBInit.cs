using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaDisponible",
                columns: table => new
                {
                    DiaDisponibleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lunes = table.Column<bool>(type: "bit", nullable: false),
                    Martes = table.Column<bool>(type: "bit", nullable: false),
                    Miercoles = table.Column<bool>(type: "bit", nullable: false),
                    Jueves = table.Column<bool>(type: "bit", nullable: false),
                    Viernes = table.Column<bool>(type: "bit", nullable: false),
                    Sabado = table.Column<bool>(type: "bit", nullable: false),
                    Domingo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDisponible", x => x.DiaDisponibleId);
                });

            migrationBuilder.CreateTable(
                name: "DisponibilidadHorarias",
                columns: table => new
                {
                    DisponibilidadHorariaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorarioInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisponibilidadHorarias", x => x.DisponibilidadHorariaId);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPostulaciones",
                columns: table => new
                {
                    EstadoPropuestaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPostulaciones", x => x.EstadoPropuestaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoUsuario",
                columns: table => new
                {
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoUsuario", x => x.EstadoUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "ObrasSociales",
                columns: table => new
                {
                    ObraSocialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrasSociales", x => x.ObraSocialId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
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
                    FechanNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Acompanantes",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ZonaLaboral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    ObraSocialId = table.Column<int>(type: "int", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documentacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisponibilidadHorariaId = table.Column<int>(type: "int", nullable: false),
                    DiaDisponibleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanantes", x => x.AcompananteId);
                    table.ForeignKey(
                        name: "FK_Acompanantes_EstadoUsuario_EstadoUsuarioId",
                        column: x => x.EstadoUsuarioId,
                        principalTable: "EstadoUsuario",
                        principalColumn: "EstadoUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acompanantes_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    TutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CertUniDisc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.TutorId);
                    table.ForeignKey(
                        name: "FK_Tutores_EstadoUsuario_EstadoUsuarioId",
                        column: x => x.EstadoUsuarioId,
                        principalTable: "EstadoUsuario",
                        principalColumn: "EstadoUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tutores_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcompananteDiasDisponible",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    DiaDisponibleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompananteDiasDisponible", x => new { x.AcompananteId, x.DiaDisponibleId });
                    table.ForeignKey(
                        name: "FK_AcompananteDiasDisponible_Acompanantes_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Acompanantes",
                        principalColumn: "AcompananteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompananteDiasDisponible_DiaDisponible_DiaDisponibleId",
                        column: x => x.DiaDisponibleId,
                        principalTable: "DiaDisponible",
                        principalColumn: "DiaDisponibleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcompananteDisponibilidadHoraria",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    DisponibilidadHorariaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompananteDisponibilidadHoraria", x => new { x.AcompananteId, x.DisponibilidadHorariaId });
                    table.ForeignKey(
                        name: "FK_AcompananteDisponibilidadHoraria_Acompanantes_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Acompanantes",
                        principalColumn: "AcompananteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompananteDisponibilidadHoraria_DisponibilidadHorarias_DisponibilidadHorariaId",
                        column: x => x.DisponibilidadHorariaId,
                        principalTable: "DisponibilidadHorarias",
                        principalColumn: "DisponibilidadHorariaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcompananteEspecialidad",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompananteEspecialidad", x => new { x.AcompananteId, x.EspecialidadId });
                    table.ForeignKey(
                        name: "FK_AcompananteEspecialidad_Acompanantes_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Acompanantes",
                        principalColumn: "AcompananteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcompananteEspecialidad_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcompananteObraSocial",
                columns: table => new
                {
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    ObrasocialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompananteObraSocial", x => new { x.AcompananteId, x.ObrasocialId });
                    table.ForeignKey(
                        name: "FK_AcompananteObraSocial_Acompanantes_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Acompanantes",
                        principalColumn: "AcompananteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompananteObraSocial_ObrasSociales_ObrasocialId",
                        column: x => x.ObrasocialId,
                        principalTable: "ObrasSociales",
                        principalColumn: "ObraSocialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosticoTEA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Pacientes_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Propuesta",
                columns: table => new
                {
                    PropuestaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TutorId = table.Column<int>(type: "int", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    InfoAdicional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    EstadoPropuestaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propuesta", x => x.PropuestaId);
                    table.ForeignKey(
                        name: "FK_Propuesta_Acompanantes_AcompananteId",
                        column: x => x.AcompananteId,
                        principalTable: "Acompanantes",
                        principalColumn: "AcompananteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propuesta_EstadoPostulaciones_EstadoPropuestaId",
                        column: x => x.EstadoPropuestaId,
                        principalTable: "EstadoPostulaciones",
                        principalColumn: "EstadoPropuestaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propuesta_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcompananteDiasDisponible_DiaDisponibleId",
                table: "AcompananteDiasDisponible",
                column: "DiaDisponibleId");

            migrationBuilder.CreateIndex(
                name: "IX_AcompananteDisponibilidadHoraria_DisponibilidadHorariaId",
                table: "AcompananteDisponibilidadHoraria",
                column: "DisponibilidadHorariaId");

            migrationBuilder.CreateIndex(
                name: "IX_AcompananteEspecialidad_EspecialidadId",
                table: "AcompananteEspecialidad",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_AcompananteObraSocial_ObrasocialId",
                table: "AcompananteObraSocial",
                column: "ObrasocialId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanantes_EstadoUsuarioId",
                table: "Acompanantes",
                column: "EstadoUsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Acompanantes_UsuarioId",
                table: "Acompanantes",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Propuesta_AcompananteId",
                table: "Propuesta",
                column: "AcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_Propuesta_EstadoPropuestaId",
                table: "Propuesta",
                column: "EstadoPropuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Propuesta_TutorId",
                table: "Propuesta",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_EstadoUsuarioId",
                table: "Tutores",
                column: "EstadoUsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_UsuarioId",
                table: "Tutores",
                column: "UsuarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcompananteDiasDisponible");

            migrationBuilder.DropTable(
                name: "AcompananteDisponibilidadHoraria");

            migrationBuilder.DropTable(
                name: "AcompananteEspecialidad");

            migrationBuilder.DropTable(
                name: "AcompananteObraSocial");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Propuesta");

            migrationBuilder.DropTable(
                name: "DiaDisponible");

            migrationBuilder.DropTable(
                name: "DisponibilidadHorarias");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "ObrasSociales");

            migrationBuilder.DropTable(
                name: "Acompanantes");

            migrationBuilder.DropTable(
                name: "EstadoPostulaciones");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropTable(
                name: "EstadoUsuario");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
