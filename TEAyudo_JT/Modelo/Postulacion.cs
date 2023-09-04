namespace TEAyudo_JT
{
    public class Postulacion
    {
        public int PostulacionId { get; set; }  
        public string Titulo { get; set; }
        public string Descripcion { get; set; } 
        public string Ubicacion { get; set; }
        public DateTime FechaCreacion { get; set; } 
        public int EspecliadadId { get; set; }  
        public int ObraSocialId { get; set; }
        public int DisponibilidadHorariaId { get; set; }
        public int AcompananteId { get; set; }
        public int EstadoPostulacionId { get; set; } 

        public ICollection<DisponibilidadHoraria> DisponibilidadesHoraria { get; set; }
        public ICollection<EstadoPostulacion> EstadosDePostulacion { get; set; }

    }
}