using System.Collections.Generic;

namespace UnixGeradorDeProvas.Dominio
{
    public class Disciplina
    {
       
        public int? Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }


        public Disciplina()
        {

        }
    }
}