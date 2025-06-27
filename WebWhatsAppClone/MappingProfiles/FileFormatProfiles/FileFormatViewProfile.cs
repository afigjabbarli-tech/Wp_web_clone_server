using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.MappingProfiles.FileFormatProfiles
{
    public class FileFormatViewProfile : Profile
    {
        public FileFormatViewProfile()
        {
            CreateMap<FileFormat, FileFormatViewDTO>();
        }
    }
}
