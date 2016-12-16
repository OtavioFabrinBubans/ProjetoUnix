using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixGeradorDeProvas.Repositorio;

namespace UnixsGeradordeProvas.Aplicativo
{
    public class FuncoesAplicativo
    {
        private readonly IFuncoesRepositorio repositorio;


        public FuncoesAplicativo()
        {
            this.repositorio = new FuncoesRepositorio();
        }


        public void Salvar(Funcoes funcoes)
        {
            if (funcoes.Id == 0)
                repositorio.Salvar(funcoes);
            else
                repositorio.Editar(funcoes);
        }


    }
}
