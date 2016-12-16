using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class PoloRepositorio : IPoloRepositorio
    {

        public void Salvar(Polo polo)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Polo.Add(polo);
                contexto.SaveChanges();
            }

        }
        public void Editar(Polo polo)
        {
            throw new NotImplementedException();
        }


        public void Excluir(Polo polo)
        {
            throw new NotImplementedException();
        }
    }
}
