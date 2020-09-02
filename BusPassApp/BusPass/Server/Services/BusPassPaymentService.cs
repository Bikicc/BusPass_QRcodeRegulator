using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Services {
    public class BusPassPaymentService : IBusPassPaymentService {
        private readonly IBusPassPaymentRepository _repo;

        public BusPassPaymentService (IBusPassPaymentRepository repo) {
            _repo = repo;
        }

        public async Task<bool> createPayment (BusPassPayment payment) {
            Year currYear = await _repo.getCurrentYear ();
            if (currYear == null) {
                return false;
            } else {
                payment.YearId = currYear.YearId;
                payment.MonthId = await getCurrMonthId();
                return await _repo.createPayment (payment);
            }
        }

        public async Task<ICollection<BusPassPayment>> getPaymentsForBusPass (int busPassId, int yearId) {
            return await _repo.getPaymentsForBusPass(busPassId, yearId);
        }
       
       public async Task<bool> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId) {
           BusPassPayment payment = await _repo.checkPassportForCurrentMonth(busPassId, monthId, yearId);
           if (payment == null) {
               return false;
           } else {
               return true;
           }
       }

       public async Task<ICollection<BusPassPayment>> getPaymentsForMonth (int yearId, int monthId) {
           return await _repo.getPaymentsForMonth(yearId, monthId);
       }

        public async Task<ICollection<BusPassPayment>> getPaymentsByPassType (int passTypeId, int yearId) {
            return await _repo.getPaymentsByPassType(passTypeId, yearId);
        }
       
        private Task<int> getCurrMonthId () {
            string monthName = DateTime.Now.ToString ("MMMM");
            return Task.FromResult(DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture ).Month);
        }
    }
}