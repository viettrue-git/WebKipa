using WebApp.Models;

namespace WebKipa_ver2.Dependency.service.User
{
    public interface IUserService
    {
        Task<int> updateUser(UserModel user);
        Task<List<UserModel>> getUser(string name);

        Task<bool> createUser(UserModel user);
    }
}
