using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class FuncoesRepositorio : IFuncoesRepositorio
    {

        public void Salvar(Funcoes funcoes)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Funcoes.Add(funcoes);
                contexto.SaveChanges();
            }

        }
        public void Editar(Funcoes funcoes)
        {
            throw new NotImplementedException();
        }


        public void Excluir(Funcoes funcoes)
        {
            throw new NotImplementedException();
        }
    }
}
