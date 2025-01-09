using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class decretos
{
    public int id { get; set; }

    public string numero { get; set; } = null!;

    public int status { get; set; }

    public DateOnly data { get; set; }

    public string arquivo { get; set; } = null!;

    public virtual status_projetos statusNavigation { get; set; } = null!;
}
