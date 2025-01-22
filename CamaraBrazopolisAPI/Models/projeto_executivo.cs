using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CamaraBrazopolisAPI.Models;

public partial class projeto_executivo
{
    public int id { get; set; }
    [Required]
    public string numero { get; set; } = null!;
    [Required]
    public DateOnly data { get; set; }
    [Required]
    public int status { get; set; }
    [Required]
    public string arquivo { get; set; } = null!;

    public virtual status_projetos statusNavigation { get; set; } = null!;
}
