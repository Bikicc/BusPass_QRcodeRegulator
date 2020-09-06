using BusPass.Client.Helpers;
using BusPass.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    public class AccountRepository: IAccountRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Accounts";
        public AccountRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateAccount (Account account)
        {
            var response = await httpService.Post(url, account);
            // if (!response.Success)
            // {
            //     throw new ApplicationException(await response.GetBody());
            // }
        }
    }
}
