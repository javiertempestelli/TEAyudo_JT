namespace TEAyudo_JT
{
    public class EstadoUsuario
    {
        public int EstadoUsuarioId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Acompanante> Acompantes { get; set; }
    }
}