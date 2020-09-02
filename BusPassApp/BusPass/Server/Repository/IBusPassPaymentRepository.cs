using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;

namespace BusPass.Server.Repository
{
    public interface IBusPassPaymentRepository
    {
        Task<bool> createPayment(BusPassPayment payment);
        Task<ICollection<BusPassPayment>> getPaymentsForBusPass(int busPassId, int yearId); 
        Task<BusPassPayment> checkPassportForCurrentMonth(int busPassId, int monthId, int yearId);
        Task<ICollection<BusPassPayment>> getPaymentsForMonth(int yearId, int monthId);
        Task<ICollection<BusPassPayment>> getPaymentsByPassType(int passTypeId, int yearId);
        Task<Year> getCurrentYear();
    }
}