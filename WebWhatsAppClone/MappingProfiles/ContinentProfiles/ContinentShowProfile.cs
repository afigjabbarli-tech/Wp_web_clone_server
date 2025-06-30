using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Continent;

namespace WebWhatsAppClone.MappingProfiles.ContinentProfiles
{
    public class ContinentShowProfile : Profile
    {
        public ContinentShowProfile()
        {
            CreateMap<Continent, ContinentShowDTO>();
        }
    }
}
