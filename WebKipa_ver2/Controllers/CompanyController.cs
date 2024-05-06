using Microsoft.AspNetCore.Mvc;

namespace WebKipa_ver2.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
