using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Client.Repository {
    public interface IBusPassportRepository {
        Task<BusPassport> getBusPassForUser (int userId);
        Task<UserBusPassport[]> getByValidity (bool valid);
        Task<UserBusPassport[]> getByType (string typeId, bool valid);
        Task<BusPassport> updatePassType (int passId, int passTypeId);
        Task<BusPassport> makePassValid (int passId);
        Task<BusPassport> makePassInvalid (int passId);
        Task<BusPassport> addPassport (BusPassport pass);
    }
}