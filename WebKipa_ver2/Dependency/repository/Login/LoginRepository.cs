using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Models;
using WebApp.Models.GetMap;
using WebKipa_ver2.Base;

namespace WebKipa_ver2.Dependency.repository.Login
{
    public class LoginRepository: BaseRepository, ILoginRepository
    {
        private readonly WebContext _context;
        private IOptions<AppSettings> _settings;
        public LoginRepository(IOptions<AppSettings> settings, WebContext context) : base(settings)
        {
            this._settings = settings;
            _context = context;
        }

        public async Task<bool> checkLogin(LoginModel model)
        {
            var dataModel = await _context.users.Where(m => m.UserName == model.UserName && m.Password == model.PassWord).FirstOrDefaultAsync();
            return dataModel !=null ? true : false ;
        }
    }
}
