﻿using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;

namespace TEAyudo_JT;
public class TEAyudoContext :DbContext
{
    public DbSet<Acompanante> Acompanantes { get; set; }
    public DbSet<DisponibilidadHoraria> DisponibilidadHorarias { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<EstadoPostulacion> EstadoPostulaciones { get; set; }
    public DbSet<ObraSocial> ObrasSociales { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Postulacion> Postulaciones { get; set; }
    public DbSet<TipoUsuario> TiposDeUsuario { get; set; }
    public DbSet<Tutor> Tutores { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //// Configuraciones de modelos y relaciones

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TEAyudo_JT;Trusted_Connection=True;TrustServerCertificate=True");
    }

}
