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

            builder.Property(x => x.Cauchuc).IsRequired(true);
        }
    }
}
