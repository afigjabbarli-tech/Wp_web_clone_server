using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.SubRegion;

namespace WebWhatsAppClone.MappingProfiles.SubRegionProfiles
{
    public class SubRegionCreateProfile : Profile
    {
        public SubRegionCreateProfile()
        {
            CreateMap<SubRegionCreateDTO, SubRegion>();
        }
    }
}
