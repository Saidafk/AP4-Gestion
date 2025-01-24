using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Message
{
    public long IdMessage { get; set; }

    public int IdChat { get; set; }

    public bool BoolCuisinier { get; set; }

    public DateTime Date { get; set; }

    public string Contenu { get; set; } = null!;

    public bool? ALire { get; set; }

    public virtual Chat IdChatNavigation { get; set; } = null!;
}
