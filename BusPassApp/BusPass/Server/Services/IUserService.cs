using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public interface IUserService {
        Task<User> LoginUser (LoginUser user);
        Task<bool> RegisterUser (User user);
    }
}