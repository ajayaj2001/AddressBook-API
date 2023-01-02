using AutoMapper;
using addressbook.Models;
using System;

namespace addressbook.Profiles
{
    public class EmailProfile : Profile
    {

        public EmailProfile()
        {

            CreateMap<EmailCreatingDto, Entities.Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<EmailUpdatingDto, Entities.Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<EmailDto, Entities.Email>().ReverseMap();
        }

    }
}
