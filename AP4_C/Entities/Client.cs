using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Client
{
    public ulong Idclient { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual User IdclientNavigation { get; set; } = null!;
}
