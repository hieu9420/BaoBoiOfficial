using BaoBoi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.Configurations
{
    class LoiChucConfiguration : IEntityTypeConfiguration<LoiChuc>
    {
        public void Configure(EntityTypeBuilder<LoiChuc> builder)
        {
            builder.ToTable("LoiChuc");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("ID");

            builder.Property(x => x.CauChuc).IsRequired(true).HasColumnName("CauChuc");

            builder.Property(x => x.Type).HasColumnName("Type");
        }
    }
}
