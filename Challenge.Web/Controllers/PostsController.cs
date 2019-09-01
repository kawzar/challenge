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
    }
}