using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IDificuldadeRepositorio
    {
        void Salvar(Dificuldade dificuldade);
        void Editar(Dificuldade dificuldade);
        void Excluir(Dificuldade dificuldade);
    }
}
