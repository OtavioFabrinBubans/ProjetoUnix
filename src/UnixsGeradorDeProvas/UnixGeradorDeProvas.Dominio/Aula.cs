using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio
{
    public class Aula
    {

        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
