using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public interface IBusPassPaymentService {
        Task<bool> createPayment (BusPassPayment payment);
        Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId, int yearId);
        Task<bool> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId);
        Task<ICollection<Payment>> getPaymentsForMonth (int yearId, int monthId);
        Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId, int yearId, int monthId);
        Task<double> getTotalAmountOfPayments(ICollection<Payment> payments);
    }
}