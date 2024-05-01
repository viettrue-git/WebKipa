using Microsoft.AspNetCore.Mvc;
using WebApp.Models.GetMap;
using WebKipa_ver2.Dependency.service.Login;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// login acount 
        /// </summary>
        /// <param name="model">Loginmodel</param>
        /// <returns>session is acount_email or return error</returns>
        /// admin - pass 123
        [HttpPost]
        [ValidateAntiForgeryToken] //chong viec request lien tuc
        public async Task<IActionResult> Index(LoginModel loginModel)
        {
            var resultLogin = await _loginService.checkLogin(loginModel);
            if (resultLogin)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Thông tin tài khoản hoặc mật khẩu không chính sác");
            }
            return View();
        }
        /*        public ActionResult Index(LoginModel model)
                {
                    var result = new AcountModel().Login(model.UserName, Encode.EncodePassword(model.PassWord));
                    if (result && ModelState.IsValid)
                    {
                        // SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                        FormsAuthentication.SetAuthCookie(model.UserName, model.Remember);
                        var acountModel = new AcountModel();
                        var acount = acountModel.GetAcount(model.UserName);
                        Session.Add("loginSession", acount);
                        if (acount.AcountRole == 0 || acount.AcountRole == null)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Admin/HomeAdmin");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or PassWord no corect");
                    }
                    return View(model);
                }*/


    }
}
