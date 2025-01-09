using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class mesa_diretora
{
    public int id { get; set; }

    public int id_vereador { get; set; }

    public int cargo { get; set; }

    public virtual cargos cargoNavigation { get; set; } = null!;

    public virtual vereadores id_vereadorNavigation { get; set; } = null!;
}
