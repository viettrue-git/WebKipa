using WebApp.Models.GetMap;

namespace WebKipa_ver2.Dependency.repository.Login
{
    public interface ILoginRepository
    {
        Task<bool> checkLogin(LoginModel loginModel);
    }
}
