using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class TipoQuestaoRepositorio : ITipoQuestaoRepositorio
    {

        public void Salvar(TipoQuestao tipoQuestao)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.TipoQuestao.Add(tipoQuestao);
                contexto.SaveChanges();
            }

        }
        public void Editar(TipoQuestao tipoQuestao)
        {
            throw new NotImplementedException();
        }


        public void Excluir(TipoQuestao tipoQuestao)
        {
            throw new NotImplementedException();
        }
    }
}
