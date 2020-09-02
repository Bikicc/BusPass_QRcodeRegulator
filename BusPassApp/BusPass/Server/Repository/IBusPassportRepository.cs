using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Repository {
    public interface IBusPassportRepository {
        Task<bool> createBussPassport (BusPassport pass);
        Task<BusPassport> getBusPassport (int busPassId);
        Task<BusPassport> changeValidity (BusPassport pass);
        Task<ICollection<BusPassport>> getBusPassports (bool valid);
        Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid);

    }
}