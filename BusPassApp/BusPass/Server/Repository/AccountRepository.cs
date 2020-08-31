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

        public async Task<bool> postAccount (Account account) {
            try {
                _context.Add (account);
                await _context.SaveChangesAsync ();
                return true;
            } catch {
                return false;
            }

        }

        public async Task<bool> substructFromBalance (int accountId, int valueToSubstract) {
            
            Account acc = await _context.Accounts.FindAsync (accountId);
            if (acc.Balance < valueToSubstract) {
                return false;
            }
            
            acc.Balance = acc.Balance - valueToSubstract;
            await _context.SaveChangesAsync ();
            return true;

        }
    }
}