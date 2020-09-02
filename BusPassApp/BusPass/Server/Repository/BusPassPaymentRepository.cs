using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class BusPassPaymentRepository : IBusPassPaymentRepository {

        private readonly ApplicationDbContext _context;

        public BusPassPaymentRepository (ApplicationDbContext context) {
            this._context = context;
        }

        public async Task<bool> createPayment (BusPassPayment payment) {
            try {
                _context.Add (payment);
                await _context.SaveChangesAsync ();
                return true;
            } catch {
                return false;
            }
        }

        public async Task<ICollection<BusPassPayment>> getPaymentsForBusPass (int busPassId, int yearId) {
            var payments = await (from p in _context.BusPassPayments where p.BusPassportId == busPassId && p.YearId == yearId select p)
                .ToListAsync ();

            return payments;
        }

        public async Task<BusPassPayment> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId) {
            var payments = await (from p in _context.BusPassPayments where p.BusPassportId == busPassId && p.MonthId == monthId && p.YearId == yearId select p)
                .SingleOrDefaultAsync ();

            return payments;
        }

        public async Task<ICollection<BusPassPayment>> getPaymentsForMonth (int yearId, int monthId) {
            var payments = await (from p in _context.BusPassPayments where p.YearId == yearId && p.MonthId == monthId select p)
                .ToListAsync ();

            return payments;
        }

        public async Task<ICollection<BusPassPayment>> getPaymentsByPassType (int passTypeId, int yearId) {
            var payments = await (from p in _context.BusPassPayments where p.YearId == yearId && p.PassTypeId == passTypeId select p)
                .ToListAsync ();

            return payments;
        }

        public async Task<Year> getCurrentYear() {
            return await _context.Years.LastOrDefaultAsync();
        }

    }
}