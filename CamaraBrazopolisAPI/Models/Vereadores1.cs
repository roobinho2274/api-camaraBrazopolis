using System;
using System.Collections.Generic;

namespace CamaraBrazopolisAPI.Models;

public partial class Vereadores1
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int Partido { get; set; }

    public string Foto { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mandatos { get; set; } = null!;

    public string Biografia { get; set; } = null!;
}
