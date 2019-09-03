using AutoMapper;
using Challenge.Data.Models;
using Challenge.Data.Repositories;
using Challenge.Services.DTOs;

namespace Challenge.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository repository;
        private readonly IMapper mapper;

        public UsersService(IUsersRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public UserDto Authenticate(string username, string password)
        {
            return mapper.Map<UserDto>(repository.Authenticate(username, password));
        }


        public UserDto GetById(int id)
        {
            return mapper.Map<UserDto>(repository.GetById(id));
        }

        public UserDto Create(UserDto user, string password)
        {
            return mapper.Map<UserDto>(repository.Create(mapper.Map<User>(user), password));
        }

        public void Update(UserDto user, string password = null)
        {
            repository.Update(mapper.Map<User>(user), password);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}