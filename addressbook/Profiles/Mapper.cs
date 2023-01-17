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
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, UserDto>();

            //email
            CreateMap<CreateEmailDto, Email>().ForMember(
              dest => dest.TypeId,
              opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
          ).ReverseMap();
            CreateMap<UpdateEmailDto, Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<EmailDto, Email>().ReverseMap();

            //address
            CreateMap<CreateAddressDto, Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))).ReverseMap();
            CreateMap<UpdateAddressDto, Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ForMember(
                    dest => dest.TypeId,
                    opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();

            //phone
            CreateMap<CreatePhoneNumberDto, Phone>().ForMember(
               dest => dest.TypeId,
               opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<UpdatePhoneNumberDto, Phone>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
            ).ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();

            //asset
            CreateMap<CreateAssetDto, Asset>().ReverseMap();
            CreateMap<ResultAssetDto, Asset>().ReverseMap();

            //Refset
            CreateMap<RefTermDto, RefSet>().ReverseMap();
            CreateMap<RefTermDto, RefTerm>().ReverseMap();

        }
    }
}
