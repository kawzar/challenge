using System.Collections.Generic;
using Challenge.Data.Models;

namespace Challenge.Services.Users
{
    public interface IUsersService
    {
        IEnumerable<User> GetAllUsers();
    }
}
