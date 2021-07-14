﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Domains
{
    public class Desenvolvedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public ICollection<Aplicacao> Aplicacoes { get; set; }
    }
}
