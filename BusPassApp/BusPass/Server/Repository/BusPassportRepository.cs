using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class BusPassportRepository : IBusPassportRepository {
        private readonly ApplicationDbContext _context;

        public BusPassportRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<bool> createBussPassport (BusPassport pass) {
            try {
                _context.Add (pass);
                await _context.SaveChangesAsync ();
                return true;
            } catch {
                return false;
            }
        }

        public async Task<BusPassport> getBusPassport (int userId) {
            var pass = await (from p in _context.BusPassports where p.UserId == userId select p)
                .SingleOrDefaultAsync ();

            return pass;
        }

        public async Task<BusPassport> changeValidity (BusPassport pass) {
            await _context.SaveChangesAsync ();
            return pass;
        }

        public async Task<ICollection<UserBusPassport>> getBusPassportsByValidity (bool valid) {
            ICollection<UserBusPassport> pass = await _context.BusPassports
                .Where (p => p.Valid == valid)
                .Join (_context.Users,
                    pass => pass.User.UserId,
                    us => us.UserId,
                    (pass, us) =>
                    new UserBusPassport (pass, us, _context.PassTypes.SingleOrDefault (pt => pt.PassTypeId == pass.PassTypeId).Name))
                .ToListAsync ();

            return pass;
        }

        public async Task<ICollection<BusPassport>> getValidBusPassports () {
            return await _context.BusPassports.Where (p => p.Valid == true).ToListAsync ();
        }

        public async Task<ICollection<UserBusPassport>> getBusPassportByType (int passTypeId, bool valid) {
            ICollection<UserBusPassport> pass = await _context.BusPassports
                .Where (p => p.PassTypeId == passTypeId && p.Valid == valid)
                .Join (_context.Users,
                    pass => pass.User.UserId,
                    us => us.UserId,
                    (pass, us) => new UserBusPassport (pass, us, _context.PassTypes.SingleOrDefault (pt => pt.PassTypeId == pass.PassTypeId).Name)).ToListAsync ();

            return pass;
        }

        public async Task<int> getUserIdFromPassport (int passportId) {
            var pass = await (from p in _context.BusPassports where p.BusPassportId == passportId select p)
                .SingleOrDefaultAsync ();
            return pass.UserId;
        }

        public async Task<BusPassport> updateBusPass (int passportId, int passTypeId) {
            var pass = await (from p in _context.BusPassports where p.BusPassportId == passportId select p)
                .SingleOrDefaultAsync ();
            pass.PassTypeId = passTypeId;
            await _context.SaveChangesAsync ();
            return pass;
        }

    }
}