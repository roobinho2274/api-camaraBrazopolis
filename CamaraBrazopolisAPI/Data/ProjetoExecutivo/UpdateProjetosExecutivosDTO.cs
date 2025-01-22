using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Data.ProjetoExecutivo
{
    public class UpdateProjetosExecutivosDTO
    {
        public string numero { get; set; } = null!;

        public DateOnly data
        {
            get; set;
        }

        public int status
        {
            get; set;
        }

        public string arquivo { get; set; } = null!;

    }
}
