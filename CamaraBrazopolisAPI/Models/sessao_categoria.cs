using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class sessao_categoria
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<sessoes> sessoes { get; set; } = new List<sessoes>();
}
