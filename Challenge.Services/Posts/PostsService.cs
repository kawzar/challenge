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

        public Post GetPostById(int id)
        {
            return context.Posts.Find(id);
        }

        public void AddPost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            context.Posts.Remove(context.Posts.Find(id));
            context.SaveChanges();
        }
    }
}
