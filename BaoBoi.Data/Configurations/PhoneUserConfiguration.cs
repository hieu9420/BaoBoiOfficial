using BaoBoi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.Configurations
{
    class PhoneUserConfiguration : IEntityTypeConfiguration<PhoneUser>
    {
        public void Configure(EntityTypeBuilder<PhoneUser> builder)
        {
            builder.ToTable("PhoneUser");

            builder.HasKey(x => x.Phone);

            builder.Property(x => x.Amount).HasDefaultValue(0.00);
        }
    }
}
