using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Personnel
{
    public ulong Idper { get; set; }

    public int Idrestau { get; set; }

    public virtual Employe? Employe { get; set; }

    public virtual User IdperNavigation { get; set; } = null!;

    public virtual Restaurant IdrestauNavigation { get; set; } = null!;

    public virtual Manager? Manager { get; set; }

    public virtual ICollection<Platdujour> Platdujours { get; set; } = new List<Platdujour>();

    public virtual ICollection<Reaprovision> Reaprovisions { get; set; } = new List<Reaprovision>();
}
