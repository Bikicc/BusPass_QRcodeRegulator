﻿using System.Threading.Tasks;
using BusPass.Shared.Entities;

namespace BusPass.Client.Repository
{
    public interface IAccountRepository {
        Task<Account> CreateAccount (Account account);
        Task<Account> getAccountForUser (int userId);
        Task<Account> updateUserAccount(Account account);
    }
}
