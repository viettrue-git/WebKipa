using WebApp.Models;

namespace WebKipa_ver2.Areas.Admin.Service
{
    public class UserService
    {
        private WebContext _webContext;
        public UserService(WebContext webContext)
        {
            _webContext = webContext;
        }
        public List<UserModel> GetAllUser(string username)
        {
            var listData =new  List<UserModel>();
            return listData;
        }

        public bool CreateUser (UserModel user)
        {
            return false;
        }

        public void UpdateUser (UserModel user)
        {

        }
        public void DeleteUser (UserModel user) { }
    }
}
