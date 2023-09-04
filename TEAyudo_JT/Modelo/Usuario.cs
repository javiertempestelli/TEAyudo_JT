namespace TEAyudo_JT;
public class Usuario
{
    public int UsuarioId { get; set; }
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
}


