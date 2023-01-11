using AutoMapper;
using AddressBook.Entities.Models;
using AddressBook.Entities.Dtos;
using System;

namespace AddressBook.Profiles
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //user
            CreateMap<UserCreatingDto, User>().ReverseMap();
            CreateMap<UserUpdatingDto, User>();
            CreateMap<User, UserDto>();

            //email
            CreateMap<EmailCreatingDto, Email>().ForMember(
              dest => dest.TypeId,
              opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
          ).ReverseMap();
            CreateMap<EmailUpdatingDto, Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<EmailDto, Email>().ReverseMap();

            //address
            CreateMap<AddressCreatingDto, Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ReverseMap();
            CreateMap<AddressUpdatingDto, Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ForMember(
                    dest => dest.TypeId,
                    opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();

            //phone
            CreateMap<PhoneNumberCreatingDto, Phone>().ForMember(
               dest => dest.TypeId,
               opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<PhoneNumberUpdatingDto, Phone>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();

            //asset
            CreateMap<AssetCreatingDto, Asset>().ReverseMap();
            CreateMap<AssetDtoResult, Asset>().ReverseMap();

            //Refset
            CreateMap<RefSetDto, RefSet>().ReverseMap();          

        }
    }
}
