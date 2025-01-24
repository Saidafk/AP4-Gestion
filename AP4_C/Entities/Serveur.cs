using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Serveur
{
    public ulong Idper { get; set; }

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Gere> Geres { get; set; } = new List<Gere>();

    public virtual Employe IdperNavigation { get; set; } = null!;
}
