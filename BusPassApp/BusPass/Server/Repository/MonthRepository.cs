using System.Collections.Generic;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class MonthRepository : IMonthRepository {
        private readonly ApplicationDbContext _context;

        public MonthRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<ICollection<Month>> getMonths () {
            return await _context.Months.ToListAsync ();
        }
    }
}