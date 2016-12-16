using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface ITipoQuestaoRepositorio
    {
        void Salvar(TipoQuestao tipoQuestao);
        void Editar(TipoQuestao tipoQuestao);
        void Excluir(TipoQuestao tipoQuestao);
    }
}
