using System;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;

namespace BusPass.Client.Repository {
    public class BusPassportRepository : IBusPassportRepository {
        private readonly IHttpService _httpService;

        public BusPassportRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<BusPassport> getBusPassForUser (int userId) {
            string url = "/api/BusPassport/" + userId.ToString ();
            var response = await _httpService.Get<BusPassport> (url);
            Console.WriteLine (response);
            return response;
        }

        public async Task<UserBusPassport[]> getByValidity (bool valid) {
            return await _httpService.Get<UserBusPassport[]> ("/api/BusPassport/byValidity/" + valid);
        }

        public async Task<UserBusPassport[]> getByType (string typeId, bool valid) {
            return await _httpService.Get<UserBusPassport[]> ("/api/BusPassport/byType/" + typeId + "/" + valid);
        }
        public async Task<BusPassport> updatePassType (int passId, int passTypeId) {
            return await _httpService.Put<BusPassport> ("/api/BusPassport/" + passId.ToString () + "/" + passTypeId.ToString ());
        }

        public async Task<BusPassport> makePassValid (int passId) {
            return await _httpService.Put<BusPassport> ("/api/BusPassport/valid/" + passId.ToString ());
        }

        public async Task<BusPassport> makePassInvalid (int passId) {
            return await _httpService.Put<BusPassport> ("/api/BusPassport/invalid/" + passId.ToString ());
        }

        public async Task<BusPassport> addPassport (BusPassport pass) {
            return await _httpService.Post("/api/BusPassport", pass);
        }
    }
}