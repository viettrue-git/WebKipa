using WebApp.Models.GetMap;
using WebKipa_ver2.Dependency.repository.Login;

namespace WebKipa_ver2.Dependency.service.Login
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        
        public LoginService(ILoginRepository loginRepository) 
        {
            _loginRepository = loginRepository;
        }
        public async Task<bool> checkLogin(LoginModel model)
        {
            return await _loginRepository.checkLogin(model);
        }
    }
}
