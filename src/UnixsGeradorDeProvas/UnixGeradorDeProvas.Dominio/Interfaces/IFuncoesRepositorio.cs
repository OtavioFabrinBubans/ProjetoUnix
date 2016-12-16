using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IFuncoesRepositorio
    {
        void Salvar(Funcoes dificuldade);
        void Editar(Funcoes dificuldade);
        void Excluir(Funcoes dificuldade);
    }
}
