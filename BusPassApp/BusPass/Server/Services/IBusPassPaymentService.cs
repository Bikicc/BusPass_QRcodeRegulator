using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Services {
    public interface IBusPassPaymentService {
        Task<bool> createPayment (BusPassPayment payment);
        Task<ICollection<BusPassPayment>> getPaymentsForBusPass (int busPassId, int yearId);
        Task<bool> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId);
        Task<ICollection<BusPassPayment>> getPaymentsForMonth (int yearId, int monthId);
        Task<ICollection<BusPassPayment>> getPaymentsByPassType (int passTypeId, int yearId);
    }
}