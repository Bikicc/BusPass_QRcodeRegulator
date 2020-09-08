using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Repository
{
    public interface IMonthRepository
    {
         Task<ICollection<Month>> getMonths();
    }
}