using AutoMapper;
using Challenge.Data.Models;
using Challenge.Services.DTOs;

namespace Challenge.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
