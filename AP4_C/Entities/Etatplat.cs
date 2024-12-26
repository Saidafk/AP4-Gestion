using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Etatplat
{
    public int Idetat { get; set; }

    public string Libelleetat { get; set; } = null!;

    public virtual ICollection<InstancePlat> InstancePlats { get; set; } = new List<InstancePlat>();
}
