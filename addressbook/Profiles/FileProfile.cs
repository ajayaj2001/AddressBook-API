using AutoMapper;
using addressbook.Models;

namespace addressbook.Profiles
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            CreateMap<FileCreatingDto, Entities.ImageFile>().ReverseMap();
        }
    }
}
