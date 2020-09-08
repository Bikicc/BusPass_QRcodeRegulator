using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Services {
    public interface IPassTypeService {
        Task<ICollection<PassType>> GetPassTypes ();
        Task<PassType> GetPassType (int passTypeId);
        Task<PassType> updatePassType (PassType type);
        Task<PassType> addPassType (PassType type);

    }
}