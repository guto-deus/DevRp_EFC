using DevRp_EFC.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Data.Configuration
{
    public class DesenvolvedorConfiguration : IEntityTypeConfiguration<Desenvolvedor>
    {
        public void Configure(EntityTypeBuilder<Desenvolvedor> builder)
        {
            builder.ToTable("Desenvolvedor");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.CPF).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();
        }
    }
}
