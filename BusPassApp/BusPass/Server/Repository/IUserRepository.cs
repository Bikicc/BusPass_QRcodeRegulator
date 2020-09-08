using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Repository {
    public interface IUserRepository {
        Task<User> LoginUser (LoginUser user);
        Task<User> RegisterUser (User user);
        Task<bool> CheckIfUserExists(User user);
        Task<User> getUserById(int userdId);
    }

}