using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Commande
{
    public int Idcommande { get; set; }

    public ulong? Idclient { get; set; }

    public int? Idreserv { get; set; }

    public string? Commentaireclient { get; set; }

    public int Idtable { get; set; }

    public virtual ICollection<Facture> Factures { get; set; } = new List<Facture>();

    public virtual Client? IdclientNavigation { get; set; }

    public virtual Reservation? IdreservNavigation { get; set; }

    public virtual Tabler IdtableNavigation { get; set; } = null!;

    public virtual ICollection<InstancePlat> InstancePlats { get; set; } = new List<InstancePlat>();
}
