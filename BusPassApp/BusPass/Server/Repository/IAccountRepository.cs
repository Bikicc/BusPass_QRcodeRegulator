using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetAccount (int userId);
        Task<Account> postAccount (Account acc);
        Task<Account> substructFromBalance (int accountId, double valueToSubstract);
        Task<bool> checkIfEnoughBalance (int accountId, double valueToSubstract);
        Task<Account> updateAccount (Account account);
    }
}