﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAyudo_JT.Clases
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public string FotoPerfil { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechanNacimiento { get; set; }
    }

}
