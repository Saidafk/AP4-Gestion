using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Facture
{
    public int Idfacture { get; set; }

    public int Idtable { get; set; }

    public int Idmoyenpaiement { get; set; }

    public int Tva { get; set; }

    public DateTime Datefacture { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual MoyenPaiement IdmoyenpaiementNavigation { get; set; } = null!;
}
