using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public interface IUserService {
        Task<LoginUser> LoginUser (LoginUser user);
        Task<User> RegisterUser (User user);
        Task<User> getUserById (int userId);

    }
}