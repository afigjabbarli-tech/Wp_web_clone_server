using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileCategory;

namespace WebWhatsAppClone.MappingProfiles.FileCategoryProfiles
{
    public class FileCategoryCreateProfile : Profile
    {
        public FileCategoryCreateProfile()
        {
            CreateMap<FileCategoryCreateDTO, FileCategory>();
        }
    }
}
