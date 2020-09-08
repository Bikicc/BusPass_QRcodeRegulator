using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;

namespace BusPass.Client.Repository {
    public class UserRepository : IUserRepository {
        private readonly IHttpService _httpService;

        public UserRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<User> getUserById (int userId) {
            return await _httpService.Get<User> ("api/user/" + userId);
        }

        public async Task<User> registerUser (User user) {
            return await _httpService.Post("api/user/createUser", user);
        }
    }
}