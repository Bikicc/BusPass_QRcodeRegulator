using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BusPass.Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class BusPassPaymentController : ControllerBase {
        private readonly IBusPassPaymentService _service;
        private readonly ApplicationDbContext _context;

        public BusPassPaymentController (IBusPassPaymentService service, ApplicationDbContext context) {
            _service = service;
            _context = context;

        }

        [Authorize (Roles = "User")]
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
            ICollection<Payment> payments = await _service.getPaymentsForBusPass (busPassId, yearId);
            double totalAmount = await _service.getTotalAmountOfPayments (payments);

            var paymentsWithAmount = new { payments = payments, totalAmount = totalAmount };
            return Ok (paymentsWithAmount);
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("forMonth/{yearId}/{monthId}")]
        public async Task<IActionResult> getPaymentsForMonth (int yearId, int monthId) {
            ICollection<Payment> payments = await _service.getPaymentsForMonth (yearId, monthId);
            double totalAmount = await _service.getTotalAmountOfPayments (payments);

            var paymentsWithAmount = new { payments = payments, totalAmount = totalAmount };
            return Ok (paymentsWithAmount);
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("forPassType/{passTypeId}/{yearId}/{monthId}")]
        public async Task<IActionResult> getPaymentsByPassType (int passTypeId, int yearId, int monthId) {
            ICollection<Payment> payments = await _service.getPaymentsByPassType (passTypeId, yearId, monthId);
            double totalAmount = await _service.getTotalAmountOfPayments (payments);

            var paymentsWithAmount = new { payments = payments, totalAmount = totalAmount };
            return Ok (paymentsWithAmount);
        }

        [HttpGet ("check/{busPassId}/{monthId}/{yearId}")]
        public async Task<IActionResult> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId) {
            bool exists = await _service.checkPassportForCurrentMonth (busPassId, monthId, yearId);
            return Ok (exists);
        }
    }
}