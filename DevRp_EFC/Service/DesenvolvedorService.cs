using DevRp_EFC.Domains;
using DevRp_EFC.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Service
{
    public class DesenvolvedorService : IDesenvolvedorService
    {
        public Desenvolvedor Inserir(Desenvolvedor desenvolvedor)
        {
            using var db = new Data.ApplicationContext();
            db.Desenvolvedores.Add(desenvolvedor);
            db.SaveChanges();
            return desenvolvedor;
        }
        public List<Desenvolvedor> Listar()
        {
            using var db = new Data.ApplicationContext();
            return db.Desenvolvedores.ToList();
        }
        public Desenvolvedor Remover(Desenvolvedor desenvolvedor)
        {
            using var db = new Data.ApplicationContext();
            var dev = db.Desenvolvedores.Find(desenvolvedor.Id);
            db.Entry(dev).State = EntityState.Deleted;
            db.SaveChanges();
            return dev;
        }

    }
}