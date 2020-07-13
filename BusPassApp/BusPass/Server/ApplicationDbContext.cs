﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusPass.Shared.Entities;

namespace BusPass.Server
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
         {

         }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BusPassport> BusPasses { get; set; }
        public DbSet<BusPassPayment> BusPassPayments { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<PassType> PassTypes { get; set; }


    }
}