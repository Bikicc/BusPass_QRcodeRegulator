using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Repository
{
    public interface IPassTypeRepository
    {
         Task<ICollection<PassType>> GetPassTypes();
         Task<PassType> GetPassType(int passTypeId);
         Task<PassType> updatePassTypePrice(PassType passTypeToUpdate);
         Task<PassType> addPassType(PassType type);
    }
}