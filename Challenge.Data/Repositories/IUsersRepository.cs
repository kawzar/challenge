using System.Collections.Generic;
using Challenge.Data.Models;

namespace Challenge.Data.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
        User Authenticate(string username, string password);
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
}
