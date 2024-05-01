using WebApp.Models;

namespace WebKipa_ver2.Dependency.repository.User
{
    public interface IUserRepository
    {
        Task<List<UserModel>> getAllUser(string name);

        Task<int> updateUser(UserModel user);

        Task<bool> createUser(UserModel user);

    }
}
