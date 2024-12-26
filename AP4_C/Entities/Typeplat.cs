using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Typeplat
{
    public int Idtypeplat { get; set; }

    public string Typeplat1 { get; set; } = null!;

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();
}
