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
    public class UserController : ControllerBase {
        private readonly IUserService _service;

        public UserController (IUserService service) {
            _service = service;
        }

        [Authorize (Roles = "Admin")]
        [Route ("createUser")]
        [HttpPost]
        public async Task<IActionResult> createUser ([FromBody] User user) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            if (await _service.RegisterUser (user)) {
                return Ok ();
            } else {
                return BadRequest ("User already exists!");
            }
        }

        [AllowAnonymous]
        [Route ("loginUser")]
        [HttpPost]
        public async Task<IActionResult> loginUser ([FromBody] LoginUser user) {
            LoginUser us = await _service.LoginUser (user);

            if (us == null) {
                return NotFound ("Wrong credentials!");
            }

            return Ok (us);
        }
    }
}