﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnixGeradorDeProvas.Dominio;

namespace UnixsGeradorDeProvas.Repositorio
{
    public class ContextoDeDados : DbContext
    {

        public ContextoDeDados() : base("Unixs")
        {

        }

        public DbSet<Dificuldade> Dificuldade { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
