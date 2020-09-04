using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BusPass.Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class BusPassportController : ControllerBase {
        private readonly IBusPassportService _service;

        public BusPassportController (IBusPassportService service) {
            _service = service;
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("byValidity/{valid}")]
        public async Task<IActionResult> getAllBusPassports (bool valid) {
            var busPasses = await _service.getBusPassports (valid);
            return Ok (busPasses);
        }

        [Authorize (Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> postBusPass (BusPassport busPass) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            if (await _service.createBussPassport (busPass)) {
                return Ok ();
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [HttpGet ("{busPassId}")]
        public async Task<IActionResult> getBusPass (int busPassId) {
            var busPass = await _service.getBusPassport (busPassId);
            if (busPass == null) {
                return BadRequest ("Required passport doesn't exists!");
            } else {
                return Ok (busPass);
            }
        }

        [Authorize (Roles = "Admin")]
        [HttpPut ("valid/{passId}")]
        public async Task<IActionResult> makePassValid (int passId) {
            BusPassport pass = await _service.makeValid (passId);

            if (pass != null) {
                return Ok (pass);
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [Authorize (Roles = "Admin")]
        [HttpPut ("invalid/{passId}")]
        public async Task<IActionResult> makePassInvalid (int passId) {
            BusPassport pass = await _service.makeInvalid (passId);

            if (pass != null) {
                return Ok (pass);
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("byType/{passTypeId}/{valid}")]
        public async Task<IActionResult> getBusPassByType (int passTypeId, bool valid) {
            var busPasses = await _service.getBusPassportByType (passTypeId, valid);

            return Ok (busPasses);
        }
    }
}