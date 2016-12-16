using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IPessoaRepositorio
    {
        void Salvar(Pessoa Pessoa);
        void Editar(Pessoa Pessoa);
        void Excluir(Pessoa Pessoa);
    }
}
