using BaoBoi.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BaoBoi.Data.EF
{
    class BaoBoiDbFactory : IDesignTimeDbContextFactory<BaoBoiDbContext>
    {
        public BaoBoiDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectString = configuration.GetConnectionString(SystemConstants.MainConnectstring);

            var optionsBuilder = new DbContextOptionsBuilder<BaoBoiDbContext>();
            optionsBuilder.UseSqlServer(connectString);

            return new BaoBoiDbContext(optionsBuilder.Options);
        }
    }
}
