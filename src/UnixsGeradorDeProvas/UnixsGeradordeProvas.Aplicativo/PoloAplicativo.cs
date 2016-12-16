using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixGeradorDeProvas.Repositorio;

namespace UnixsGeradordeProvas.Aplicativo
{
    public class PoloAplicativo
    {

        private readonly IPoloRepositorio repositorio;


        public PoloAplicativo()
        {
            this.repositorio = new PoloRepositorio();
        }

    
        public void Salvar(Polo polo)
        {
            if (polo.Id == 0)
                repositorio.Salvar(polo);
            else
                repositorio.Editar(polo);
        }
    }
}
