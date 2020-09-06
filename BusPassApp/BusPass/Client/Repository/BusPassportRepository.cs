using BusPass.Shared.Entities;
using System.Threading.Tasks;
using BusPass.Client.Helpers;
using System;
namespace BusPass.Client.Repository
{
    public class BusPassportRepository : IBusPassportRepository
    {
        private readonly IHttpService _httpService;

        public BusPassportRepository(IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<BusPassport> getBusPassForUser(int userId) {
            string url = "/api/BusPassport/" + userId.ToString();
            var response = await _httpService.Get<BusPassport>(url);
            Console.WriteLine(response);
            return response;
        }
    }
}