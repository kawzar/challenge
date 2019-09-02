using System.Collections.Generic;
using Challenge.Data.Models;

namespace Challenge.Data.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}
