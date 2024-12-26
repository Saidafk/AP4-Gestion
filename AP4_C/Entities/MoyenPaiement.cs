using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class MoyenPaiement
{
    public int Idmoyenpaiement { get; set; }

    public string Libellemoyenpaiement { get; set; } = null!;

    public virtual ICollection<Facture> Factures { get; set; } = new List<Facture>();
}
