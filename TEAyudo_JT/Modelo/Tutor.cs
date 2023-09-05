using System;
namespace TEAyudo_JT;
public class Tutor
{
    public int TutorId { get; set; }
    public int PacienteId { get; set; }
    public ICollection<Paciente> Pacientes { get; set; }
    public string CertUniDisc { get; set; }
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

    public ICollection<ChatConversacion> ChatConversaciones { get; set; }

}
