using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class leis
{
    public int id { get; set; }

    public string numero { get; set; } = null!;

    public DateOnly data { get; set; }

    public string arquivo { get; set; } = null!;

    public string Caput { get; set; } = null!;
}
