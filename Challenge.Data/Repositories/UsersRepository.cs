using System.Collections.Generic;
using Challenge.Data.Context;
using Challenge.Data.Models;

namespace Challenge.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ChallengeContext context;

        public UsersRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }
    }
}
