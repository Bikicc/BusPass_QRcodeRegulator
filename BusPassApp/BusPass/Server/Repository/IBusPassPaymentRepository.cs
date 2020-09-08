using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
namespace BusPass.Server.Repository {
    public interface IBusPassPaymentRepository {
        Task<BusPassPayment> createPayment (BusPassPayment payment);
        Task<ICollection<Payment>> getPaymentsForBusPassForYear (int busPassId, int yearId);
        Task<BusPassPayment> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId);
        Task<ICollection<Payment>> getPaymentsForMonth (int monthId);
        Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId);
        Task<int> getCurrentYearId ();
        Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId);
        Task<ICollection<Payment>> getAllPayments();
        Task<ICollection<Payment>> getPaymentsForMonthAndType (int monthId, int typeId);
        Task<ICollection<Payment>> getPaymentsForYear (int yearId);
        Task<ICollection<Payment>> getPaymentsForYearAndType (int yearId, int typeId);
        Task<ICollection<Payment>> getPaymentsForYearAndMonth (int yearId, int monthId);
        Task<ICollection<Payment>> getPaymentsForYearAndMonthAndType (int yearId, int monthId, int typeId);
    }
}