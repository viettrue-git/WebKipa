using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApp.Models;
using WebApp.Models.GetMap;
using WebKipa_ver2.Areas.Admin.Service;
using WebKipa_ver2.Dependency.service.User;

namespace WebKipa_ver2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private IUserService _userservice;
        private readonly IOptions<AppSettings> _appsettings;

        public UserController(IUserService userservice, IOptions<AppSettings> appsettings)
        {
            _userservice = userservice;
            _appsettings = appsettings;
        }

        // GET: UserController
        [HttpGet]
        public async Task<IActionResult> Index(string name)
        {
            var listData = await _userservice.getUser(name);
            return View(listData);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        // GET: UserController/Create
        public ActionResult CreateUser()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser([Bind(include: "UserId,UserName,Password,Email")] UserModel user)
        {
            try
            {
                var resultLogin = await _userservice.createUser(user);
                if (resultLogin)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin tài khoản hoặc mật khẩu không chính sác");
                }

            }
            catch (Exception ex)
            {

            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
