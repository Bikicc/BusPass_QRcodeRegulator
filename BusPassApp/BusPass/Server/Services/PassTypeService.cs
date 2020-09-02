using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;

namespace BusPass.Server.Services {
    public class PassTypeService : IPassTypeService {
        private readonly IPassTypeRepository _repo;

        public PassTypeService (IPassTypeRepository repo) {
            _repo = repo;
        }

        public async Task<ICollection<PassType>> GetPassTypes () {
            return await _repo.GetPassTypes ();
        }

        public async Task<PassType> GetPassType (int passTypeId) {
            return await _repo.GetPassType (passTypeId);
        }

        public async Task<PassType> updatePassTypePrice (int passTypeId, double newPrice) {
            PassType pass = await _repo.GetPassType (passTypeId);
            pass.Price = newPrice;
            return await _repo.updatePassTypePrice (pass);
        }
    }
}