using AutoMapper;

using CamaraBrazopolisAPI.Data.PartidosDTO;
using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Profiles;

public class PartidoProfile : Profile
{
    public PartidoProfile()
    {
        CreateMap<ReadPartidoDTO, partidos>();
        CreateMap<partidos, ReadPartidoDTO>();
        CreateMap<InsertPartidoDTO, partidos>();
        CreateMap<UpdatePartidoDTO, partidos>();
    }
}
