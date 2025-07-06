using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.SubRegion;

namespace WebWhatsAppClone.MappingProfiles.SubRegionProfiles
{
    public class SubRegionShowProfile : Profile
    {
        public SubRegionShowProfile()
        {
            CreateMap<SubRegion, SubRegionShowDTO>();
        }
    }
}
