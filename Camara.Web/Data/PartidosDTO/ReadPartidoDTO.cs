namespace Camara.Web.Data.PartidosDTO
{
    public class ReadPartidoDTO
    {
        public int Id
        {
            get; set;
        }

        public string Nome { get; set; } = null!;

        public string Imagem { get; set; } = null!;
    }
}
