using Challenge.Services.DTOs;

namespace Challenge.Services.Users
{
    public interface IUsersService
    {
        UserDto Authenticate(string username, string password);
        UserDto GetById(int id);
        UserDto Create(UserDto user, string password);
        void Update(UserDto user, string password = null);
        void Delete(int id);
    }
}
