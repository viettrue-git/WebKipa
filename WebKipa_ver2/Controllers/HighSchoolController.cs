using Microsoft.AspNetCore.Mvc;

namespace WebKipa_ver2.Controllers
{
    public class HighSchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
