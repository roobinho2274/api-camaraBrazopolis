using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class noticias
{
    public int id { get; set; }

    public string titulo { get; set; } = null!;

    public string texto { get; set; } = null!;

    public DateOnly data { get; set; }

    public string? foto { get; set; }

    public string url_facebook { get; set; } = null!;

    public string descricao { get; set; } = null!;
}
