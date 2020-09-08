using System.Collections.Generic;
using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    public class MonthRepository: IMonthRepository
    {
        private readonly IHttpService httpService;
        public MonthRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<ICollection<Month>> GetMonths() {
            return await httpService.Get<ICollection<Month>>("api/month");
        }
    }
}
