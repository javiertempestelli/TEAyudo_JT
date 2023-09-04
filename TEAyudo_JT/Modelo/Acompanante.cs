using System;

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
    public int Edad { get; set; }
    public int TipoUsuarioId { get; set; }
    public int EstadoUsuario { get; set; }



    public ICollection<EstadoUsuario> EstadosDeUsuario { get; set; }
    public ICollection<TipoUsuario> TiposDeUsuario { get; set; }

    public int ObraSocialId { get; set; }
	public ICollection <ObraSocial> ObrasSociales { get; set; }
	public string Contacto { get; set; }
	public string Documentacion {get; set; }
	public int PostulacionId { get; set; }
	public ICollection<Postulacion> Postulaciones { get; set; }
	public int Especialidad { get; set; }
	public ICollection<Especialidad> Especialidades { get; set; }
	public string Experiencia { get; set; }

}
