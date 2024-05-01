using WebApp.Models.GetMap;

namespace WebKipa_ver2.Dependency.service.Login
{
    public interface ILoginService
    {
        Task<bool> checkLogin(LoginModel model);
    }
}
