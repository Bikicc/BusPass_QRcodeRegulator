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

        public async Task<BusPassPayment> createPayment (BusPassPayment payment) {
            try {
                _context.Add (payment);
                await _context.SaveChangesAsync ();
                return payment;
            } catch {
                return null;
            }
        }
        public async Task<ICollection<Payment>> getAllPayments () {
            ICollection<Payment> payments = await _context.BusPassPayments
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForBusPassForYear (int busPassId, int yearId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.BusPassportId == busPassId && p.YearId == yearId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForBusPass (int busPassId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.BusPassportId == busPassId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForMonth (int monthId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.MonthId == monthId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForYear (int yearId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId)
                .OrderByDescending (p => p.DateOfPayment)
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
        public async Task<ICollection<Payment>> getPaymentsByPassType (int passTypeId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.PassTypeId == passTypeId)
                .OrderByDescending (p => p.DateOfPayment)
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
        public async Task<ICollection<Payment>> getPaymentsForMonthAndType (int monthId, int typeId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.MonthId == monthId && p.PassTypeId == typeId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForYearAndType (int yearId, int typeId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId && p.PassTypeId == typeId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForYearAndMonth (int yearId, int monthId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId && p.MonthId == monthId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<ICollection<Payment>> getPaymentsForYearAndMonthAndType (int yearId, int monthId, int typeId) {
            ICollection<Payment> payments = await _context.BusPassPayments
                .Where (p => p.YearId == yearId && p.MonthId == monthId && p.PassTypeId == typeId)
                .OrderByDescending (p => p.DateOfPayment)
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

        public async Task<int> getCurrentYearId () {
            var allYears = await _context.Years.ToListAsync ();
            var year = allYears.LastOrDefault ();
            return year.YearId;
        }

    }
}