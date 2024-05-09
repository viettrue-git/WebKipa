using Microsoft.AspNetCore.Mvc;

namespace WebKipa_ver2.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
