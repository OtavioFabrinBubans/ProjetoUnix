using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class StatusQuestaoRepositorio : IStatusQuestaoRepositorio
    {

        public void Salvar(StatusQuestao statusQuestao)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.StatusQuestao.Add(statusQuestao);
                contexto.SaveChanges();

      //          using (var context = new BloggingContext())
      //         {
      //              context.Database.ExecuteSqlCommand(
      //                  "UPDATE dbo.Blogs SET Name = 'Another Name' WHERE BlogId = 1");
      //          }
            }

        }
        public void Editar(StatusQuestao statusQuestao)
        {
            throw new NotImplementedException();
        }

        public void Excluir(StatusQuestao statusQuestao)
        {
            throw new NotImplementedException();
        }




    }
}
