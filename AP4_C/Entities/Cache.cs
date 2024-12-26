using System;
using System.Collections.Generic;

namespace AP4_C.Entities;

public partial class Cache
{
    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int Expiration { get; set; }
}
