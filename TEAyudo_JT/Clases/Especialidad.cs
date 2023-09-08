using TEAyudo_JT.Clases;

namespace TEAyudo_JT
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }

        public string Descripcion { get; set; }

        //        public int AcompananteId { get; set; }
        public ICollection<Acompanante> Acompanantes { get; set; }
    }
}