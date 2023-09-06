using System;
using TEAyudo_JT;

namespace TEAyudo_JT;
public class EstadoPropuesta
{
    public int EstadoPropuestaId { get; set; }
    public string Descripcion { get; set; } 
    public int PropuestaId { get; set; }
    public ICollection<Propuesta> Propuestas { get; set; }


}
