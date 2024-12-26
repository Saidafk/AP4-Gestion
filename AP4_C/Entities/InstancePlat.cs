using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class InstancePlat
{
    public int Idcommande { get; set; }

    public int Idinstance { get; set; }

    public int Idplat { get; set; }

    public int Idetat { get; set; }

    public virtual Commande IdcommandeNavigation { get; set; } = null!;

    public virtual Etatplat IdetatNavigation { get; set; } = null!;

    public virtual Plat IdplatNavigation { get; set; } = null!;
}
