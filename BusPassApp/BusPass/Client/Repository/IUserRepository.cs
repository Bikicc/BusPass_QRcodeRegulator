using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Client.Repository {
    public interface IUserRepository {
        Task<User> getUserById (int userId);
    }
}