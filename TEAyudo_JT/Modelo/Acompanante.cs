using System;
using TEAyudo_JT.Modelo;

namespace TEAyudo_JT;
public class Acompanante
{
	public int AcompananteId { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CorreoElectronico { get; set; }
    public string Contrasena { get; set; }
    public string FotoPerfil { get; set; }
    public string Domicilio { get; set; }
    public string ZonaLaboral { get; set; }
    public int Edad { get; set; }
    public int EstadoUsuarioId { get; set; }
    public EstadoUsuario EstadoUsuario { get; set; }
    public int ObraSocialId { get; set; }
	public ICollection <ObraSocial> ObrasSociales { get; set; }
	public string Contacto { get; set; }
	public string Documentacion {get; set; }
	public int Especialidad { get; set; }
	public ICollection<Especialidad> Especialidades { get; set; }
	public string Experiencia { get; set; }
    public ICollection<ChatConversacion> ChatConversaciones { get;set; }
    public int DisponibilidadHorariaId { get; set; }
    public ICollection<DisponibilidadHoraria> DisponibilidadesHorarias { get; set; }
    public ICollection<Propuesta> Propuestas { get; set; }

}
