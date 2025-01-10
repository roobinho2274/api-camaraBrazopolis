using AutoMapper;
using CamaraBrazopolisAPI.Data.LeisDTO;
using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Profiles;

public class LeisProfile: Profile
{
    public LeisProfile()
    {
        CreateMap<InsertLeisDTO, leis>();
        CreateMap<leis, ReadLeisDTO>();
        CreateMap<UpdateLeiDTO, leis>();
    }
}
