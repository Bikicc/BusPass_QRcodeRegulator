using System.Threading.Tasks;
using BusPass.Shared.Entities;
using System.Collections.Generic;

namespace BusPass.Client.Repository {
    interface IMonthRepository {
        Task<ICollection<Month>> GetMonths ();
    }
}