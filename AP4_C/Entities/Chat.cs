using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Chat
{
    public int IdChat { get; set; }

    public ulong IdServeur { get; set; }

    public virtual Serveur IdServeurNavigation { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
