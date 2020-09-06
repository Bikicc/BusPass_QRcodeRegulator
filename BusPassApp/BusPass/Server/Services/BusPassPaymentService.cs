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

        public async Task<BusPassPayment> createPayment (BusPassPayment payment) {
            payment.YearId  = await _repo.getCurrentYearId ();
            payment.DateOfPayment = DateTime.Now;
            payment.MonthId = await getCurrMonthId ();
            if (await _repo.checkPassportForCurrentMonth (payment.BusPassportId, payment.MonthId, payment.YearId) == null) {
                return await _repo.createPayment (payment);
            } else {
                return null;
            }

        }

        public async Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId, int yearId) {
            return await _repo.getPaymentsForBusPass (busPassId, yearId);
        }

        public async Task<bool> checkPassportForCurrentMonth (int busPassId) {
            int yearId = await _repo.getCurrentYearId ();
            int monthId = await getCurrMonthId ();

            BusPassPayment payment = await _repo.checkPassportForCurrentMonth (busPassId, monthId, yearId);
            if (payment == null) {
                return false;
            } else {
                return true;
            }
        }

        public async Task<ICollection<Payment>> getPaymentsForMonth (int yearId, int monthId) {
            return await _repo.getPaymentsForMonth (yearId, monthId);
        }

        public async Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId, int yearId, int monthId) {
            return await _repo.getPaymentsByPassType (passTypeId, yearId, monthId);
        }

        private Task<int> getCurrMonthId () {
            string monthName = DateTime.Now.ToString ("MMMM");
            return Task.FromResult (DateTime.ParseExact (monthName, "MMMM", CultureInfo.CurrentCulture).Month);
        }

        public Task<double> getTotalAmountOfPayments (ICollection<Payment> payments) {
            double totalAmount = 0;
            foreach (Payment payment in payments) {
                totalAmount += payment.price;
            }
            return Task.FromResult (totalAmount);
        }
    }
}