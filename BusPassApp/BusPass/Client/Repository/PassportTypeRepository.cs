using BusPass.Shared.Entities;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using System.Collections.Generic;

namespace BusPass.Client.Repository {
    public class PassportTypeRepository : IPassportTypeRepository {
        private readonly IHttpService _httpService;

        public PassportTypeRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<ICollection<PassType>> getPassTypes() {
            return await _httpService.Get<ICollection<PassType>>("/api/PassType");
        }

        public async Task<PassType> getPassType(int passTypeId) {
            return await _httpService.Get<PassType>("/api/PassType/" + passTypeId.ToString());
        }

    }
}