using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public interface IBusPassPaymentService {
        Task<BusPassPayment> createPayment (BusPassPayment payment);
        Task<ICollection<Payment>> getPaymentsForBusPassForYear (int busPassId, int yearId);
        Task<bool> checkPassportForCurrentMonth (int busPassId);
        Task<ICollection<Payment>> getPaymentsForMonth (int yearId, int monthId);
        Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId, int yearId, int monthId);
        Task<PaymentWithRecap> getRecap (ICollection<Payment> payments);
        Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId);
    }
}