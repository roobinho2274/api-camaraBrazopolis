using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class vereadores
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public int partido { get; set; }

    public string foto { get; set; } = null!;

    public string email { get; set; } = null!;

    public string? biografia { get; set; }

    public int ativo { get; set; }

    public virtual ICollection<mesa_diretora> mesa_diretora { get; set; } = new List<mesa_diretora>();

    public virtual ICollection<vereador_indicacao> vereador_indicacao { get; set; } = new List<vereador_indicacao>();

    public virtual ICollection<vereador_pedido> vereador_pedido { get; set; } = new List<vereador_pedido>();

    public virtual ICollection<vereador_requerimento> vereador_requerimento { get; set; } = new List<vereador_requerimento>();
}
