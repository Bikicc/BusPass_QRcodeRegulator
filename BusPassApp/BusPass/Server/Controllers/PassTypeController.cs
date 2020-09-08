using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BusPass.Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class PassTypeController : ControllerBase {
        private readonly IPassTypeService _service;

        public PassTypeController (IPassTypeService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> getAllPassTypes () {
            var passTypes = await _service.GetPassTypes ();
            return Ok (passTypes);
        }

        [HttpGet ("{passTypeId}")]
        public async Task<IActionResult> getPassType (int passTypeId) {
            var passType = await _service.GetPassType (passTypeId);
            if (passType != null) {
                return Ok (passType);
            } else {
                return BadRequest ("There is no required pass type!");
            }
        }

        [Authorize (Roles = "Admin")]
        [HttpPut ()]
        public async Task<IActionResult> updatePassType ([FromBody] PassType type) {
            var passType = await _service.updatePassType (type);
            if (passType != null) {
                return Ok (passType);
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [Authorize (Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> getPassType ([FromBody] PassType type) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }
            var passType = await _service.addPassType (type);
            return Ok (passType);
        }
    }
}