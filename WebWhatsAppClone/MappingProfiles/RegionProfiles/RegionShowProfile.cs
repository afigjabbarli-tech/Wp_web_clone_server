using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Region;

namespace WebWhatsAppClone.MappingProfiles.RegionProfiles
{
    public class RegionShowProfile : Profile
    {
        public RegionShowProfile()
        {
            CreateMap<Region, RegionShowDTO>();
        }
    }
}
