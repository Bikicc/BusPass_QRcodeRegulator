using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;

namespace BusPass.Client.Repository {
    public interface IBusPassPaymentRepository {
        Task<bool> getBusPassForUser (int userId);
        Task renewBusPass(BusPassPayment payment);
        Task<ICollection<BusPassPayment>> getPaymentsForUser(int busPassId, int yearId);
    }
}