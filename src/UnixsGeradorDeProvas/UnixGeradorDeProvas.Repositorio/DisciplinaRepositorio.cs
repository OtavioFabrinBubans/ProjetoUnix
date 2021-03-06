﻿using System;
using UnixGeradorDeProvas.Dominio;
using UnixGeradorDeProvas.Dominio.Interfaces;
using UnixsGeradorDeProvas.Repositorio;

namespace UnixGeradorDeProvas.Repositorio
{
    public class DisciplinaRepositorio : IDisciplinaRepositorio
    {

        public void Salvar(Disciplina disciplina)
        {
            using (var contexto = new ContextoDeDados())
            {
                contexto.Disciplina.Add(disciplina);
                contexto.SaveChanges();
            }

        }
        public void Editar(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }


        public void Exclui(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }
    }
}
