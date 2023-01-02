using AutoMapper;
using addressbook.Entities;
using addressbook.Models;

namespace addressbook.Profiles
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<AssetDto, AssetDtoCreating>().ReverseMap();
            CreateMap<AssetDto, AssetUpdateDto>().ReverseMap();
            CreateMap<AssetDtoResult, AssetDto>().ReverseMap();
        }
    }
}
