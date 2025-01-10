using System.ComponentModel.DataAnnotations;

namespace CamaraBrazopolisAPI.Models;

public partial class leis
{
    public int Id { get; set; }
    [Required]
    public string Numero { get; set; } = null!;
    [Required]
    public DateOnly Data { get; set; }
    [Required]
    public string Arquivo { get; set; } = null!;
    [Required]
    public string Caput { get; set; } = null!;
}
