﻿namespace TEAyudo_JT;
public class ChatMensaje
{
    public int ChatMensajeId { get; set; }
    public int ChatConversacionId { get; set; }
    public int RemitenteId { get; set; }
    public string Contenido { get; set; }
    public DateTime FechaEnvio { get; set; }
}
