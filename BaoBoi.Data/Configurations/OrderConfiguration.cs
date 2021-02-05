using BaoBoi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.ShipEmail).HasMaxLength(50).IsUnicode(false).IsRequired();

            builder.Property(x => x.ShipName).IsRequired();

            builder.Property(x => x.ShipAddress).IsRequired();

            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(11);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
        }
    }
}
