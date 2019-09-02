using Challenge.Data.Models;
using Challenge.Services.Posts;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Web.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly IPostsService service;

        public PostsController(IPostsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public JsonResult Posts()
        {
            return Json(service.GetAllPosts());
        }

        [HttpGet]
        public JsonResult Post(int id)
        {
            return Json(service.GetPostById(id));
        }

        [HttpPost]
        public void SavePost(Post post)
        {
            service.AddPost(post);
        }

        [HttpDelete]
        public void DeletePost(int id)
        {
            service.DeletePost(id);
        }
    }
}