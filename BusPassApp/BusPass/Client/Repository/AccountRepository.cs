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
    }
}
