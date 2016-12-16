using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio
{
    public class Profissional
    {

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public int FuncoesId { get; set; }
        public virtual Funcoes Funcoes { get; set; }
    }
}
