using AutoMapper;
using addressbook.Models;
using System;

namespace addressbook.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressCreatingDto, Entities.Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ReverseMap();
            CreateMap<AddressUpatingDto, Entities.Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ForMember(
                    dest => dest.TypeId,
                    opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<AddressDto, Entities.Address>().ReverseMap();
        }
    }
}
