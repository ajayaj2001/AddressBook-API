using AutoMapper;
using addressbook.Models;
using System;

namespace addressbook.Profiles
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<PhoneNumberCreatingDto, Entities.PhoneNumber>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<PhoneNumberUpdatingDto, Entities.PhoneNumber>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<PhoneDto, Entities.PhoneNumber>().ReverseMap();
        }
    }
}
