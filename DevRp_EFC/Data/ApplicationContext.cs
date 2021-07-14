using DevRp_EFC.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Aplicacao> Aplicacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Password=senh@123;Persist Security Info=True;User ID=sa;Initial Catalog=db_DevRp_EFC;Data Source=AGOSTINHO\\SQLEXPRESS");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}