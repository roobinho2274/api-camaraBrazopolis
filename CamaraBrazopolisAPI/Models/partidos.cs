using System.ComponentModel.DataAnnotations;

namespace CamaraBrazopolisAPI.Models;

public partial class partidos
{
    public int Id{ get; set;}
    [Required]
    public string Nome { get; set; } = null!;
    [Required]
    public string Imagem { get; set; } = null!;

    // Relação inversa
    public ICollection<vereadores> partido_vereadores
    {
        get; set;
    }
}
