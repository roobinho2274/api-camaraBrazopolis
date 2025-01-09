using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class vereador_pedido
{
    public int id { get; set; }

    public int id_vereador { get; set; }

    public int id_pedido { get; set; }

    public DateTime dh_postagem { get; set; }

    public virtual vereadores id_vereadorNavigation { get; set; } = null!;
}
