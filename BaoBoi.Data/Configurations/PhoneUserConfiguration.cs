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

            builder.Property(x => x.Phone).HasColumnName("Phone").HasMaxLength(11);

            builder.Property(x => x.Amount).HasDefaultValue(0.00).HasColumnName("Amount");

            builder.Property(x => x.Name).HasColumnName("Name");

            builder.Property(x => x.Pay).HasColumnName("Pay").HasDefaultValue(false);

            builder.Property(x => x.DatePlay).HasColumnName("DatePlay");

            builder.Property(x => x.DatePay).HasColumnName("DatePay");

        }
    }
}
