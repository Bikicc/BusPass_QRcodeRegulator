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
        [HttpGet ("withFilters/{filters}/{yearId}/{monthId}/{typeId}")]
        //filter je troznamenkasti broj u obliku stringa gdje je 1.znamenka -> yearId, 2.znamenka -> monthId, 3.znamenka -> typeId, id = 0 znaci iskljucnost filtera
        public async Task<IActionResult> getPaymentsWithFilters (string filters, int yearId, int monthId, int typeId) {
            ICollection<Payment> payments = await _service.getPaymentsWithFilters (filters, yearId, monthId, typeId);
            PaymentWithRecap payWr = await _service.getRecap (payments);
            return Ok (payWr);
        }

        [HttpGet ("check/{busPassId}")]
        public async Task<IActionResult> checkPassportForCurrentMonth (int busPassId) {
            bool exists = await _service.checkPassportForCurrentMonth (busPassId);
            return Ok (exists);
        }
    }
}