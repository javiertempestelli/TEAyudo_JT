using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAyudo_JT.Clases
{
    public class AcompananteDiasDisponible
    {
        public int AcompananteId { get; set; }
        public int DiaDisponibleId { get; set; }

        public Acompanante Acompanante { get; set; }
        public DiaDisponible DiaDisponible { get; set; }
    }
}
