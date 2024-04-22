using WebApp.Models;

namespace WebKipa_ver2.Areas.Admin.Service
{
    public class UserService
    {
        public UserService() { }
        public List<User> GetAllUser(string username)
        {
            var listData = new List<User>();
            return listData;
        }

        public bool CreateUser (User user)
        {
            return false;
        }

        public void UpdateUser (User user)
        {

        }
        public void DeleteUser (User user) { }
    }
}
