using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using System;
using System.Text.Json;

namespace BusPass.Client.Repository {
    public class BusPassPaymentRepository : IBusPassPaymentRepository {

        private readonly IHttpService _httpService;

        public BusPassPaymentRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<bool> getBusPassForUser (int userId) {
            return await _httpService.Get<bool> ("/api/BusPassPayment/check/" + userId.ToString ());
        }

        public async Task<bool> renewBusPass (BusPassPayment payment) {
            BusPassPayment p = await _httpService.Post("/api/BusPassPayment", payment);
            Console.WriteLine(JsonSerializer.Serialize(p));
            if (p == null) {
                return false;
            } else {
                return true;
            }
            // return p;
            // return await _httpService.Post("/api/BusPassPayment", payment);
        }

        public async Task<ICollection<BusPassPayment>> getPaymentsForUser (int busPassId, int yearId) {
            return await _httpService.Get<ICollection<BusPassPayment>>("/api/BusPassPayment/forBusPass/" + busPassId.ToString() + "/" + yearId.ToString());
        }
    }
}