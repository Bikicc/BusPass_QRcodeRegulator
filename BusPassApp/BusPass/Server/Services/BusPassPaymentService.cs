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
        private readonly IAccountRepository _accRepo;
        private readonly IBusPassportRepository _busPassRepo;

        public BusPassPaymentService (IBusPassPaymentRepository repo, IAccountRepository accRepo, IBusPassportRepository busPassRepo) {
            _repo = repo;
            _accRepo = accRepo;
            _busPassRepo = busPassRepo;
        }

        public async Task<BusPassPayment> createPayment (BusPassPayment payment) {
            payment.YearId = await _repo.getCurrentYearId ();
            payment.MonthId = await getCurrMonthId ();
           
            if (await _repo.checkPassportForCurrentMonth (payment.BusPassportId, payment.MonthId, payment.YearId) == null) {
                int userId = await _busPassRepo.getUserIdFromPassport (payment.BusPassportId);
                Account acc = await _accRepo.GetAccount (userId);
                if (await _accRepo.checkIfEnoughBalance (acc.AccountId, payment.Price)) {
                    await _accRepo.substructFromBalance (acc.AccountId, payment.Price);
                    payment.DateOfPayment = DateTime.Now;
                    return await _repo.createPayment (payment);
                } else {
                    return null;
                }
            } else {
                return null;
            }
        }

        public async Task<ICollection<Payment>> getPaymentsForBusPassForYear (int busPassId, int yearId) {
            return await _repo.getPaymentsForBusPassForYear (busPassId, yearId);
        }

        public async Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId) {
            return await _repo.getPaymentsForBusPass(busPassId);
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

        public Task<PaymentWithRecap> getRecap (ICollection<Payment> payments) {
            double totalAmount = 0;
            int numberOfPayments = 0;

            foreach (Payment payment in payments) {
                totalAmount += payment.price;
                numberOfPayments++;
            }

            PaymentWithRecap paymentsWithRecap = new PaymentWithRecap (payments, totalAmount, numberOfPayments);
            return Task.FromResult (paymentsWithRecap);
        }
    }
}