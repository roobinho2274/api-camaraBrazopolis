using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class comissao_camara
{
    public int id { get; set; }

    public int id_vereador { get; set; }

    public int id_cargo { get; set; }

    public int id_comissao { get; set; }
}
