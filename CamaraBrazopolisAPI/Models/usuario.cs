using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class usuario
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public string user { get; set; } = null!;

    public string email { get; set; } = null!;

    public string senha { get; set; } = null!;
}
