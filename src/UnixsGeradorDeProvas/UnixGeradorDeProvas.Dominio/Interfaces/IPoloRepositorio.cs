using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Dominio.Interfaces
{
    public interface IPoloRepositorio
    {
        void Salvar(Polo dificuldade);
        void Editar(Polo dificuldade);
        void Excluir(Polo dificuldade);
    }
}
