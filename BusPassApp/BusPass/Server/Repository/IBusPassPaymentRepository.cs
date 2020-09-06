using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;
using BusPass.Shared.HelperEntities;
namespace BusPass.Server.Repository
{
    public interface IBusPassPaymentRepository
    {
        Task<BusPassPayment> createPayment(BusPassPayment payment);
        Task<ICollection<Payment>> getPaymentsForBusPass(int busPassId, int yearId); 
        Task<BusPassPayment> checkPassportForCurrentMonth(int busPassId, int monthId, int yearId);
        Task<ICollection<Payment>> getPaymentsForMonth(int yearId, int monthId);
        Task<ICollection<Payment>> getPaymentsByPassType(int passTypeId, int yearId, int monthId);
        Task<int> getCurrentYearId();
    }
}