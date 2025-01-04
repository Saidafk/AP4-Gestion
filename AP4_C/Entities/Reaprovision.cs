using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Reaprovision
{
    public int Idplat { get; set; }

    public DateTime Ddmmyyyy { get; set; }

    public ulong Idper { get; set; }

    public int Qtereap { get; set; }

    public virtual Personnel IdperNavigation { get; set; } = null!;

    public virtual Plat IdplatNavigation { get; set; } = null!;
}
