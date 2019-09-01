using System.Collections.Generic;
using Challenge.Data.Context;
using Challenge.Data.Models;

namespace Challenge.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ChallengeContext context;

        public UsersService(ChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }
    }
}
