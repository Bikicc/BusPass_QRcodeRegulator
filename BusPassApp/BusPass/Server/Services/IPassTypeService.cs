using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;

namespace BusPass.Server.Services {
    public interface IPassTypeService {
        Task<ICollection<PassType>> GetPassTypes ();
        Task<PassType> GetPassType (int passTypeId);
        Task<PassType> updatePassTypePrice (int passTypeId, double newPrice);
    }
}