using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Region;

namespace WebWhatsAppClone.MappingProfiles.RegionProfiles
{
    public class RegionCreateProfile : Profile  
    {
        public RegionCreateProfile()
        {
            CreateMap<RegionCreateDTO, Region>();
        }
    }
}
