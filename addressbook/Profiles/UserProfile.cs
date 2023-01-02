using AutoMapper;

namespace addressbook.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            //create
            CreateMap<Models.UserCreatingDto,Entities.User>().ReverseMap();
            //update
            CreateMap<Models.UserUpdatingDto, Entities.User>();
            //map
            CreateMap<Entities.User, Models.UserDto>();
        }

    }
}
