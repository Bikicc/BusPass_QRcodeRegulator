using System.Threading.Tasks;
using BusPass.Server.HelperClasses;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BusPass.Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase {
        private readonly IAccountService _service;
        public AccountsController (IAccountService service) {
            _service = service;
        }

        [Authorize (Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> postAccount (Account account) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            if (await _service.postAccount (account)) {
                return Ok ();
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [Authorize (Roles = "User")]
        [HttpGet ("{userId}")]
        public async Task<IActionResult> getAccount (int userId) {
            Account acc = await _service.GetAccount (userId);

            if (acc == null) {
                return BadRequest ("Account doesn't exists!");
            } else {
                return Ok (acc);
            }
        }

        [Authorize (Roles = "User")]
        [HttpPut ("{userId}/{valueToSubstract}")]
        public async Task<IActionResult> putAccount (int userId, int valueToSubstract) {
            Account acc = await _service.substructFromBalance (userId, valueToSubstract);

            if (acc != null) {
                return Ok (acc);
            } else {
                return BadRequest ("Insufficient funds!");
            }
        }
    }
}