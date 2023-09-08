﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TEAyudo_JT;

#nullable disable

namespace TEAyudo_JT.Migrations
{
    [DbContext(typeof(TEAyudoContext))]
    partial class TEAyudoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TEAyudo_JT.Acompanante", b =>
                {
                    b.Property<int>("AcompananteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcompananteId"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisponibilidadSemanalId")
                        .HasColumnType("int");

                    b.Property<string>("Documentacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Experiencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObraSocialId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("ZonaLaboral")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcompananteId");

                    b.HasIndex("EstadoUsuarioId")
                        .IsUnique();

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Acompanantes");
                });

            modelBuilder.Entity("TEAyudo_JT.AcompananteEspecialidad", b =>
                {
                    b.Property<int>("AcompananteId")
                        .HasColumnType("int");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.HasKey("AcompananteId", "EspecialidadId");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("AcompananteEspecialidad");
                });

            modelBuilder.Entity("TEAyudo_JT.AcompananteObraSocial", b =>
                {
                    b.Property<int>("AcompananteId")
                        .HasColumnType("int");

                    b.Property<int>("ObrasocialId")
                        .HasColumnType("int");

                    b.HasKey("AcompananteId", "ObrasocialId");

                    b.HasIndex("ObrasocialId");

                    b.ToTable("AcompananteObraSocial");
                });

            modelBuilder.Entity("TEAyudo_JT.Clases.DisponibilidadSemanal", b =>
                {
                    b.Property<int>("DisponibilidadSemanalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisponibilidadSemanalId"));

                    b.Property<int>("AcompananteId")
                        .HasColumnType("int");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<DateTime>("HorarioFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("DisponibilidadSemanalId");

                    b.HasIndex("AcompananteId");

                    b.ToTable("DisponibilidadSemanal");
                });

            modelBuilder.Entity("TEAyudo_JT.Clases.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechanNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TEAyudo_JT.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EspecialidadId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EspecialidadId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("TEAyudo_JT.EstadoPropuesta", b =>
                {
                    b.Property<int>("EstadoPropuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoPropuestaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoPropuestaId");

                    b.ToTable("EstadoPostulaciones");
                });

            modelBuilder.Entity("TEAyudo_JT.EstadoUsuario", b =>
                {
                    b.Property<int>("EstadoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoUsuarioId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoUsuarioId");

                    b.ToTable("EstadoUsuario");
                });

            modelBuilder.Entity("TEAyudo_JT.ObraSocial", b =>
                {
                    b.Property<int>("ObraSocialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObraSocialId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObraSocialId");

                    b.ToTable("ObrasSociales");
                });

            modelBuilder.Entity("TEAyudo_JT.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnosticoTEA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.HasKey("PacienteId");

                    b.HasIndex("TutorId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("TEAyudo_JT.Propuesta", b =>
                {
                    b.Property<int>("PropuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropuestaId"));

                    b.Property<int>("AcompananteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoPropuestaId")
                        .HasColumnType("int");

                    b.Property<string>("InfoAdicional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.HasKey("PropuestaId");

                    b.HasIndex("AcompananteId");

                    b.HasIndex("EstadoPropuestaId");

                    b.HasIndex("TutorId");

                    b.ToTable("Propuesta");
                });

            modelBuilder.Entity("TEAyudo_JT.Tutor", b =>
                {
                    b.Property<int>("TutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TutorId"));

                    b.Property<string>("CertUniDisc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoUsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("TutorId");

                    b.HasIndex("EstadoUsuarioId")
                        .IsUnique();

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("TEAyudo_JT.Acompanante", b =>
                {
                    b.HasOne("TEAyudo_JT.EstadoUsuario", "EstadoUsuario")
                        .WithOne("Acompanante")
                        .HasForeignKey("TEAyudo_JT.Acompanante", "EstadoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.Clases.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("TEAyudo_JT.Acompanante", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TEAyudo_JT.AcompananteEspecialidad", b =>
                {
                    b.HasOne("TEAyudo_JT.Acompanante", "Acompanante")
                        .WithMany()
                        .HasForeignKey("AcompananteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Acompanante");

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("TEAyudo_JT.AcompananteObraSocial", b =>
                {
                    b.HasOne("TEAyudo_JT.Acompanante", "Acompanante")
                        .WithMany()
                        .HasForeignKey("AcompananteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.ObraSocial", "ObraSocial")
                        .WithMany()
                        .HasForeignKey("ObrasocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acompanante");

                    b.Navigation("ObraSocial");
                });

            modelBuilder.Entity("TEAyudo_JT.Clases.DisponibilidadSemanal", b =>
                {
                    b.HasOne("TEAyudo_JT.Acompanante", "Acompanante")
                        .WithMany("DisponibilidadesSemanales")
                        .HasForeignKey("AcompananteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Acompanante");
                });

            modelBuilder.Entity("TEAyudo_JT.Paciente", b =>
                {
                    b.HasOne("TEAyudo_JT.Tutor", "Tutor")
                        .WithMany("Pacientes")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TEAyudo_JT.Propuesta", b =>
                {
                    b.HasOne("TEAyudo_JT.Acompanante", "Acompanante")
                        .WithMany("Propuestas")
                        .HasForeignKey("AcompananteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.EstadoPropuesta", "EstadoPropuesta")
                        .WithMany("Propuestas")
                        .HasForeignKey("EstadoPropuestaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.Tutor", "Tutor")
                        .WithMany("Propuestas")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Acompanante");

                    b.Navigation("EstadoPropuesta");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TEAyudo_JT.Tutor", b =>
                {
                    b.HasOne("TEAyudo_JT.EstadoUsuario", "EstadoUsuario")
                        .WithOne("Tutor")
                        .HasForeignKey("TEAyudo_JT.Tutor", "EstadoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TEAyudo_JT.Clases.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("TEAyudo_JT.Tutor", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TEAyudo_JT.Acompanante", b =>
                {
                    b.Navigation("DisponibilidadesSemanales");

                    b.Navigation("Propuestas");
                });

            modelBuilder.Entity("TEAyudo_JT.EstadoPropuesta", b =>
                {
                    b.Navigation("Propuestas");
                });

            modelBuilder.Entity("TEAyudo_JT.EstadoUsuario", b =>
                {
                    b.Navigation("Acompanante")
                        .IsRequired();

                    b.Navigation("Tutor")
                        .IsRequired();
                });

            modelBuilder.Entity("TEAyudo_JT.Tutor", b =>
                {
                    b.Navigation("Pacientes");

                    b.Navigation("Propuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
