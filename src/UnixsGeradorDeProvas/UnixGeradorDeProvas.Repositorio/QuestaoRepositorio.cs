using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class QuestaoRepositorio : IQuestaoRepositorio
    {

        public void Salvar(Questao questao)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Questao.Add(questao);
                contexto.SaveChanges();
            }

        }
        public void Editar(Questao questao)
        {
            throw new NotImplementedException();
        }


        public void Excluir(Questao questao)
        {
            throw new NotImplementedException();
        }
    }
}
