using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;

namespace BusPass.Client.Repository
{
    public interface IPassportTypeRepository
    {
         Task<ICollection<PassType>> getPassTypes();
         Task<PassType> getPassType(int passTypeId);
         Task<PassType> updatePassType (PassType type);
         Task<PassType> addPassType (PassType pass);
    }
}