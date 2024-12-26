using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Manager
{
    public ulong Idper { get; set; }

    public bool Estadmin { get; set; }

    public virtual Personnel IdperNavigation { get; set; } = null!;
}
