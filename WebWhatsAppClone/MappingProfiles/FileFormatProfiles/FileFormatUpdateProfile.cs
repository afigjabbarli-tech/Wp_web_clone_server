using AutoMapper;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.MappingProfiles.FileFormatProfiles
{
    public class FileFormatUpdateProfile : Profile
    {
        public FileFormatUpdateProfile()
        {
            CreateMap<FileFormatUpdateDTO, FileFormat>();
        }
    }
}
