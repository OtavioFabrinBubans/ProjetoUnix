using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class DificuldadeRepositorio : IDificuldadeRepositorio
    {

        public void Salvar(Dificuldade dificuldade)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Dificuldade.Add(dificuldade);
                contexto.SaveChanges();

      //          using (var context = new BloggingContext())
      //         {
      //              context.Database.ExecuteSqlCommand(
      //                  "UPDATE dbo.Blogs SET Name = 'Another Name' WHERE BlogId = 1");
      //          }
            }

        }
        public void Editar(Dificuldade dificuldade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Dificuldade dificuldade)
        {
            throw new NotImplementedException();
        }




    }
}
