using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Data.ProjetoExecutivo
{
    public class ReadProjetosExecutivosDTO
    {
        public int id
        {
            get; set;
        }

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
