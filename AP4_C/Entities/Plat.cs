using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Plat
{
    public int Idplat { get; set; }

    public int Idtypeplat { get; set; }

    public int Idrestau { get; set; }

    public string Libelleplat { get; set; } = null!;

    public string? Description { get; set; }

    public int Qte { get; set; }

    public double Prixplatht { get; set; }

    public string? Lienimg { get; set; }

    public bool Veggie { get; set; }

    public virtual Restaurant IdrestauNavigation { get; set; } = null!;

    public virtual Typeplat IdtypeplatNavigation { get; set; } = null!;

    public virtual ICollection<InstancePlat> InstancePlats { get; set; } = new List<InstancePlat>();

    public virtual ICollection<Platdujour> Platdujours { get; set; } = new List<Platdujour>();

    public virtual ICollection<Reaprovision> Reaprovisions { get; set; } = new List<Reaprovision>();

    public virtual ICollection<Allergene> Idallergenes { get; set; } = new List<Allergene>();
}
