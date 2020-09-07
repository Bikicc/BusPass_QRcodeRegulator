using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class YearRepository : IYearRepository {
        private readonly ApplicationDbContext _context;

        public YearRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<ICollection<Year>> GetYears () {
            return await _context.Years.ToListAsync ();
        }
    }
}