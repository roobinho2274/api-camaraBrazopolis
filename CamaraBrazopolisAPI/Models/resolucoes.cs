using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class resolucoes
{
    public int id { get; set; }

    public string? numero { get; set; }

    public int status { get; set; }

    public DateOnly data { get; set; }

    public string arquivo { get; set; } = null!;

    public virtual status_projetos statusNavigation { get; set; } = null!;
}
