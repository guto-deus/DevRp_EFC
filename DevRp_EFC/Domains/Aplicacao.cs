using DevRp_EFC.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Domains
{
    public class Aplicacao
    {
        public int Id { get; set; }
        public int DesenvolvedorId { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Plataforma Plataforma { get; set; }
    }
}
