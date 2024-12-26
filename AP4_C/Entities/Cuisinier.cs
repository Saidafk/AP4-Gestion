using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Cuisinier
{
    public ulong Idper { get; set; }

    public virtual Employe IdperNavigation { get; set; } = null!;
}
