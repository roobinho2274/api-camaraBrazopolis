using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class partidovereador
{
    public string partidoNome { get; set; } = null!;

    public int idPartido { get; set; }

    public string imagem { get; set; } = null!;

    public string foto { get; set; } = null!;

    public string nome { get; set; } = null!;

    public int partido { get; set; }

    public string email { get; set; } = null!;

    public string? biografia { get; set; }

    public int id { get; set; }

    public int ativo { get; set; }
}
