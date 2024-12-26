using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Commande
{
    public int Idcommande { get; set; }

    public ulong Idclient { get; set; }

    public int Idreserv { get; set; }

    public int Idfacture { get; set; }

    public string? Commentaireclient { get; set; }

    public virtual Client IdclientNavigation { get; set; } = null!;

    public virtual Facture IdfactureNavigation { get; set; } = null!;

    public virtual Reservation IdreservNavigation { get; set; } = null!;

    public virtual ICollection<InstancePlat> InstancePlats { get; set; } = new List<InstancePlat>();
}
