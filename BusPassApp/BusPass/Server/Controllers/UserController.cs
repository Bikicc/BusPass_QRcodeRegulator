using System.Threading.Tasks;
using BusPass.Server.Services;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IUserService _service;

        public UserController (IUserService service) {
            _service = service;
        }

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

        [Route ("loginUser")]
        [HttpPost]
        public async Task<IActionResult> loginUser ([FromBody] LoginUser user) {
            var us = await _service.LoginUser (user);

            if (us != null) {
                return Ok (us);
            } else {
                return BadRequest ("Wrong credentials");
            }
        }
    }
}