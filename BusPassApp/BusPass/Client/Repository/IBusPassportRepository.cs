using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Client.Repository {
    public interface IBusPassportRepository {
        Task<BusPassport> getBusPassForUser (int userId);
    }
}