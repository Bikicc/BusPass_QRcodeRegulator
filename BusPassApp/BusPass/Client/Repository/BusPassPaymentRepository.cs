using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Client.Repository {
    public class BusPassPaymentRepository : IBusPassPaymentRepository {

        private readonly IHttpService _httpService;

        public BusPassPaymentRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<bool> getBusPassForUser (int userId) {
            return await _httpService.Get<bool> ("/api/BusPassPayment/check/" + userId.ToString ());
        }

        public async Task renewBusPass (BusPassPayment payment) {
            await _httpService.Post ("/api/BusPassPayment", payment);
        }

        public async Task<PaymentWithRecap> getPaymentsForUserByYear (int busPassId, string yearId) {
            var p = await _httpService.Get<PaymentWithRecap> ("/api/BusPassPayment/forBusPass/" + busPassId.ToString () + "/" + yearId);
            return p;
        }

        public async Task<PaymentWithRecap> getAllPaymentsForUser (int busPassId) {
            var p = await _httpService.Get<PaymentWithRecap> ("/api/BusPassPayment/forBusPass/" + busPassId.ToString ());
            return p;
        }

        public async Task<PaymentWithRecap> getAllPaymentsWithFilters (string filterIndicators, int yearId, int monthId, int typeId) {
            return await _httpService.Get<PaymentWithRecap> ("api/BusPassPayment/withFilters/" + filterIndicators + "/" + yearId + "/" + monthId + "/" + typeId);
        }
    }
}