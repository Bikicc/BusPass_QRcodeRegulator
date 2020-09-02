using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Server.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetAccount (int userId);
        Task<bool> postAccount (Account acc);
        Task<Account> substructFromBalance (int accountId, int valueToSubstract);
        Task<bool> checkIfEnoughBalance (int accountId, int valueToSubstract);
    }
}