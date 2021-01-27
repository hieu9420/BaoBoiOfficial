using BaoBoi.Data.Configurations;
using BaoBoi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.EF
{
    class BaoBoiDbContext : DbContext
    {
        public BaoBoiDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoiChucConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneUserConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<PhoneUser> PhoneUsers { get; set; }
        public DbSet<LoiChuc> LoiChucs { get; set; }
    }
}
