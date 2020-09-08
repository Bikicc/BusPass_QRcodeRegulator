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
            var registeredUser = await _service.RegisterUser (user);

            if (registeredUser != null) {
                return Ok (registeredUser);
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

        [Authorize (Roles = "User")]
        [HttpPut]
        public async Task<IActionResult> updateUser ([FromBody] User user) {
            User us = await _service.updateUser (user);
            if (us == null) {
                return BadRequest("Something went wrong!");
            } else {

                return Ok (us);
            }
        }

        [HttpGet ("{userId}")]
        public async Task<IActionResult> getUserById (int userId) {
            var user = await _service.getUserById (userId);
            return Ok (user);
        }
    }
}