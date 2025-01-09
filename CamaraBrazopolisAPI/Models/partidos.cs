using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class partidos
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public string imagem { get; set; } = null!;
}
