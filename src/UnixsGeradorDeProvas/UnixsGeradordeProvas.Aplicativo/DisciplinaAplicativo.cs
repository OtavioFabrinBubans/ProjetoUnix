using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
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
