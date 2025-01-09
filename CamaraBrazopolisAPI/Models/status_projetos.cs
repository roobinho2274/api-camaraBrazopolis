using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class status_projetos
{
    public int id { get; set; }

    public string status_nome { get; set; } = null!;

    public virtual ICollection<decretos> decretos { get; set; } = new List<decretos>();

    public virtual ICollection<projeto_executivo> projeto_executivo { get; set; } = new List<projeto_executivo>();

    public virtual ICollection<resolucoes> resolucoes { get; set; } = new List<resolucoes>();
}
