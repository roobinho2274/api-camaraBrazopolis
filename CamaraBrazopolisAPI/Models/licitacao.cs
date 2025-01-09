using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class licitacao
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public int numero { get; set; }

    public DateOnly data { get; set; }

    public string arquivo { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
