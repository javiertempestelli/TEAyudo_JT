using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAyudo_JT.Modelo
{
    public class AcompananteObraSocial
    {
        public int AcompananteId { get; set; }
        public Acompanante Acompanante { get; set; }
        public int ObrasocialId { get; set; }
        public ObraSocial ObraSocial{ get; set; }
    }
}
