using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileCategory;

namespace WebWhatsAppClone.MappingProfiles.FileCategoryProfiles
{
    public class FileCategoryViewProfile : Profile
    {
        public FileCategoryViewProfile()
        {
            CreateMap<FileCategory,  FileCategoryViewDTO>();
        }
    }
}
