using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Allergene
{
    public int Idallergene { get; set; }

    public string Libellealergene { get; set; } = null!;

    public string? Commentaire { get; set; }

    public virtual ICollection<Plat> Idplats { get; set; } = new List<Plat>();
}
