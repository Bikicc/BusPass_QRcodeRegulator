using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class PassTypeRepository : IPassTypeRepository {
        private readonly ApplicationDbContext _context;

        public PassTypeRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<ICollection<PassType>> GetPassTypes () {
            return await _context.PassTypes.ToListAsync ();
        }

        public async Task<PassType> GetPassType (int passTypeId) {
            return await _context.PassTypes.SingleOrDefaultAsync (x => x.PassTypeId == passTypeId);
        }

        public async Task<PassType> updatePassTypePrice (PassType passTypeToUpdate) {
            await _context.SaveChangesAsync ();
            return passTypeToUpdate;
        }
    }
}