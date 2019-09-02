using System.Collections.Generic;
using Challenge.Data.Models;
using Challenge.Data.Repositories;

namespace Challenge.Services.Posts
{
    public class PostsService : IPostsService
    {
        private readonly IPostsRepository repository;

        public PostsService(IPostsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return repository.GetAllPosts();
        }

        public Post GetPostById(int id)
        {
            return repository.GetPostById(id);
        }

        public void AddPost(Post post)
        {
            repository.AddPost(post);
        }

        public void DeletePost(int id)
        {
            repository.DeletePost(id);
        }
    }
}
