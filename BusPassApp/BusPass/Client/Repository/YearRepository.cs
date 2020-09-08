using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Client.Helpers;

namespace BusPass.Client.Repository {
    public class YearRepository : IYearRepository {
        private readonly IHttpService _httpService;

        public YearRepository (IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<Year[]> getYears() {
            return await _httpService.Get<Year[]>("/api/year");
        }
    }
}