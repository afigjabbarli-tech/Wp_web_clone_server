using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.SubRegion;

namespace WebWhatsAppClone.MappingProfiles.SubRegionProfiles
{
    public class SubRegionUpdateProfile : Profile
    {
        public SubRegionUpdateProfile()
        {
            CreateMap<SubRegionUpdateDTO, SubRegion>();
        }
    }
}
