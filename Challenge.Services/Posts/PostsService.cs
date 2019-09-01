using System.Collections.Generic;
using Challenge.Data.Context;
using Challenge.Data.Models;

namespace Challenge.Services.Posts
{
    public class PostsService : IPostsService
    {
        private readonly ChallengeContext context;

        public PostsService(ChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return context.Posts;
        }
    }
}
