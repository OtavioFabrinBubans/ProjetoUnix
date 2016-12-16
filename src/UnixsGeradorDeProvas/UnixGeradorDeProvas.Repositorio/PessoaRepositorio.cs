using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class PessoaRepositorio : IPessoaRepositorio
    {

        public void Salvar(Pessoa pessoa)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Pessoa.Add(pessoa);
                contexto.SaveChanges();

      //          using (var context = new BloggingContext())
      //         {
      //              context.Database.ExecuteSqlCommand(
      //                  "UPDATE dbo.Blogs SET Name = 'Another Name' WHERE BlogId = 1");
      //          }
            }

        }
        public void Editar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }




    }
}
