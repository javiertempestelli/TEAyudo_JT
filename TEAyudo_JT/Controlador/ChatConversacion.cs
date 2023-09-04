﻿using TEAyudo_JT;
using System;

public class ChatConversacion
{
    public int ChatConversacionId { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int TutorId { get; set; } 
    public int AcompananteId { get; set; }

    public ICollection<ChatMensaje> ChatMensajes { get; set; }
    public ICollection<Tutor> Tutores { get; set; }
    public ICollection<Acompanante> Acompanantes { get; set; }
    public Tutor Tutor { get; set; }
    public Acompanante Acompanante { get; set; }
}
