using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IDisciplinaRepositorio
    {
        void Salvar(Disciplina disciplina);
        void Editar(Disciplina disciplina);
        void Exclui(Disciplina disciplina);
    }
}
