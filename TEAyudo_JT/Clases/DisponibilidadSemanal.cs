﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAyudo_JT.Clases
{
    public class DisponibilidadSemanal
    {
        public int DisponibilidadSemanalId { get; set; }
        public int AcompananteId { get; set; }
        public int DiaSemana { get; set; } 
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }

        public Acompanante Acompanante { get; set; }
    }

}
