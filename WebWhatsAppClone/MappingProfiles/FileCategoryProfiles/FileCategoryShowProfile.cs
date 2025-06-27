using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileCategory;

namespace WebWhatsAppClone.MappingProfiles.FileCategoryProfiles
{
    public class FileCategoryShowProfile : Profile
    {
        public FileCategoryShowProfile()
        {
            CreateMap<FileCategory, FileCategoryShowDTO>();
        }
    }
}
