using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    public class AccountRepository: IAccountRepository
    {
        private readonly IHttpService httpService;
        public AccountRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<Account> CreateAccount (Account account)
        {
            return await httpService.Post("api/Accounts", account);
        }

        public async Task<Account> getAccountForUser (int userId)
        {
            return await httpService.Get<Account>("api/Accounts/" + userId);
        }

        public async Task<Account> updateUserAccount(Account account) {
            return await httpService.Put("api/accounts", account);
        }
    }
}
