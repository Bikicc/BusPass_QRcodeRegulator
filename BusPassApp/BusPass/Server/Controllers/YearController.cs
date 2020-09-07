using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusPass.Shared.Entities;

namespace BusPass.Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class YearController : ControllerBase {

        private readonly IYearRepository _repo;

        public YearController (IYearRepository repo) {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> getYears () {
            ICollection<Year> years = await _repo.GetYears ();
            return Ok(years);
        }
    }
}