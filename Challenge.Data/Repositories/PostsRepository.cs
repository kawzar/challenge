using System.Collections.Generic;
using System.Linq;
using Challenge.Data.Context;
using Challenge.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Data.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly ChallengeContext context;

        public PostsRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return context.Posts.Include(x => x.Author);
        }

        public Post GetPostById(int id)
        {
            return context.Posts.Include(x => x.Author).SingleOrDefault(x => x.Id == id);
        }

        public void AddPost(Post post)
        {
            context.Entry(post.Author).State = EntityState.Unchanged;
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
