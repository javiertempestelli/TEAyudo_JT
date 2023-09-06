using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAyudo_JT.Modelo
{
    public class AcompananteEspecialidad
    {
        public int AcompananteId {get; set;}
        public Acompanante Acompanante { get; set;}
        public int EspecialidadId { get; set;}
        public Especialidad Especialidad { get; set;}

    }
}
