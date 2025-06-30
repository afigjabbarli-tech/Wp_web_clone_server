using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Continent;

namespace WebWhatsAppClone.MappingProfiles.ContinentProfiles
{
    public class ContinentCreateProfile : Profile
    {
        public ContinentCreateProfile()
        {
            CreateMap<ContinentCreateDTO, Continent>();
        }
    }
}
