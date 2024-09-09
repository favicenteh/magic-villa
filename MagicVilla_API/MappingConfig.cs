using AutoMapper;
using MagicVilla_API.Controllers.Modelos;
using MagicVilla_API.Controllers.Modelos.Dto;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();
            
            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
            
        }
    }
}
