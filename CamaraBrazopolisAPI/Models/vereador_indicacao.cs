using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class vereador_indicacao
{
    public int id { get; set; }

    public int id_vereador { get; set; }

    public int id_indicacao { get; set; }

    public virtual indicacoes id_indicacaoNavigation { get; set; } = null!;

    public virtual vereadores id_vereadorNavigation { get; set; } = null!;
}
