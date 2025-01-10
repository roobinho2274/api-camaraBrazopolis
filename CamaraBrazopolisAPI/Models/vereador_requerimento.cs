namespace CamaraBrazopolisAPI.Models;

public partial class vereador_requerimento
{
    public int id { get; set; }

    public int id_vereador { get; set; }

    public int id_requerimentos { get; set; }

    public DateTime dh_postagem { get; set; }

    public virtual Requerimentos id_requerimentosNavigation { get; set; } = null!;

    public virtual vereadores id_vereadorNavigation { get; set; } = null!;
}
