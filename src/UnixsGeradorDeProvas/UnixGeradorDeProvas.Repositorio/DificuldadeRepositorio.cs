using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnixGeradorDeProvas.Dominio;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class DificuldadeRepositorio
    {

        public void Salvar(Dificuldade dificuldade)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Dificuldade.Add(dificuldade);
                contexto.SaveChanges();
            }

        }


    }
}
