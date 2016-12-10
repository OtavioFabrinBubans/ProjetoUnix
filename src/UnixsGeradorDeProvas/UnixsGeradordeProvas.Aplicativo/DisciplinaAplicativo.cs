using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Repositorio;

namespace UnixsGeradordeProvas.Aplicativo
{
    public class DisciplinaAplicativo
    {

        private readonly IDisciplinaRepositorio repositorio;


        public DisciplinaAplicativo()
        {
            this.repositorio = new DisciplinaRepositorio();
        }

    
        public void Salvar(Disciplina disciplina)
        {
            if (disciplina.Id == 0)
                repositorio.Salvar(disciplina);
            else
                repositorio.Editar(disciplina);
        }
    }
}
