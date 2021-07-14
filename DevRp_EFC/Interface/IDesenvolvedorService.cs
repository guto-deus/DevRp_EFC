using DevRp_EFC.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Interface
{
    public interface IDesenvolvedorService
    {
        Desenvolvedor Inserir(Desenvolvedor desenvolvedor);
        List<Desenvolvedor> Listar();
        public Desenvolvedor Remover(Desenvolvedor desenvolvedor);
    }
}