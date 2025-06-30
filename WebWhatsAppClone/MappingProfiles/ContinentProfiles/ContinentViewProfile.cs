using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Continent;

namespace WebWhatsAppClone.MappingProfiles.ContinentProfiles
{
    public class ContinentViewProfile : Profile
    {
        public ContinentViewProfile()
        {
            CreateMap<Continent, ContinentViewDTO>();   
        }
    }
}
