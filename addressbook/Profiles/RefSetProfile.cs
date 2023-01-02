using AutoMapper;
using addressbook.Models;
using addressbook.Entities;

namespace addressbook.Profiles
{
    public class RefSetProfile : Profile
    {
        public RefSetProfile()
        {
            CreateMap<RefSetDto, RefSet>().ReverseMap();
        }
    }
}
