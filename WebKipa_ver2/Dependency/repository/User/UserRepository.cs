using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Models;
using WebKipa_ver2.Base;
using WebKipa_ver2.Models;

namespace WebKipa_ver2.Dependency.repository.User
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        private readonly WebContext _context;
        private IOptions<AppSettings> _settings;
        public UserRepository(IOptions<AppSettings> settings, WebContext context) : base(settings)
        {
            this._settings = settings;
            _context = context;
        }

        public async Task<List<UserModel>> getAllUser(string name)
        {
           var listData = await _context.users.Select(x => new UserModel
           {
               UserName = x.UserName,

           }).ToListAsync();
            return listData;
        }

        public async Task<int> updateUser(UserModel user)
        {
            _context.users.Update(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> createUser(UserModel user)
        {
            //validate user
            var isValidate = true;
            var emailValid = await _context.users.Where(m=>m.Email.Equals(user.Email)).FirstOrDefaultAsync();
            if (emailValid != null)
            {
                isValidate = false;
                throw new Exception("Email người dùng đã tồn tại");
            }
            var userNameValid = await _context.users.Where(m => m.UserName.Equals(user.UserName)).FirstOrDefaultAsync();
            if (userNameValid != null)
            {
                isValidate = false;
                throw new Exception("Tên đăng nhập đã tồn tại");
            }

            _context.users.Add(user);
            return true;
            
        }
    }
}
