using System.Linq;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using BusPass.Shared.HelperEntities;

namespace BusPass.Server.Repository {
    public class UserRepository : IUserRepository {
        private readonly ApplicationDbContext _context;

        public UserRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<bool> CheckIfUserExists(User user) {
            return await _context.Users.Where (x => x.OIB == user.OIB || x.Email == user.Email).AnyAsync ();
        }

        public async Task<bool> RegisterUser (User user) {
            try {
                _context.Users.Add (user);
                await _context.SaveChangesAsync ();
                return true;
            } catch {
                return false;
            }
        }

        public async Task<User> LoginUser (LoginUser user) {
            var us = await (from u in this._context.Users where u.Email == user.Email && u.Password == user.Password select u) 
                .FirstOrDefaultAsync ();
 
            return us;
        }

        public async Task<User> getUserById(int userdId) {
            var us = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userdId);
            return us;
        }

    }
}