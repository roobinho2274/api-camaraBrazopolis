using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class pedidos
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public string arquivo { get; set; } = null!;

    public DateOnly data_publicacao { get; set; }

    public DateTime data_postagem { get; set; }

    public string resposta { get; set; } = null!;
}
