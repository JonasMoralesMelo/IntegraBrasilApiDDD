using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Models;
using AutoMapper;

namespace artigotech_integra_brasilapi.Mapping
{
    public class DDDMapping : Profile
    {
        public DDDMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<DDDResponse, DDDModel>();
            CreateMap<DDDModel, DDDResponse>();
        }
    }
}