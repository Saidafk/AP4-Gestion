using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Gere
{
    public ulong Idper { get; set; }

    public int Idtable { get; set; }

    public DateTime Ddmmyyyy { get; set; }

    public virtual Serveur IdperNavigation { get; set; } = null!;

    public virtual Tabler IdtableNavigation { get; set; } = null!;
}
