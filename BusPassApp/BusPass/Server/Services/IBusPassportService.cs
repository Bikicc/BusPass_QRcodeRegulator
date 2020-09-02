using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
namespace BusPass.Server.Services {
    public interface IBusPassportService {
        Task<bool> createBussPassport (BusPassport pass);
        Task<BusPassport> getBusPassport (int busPassId);
        Task<BusPassport> makeInvalid (int passId);
        Task<BusPassport> makeValid (int passId);
        Task<ICollection<BusPassport>> getBusPassports (bool valid);
        Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid);
    }
}