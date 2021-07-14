using DevRp_EFC.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Data.Configuration
{
    public class AplicacaoConfiguration : IEntityTypeConfiguration<Aplicacao>
    {
        public void Configure(EntityTypeBuilder<Aplicacao> builder)
        {
            builder.ToTable("Aplicacao");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("NVARCHAR(80)").IsRequired();
            builder.Property(p => p.DataLancamento).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.Plataforma).HasConversion<int>();

            builder.HasOne(p => p.Desenvolvedor)
                .WithMany(p => p.Aplicacoes);
        }
    }
}