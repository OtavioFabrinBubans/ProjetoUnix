using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IQuestaoRepositorio
    {
        void Salvar(Questao questao);
        void Editar(Questao questao);
        void Excluir(Questao questao);
    }
}
