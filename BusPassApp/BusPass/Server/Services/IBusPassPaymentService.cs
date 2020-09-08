using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public interface IBusPassPaymentService {
        Task<BusPassPayment> createPayment (BusPassPayment payment);
        Task<ICollection<Payment>> getPaymentsForBusPassForYear (int busPassId, int yearId);
        Task<bool> checkPassportForCurrentMonth (int busPassId);
        Task<PaymentWithRecap> getRecap (ICollection<Payment> payments);
        Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId);
        Task<ICollection<Payment>> getPaymentsWithFilters (string filters, int yearId, int monthId, int typeId);
    }
}