using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixGeradorDeProvas.Repositorio;

namespace UnixsGeradordeProvas.Aplicativo
{
    public class DificuldadeAplicativo
    {
        private readonly IDificuldadeRepositorio repositorio;


        public DificuldadeAplicativo()
        {
            this.repositorio = new DificuldadeRepositorio();
        }


        public void Salvar(Dificuldade dificuldade)
        {
            if (dificuldade.Id == 0)
                repositorio.Salvar(dificuldade);
            else
                repositorio.Editar(dificuldade);
        }


    }
}
