using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.MappingProfiles.FileFormatProfiles
{
    public class FileFormatCreateProfile : Profile
    {
        public FileFormatCreateProfile()
        {
            CreateMap<FileFormatCreateDTO, FileFormat>();
        }
    }
}
