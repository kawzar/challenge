using System.Collections.Generic;
using System.Linq;
using Challenge.Data.Models;
using Challenge.Data.Repositories;
using Challenge.Services.Posts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Challenge.Services.Test
{
    [TestClass]
    public class PostsServiceTests
    {
        private readonly Mock<IPostsRepository> repositoryMock;
        private IPostsService service;

        public PostsServiceTests()
        {
            repositoryMock = new Mock<IPostsRepository>();
        }

        [TestInitialize]
        public void Initialize()
        {
            service = new PostsService(repositoryMock.Object);
        }

        [TestMethod]
        public void GetAllPosts_ShouldReturnPosts()
        {
            var posts = GetPostsListMock();
            repositoryMock.Setup(x => x.GetAllPosts()).Returns(posts);

            var result = service.GetAllPosts();

            Assert.AreEqual(result, posts);
        }

        [TestMethod]
        public void GetPostById_ShouldReturnPost()
        {
            var post = GetPostsListMock().First();
            repositoryMock.Setup(x => x.GetPostById(It.IsAny<int>())).Returns(post);

            var result = service.GetPostById(It.IsAny<int>());

            Assert.AreEqual(result, post);
        }

        [TestMethod]
        public void Add_ShouldCallAddOnRepository()
        {
            repositoryMock.Setup(x => x.AddPost(It.IsAny<Post>())).Verifiable();

            service.AddPost(It.IsAny<Post>());

            repositoryMock.Verify(x => x.AddPost(It.IsAny<Post>()), Times.Once);
        }

        [TestMethod]
        public void Delete_ShouldCallDeleteOnRepository()
        {
            repositoryMock.Setup(x => x.DeletePost(It.IsAny<int>())).Verifiable();

            service.DeletePost(It.IsAny<int>());

            repositoryMock.Verify(x => x.DeletePost(It.IsAny<int>()), Times.Once);
        }

        private IList<Post> GetPostsListMock()
        {
            return new List<Post>
            {
                new Post
                {
                    Author = null,
                    AuthorId = 1,
                    Content = "Content",
                    Id = 1,
                    Title = "Title"
                },
                new Post
                {
                    Author = null,
                    AuthorId = 1,
                    Content = "Content",
                    Id = 1,
                    Title = "Title"
                }
            };
        }
    }
}
