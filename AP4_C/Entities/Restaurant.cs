using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Restaurant
{
    public int Idrestau { get; set; }

    public string Nomrestau { get; set; } = null!;

    public string Adrrestau { get; set; } = null!;

    public string Logoimg { get; set; } = null!;

    public virtual ICollection<Personnel> Personnel { get; set; } = new List<Personnel>();

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();

    public virtual ICollection<Tabler> Tablers { get; set; } = new List<Tabler>();
}
