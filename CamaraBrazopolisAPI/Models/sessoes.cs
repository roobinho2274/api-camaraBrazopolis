using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class sessoes
{
    public int id { get; set; }

    public int categoria { get; set; }

    public DateOnly data { get; set; }

    public string nome { get; set; } = null!;

    public string arquivo { get; set; } = null!;

    public int sessao { get; set; }

    public string Link { get; set; } = null!;

    public virtual sessao_categoria categoriaNavigation { get; set; } = null!;
}
