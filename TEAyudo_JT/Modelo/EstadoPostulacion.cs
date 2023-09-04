using System;
namespace TEAyudo_JT;
public class EstadoPostulacion
{
    public int EstadoPostulacionId { get; set; }
    public string Descripcion { get; set; } 

    public ICollection<Postulacion> Postulaciones { get; set; }


}
