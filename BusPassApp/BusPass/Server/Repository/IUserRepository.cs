using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BussPass.Server.HelperEntities;

namespace BusPass.Server.Repository {
    public interface IUserRepository {
        Task<User> LoginUser (LoginUser user);
        Task<bool> RegisterUser (User user);
    }

}