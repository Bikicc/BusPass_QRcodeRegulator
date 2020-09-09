using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Services {
    public interface IAccountService {
        Task<Account> GetAccount (int userId);
        Task<Account> postAccount (Account acc);
        Task<Account> substructFromBalance (int accountId, int valueToSubstract);
        Task<Account> updateAccount(Account account);
    }
}