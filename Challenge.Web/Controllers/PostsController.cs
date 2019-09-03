using Challenge.Data.Models;
using Challenge.Services.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Web.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private readonly IPostsService service;

        public PostsController(IPostsService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult AllPosts()
        {
            return Json(service.GetAllPosts());
        }
        [AllowAnonymous]
        [HttpGet]
        public JsonResult Post(int id)
        {
            return Json(service.GetPostById(id));
        }

        [HttpPost]
        public void SavePost([FromBody]Post post)
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