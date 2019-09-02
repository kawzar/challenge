using System.Collections.Generic;
using Challenge.Data.Models;
using Challenge.Data.Repositories;

namespace Challenge.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository repository;

        public UsersService(IUsersRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return repository.GetAllUsers();
        }
    }
}
