using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Message
{
    public int IdMessage { get; set; }

    public int IdChat { get; set; }

    public bool BoolCuisinier { get; set; }

    public string? Contenu { get; set; }

    public DateTime Date { get; set; }

    public virtual Chat IdChatNavigation { get; set; } = null!;
}
