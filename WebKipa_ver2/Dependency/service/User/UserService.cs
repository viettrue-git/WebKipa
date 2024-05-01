using WebApp.Models;
using WebKipa_ver2.Dependency.repository.User;

namespace WebKipa_ver2.Dependency.service.User
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> createUser(UserModel user)
        {
            return await _userRepository.createUser(user);
        }

        public async Task<List<UserModel>> getUser(string name)
        {
            return await _userRepository.getAllUser(name); ;   
        }

        public Task<int> updateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
