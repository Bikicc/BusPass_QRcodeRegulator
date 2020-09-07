using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;

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

        public async Task<ICollection<BusPassPayment>> getPaymentsForUser (int busPassId, int yearId) {
            return await _httpService.Get<ICollection<BusPassPayment>> ("/api/BusPassPayment/forBusPass/" + busPassId.ToString () + "/" + yearId.ToString ());
        }
    }
}