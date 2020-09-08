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

        public async Task<PassType> updatePassType (PassType type) {
            PassType pass = await _repo.GetPassType (type.PassTypeId);
            pass.Name = type.Name;
            pass.Price = type.Price;
            return await _repo.updatePassTypePrice (pass);
        }

        public async Task<PassType> addPassType (PassType type) {
            return await _repo.addPassType(type);
        }
    }
}