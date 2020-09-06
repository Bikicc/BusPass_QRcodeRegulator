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

        public BusPassPaymentController (IBusPassPaymentService service) {
            _service = service;

        }

        [Authorize (Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> postPayment (BusPassPayment payment) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var pay = await _service.createPayment (payment);
            return Ok(pay);
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

        [HttpGet ("check/{busPassId}")]
        public async Task<IActionResult> checkPassportForCurrentMonth (int busPassId) {
            bool exists = await _service.checkPassportForCurrentMonth (busPassId);
            return Ok(exists);
        }
    }
}