using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio
{
    public class Pessoa
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }

        public virtual ICollection<Funcoes> Funcoes { get; set; }

        public Pessoa()
        {

        }

    }
}
