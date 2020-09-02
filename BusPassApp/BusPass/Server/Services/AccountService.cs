using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Server.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;

        public AccountService (IAccountRepository repo) {
            _repo = repo;
        }

        public async Task<Account> GetAccount (int userId) {
            return await _repo.GetAccount(userId);
        }

        public async Task<bool> postAccount (Account acc) {
            return await _repo.postAccount(acc);
        }

        public async Task<Account> substructFromBalance (int accountId, int valueToSubstract) {
            if (await _repo.checkIfEnoughBalance(accountId, valueToSubstract)) {
                return await _repo.substructFromBalance(accountId, valueToSubstract);
            } else {
                return null;
            }
        }
    }
}