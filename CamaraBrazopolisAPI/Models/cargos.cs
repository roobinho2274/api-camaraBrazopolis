using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class cargos
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<mesa_diretora> mesa_diretora { get; set; } = new List<mesa_diretora>();
}
