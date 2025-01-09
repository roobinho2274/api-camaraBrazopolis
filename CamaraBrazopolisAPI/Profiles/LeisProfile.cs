using AutoMapper;

using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Models;

namespace CamaraBrazopolisAPI.Profiles
{
    public class LeisProfile: Profile
    {
        public LeisProfile()
        {
            CreateMap<InsereLeisDTO, Leis>();
            CreateMap<Leis, ReadLeisDTO>();
            CreateMap<UpdateLeiDTO, Leis>();
        }
    }
}
