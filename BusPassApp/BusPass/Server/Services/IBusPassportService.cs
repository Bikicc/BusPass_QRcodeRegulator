using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
namespace BusPass.Server.Services {
    public interface IBusPassportService {
        Task<BusPassport> createBussPassport (BusPassport pass);
        Task<BusPassport> getBusPassport (int busPassId);
        Task<ICollection<UserBusPassport>> getBusPassportsByValidity (bool valid);
        Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid);
        Task<BusPassport> makeInvalid (int passId);
        Task<BusPassport> makeValid (int passId);
        void changePasswordValidityIfExpired ();
        Task<BusPassport> updatePassType(int passId, int passTypeId);
    }
}