using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusPass.Shared.Entities;

namespace BusPass.Server.Controllers
{
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class MonthController : ControllerBase 
    {
        private readonly IMonthRepository _repo;

        public MonthController (IMonthRepository repo) {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ICollection<Month>> GetMonths() {
            return await _repo.getMonths();
        }

    }
}