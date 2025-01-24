using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class User
{
    public ulong Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? EmailVerifiedAt { get; set; }

    public string? Mdp { get; set; }

    public string? MdpTemp { get; set; }

    public string? Tel { get; set; }

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Personnel? Personnel { get; set; }
}
