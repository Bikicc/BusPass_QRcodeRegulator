﻿using BusPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusPass.Server {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BusPassport> BusPassports { get; set; }
        public DbSet<BusPassPayment> BusPassPayments { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<PassType> PassTypes { get; set; }

    }
}