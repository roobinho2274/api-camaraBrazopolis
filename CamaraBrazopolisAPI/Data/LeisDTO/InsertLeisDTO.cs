namespace CamaraBrazopolisAPI.Data.LeisDTO;

public class InsertLeisDTO
{
    public string Numero { get; set; } = null!;
    public DateOnly Data
    {
        get; set;
    }
    public string Arquivo { get; set; } = null!;
    public string Caput { get; set; } = null!;
}
