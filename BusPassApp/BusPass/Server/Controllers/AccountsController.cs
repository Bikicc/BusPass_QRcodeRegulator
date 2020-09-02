using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase {
        private readonly IAccountService _service;
        private readonly ApplicationDbContext _context;

        public AccountsController (IAccountService service, ApplicationDbContext context) {
            _service = service;
            this._context = context;
        }

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

        [HttpGet ("{userId}")]
        public async Task<IActionResult> getAccount (int userId) {
            Account acc = await _service.GetAccount (userId);

            if (acc == null) {
                return BadRequest ("Account doesn't exists!");
            } else {
                return Ok (acc);
            }
        }

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