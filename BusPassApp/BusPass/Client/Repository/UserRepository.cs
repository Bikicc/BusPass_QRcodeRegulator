using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Client.Helpers;

namespace BusPass.Client.Repository {
    public class UserRepository : IUserRepository {
        private readonly IHttpService _httpService;

        public UserRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<User> getUserById (int userId) {
            return await _httpService.Get<User>("api/user/" + userId);
        }
    }
}