using System.Collections.Generic;
using Challenge.Data.Models;

namespace Challenge.Services.Posts
{
    public interface IPostsService
    {
        IEnumerable<Post> GetAllPosts();
    }
}
