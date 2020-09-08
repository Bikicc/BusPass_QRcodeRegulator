using System.Linq;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class UserRepository : IUserRepository {
        private readonly ApplicationDbContext _context;

        public UserRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<bool> CheckIfUserExists (User user) {
            return await _context.Users.Where (x => x.OIB == user.OIB || x.Email == user.Email).AnyAsync ();
        }

        public async Task<User> RegisterUser (User user) {
            _context.Users.Add (user);
            await _context.SaveChangesAsync ();
            return user;
        }

        public async Task<User> LoginUser (LoginUser user) {
            var us = await (from u in this._context.Users where u.Email == user.Email && u.Password == user.Password select u)
                .FirstOrDefaultAsync ();

            return us;
        }

        public async Task<User> getUserById (int userdId) {
            var us = await _context.Users.FirstOrDefaultAsync (u => u.UserId == userdId);
            return us;
        }

    }
}