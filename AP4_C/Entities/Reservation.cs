using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Reservation
{
    public int Idreserv { get; set; }

    public ulong Idclient { get; set; }

    public int Idtable { get; set; }

    public string Qr { get; set; } = null!;

    public int Nbpers { get; set; }

    public DateTime Datedebut { get; set; }

    public DateTime? Datefin { get; set; }

    public string? Commentaire { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual Client IdclientNavigation { get; set; } = null!;

    public virtual Tabler IdtableNavigation { get; set; } = null!;
}
