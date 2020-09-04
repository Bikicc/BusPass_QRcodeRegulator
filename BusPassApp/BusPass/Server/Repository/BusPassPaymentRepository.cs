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

        public async Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId, int yearId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.BusPassportId == busPassId && p.YearId == yearId)
                .Join (_context.BusPassports,
                    payment => payment.BusPassportId,
                    busPass => busPass.BusPassportId,
                    (payment, busPass) => new { p = payment, bp = busPass })
                .Join (_context.Users,
                    pbp => pbp.bp.UserId,
                    user => user.UserId,
                    (pbp, u) =>
                    new Payment (pbp.p, pbp.bp, u, pbp.p.Month.Name, _context.PassTypes.SingleOrDefault (pt => pt.PassTypeId == pbp.p.PassTypeId).Name))
                .ToListAsync ();

            return payments;
        }

        public async Task<BusPassPayment> checkPassportForCurrentMonth (int busPassId, int monthId, int yearId) {
            var payments = await (from p in _context.BusPassPayments where p.BusPassportId == busPassId && p.MonthId == monthId && p.YearId == yearId select p)
                .SingleOrDefaultAsync ();

            return payments;
        }

        public async Task<ICollection<Payment>> getPaymentsForMonth (int yearId, int monthId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId && p.MonthId == monthId)
                .Join (_context.BusPassports,
                    payment => payment.BusPassportId,
                    busPass => busPass.BusPassportId,
                    (payment, busPass) => new { p = payment, bp = busPass })
                .Join (_context.Users,
                    pbp => pbp.bp.UserId,
                    user => user.UserId,
                    (pbp, u) =>
                    new Payment (pbp.p, pbp.bp, u, pbp.p.Month.Name, _context.PassTypes.SingleOrDefault (pt => pt.PassTypeId == pbp.p.PassTypeId).Name))
                .ToListAsync ();

            return payments;
        }

        public async Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId, int yearId, int monthId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId && p.PassTypeId == passTypeId && p.MonthId == monthId)
                .Join (_context.BusPassports,
                    payment => payment.BusPassportId,
                    busPass => busPass.BusPassportId,
                    (payment, busPass) => new { p = payment, bp = busPass })
                .Join (_context.Users,
                    pbp => pbp.bp.UserId,
                    user => user.UserId,
                    (pbp, u) =>
                    new Payment (pbp.p, pbp.bp, u, pbp.p.Month.Name, _context.PassTypes.SingleOrDefault (pt => pt.PassTypeId == pbp.p.PassTypeId).Name))
                .ToListAsync ();

            return payments;

        }

        public async Task<Year> getCurrentYear () {
            var allYears = await _context.Years.ToListAsync ();
            return allYears.LastOrDefault ();
        }

    }
}