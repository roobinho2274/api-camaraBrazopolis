using AutoMapper;

using CamaraBrazopolisAPI.Data.VereadoresDTO;
using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Profiles;

public class VereadorProfile : Profile
{
    public VereadorProfile()
    {
        CreateMap<InsertVereadorDTO, vereadores>();
        CreateMap<vereadores, ReadVereadorDTO>();
        CreateMap<UpdateVereadorDTO, vereadores>();
    }
}
