using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;
using BusPass.Shared.HelperEntities;

namespace BusPass.Client.Repository {
    public interface IBusPassPaymentRepository {
        Task<bool> getBusPassForUser (int userId);
        Task renewBusPass(BusPassPayment payment);
        Task<PaymentWithRecap> getPaymentsForUserByYear(int busPassId, string yearId);
        Task<PaymentWithRecap> getAllPaymentsForUser (int busPassId);
        Task<PaymentWithRecap> getAllPaymentsWithFilters (string filterIndicators, int yearId, int monthId, int typeId);
    }
}