using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.MappingProfiles.FileFormatProfiles
{
    public class FileFormatShowProfile : Profile
    {
        public FileFormatShowProfile()
        {
            CreateMap<FileFormat, FileFormatShowDTO>();
        }
    }
}
