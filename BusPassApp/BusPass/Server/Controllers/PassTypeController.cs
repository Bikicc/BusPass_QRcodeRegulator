using System.Threading.Tasks;
using BusPass.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusPass.Server.Controllers {

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

        [HttpPut ("{passTypeId}/{price}")]
        public async Task<IActionResult> getPassType (int passTypeId, double price) {
            var passType = await _service.updatePassTypePrice (passTypeId, price);
            if (passType != null) {
                return Ok (passType);
            } else {
                return BadRequest ("Something went wrong!");
            }
        }
    }
}