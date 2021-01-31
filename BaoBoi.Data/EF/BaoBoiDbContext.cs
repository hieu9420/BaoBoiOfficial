using BaoBoi.Data.Configurations;
using BaoBoi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BaoBoi.Data.SeedData;

namespace BaoBoi.Data.EF
{
    public class BaoBoiDbContext : DbContext
    {
        public BaoBoiDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoiChucConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneUserConfiguration());
            //base.OnModelCreating(modelBuilder);

            //Seed Data

            modelBuilder.Seed();
        }

        public DbSet<PhoneUser> PhoneUsers { get; set; }
        public DbSet<LoiChuc> LoiChucs { get; set; }
    }
}
