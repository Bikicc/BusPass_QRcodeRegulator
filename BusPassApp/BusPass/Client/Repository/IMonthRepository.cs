using BusPass.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    interface IMonthRepository
    {
        Task CreateMonth(Month month);
    }
}
