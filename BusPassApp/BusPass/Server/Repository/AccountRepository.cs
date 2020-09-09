using System.Linq;
using System.Threading.Tasks;
using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server.Repository {
    public class AccountRepository : IAccountRepository {
        private readonly ApplicationDbContext _context;

        public AccountRepository (ApplicationDbContext context) {
            this._context = context;
        }
        public async Task<Account> GetAccount (int userId) {
            var acc = await (from a in _context.Accounts where a.UserId == userId select a)
                .SingleOrDefaultAsync ();

            return acc;
        }

        public async Task<Account> postAccount (Account account) {
            try {
                _context.Add (account);
                await _context.SaveChangesAsync ();
                return account;
            } catch {
                return null;
            }

        }

        public async Task<Account> updateAccount (Account account) {
            var acc = await (from a in _context.Accounts where a.AccountId == account.AccountId select a)
                .SingleOrDefaultAsync ();
            acc.IBAN = account.IBAN;
            await _context.SaveChangesAsync ();
            return acc;
        }

        public async Task<Account> substructFromBalance (int accountId, double valueToSubstract) {

            var acc = await _context.Accounts.FindAsync (accountId);

            acc.Balance = acc.Balance - valueToSubstract;
            await _context.SaveChangesAsync ();
            return acc;

        }

        public async Task<bool> checkIfEnoughBalance (int accountId, double valueToSubstract) {
            return (await _context.Accounts.FindAsync (accountId)).Balance >= valueToSubstract;
        }
    }
}