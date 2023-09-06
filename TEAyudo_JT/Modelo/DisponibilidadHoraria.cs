namespace TEAyudo_JT
{
    public class DisponibilidadHoraria
    {
        public int DisponibilidadHorariaId { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }
        public int AcompananteId { get; set; }
        public Acompanante Acompanante { get; set; }

    }
}