using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusPass.Server.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase {
        private readonly IAccountRepository _repo;

        public AccountsController (IAccountRepository repo) {
            this._repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> postAccount (Account account) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }
            if (await _repo.postAccount (account)) {
                return Ok ();
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> getAccount (int userId) {
            Account acc = await _repo.GetAccount (userId);

            if (acc == null) {
                return BadRequest ("Account doesn't exists!");
            } else {
                return Ok (acc);
            }
        }

        [HttpPut("{userId}/{valueToSubstract}")]
        public async Task<IActionResult> putAccount (int userId, int valueToSubstract) {

            if (await _repo.substructFromBalance (userId, valueToSubstract)) {
                var acc = await _repo.GetAccount (userId);
                return Ok (acc);
            } else {
                return BadRequest ("Insufficient funds!");
            }
        }
    }
}