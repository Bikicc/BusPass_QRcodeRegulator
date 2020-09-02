using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusPass.Server.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class BusPassPaymentController : ControllerBase {
        private readonly IBusPassPaymentService _service;

        public BusPassPaymentController (IBusPassPaymentService service) {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> postPayment (BusPassPayment payment) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            if (await _service.createPayment (payment)) {
                return Ok ();
            } else {
                return BadRequest ("Something went wrong!");
            }
        }

        [HttpGet ("forBusPass/{busPassId}/{yearId}")]
        public async Task<IActionResult> getPaymentsForBusPass (int busPassId, int yearId) {
            var payments = await _service.getPaymentsForBusPass (busPassId, yearId);
            return Ok (payments);
        }

        [HttpGet ("forMonth/{yearId}/{monthId}")]
        public async Task<IActionResult> getPaymentsForMonth (int yearId, int monthId) {
            var payments = await _service.getPaymentsForMonth (yearId, monthId);
            return Ok (payments);
        }

        [HttpGet ("forPassType/{passTypeId}/{yearId}")]
        public async Task<IActionResult> getPaymentsByPassType (int passTypeId, int yearId) {
            var payments = await _service.getPaymentsByPassType (passTypeId, yearId);
            return Ok (payments);
        }

        [HttpGet ("check/{busPassId}/{monthId}/{yearId}")]
        public async Task<IActionResult> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId) {
            bool exists = await _service.checkPassportForCurrentMonth (busPassId, monthId, yearId);
            return Ok (exists);
        }
    }
}