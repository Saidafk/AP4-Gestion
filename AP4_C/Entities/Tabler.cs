using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Tabler
{
    public int Idtable { get; set; }

    public int Idrestau { get; set; }

    public int Nbpersmax { get; set; }

    public bool Estdispo { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual ICollection<Gere> Geres { get; set; } = new List<Gere>();

    public virtual Restaurant IdrestauNavigation { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
