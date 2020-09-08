using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;

namespace BusPass.Client.Repository {
    public class PassportTypeRepository : IPassportTypeRepository {
        private readonly IHttpService _httpService;

        public PassportTypeRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<ICollection<PassType>> getPassTypes () {
            return await _httpService.Get<ICollection<PassType>> ("/api/PassType");
        }

        public async Task<PassType> getPassType (int passTypeId) {
            return await _httpService.Get<PassType> ("/api/PassType/" + passTypeId.ToString ());
        }

        public async Task<PassType> updatePassType (PassType type) {
            return await _httpService.Put<PassType> ("/api/PassType", type);
        }

        public async Task<PassType> addPassType (PassType pass) {
            return await _httpService.Post("/api/PassType", pass);
        }

    }
}