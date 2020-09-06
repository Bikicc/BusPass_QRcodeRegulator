using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    public class MonthRepository: IMonthRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Months";
        public MonthRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateMonth(Month month)
        {
            var response = await httpService.Post(url, month);
            //if (!response.Success)
            // {
            //     throw new ApplicationException(await response.GetBody());
            // } 
        }
    }
}
