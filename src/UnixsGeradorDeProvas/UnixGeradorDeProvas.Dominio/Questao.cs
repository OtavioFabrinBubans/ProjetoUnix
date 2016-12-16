using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio
{
    public class Questao
    {

        public int Id { get; set; }

        public int DisciplinaInt { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public int DificuldadeId { get; set; }
        public virtual Dificuldade Dificuldade { get; set; }

        public int NumSemana { get; set; }

        public bool TemConsulta { get; set; }

        public int TipoQuestaoInt { get; set; }
        public virtual TipoQuestao TipoQuestao { get; set; }

        public string Enunciado { get; set; }


        public int StatusQuestaoId { get; set; }
        public StatusQuestao MyProperty { get; set; }

        public int QtdUso { get; set; }


    }
}
