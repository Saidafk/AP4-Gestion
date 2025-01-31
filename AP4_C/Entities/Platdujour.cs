using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Platdujour
{
    public DateOnly Ddmmyyyy { get; set; }

    public int Idplat { get; set; }

    public ulong Idper { get; set; }

    public virtual Personnel IdperNavigation { get; set; } = null!;

    public virtual Plat IdplatNavigation { get; set; } = null!;
}
