using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Employe
{
    internal object User;

    public ulong Idper { get; set; }

    public virtual Cuisinier? Cuisinier { get; set; }

    public virtual Personnel IdperNavigation { get; set; } = null!;

    public virtual Serveur? Serveur { get; set; }
}
