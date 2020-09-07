using System;
using System.Collections.Generic;
using System.Text.Json;
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
            if (pay == null) {
                return BadRequest ("Passport already renewed or Insuficient funds!");
            } else {
                return Ok (pay);
            }
        }

        [HttpGet ("forBusPass/{busPassId}/{yearId}")]
        public async Task<IActionResult> getPaymentsForBusPassForYear (int busPassId, int yearId) {
            ICollection<Payment> payments = await _service.getPaymentsForBusPassForYear (busPassId, yearId);
            PaymentWithRecap payWr = await _service.getRecap (payments);
            return Ok (payWr);
        }

        [HttpGet ("forBusPass/{busPassId}")]
        public async Task<IActionResult> getPaymentsForBusPass (int busPassId) {
            ICollection<Payment> payments = await _service.getPaymentsForBusPass (busPassId);
            PaymentWithRecap payWr = await _service.getRecap (payments);
            return Ok (payWr);
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("forMonth/{yearId}/{monthId}")]
        public async Task<IActionResult> getPaymentsForMonth (int yearId, int monthId) {
            ICollection<Payment> payments = await _service.getPaymentsForMonth (yearId, monthId);
            PaymentWithRecap payWr = await _service.getRecap (payments);

            // double totalAmount = await _service.getRecap (payments);

            // var paymentsWithAmount = new { payments = payments, totalAmount = totalAmount };
            // return Ok (paymentsWithAmount);
            return Ok (payWr);
        }

        [Authorize (Roles = "Admin")]
        [HttpGet ("forPassType/{passTypeId}/{yearId}/{monthId}")]
        public async Task<IActionResult> getPaymentsByPassType (int passTypeId, int yearId, int monthId) {
            ICollection<Payment> payments = await _service.getPaymentsByPassType (passTypeId, yearId, monthId);
            PaymentWithRecap payWr = await _service.getRecap (payments);

            // double totalAmount = await _service.getRecap (payments);

            // var paymentsWithAmount = new { payments = payments, totalAmount = totalAmount };
            // return Ok (paymentsWithAmount);
            return Ok (payWr);

        }

        [HttpGet ("check/{busPassId}")]
        public async Task<IActionResult> checkPassportForCurrentMonth (int busPassId) {
            bool exists = await _service.checkPassportForCurrentMonth (busPassId);
            return Ok (exists);
        }
    }
}