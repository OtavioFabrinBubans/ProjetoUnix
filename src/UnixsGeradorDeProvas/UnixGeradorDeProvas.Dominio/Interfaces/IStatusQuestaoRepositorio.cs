using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IStatusQuestaoRepositorio
    {
        void Salvar(StatusQuestao statusQuestao);
        void Editar(StatusQuestao statusQuestao);
        void Excluir(StatusQuestao statusQuestao);
    }
}
