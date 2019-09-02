using System.Collections.Generic;
using Challenge.Data.Models;

namespace Challenge.Data.Repositories
{
    public interface IPostsRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void AddPost(Post post);
        void DeletePost(int id);
    }
}
