using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Repository {
    public interface IBusPassportRepository {
        Task<BusPassport> createBussPassport (BusPassport pass);
        Task<BusPassport> getBusPassport (int busPassId);
        Task<BusPassport> changeValidity (BusPassport pass);
        Task<ICollection<UserBusPassport>> getBusPassportsByValidity (bool valid);
        Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid);
        Task<int> getUserIdFromPassport(int passportId);
        Task<ICollection<BusPassport>> getValidBusPassports ();
        Task<BusPassport> updateBusPass (int passportId, int passTypeId);
        Task<BusPassport> getBusPassportById (int passId);
    }
}