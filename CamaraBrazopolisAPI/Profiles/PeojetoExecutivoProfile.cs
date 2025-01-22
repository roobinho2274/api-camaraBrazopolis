using AutoMapper;

using CamaraBrazopolisAPI.Data.ProjetoExecutivo;
using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Profiles
{
    public class PeojetoExecutivoProfile : Profile
    {
        public PeojetoExecutivoProfile()
        {
            CreateMap<ReadProjetosExecutivosDTO, projeto_executivo>();
            CreateMap<projeto_executivo, ReadProjetosExecutivosDTO>();
            CreateMap<InsertProjetosExecutivosDTO, projeto_executivo>();
            CreateMap<UpdateProjetosExecutivosDTO, projeto_executivo>();
        }
    }
}
