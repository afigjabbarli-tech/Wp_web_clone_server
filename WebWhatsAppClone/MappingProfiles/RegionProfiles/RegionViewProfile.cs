using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Region;

namespace WebWhatsAppClone.MappingProfiles.RegionProfiles
{
    public class RegionViewProfile : Profile
    {
        public RegionViewProfile()
        {
            CreateMap<Region, RegionViewDTO>();
        }
    }
}
