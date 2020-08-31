using System.Threading.Tasks;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using BussPass.Server.HelperEntities;

namespace BusPass.Server.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IUserRepository _repo;

        public UserController (IUserRepository repo) {
            this._repo = repo;
        }

        [Route ("createUser")]
        [HttpPost]
        public async Task<IActionResult> createUser ([FromBody] User user) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            if (await _repo.RegisterUser (user)) {
                return Ok ();
            } else {
                return BadRequest ("User already exists!");
            }
        }

        [Route ("loginUser")]
        [HttpPost]
        public async Task<IActionResult> loginUser ([FromBody] LoginUser user) {
            var us = await _repo.LoginUser (user);

            if (us != null) {
                return Ok (us);
            } else {
                return BadRequest ("Wrong credentials");
            }
        }
    }
}